using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib.Tests
{
    [TestClass()]
    public class CardTests
    {
        [TestMethod()]
        public void CardTest()
        {
            Card card = new Card(Suit.Copas, Rank.As);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Card card = new Card(Suit.Copas, Rank.As);
            Assert.AreEqual("The As of Copas", card.ToString());
        }

        [TestMethod()]
        public void ComparationTest()
        {
            Card.isAceHigh = true;
            Card.useTrumps = true;
            Card.trump = Suit.Paus;

            Card card1, card2, card3, card4, card5;
            card1 = new Card(Suit.Paus, Rank.Cinco);
            card2 = new Card(Suit.Paus, Rank.Cinco);
            card3 = new Card(Suit.Paus, Rank.As);
            card4 = new Card(Suit.Copas, Rank.Dez);
            card5 = new Card(Suit.Ouros, Rank.As);
            Assert.AreEqual(card1, card2);
            Assert.AreNotEqual(card1, card3);
            Assert.IsFalse(card1.Equals(card4));
            Assert.IsFalse(Card.Equals(card3, card4));
            Assert.IsFalse(card1 > card2);
            Assert.IsTrue(card1 <= card3);
            Assert.IsTrue(card1 > card4);
            Assert.IsFalse(card4 > card1);
            Assert.IsTrue(card5 > card4);
            Assert.IsTrue(card4 > card5);

        }
    }
}