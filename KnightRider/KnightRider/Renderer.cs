using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
// X = Largura = Colunas
// Y = Altura = Linhas 

namespace KnightRider
{
    public class Renderer
    {
        public const int xspan = 50;
        public const int yspan = 50;

        public Jogador mJogador { get; set; }
        private TabForm tabForm;
        Bitmap Cavalinho;
        public Renderer(Jogador jogador, TabForm tabForm)
        {
            this.mJogador = jogador;
            this.tabForm = tabForm;
            tabForm.Renderer = this;

            tabForm.ClientSize = new Size(xspan * jogador.Largura, yspan * jogador.Altura);

            Cavalinho = ResizeBitmap(Properties.Resources._40px_Chess_ndt45_svg, xspan, yspan);
            Render(tabForm.CreateGraphics());
        }

        public void ResizeTabuleiro(int larg, int alt)
        {
            tabForm.ClientSize = new Size(xspan * larg, yspan * alt);
        }

        public void Render()
        {
            Render(mJogador, tabForm.CreateGraphics());
        }
        public void Render(Graphics g)
        {
            DesenhaTabuleiro(mJogador, g);

            if (mJogador.mStatus == PlayerStatus.JogadasObtidas)
                DesenhaPossiveis(mJogador, g);
            if (mJogador.mStatus == PlayerStatus.PeçaEmNovaPosição)
                DesenhaMovimento(mJogador, g);
            if (mJogador.mStatus == PlayerStatus.ObtendoJogadasRestantes)
                DesenhaPossiveis(mJogador, g);

            DesenhaCavalo(mJogador, g);
        }

        public void Render(Jogador jog, Graphics g)
        {
            DesenhaTabuleiro(jog, g);

            if (jog.mStatus == PlayerStatus.JogadasObtidas)
                DesenhaPossiveis(jog, g);
            if (jog.mStatus == PlayerStatus.PeçaEmNovaPosição)
                DesenhaMovimento(jog, g);
            if (jog.mStatus == PlayerStatus.ObtendoJogadasRestantes)
                DesenhaPossiveis(jog, g);

            DesenhaCavalo(jog, g);
        }

        private void DesenhaTabuleiro(Jogador jogador, Graphics g)
        {

            bool isBlackSquareTime = true;
            int posx = 0, posy = 0;
            for (int lin = 0; lin < jogador.Altura; lin++)
            {
                for (int col = 0; col < jogador.Largura; col++)
                {
                    Point temp = new Point(lin, col);
                    if (jogador.mTab.jaPassou(temp))
                    {
                        if (isBlackSquareTime)
                        {
                            g.FillRectangle(Brushes.ForestGreen, posx, posy, xspan, yspan);
                            isBlackSquareTime = !isBlackSquareTime; 
                        }
                        else
                        {
                            g.FillRectangle(Brushes.PaleGreen, posx, posy, xspan, yspan);
                            isBlackSquareTime = !isBlackSquareTime; 
                        }
                    }
                    else
                    {
                        if (isBlackSquareTime)
                        {
                            g.FillRectangle(Brushes.Sienna, posx, posy, xspan, yspan);
                            isBlackSquareTime = !isBlackSquareTime; 
                        }
                        else
                        {
                            g.FillRectangle(Brushes.NavajoWhite, posx, posy, xspan, yspan);
                            isBlackSquareTime = !isBlackSquareTime;
                        }
                    }
                    posx += xspan;
                }
                if ((lin % 2) != 0)
                    isBlackSquareTime = true;
                else
                    isBlackSquareTime = false;
                posy += yspan;
                posx = 0;
            }
        }

        private void DesenhaCavalo(Jogador jogador, Graphics g) 
        {
            Point tempx = new Point();
            // O Desenho é espelhado
            tempx.X = (jogador.mPosicao.Y * xspan);
            tempx.Y = (jogador.mPosicao.X * yspan);
            g.DrawImageUnscaled(Cavalinho, tempx);
        }

        private void DesenhaPossiveis(Jogador jogador, Graphics g) 
        {
            foreach (Point point in jogador.mPossivelPosCorrente)
            {
                int xspanzinho = xspan / 2;
                int yspanzinho = yspan / 2;
                Point tempx = new Point();
                tempx.X = (point.X * xspan);
                tempx.Y = (point.Y * yspan);
                g.FillEllipse(Brushes.Black, tempx.Y + (yspanzinho / 2), tempx.X + (xspanzinho / 2), yspanzinho, xspanzinho);
            }
        }

        private void DesenhaMovimento(Jogador jogador, Graphics g)
        {
            Point tempAnt = jogador.mPosAnt;
            Point tempAtu = jogador.mPosicao;


            List<Point> tCam = Cavalo.getCaminhoJogada(tempAnt, tempAtu);
            if (tCam != null)
            {
                foreach (Point point in tCam)
                {
                    Point tempx = new Point();
                    tempx.X = (point.X * xspan);
                    tempx.Y = (point.Y * yspan);
                    g.FillRectangle(Brushes.Blue, tempx.Y, tempx.X, yspan, xspan);

                }

                Point temp = new Point();
                temp.X = (tempAnt.X * xspan);
                temp.Y = (tempAnt.Y * yspan);
                g.FillRectangle(Brushes.Blue, temp.Y, temp.X, yspan, xspan);
                temp.X = (tempAtu.X * xspan);
                temp.Y = (tempAtu.Y * yspan);
                g.FillRectangle(Brushes.Blue, temp.Y, temp.X, yspan, xspan);
            }

        }


        public static Bitmap ResizeBitmap(Image ImageToSize, int Width, int Height)
        {
            Bitmap bitmap = new Bitmap(Width, Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawImage(ImageToSize, 0, 0, Width, Height);
            }
            return bitmap;
        }
    }
}
