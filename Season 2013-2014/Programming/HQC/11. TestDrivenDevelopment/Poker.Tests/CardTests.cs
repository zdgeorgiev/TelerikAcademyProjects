using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestToStringAceSpades()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Spades);
            string actual = card.ToString();
            string expected = "A♠";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringTwoClubs()
        {
            Card card = new Card(CardFace.Two, CardSuit.Clubs);
            string actual = card.ToString();
            string expected = "2♣";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringTenHearts()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Hearts);
            string actual = card.ToString();
            string expected = "10♥";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringJackDiamonds()
        {
            Card card = new Card(CardFace.Jack, CardSuit.Diamonds);
            string actual = card.ToString();
            string expected = "J♦";
            Assert.AreEqual(expected, actual);
        }
    }
}