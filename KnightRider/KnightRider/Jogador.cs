using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
// X = Largura = Colunas
// Y = Altura = Linhas 
namespace KnightRider
{
    [Serializable]
    public class Jogador
    {

        Cavalo mPeca;
        public Point mPosicao { get; private set; }
        public Point mPosAnt { get; private set; }
        public Tabuleiro mTab { get; private set; }

        [NonSerialized]
        public StateMessage StObserver = null;
        [NonSerialized]
        public MoveMessage MovementObserver = null;

        public int Altura { get; private set; }
        public int Largura { get; private set; }
        public PlayerStatus mStatus { get; set; }
        public Point posInicial { get; set; }

        public Dictionary<Point, List<Point>> mCaminho { get; private set; }
        public List<List<Point>> Respostas { get; private set; }

        public List<Point> mPossivelPosCorrente { get; private set; }

        public bool TotalSolution { get; private set; }
        public Jogador(int Largura, int Altura, Point posicao, bool totalSolution)
        {
            this.Largura = Largura;
            this.Altura = Altura;

            mTab = new Tabuleiro(Largura, Altura);
            mPeca = new Cavalo();
            posInicial = posicao;

            mCaminho = new Dictionary<Point, List<Point>>();
            Respostas = new List<List<Point>>();

            TotalSolution = totalSolution;

        }

        public void Start()
        {
            mPosicao = posInicial;
            mTab.setPassou(mPosicao);
            mStatus = PlayerStatus.Iniciando;
            Observer();

        }

        public void Reset()
        {
            mCaminho.Clear();
            mTab.Clear();
            Start();
        }
        public void StartLoop()
        {
            while (mStatus != PlayerStatus.Finalizado)
            {
                Jogar();
            }
        }
        public void Jogar()
        {
            Observer(); 
            switch (mStatus)
            {
                case PlayerStatus.Iniciando:
                    {
                        mStatus = PlayerStatus.ObtendoJogadas;
                        break;
                    }
                case PlayerStatus.Finalizado:
                    {
                        _Fim();
                        break;
                    }
                case PlayerStatus.DescartandoJogada:
                    {

                        mTab.setNaoPassou(mPosicao);
                        mCaminho.Remove(mPosicao);

                        if (mCaminho.Count <= 0)
                        {
                            mStatus = PlayerStatus.NenhumCaminho;
                            break;
                        }

                        Point temp = mCaminho.Keys.Last();
                        ObserverMove(temp);
                        mPosicao = temp;

                        if (mCaminho[mPosicao].Count <= 0)
                        {
                            mStatus = PlayerStatus.DescartandoJogada;
                            break;
                        }

                        mPossivelPosCorrente = mCaminho[mPosicao];

                        mStatus = PlayerStatus.ObtendoJogadasRestantes;
                        break;
                    }
                case PlayerStatus.ObtendoJogadasRestantes:
                    {

                        mStatus = PlayerStatus.MovendoPeça;
                        break;
                    }
                case PlayerStatus.MovendoPeça:
                    {
                        // Ainda tem jogada possível ?
                        if (mCaminho[mPosicao].Count <= 0)
                        {
                            mStatus = PlayerStatus.DescartandoJogada;
                            break;
                        }

                        Point temp = mCaminho[mPosicao][0];
                        mCaminho[mPosicao].Remove(temp);

                        ObserverMove(temp);
                        mPosAnt = mPosicao;
                        mPosicao = temp;

                        mStatus = PlayerStatus.PeçaEmNovaPosição;
                        break;
                    }

                case PlayerStatus.PeçaEmNovaPosição: 
                    {
                        mTab.setPassou(mPosicao);

                        //Doce Vitória ?
                        if (mTab.isCompleto())
                        {
                            mStatus = PlayerStatus.CaminhoEncontrado;
                            break;
                        }

                        if (mCaminho.ContainsKey(mPosicao))
                        {
                            //Essa posição já foi testada aqui ..
                            mStatus = PlayerStatus.DescartandoJogada;
                            break;
                        }
                        else
                        {
                            mCaminho.Add(mPosicao, new List<Point>());
                        }
                        
                        mStatus = PlayerStatus.ObtendoJogadas;
                        break;
                    }
                case PlayerStatus.ObtendoJogadas:
                    {

                        mPossivelPosCorrente = mPeca.getJogadasPossiveis(mPosicao);
                        mStatus = PlayerStatus.TestandoJogadas;
                        break;
                    }
                case PlayerStatus.TestandoJogadas:
                    {

                        // Tirando as Óbvias
                        for (int i = (mPossivelPosCorrente.Count - 1); i >= 0; i--)
                        {
                            Point temp = mPossivelPosCorrente[i];
                            if (temp.X >= Altura)
                                mPossivelPosCorrente.Remove(temp);

                            else if (temp.Y >= Largura)
                                mPossivelPosCorrente.Remove(temp);

                            //Tirando as que já foram
                            else if (mTab.jaPassou(temp))
                                mPossivelPosCorrente.Remove(temp);
                        }
                        mStatus = PlayerStatus.JogadasObtidas;
                        break;
                    }
                case PlayerStatus.JogadasObtidas:
                    {
                        mCaminho[mPosicao] = mPossivelPosCorrente;
                        mStatus = PlayerStatus.MovendoPeça;
                        break;
                    }

                case PlayerStatus.CaminhoEncontrado:
                    {
                        //usar um delegate pra algo do form dizendo que rolou
                        _Vitoria();

                        //Continua até todos os Caminhos encontrados?
                        if (TotalSolution)
                            mStatus = PlayerStatus.DescartandoJogada;
                        else
                            mStatus = PlayerStatus.Finalizado;
                        break;
                    }
                case PlayerStatus.NenhumCaminho:
                    {
                        if (Respostas.Count <= 0)
                            _Derrota();
                        mPossivelPosCorrente = null;
                        //usar um delegate pra algo do form dizendo que rolou
                        mStatus = PlayerStatus.Finalizado;
                        break;
                    }
                default:
                    {
                        throw new NotImplementedException();
                    }
            }
        }

        private void Observer()
        {
            if (StObserver != null)
                StObserver(mStatus);

            //Console.WriteLine("{0} -> {1}", mPosicao.ToString(), mStatus.ToString());
        }

        private void ObserverMove(Point fim)
        {
            if (MovementObserver != null)
                MovementObserver(mPosicao, fim, mStatus);

            //Console.WriteLine("{0} -> {1} = {2}", mPosicao.ToString(), fim.ToString(), mStatus.ToString());
        }

        private void _Vitoria()
        {
            if (StObserver != null)
                StObserver(mStatus);
            Respostas.Add(mCaminho.Keys.ToList());

            foreach (Point pp in mCaminho.Keys)
            {
                Console.Write("{0} ", pp.ToString());
            }
            Console.WriteLine();
        }

        private void _Derrota()
        {
            if (StObserver != null)
                StObserver(mStatus);

            Console.WriteLine("Nenhum caminho possível nesse tabuleiro{0}x{1} dessa posição {2}", Largura, Altura, posInicial);
        }

        private void _Fim()
        {
            if (StObserver != null)
                StObserver(mStatus);
            Console.WriteLine("Todos os caminhos foram testados");
        }

    }

    public enum PlayerStatus
    {
        MovendoPeça,
        ObtendoJogadas,
        Finalizado,
        DescartandoJogada,
        TestandoJogadas,
        CaminhoEncontrado,
        EscolhendoCaminho,
        NenhumCaminho,
        Iniciando,
        PeçaEmNovaPosição,
        JogadasObtidas,
        ObtendoJogadasRestantes,
    }
}
