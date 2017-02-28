using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void TestHandHaveSpecificCards()
        {
            Hand hand = new Hand(
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Clubs)
                );

            string actual = hand.ToString();
            string expected = "A♠J♦3♠5♥2♣";
            Assert.AreEqual(expected, actual);
        }
    }
}