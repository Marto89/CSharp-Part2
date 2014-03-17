//Write a test program to check if the method "CountNum" is working correctly.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04.CountNumInArray_Test
{
    [TestClass]
    public class UnitTest1
    {
        int minValue = int.MinValue;
        int maxValue = int.MaxValue;
        [TestMethod]
        public void TestMethod1()
        {
            int [] testArray = { 1, 3, 1, 5, 1, 3, 2 };
            int seekingNumber = 1;
            Assert.AreEqual(3, CountNumInArray.CountNum(testArray,seekingNumber));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] testArray = { 1, 3, 1, 5, 1, 3, 2 };
            int seekingNumber = 3;
            Assert.AreEqual(2, CountNumInArray.CountNum(testArray, seekingNumber));
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] testArray = { minValue, 2, 1, 5, minValue, 3, minValue };
            int seekingNumber = minValue;
            Assert.AreEqual(3, CountNumInArray.CountNum(testArray, seekingNumber));
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] testArray = { 1, maxValue, 1, 5, minValue, 3, maxValue };
            int seekingNumber = maxValue;
            Assert.AreEqual(2, CountNumInArray.CountNum(testArray, seekingNumber));
        }
    }
}