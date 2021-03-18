using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck.Fly
{
    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm Flying!!");
        }
    }
}
