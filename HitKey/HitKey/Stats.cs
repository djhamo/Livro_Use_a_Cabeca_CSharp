using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitKey
{
    class Stats
    {
        public int Total = 0;
        public int Missed = 0;
        public int Correct = 0;
        public double Accuracy = 100d;

        public void Update(bool correctKey)
        {
            Total++;
            if (!correctKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }
            //Accuracy = 100;
            Accuracy = (100 * Correct) / Total;
            Console.WriteLine("Accuracy" + Accuracy.ToString() + "%");
        }
    }
}
