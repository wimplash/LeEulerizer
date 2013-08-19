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
            Assert.IsNotNull(new Problem1(10));
        }

        [TestMethod]
        public void calculate_three_shouldReturnZero()
        {
            Assert.AreEqual(0, new Problem1(3).calculate());
        }

        [TestMethod]
        public void calculate_four_shouldReturnThree()
        {
            Assert.AreEqual(3, new Problem1(4).calculate());
        }

        [TestMethod]
        public void calculate_six_shouldReturnEight()
        {
            Assert.AreEqual(8, new Problem1(6).calculate());
        }

        [TestMethod]
        public void calculate_ten_shouldReturnTwentyThree()
        {
            Assert.AreEqual(23, new Problem1(10).calculate());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void constructor_shouldThrowExceptionWhenPassedZero()
        {
            new Problem1(0);
        }
    }
}