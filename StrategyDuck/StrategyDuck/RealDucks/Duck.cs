using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyDuck.Fly;
using StrategyDuck.Quacks;

namespace StrategyDuck
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior { private get;  set; }
        public QuackBehavior quackBehavior { private get; set; }

        public Duck()
        {

        }

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
