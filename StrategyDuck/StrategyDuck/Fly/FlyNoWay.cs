using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck.Fly
{
    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly :(");
        }
    }
}
