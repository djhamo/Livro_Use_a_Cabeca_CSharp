using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            double val = Math.Sin(90);
            Console.WriteLine(val);
            System.Threading.Thread.Sleep(3000);
        }
    }
}
