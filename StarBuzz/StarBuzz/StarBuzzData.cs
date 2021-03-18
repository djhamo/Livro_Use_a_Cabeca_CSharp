using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    class StarbuzzData
    {
        public string Name { get; set; }
        public Drink FavoriteDrink { get; set; }
        public int MoneySpent { get; set; }
        public int Visits { get; set; }

        public static IEnumerable<StarbuzzData> GetStarbuzzData()
        {
            return new List<StarbuzzData> {
                new StarbuzzData {
                    Name = "Janet Venutian", FavoriteDrink = Drink.ChocoMacchiato,
                    MoneySpent = 255, Visits = 50 },
                new StarbuzzData {
                    Name = "Liz Nelson", FavoriteDrink = Drink.DoubleCappuccino,
                    MoneySpent = 150, Visits = 35 },
                new StarbuzzData {
                    Name = "Matt Franks", FavoriteDrink = Drink.ZestyLemonChai,
                    MoneySpent = 75, Visits = 15 },
                new StarbuzzData {
                    Name = "Joe Ng", FavoriteDrink = Drink.BananaSplitInACup,
                    MoneySpent = 60, Visits = 10 },
                new StarbuzzData {
                    Name = "Sarah Kalter", FavoriteDrink = Drink.BoringCoffee,
                    MoneySpent = 110, Visits = 15 }
            };
        }

    }

    enum Drink
    {
        BoringCoffee,
        ChocoRockoLatte,
        TripleEspresso,
        ZestyLemonChai,
        DoubleCappuccino,
        HalfCafAmericano,
        ChocoMacchiato,
        BananaSplitInACup,
    }
}
