using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyDuck.Fly;
using StrategyDuck.Quacks;
using StrategyDuck.RealDucks;

namespace StrategyDuck.Tests
{
    [TestClass]
    public class DuckTester
    {
        [TestMethod]
        public void TestMallardDuck()
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
        }

        [TestMethod]
        public void TestRocketDuck()
        {
            Duck model = new ModelDuck();
            model.performFly();

            model.flyBehavior = new FlyRocketPowered();

            model.performFly();
        }
    }
}
