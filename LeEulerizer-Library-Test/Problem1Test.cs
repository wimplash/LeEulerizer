using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeEulerizer_Library;

namespace LeEulerizer_Library_Test
{
    [TestClass]
    public class Problem1Test
    {
        [TestMethod]
        public void Problem1_canBeConstructed()
        {
            Assert.IsNotNull(new Problem1());
        }

        [TestMethod]
        public void calculate_three_shouldReturnZero()
        {
            Assert.AreEqual(0, new Problem1().calculate(3));
        }

        [TestMethod]
        public void calculate_four_shouldReturnThree()
        {
            Assert.AreEqual(3, new Problem1().calculate(4));
        }

        [TestMethod]
        public void calculate_six_shouldReturnEight()
        {
            Assert.AreEqual(8, new Problem1().calculate(6));
        }

        [TestMethod]
        public void calculate_ten_shouldReturnTwentyThree()
        {
            Assert.AreEqual(23, new Problem1().calculate(10));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void calculate_shouldThrowExceptionWhenPassedZero()
        {
            new Problem1().calculate(0);
        }
    }
}