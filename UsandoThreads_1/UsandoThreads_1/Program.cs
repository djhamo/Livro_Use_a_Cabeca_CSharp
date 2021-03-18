using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UsandoThreads_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(NovaThread);
            t.Start();

            for (int i = 0; i < 10000; i++)
            {
                Console.Write("1");
            }
        }

        static void NovaThread()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.Write("2");
            }
        }
    }
}
