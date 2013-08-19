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
        public void Calculate_shouldReturnZeroWhenPassedThree()
        {
            Assert.AreEqual(0, new Problem1().Calculate(3));
        }

        [TestMethod]
        public void Calculate_shouldReturnThreeWhenPassedFour()
        {
            Assert.AreEqual(3, new Problem1().Calculate(4));
        }

        [TestMethod]
        public void Calculate_shouldReturnEightWhenPassedSix()
        {
            Assert.AreEqual(8, new Problem1().Calculate(6));
        }

        [TestMethod]
        public void Calculate_shouldReturnTwentyThreeWhenPassedTen()
        {
            Assert.AreEqual(23, new Problem1().Calculate(10));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Calculate_shouldThrowExceptionWhenPassedZero()
        {
            new Problem1().Calculate(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Calculate_shouldThrowExceptionWhenPassedNegativeOne()
        {
            new Problem1().Calculate(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Calculate_shouldThrowExceptionWhenPassedOne()
        {
            new Problem1().Calculate(1);
        }
    }
}