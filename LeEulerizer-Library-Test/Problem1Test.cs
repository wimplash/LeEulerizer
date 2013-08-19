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
            Assert.AreEqual(new Problem1(1).calculate(), 0);
        }

        [TestMethod]
        public void calculate_three_shouldReturnThree()
        {
            Assert.AreEqual(new Problem1(3).calculate(), 3);
        }
    }
}