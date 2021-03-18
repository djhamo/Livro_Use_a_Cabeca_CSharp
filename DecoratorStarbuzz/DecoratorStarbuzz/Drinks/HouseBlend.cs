using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorStarbuzz.Interface;

namespace DecoratorStarbuzz.Drinks
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override decimal cost()
        {
            return .89M;
        }
    }
}
