using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class TestCalLib
    {
        [TestMethod]
        public void Test_Sum()
        {
            int a = 10;
            int b = 15;
            int x = 25;
            Assert.AreEqual(x, CalculateLib.CalCulate.Sum(a, b));
        }
        [TestMethod]
        public void Test_Div()
        {
            int a = 10;
            int b = 15;
            int x = -5;
            Assert.AreEqual(x, CalculateLib.CalCulate.Div(a, b));
        }
    }
}
