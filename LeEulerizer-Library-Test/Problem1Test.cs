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
        public void calculate_one_shouldReturnZero()
        {
            Assert.AreEqual(0, new Problem1(1).calculate());
        }

        [TestMethod]
        public void calculate_three_shouldReturnThree()
        {
            Assert.AreEqual(3, new Problem1(3).calculate());
        }

        [TestMethod]
        public void calculate_five_shouldReturnEight()
        {
            Assert.AreEqual(8, new Problem1(5).calculate());
        }
    }
}