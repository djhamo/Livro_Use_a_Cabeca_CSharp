using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveSystem
{
    class Bee
    {
        public Bee(double weight)
        {
            this.weight = weight;
        }

        private double weight = 0.0;

        public virtual int ShiftsLeft
        {
            get { return 0;  }
        }

        public virtual double GetHoneyConsumption()
        {
            double consumption = 0.0;
            if (ShiftsLeft == 0)
                consumption = 7.5;
            else
                consumption = ShiftsLeft + 9;

            if (weight > 150)
                consumption *= 1.35;

            return consumption;
        }

    }
}
