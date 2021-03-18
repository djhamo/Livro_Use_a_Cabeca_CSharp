using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KnightRider
{
    [Serializable]
    public class Tabuleiro
    {
        //bool[,] myTabuleiro;
        private int mAltura = 0;
        private int mLargura = 0;
        public bool[,] myTabuleiro { get; set; }
        public Tabuleiro(int altura, int largura)
        {
            // X = Largura = Colunas
            // Y = Altura = Linhas
            myTabuleiro = new bool[largura, altura];
            //myTabuleiro = new bool[altura, largura];
            mAltura = altura;
            mLargura = largura;
        }

        public bool isCompleto()
        {
            for (int lin = 0; lin < mLargura; lin++)
            {
                for (int col = 0; col < mAltura; col++)
                {
                    if (!myTabuleiro[lin, col])
                        return false;
                }
            }
            return true;
        }

        public void setPassou(Point posicao)
        {
            myTabuleiro[posicao.X, posicao.Y] = true;
        }

        public void setNaoPassou(Point posicao)
        {
            myTabuleiro[posicao.X, posicao.Y] = false;
        }

        public bool jaPassou(Point posicao)
        {
            return myTabuleiro[posicao.X, posicao.Y];
        }

        public void Clear()
        {
            for (int lin = 0; lin < mLargura; lin++)
            {
                for (int col = 0; col < mAltura; col++)
                {
                    myTabuleiro[lin, col] = false;
                }
            }
        }
    }
}
