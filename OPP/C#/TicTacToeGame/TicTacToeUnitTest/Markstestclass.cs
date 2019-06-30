using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;

namespace TicTacToeUnitTest
{
    [TestClass]
    public class Markstestclass
    {
        [TestMethod]
        public void InitialMarktestMethod()
        {
            Cell cell= new Cell();

            Assert.AreEqual(Mark.EMPTY, cell.MARK);
        }
        [TestMethod]
        public void XMarkTestMethod()
        {
            Cell cell = new Cell();
            cell.MARK = Mark.O;
            Assert.AreEqual(Mark.O,cell.MARK);
            
        }
        [TestMethod]
        public void OMarkTestMethod()
        {
            Cell cell = new Cell();
            cell.MARK = Mark.O;
            Assert.AreEqual(Mark.O, cell.MARK);

        }
        [TestMethod]
        public void IsalreadyMarkedMethodTest()

        {
            Cell cell = new Cell();
            
            Assert.AreEqual(false,cell.IsAlreadymarked());

        }
    }
}
