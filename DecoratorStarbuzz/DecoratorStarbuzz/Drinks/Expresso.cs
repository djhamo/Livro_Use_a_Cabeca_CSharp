using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorStarbuzz.Interface;

namespace DecoratorStarbuzz.Drinks
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            description = "Expresso";
        }

        public override decimal cost()
        {
            return 1.99M;
        }
    }
}
