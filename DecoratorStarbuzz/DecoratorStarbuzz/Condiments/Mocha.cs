using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorStarbuzz.Interface;

namespace DecoratorStarbuzz.Condiments
{
    public class Mocha : CondimentDecoratorcs
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            this.description = beverage.getDescription();
        }

        public override string getDescription()
        {
            return description + ", Mocha";
        }
        public override decimal cost()
        {
            return .20M + beverage.cost();
        }
    }
}
