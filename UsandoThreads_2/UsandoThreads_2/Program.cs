using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace UsandoThreads_2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(NovaThread).Start();
            NovaThread();
            Console.ReadKey();
        }

        static void NovaThread()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("2");
            }
        }
    }
}
