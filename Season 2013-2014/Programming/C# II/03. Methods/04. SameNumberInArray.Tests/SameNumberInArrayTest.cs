using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04.SameNumberInArray.Tests
{
    [TestClass]
    public class SameNumberInArrayTest
    {
        [TestMethod]
        public void TestSameArrayNumbersWithTheNumber()
        {
            int[] array = new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };

            int number = 9;
            int expectedNumberCount = array.Length;

            int actualNumberCount = SameNumberInArray.NumberCount(array, number);

            Assert.AreEqual(expectedNumberCount, actualNumberCount);
        }

        [TestMethod]
        public void TestSameArrayNumbersAndDifferentNumber()
        {
            int[] array = new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };

            int number = -1;
            int expectedNumberCount = 0;

            int actualNumberCount = SameNumberInArray.NumberCount(array, number);

            Assert.AreEqual(expectedNumberCount, actualNumberCount);
        }

        [TestMethod]
        public void TestFirstAndTheLastNumbers()
        {
            int[] array = new int[] { 2, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 2 };

            int number = 2;
            int expectedNumberCount = 2;

            int actualNumberCount = SameNumberInArray.NumberCount(array, number);

            Assert.AreEqual(expectedNumberCount, actualNumberCount);
        }
    }
}
