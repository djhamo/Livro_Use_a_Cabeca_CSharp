using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobustGuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter birthday: ");
            string birthday = Console.ReadLine();
            Console.Write("Ener height in inches: ");
            string height = Console.ReadLine();
            RobustGuy guy = new RobustGuy(birthday, height);
            Console.WriteLine(guy.ToString());
            Console.ReadKey();
        }
    }
}
