﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Representante
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertIntToString someMethod = new ConvertIntToString(HiThere);
            string message = someMethod(5);
            Console.WriteLine(message);
            Console.ReadKey();
        }

        private static string HiThere(int i)
        {
            return "Hi There! #" + (i * 100); 
        }
    }
}
