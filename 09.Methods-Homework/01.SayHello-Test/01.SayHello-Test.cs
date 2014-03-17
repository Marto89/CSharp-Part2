//Write a program to test "PrintName" method.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01.SayHello_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string firstTest = SayHello.PrintName("Peter");
            Assert.AreEqual("Hello, Peter!", firstTest);
        }
    }
}
