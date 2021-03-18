using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Comic> comics = Comic.BuildCatalog();
            Dictionary<int, decimal> values = Comic.GetPrices();

            var mostExpensive =
                from comic in comics
                where values[comic.Issue] > 500
                orderby values[comic.Issue] descending
                select comic;

            foreach (Comic comic in mostExpensive)
            {
                Console.WriteLine("{0} is worth {1:c}", comic.Name, values[comic.Issue]);
            }
            Console.ReadKey();

            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            int length = random.Next(50, 150);
            for (int i = 0; i < length; i++)
            {
                listOfNumbers.Add(random.Next(100));
            }

            Console.WriteLine("There are {0} numbers", listOfNumbers.Count());
            Console.WriteLine("The smallest is {0}", listOfNumbers.Min());
            Console.WriteLine("The biggest is {0}", listOfNumbers.Max());
            Console.WriteLine("The sum is {0}", listOfNumbers.Sum());
            Console.WriteLine("The Avarege is {0:F2}", listOfNumbers.Average());

            Console.ReadKey();

            var under50sorted =
                from number in listOfNumbers
                where number < 50
                orderby number descending
                select number;

            List<int> newList = under50sorted.ToList();
            foreach (int n in newList)
            {
                Console.Write("{0} ",n);
            }
            Console.WriteLine();
            Console.ReadKey();

            var firstFive = under50sorted.Take(6);

            List<int> shortList = firstFive.ToList();
            foreach (int n in shortList)
            {
                Console.Write("{0} ",n);

            }
            Console.WriteLine();
            Console.ReadKey();

            IEnumerable<Purchase> purchases = Purchase.FindPurchase();

            var results =
                from comic in comics
                join purchase in purchases
                on comic.Issue equals purchase.Issue
                orderby comic.Issue ascending
                select new { comic.Name, comic.Issue, purchase.Price };

            decimal gregsListValue = 0;
            decimal totalSpent = 0;
            foreach (var result in results)
            {
                gregsListValue += values[result.Issue];
                totalSpent += result.Price;
                Console.WriteLine("Issue #{0} ({1}) bought for {2:c}",
                    result.Issue, result.Name, result.Price);
            }
            Console.WriteLine("I Spent {0:c} oncomics worth {1:c}",
                totalSpent, gregsListValue);
            Console.ReadKey();

            string connectionString = "Data Source=|DataDirectory|\\ContactDB.sdf";
            ContactDB context = new ContactDB(connectionString);

            var peopleData =
                from person in context.People
                select new { person.Name, person.Company };

            foreach (var person in peopleData)
            {
                Console.WriteLine("{0} works at {1}", person.Name, person.Company);
            }
            Console.ReadKey();

            IEnumerable<StarbuzzData> starbuzzList = StarbuzzData.GetStarbuzzData();

            var results2 =
                from starbuzzCustomer in starbuzzList
                where starbuzzCustomer.MoneySpent > 90
                join person in context.People
                on starbuzzCustomer.Name equals person.Name
                select new
                {
                    person.Name,
                    person.Company,
                    starbuzzCustomer.FavoriteDrink
                };

            foreach (var row in results2)
            {
                Console.WriteLine("{0} at {1} likes {2}",
                    row.Name, row.Company, row.FavoriteDrink);
            }
            Console.ReadKey();
        }
    }
}
