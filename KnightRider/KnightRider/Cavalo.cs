using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KnightRider
{
    [Serializable]
    public class Cavalo
    {
        public List<Point> getJogadasPossiveis(Point posicao)
        {
            List<Point> result = new List<Point>();

            // X = Largura = Colunas
            // Y = Altura = Linhas
            Point temp = new Point();
            //2 pra cima
            //1 pra esq
            temp = posicao;
            temp.Y += 2;
            temp.X -= 1;
            if (isPosicaoValida(temp))
                result.Add(temp);
            //1 pra dir
            temp = posicao;
            temp.Y += 2;
            temp.X += 1;
            if (isPosicaoValida(temp))
                result.Add(temp);
            
            //2 pra traz
            //1 pra esq
            temp = posicao;
            temp.Y -= 2;
            temp.X += 1;
            if (isPosicaoValida(temp))
                result.Add(temp);
            //1 pra dir
            temp = posicao;
            temp.Y -= 2;
            temp.X -= 1;
            if (isPosicaoValida(temp))
                result.Add(temp);

            //2 pra esq
            //1 pra frente
            temp = posicao;
            temp.Y += 1;
            temp.X -= 2;
            if (isPosicaoValida(temp))
                result.Add(temp);
            //1 pra traz
            temp = posicao;
            temp.Y -= 1;
            temp.X -= 2;
            if (isPosicaoValida(temp))
                result.Add(temp);

            //2 pra dir
            //1 pra frente
            temp = posicao;
            temp.Y += 1;
            temp.X += 2;
            if (isPosicaoValida(temp))
                result.Add(temp);
            //1 pra traz
            temp = posicao;
            temp.Y -= 1;
            temp.X += 2;
            if (isPosicaoValida(temp))
                result.Add(temp);

            return result;
        }


        private bool isPosicaoValida(Point posicao)
        {
            if (posicao.X < 0 || posicao.Y < 0)
            {
                return false;
            }
            return true;
        }

        public static List<Point> getCaminhoJogada(Point posicao, Point final)
        {
            List<Point> result = new List<Point>();

            Point temp = new Point();
            //2 pra frete
            //1 pra esq
            temp = posicao;
            temp.Y += 1;
            result.Add(temp);
            temp.Y += 1;
            result.Add(temp);
            temp.X -= 1;
            result.Add(temp);
            if (temp == final)
                return result;
            //1 pra dir
            result.Clear();
            temp = posicao;
            temp.Y += 1;
            result.Add(temp);
            temp.Y += 1;
            result.Add(temp);
            temp.X += 1;
            result.Add(temp);
            if (temp == final)
                return result;

            //2 pra traz
            //1 pra esq
            result.Clear();
            temp = posicao;

            temp.Y -= 1;
            result.Add(temp);
            temp.Y -= 1;
            result.Add(temp);
            temp.X += 1;
            result.Add(temp);
            if (temp == final)
                return result;

            //1 pra dir
            result.Clear();
            temp = posicao;
            temp.Y -= 1;
            result.Add(temp);
            temp.Y -= 1;
            result.Add(temp);
            temp.X -= 1;
            result.Add(temp);
            if (temp == final)
                return result;

            //2 pra esq
            //1 pra frente
            result.Clear();
            temp = posicao;
            temp.Y += 1;
            result.Add(temp);
            temp.X -= 1;
            result.Add(temp);
            temp.X -= 1;
            result.Add(temp);
            if (temp == final)
                return result;
            //1 pra traz
            result.Clear();
            temp = posicao;
            temp.Y -= 1;
            result.Add(temp);
            temp.X -= 1;
            result.Add(temp);
            temp.X -= 1;
            result.Add(temp);
            if (temp == final)
                return result;

            //2 pra dir
            //1 pra frente
            result.Clear();
            temp = posicao;
            temp.Y += 1;
            result.Add(temp);
            temp.X -= 1;
            result.Add(temp);
            temp.X -= 1;
            result.Add(temp);
            if (temp == final)
                return result;
            //1 pra traz
            result.Clear();
            temp = posicao;
            temp.Y -= 1;
            result.Add(temp);
            temp.X += 1;
            result.Add(temp);
            temp.X += 1;
            result.Add(temp);
            if (temp == final)
                return result;

            return null;

        }

    }


}
