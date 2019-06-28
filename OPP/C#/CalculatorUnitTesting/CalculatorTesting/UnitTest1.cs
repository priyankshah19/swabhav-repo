using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorUnitTesting;
namespace CalculatorTesting
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void ADD_Normal_ReturnAddition()
        {
            var calculator = new Calculator();
            var result = calculator.Add(10, 20);
            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void ADD_Exception_ReturnAddition()
        {
            var calculator = new Calculator();
            var result1 = calculator.Add(10, 20);
            Assert.AreEqual(30, result1);
        }
    }
}
