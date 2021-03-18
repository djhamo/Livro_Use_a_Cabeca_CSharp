using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecoratorStarbuzz.Drinks;
using DecoratorStarbuzz.Condiments;
using DecoratorStarbuzz.Interface;

namespace DecoratorStarbuzz.Test
{
    [TestClass]
    public class DrinkTest
    {
        [TestMethod]
        public void DrinkBasic()
        {
            Beverage beverage = new Expresso();
            Console.WriteLine(beverage);
        }

        [TestMethod]
        public void DrinkDoubleMocha()
        {
            Beverage beverage = new HouseBlend();
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            Console.WriteLine(beverage);
        }
    }
}
