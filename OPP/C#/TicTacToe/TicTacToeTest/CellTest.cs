using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;
namespace TicTacToeTest
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
        public void CellShouldBeMarkedX()
        {
            Cell cell = new Cell();
            cell.SetMark(Mark.X);
            var result = cell.GetMark();
            Assert.AreEqual(result,Mark.X);
        }
        [TestMethod]
        public void CellShouldBeMarkedO()
        {
            Cell cell = new Cell();
            cell.SetMark(Mark.O);
            var result = cell.GetMark();
            Assert.AreEqual(result,Mark.O);
        }
        [TestMethod]
        public void CellShouldBeMarkedEmpty()
        {
            Cell cell = new Cell();
            var result = cell.GetMark();
            Assert.AreEqual(result,Mark.EMPTY);
        }
    }
}
