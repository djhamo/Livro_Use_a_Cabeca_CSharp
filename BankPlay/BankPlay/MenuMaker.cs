using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPlay
{
    class MenuMaker
    {
        public Random Randomise;

        string[] carne = { "Carne Assada", "Salame", "Peru", "Presunto", "Pastrami" };
        string[] tempero = { "Mostarda Amarela", "Mostarda Marrom", "Mostarda com mel", "Maionese", "Relish", "Molho Especial" };
        string[] pao = { "Pão Branco", "Pao de Forma", "Ciabata", "Pão Italiano", "Baguette", "Pão Francês" };
        public MenuMaker()
        {
            Randomise = new Random();
        }

        public string getNewMenu()
        {
            string saida = "";

            saida = carne[Randomise.Next(carne.Length)];
            saida += " com ";
            saida += tempero[Randomise.Next(tempero.Length)];
            saida += " servido ";
            saida += pao[Randomise.Next(pao.Length)];

            return saida;
        }
    }
}
