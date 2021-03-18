using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck.Quacks
{
    public class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
