using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StarBuzz
{
    class Comic
    {
        public string Name { get; set; }
        public int Issue { get; set; }


        public static IEnumerable<Comic> BuildCatalog()
        {
            return new List<Comic> {
                new Comic { Name = "Johnny America vs. the Pinko", Issue = 6 },
                new Comic { Name = "Rock and Roll (limited edition)", Issue = 19 },
                new Comic { Name = "Woman’s Work", Issue = 36 },
                new Comic { Name = "Hippie Madness (misprinted)", Issue = 57 },
                new Comic { Name = "Revenge of the New Wave Freak (damaged)", Issue = 68 },
                new Comic { Name = "Black Monday", Issue = 74 },
                new Comic { Name = "Tribal Tattoo Madness", Issue = 83 },
                new Comic { Name = "The Death of an Object", Issue = 97 },
            };
        }

        public static Dictionary<int, decimal> GetPrices()
        {
            return new Dictionary<int, decimal> {
                { 6, 3600M },
                { 19, 500M },
                { 36, 650M },
                { 57, 13525M },
                { 68, 250M },
                { 74, 75M },
                { 83, 25.75M },
                { 97, 35.25M },
            };
        }

        
    }
    enum PriceRange { Cheap, Midrange, Expensive }

    class Purchase
    {
        public int Issue { get; set; }
        public decimal Price { get; set; }

        public static IEnumerable<Purchase> FindPurchase()
        {
            List<Purchase> purchases = new List<Purchase>() 
            {
                new Purchase() { Issue = 68, Price = 225M },
                new Purchase() { Issue = 19, Price = 375M },
                new Purchase() { Issue = 6, Price = 3600M },
                new Purchase() { Issue = 57, Price = 13215M },
                new Purchase() { Issue = 36, Price = 660M },
            };
            return purchases;
        }
    }


}
