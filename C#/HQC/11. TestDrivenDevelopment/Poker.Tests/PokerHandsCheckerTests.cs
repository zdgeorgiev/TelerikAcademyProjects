using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class PokerHandsCheckerTests
    {
        [TestMethod]
        public void TestIsHandValid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Clubs)
                );

            bool actual = checker.IsValidHand(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsntHandValidWithSixCards()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts)
                );

            bool actual = checker.IsValidHand(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStraightFromTenToAce()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts)
                );

            bool actual = checker.IsStraight(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStraightFromAceToFive()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts)
                );

            bool actual = checker.IsStraight(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStraightFromAceToFiveWithoutFive()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts)
                );

            bool actual = checker.IsStraight(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFlushForClubs()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Clubs)
                );

            bool actual = checker.IsFlush(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFlushForHearts()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Diamonds)
                );

            bool actual = checker.IsFlush(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInvalidFlushWith3EqualSuits()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Diamonds)
                );

            bool actual = checker.IsFlush(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStraightFlushWithSortedHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades)
                );

            bool actual = checker.IsStraightFlush(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStraightFlushInRandomOrder()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades)
                );

            bool actual = checker.IsStraightFlush(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLowerStraightFlushWithNoAce()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades)
                );

            bool actual = checker.IsStraightFlush(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLowerStraightFlushWithNo4Suites()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Spades)
                );

            bool actual = checker.IsStraightFlush(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLowerStraightFlushWith2Aces()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Spades)
                );

            bool actual = checker.IsStraightFlush(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStraightFlushWithNoStraight()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades)
                );

            bool actual = checker.IsStraightFlush(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIStraightFlushWithNoFlush()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades)
                );

            bool actual = checker.IsStraightFlush(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStraightFlushFromAceToFive()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades)
                );

            bool actual = checker.IsStraightFlush(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPairOfFours()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades)
                );

            bool actual = checker.IsOnePair(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPairOfTens()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades)
                );

            bool actual = checker.IsOnePair(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPairWithNoSameCards()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades)
                );

            bool actual = checker.IsOnePair(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTwoPairsOfFoursAndTens()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Diamonds)
                );

            bool actual = checker.IsTwoPair(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTwoPairOfAcesAndThrees()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades)
                );

            bool actual = checker.IsTwoPair(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTwoPairFail()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Spades)
                );

            bool actual = checker.IsTwoPair(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThreeOfAKindAces()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades)
                );

            bool actual = checker.IsThreeOfAKind(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThreeOfAKindJacks()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades)
                );

            bool actual = checker.IsThreeOfAKind(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThreeOfAKindWithNo3SameCards()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades)
                );

            bool actual = checker.IsThreeOfAKind(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThreeOfAKindFives()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades)
                );

            bool actual = checker.IsThreeOfAKind(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThreeOfAKindFivesDifferentPlace()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds)
                );

            bool actual = checker.IsThreeOfAKind(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThreeOfAKindFivesDifferentPlace1()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Spades)
                );

            bool actual = checker.IsThreeOfAKind(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThreeOfAKindFivesDifferentPlace2()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Clubs)
                );

            bool actual = checker.IsThreeOfAKind(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInvalidThreeOfAKindSpecificCase()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs)
                );

            bool actual = checker.IsThreeOfAKind(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFourOfAKindOfSevens()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Hearts)
                );

            bool actual = checker.IsFourOfAKind(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFourOfAKindOfSevensDifOrder()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Hearts)
                );

            bool actual = checker.IsFourOfAKind(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFourOfAKindOfSevensDifOrder2()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Hearts)
                );

            bool actual = checker.IsFourOfAKind(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFourOfAKindFailTest()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Hearts)
                );

            bool actual = checker.IsFourOfAKind(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFullHouseWithAcesAdndThrees()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Hearts)
                );

            bool actual = checker.IsFullHouse(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFullHouseWithFoursAdndTens()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts)
                );

            bool actual = checker.IsFullHouse(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInvalidFullHouseWithNoPair()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts)
                );

            bool actual = checker.IsFullHouse(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInvalidFullHouseWithNoPair2()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Hearts)
                );

            bool actual = checker.IsFullHouse(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestHighCardAce()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Hearts)
                );

            bool actual = checker.IsHighCard(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestHighCardKing()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Hearts)
                );

            bool actual = checker.IsHighCard(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestHighCardQueen()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts)
                );

            bool actual = checker.IsHighCard(hand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTwoPairsFailWithThreeOfAKind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Hearts)
                );

            bool actual = checker.IsTwoPair(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThreeOfAKindWithFourOfAKind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Hearts)
                );

            bool actual = checker.IsThreeOfAKind(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStraightFailWithStraightFlush()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
                );

            bool actual = checker.IsStraight(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestOnePairFailWithTwoPairs()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Hearts)
                );

            bool actual = checker.IsOnePair(hand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}