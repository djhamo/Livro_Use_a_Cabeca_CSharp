using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CardLib.Tests
{
    [TestClass()]
    public class DeckTests
    {

        [TestMethod()]
        public void DeckTest()
        {
            Deck deck1 = new Deck();
            Deck deck2 = (Deck)deck1.Clone();
            Assert.AreEqual(deck1.GetCard(0), deck2.GetCard(0));
            deck1.Shuffle();
            Assert.AreNotEqual(deck1.GetCard(0), deck2.GetCard(0));

        }
        /*
        [TestMethod()]
        public void CloneTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void GetCardTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void ShuffleTest()
        {

        }
        */
    }
}