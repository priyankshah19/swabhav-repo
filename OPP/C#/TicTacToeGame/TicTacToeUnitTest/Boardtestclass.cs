using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;
namespace TicTacToeUnitTest
{
    [TestClass]
    public class Boardtestclass
    {
        [TestMethod]
        public void IsAllCellPositionInitiallyEmpty()
        {
            Board board = new Board();
            foreach(Cell cell in board.Getcells)
            {
                Assert.AreEqual(Mark.EMPTY, cell.MARK);
            }

        }
        [TestMethod]
        public void TestsetandgetPosition()
        {
            Board board = new Board();
            board.SetPosition(1,Mark.O);
            Assert.AreEqual(Mark.O, board.Getpositionmark(1));
            try
            {
                board.SetPosition(1, Mark.X);
            }
            catch(Exception e)
            {
                Assert.AreEqual("cell is already filled",e.Message);
            }
            
        }
        [TestMethod]
        public void TestIsBoardEmpty()
        {
            Board board = new Board();
            Assert.AreEqual(true, board.IsBoardEmpty());
            board.SetPosition(1, Mark.X);
            Assert.AreEqual(false,board.IsBoardEmpty());
        }
        [TestMethod]
        public void TestIsBoardFull()
        {
            Board board = new Board();

            foreach (Cell cell in board.Getcells)
            {
                cell.MARK = Mark.O;
            }
            Assert.AreEqual(true, board.IsBoardFull());
        }


    }
}
