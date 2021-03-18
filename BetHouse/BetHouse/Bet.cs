using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetHouse
{
    class Bet
    {
        private int amount = 0;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private int dog = 0;
        public int Dog
        {
            get { return dog; }
            set { dog = value; }
        }
        private Guy Bettor;

        public Bet(Guy nBettor)
        {
            Bettor = nBettor;
        }

        public string getDescription()
        {
            string saida;
            if (Dog != 0) 
            {
                saida = Bettor.Name + " apostou $" + this.Amount + " no Cachorro #" + this.Dog;
            }
            else
            {
                saida = Bettor.Name + " apostou $" + this.Amount + " em Nenhum Cachorro";
            }
            
            return saida;
        }

        public int PayOut(int Winner)
        {
            if (Winner == Dog)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
