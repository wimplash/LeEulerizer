using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeEulerizer_Library;

namespace LeEulerizer_Library_Test
{
    [TestClass]
    public class Problem1Test
    {
        private Problem1 cut;

        [TestInitialize]
        public void CreateClassUnderTest()
        {
            cut = new Problem1();
        }

        [TestMethod]
        public void Calculate_shouldReturnZeroWhenPassedThree()
        {
            Assert.AreEqual(0, cut.Calculate(3));
        }

        [TestMethod]
        public void Calculate_shouldReturnThreeWhenPassedFour()
        {
            Assert.AreEqual(3, cut.Calculate(4));
        }

        [TestMethod]
        public void Calculate_shouldReturnEightWhenPassedSix()
        {
            Assert.AreEqual(8, cut.Calculate(6));
        }

        [TestMethod]
        public void Calculate_shouldReturnTwentyThreeWhenPassedTen()
        {
            Assert.AreEqual(23, cut.Calculate(10));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Calculate_shouldThrowExceptionWhenPassedZero()
        {
            cut.Calculate(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Calculate_shouldThrowExceptionWhenPassedNegativeOne()
        {
            cut.Calculate(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Calculate_shouldThrowExceptionWhenPassedOne()
        {
            cut.Calculate(1);
        }
    }
}