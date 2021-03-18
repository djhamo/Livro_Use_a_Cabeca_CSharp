using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCards
{
    enum Suits {
        Espadas,
        Copas,
        Paus,
        Ouros
    }

    enum Values
    {
        Ás = 1,
        Dois = 2,
        Três = 3,
        Quatro = 4,
        Cinco = 5,
        Seis = 6,
        Sete = 7,
        Oito = 8,
        Nove = 9,
        Dez = 10,
        Valete = 11,
        Dama = 12,
        Rei = 13
    }

    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public string Name
        {
            get
            {
                return Value.ToString() + " de " + Suit.ToString();
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public static string Plural(Values value)
        {
            if (value == Values.Ás)
                return "Azes";
            else if (value == Values.Dama)
                return "Damas";
            else if (value == Values.Valete)
                return "Valetes";
            else if (value == Values.Rei)
                return "Reis";
            else
                return value.ToString();
        }
    }

    class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value < y.Value)
            {
                return -1;
            }
            if (x.Value > y.Value)
            {
                return 1;
            }
            if (x.Suit < y.Suit)
            {
                return -1;
            }
            if (x.Suit > y.Suit)
            {
                return 1;
            }
            return 0;
        }
    }

    class CardComparer_bySuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Suit < y.Suit)
            {
                return -1;
            }
            if (x.Suit > y.Suit)
            {
                return 1;
            }
            if (x.Value < y.Value)
            {
                return -1;
            }
            if (x.Value > y.Value)
            {
                return 1;
            }
            return 0;
        }
    }
}
