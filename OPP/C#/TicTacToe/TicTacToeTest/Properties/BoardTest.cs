using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;

namespace TicTacToeTest
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void BoardIsEmpty_IsTrue()
        {
            Board board = new Board();
            Assert.AreEqual(true, board.IsBoardEmpty());
        }
        [TestMethod]
        public void AddXAtParticularLocation()
        {
            Board board = new Board();
            int index = 3;
            Mark mark = Mark.X;
            board.SetLocation(mark, index);
            Cell[] celltest = board.GetCells();
            Assert.AreEqual(Mark.X, celltest[3].GetMark());
        }
        [TestMethod]
        public void AddOAtParticularLocation()
        {
            Board board = new Board();
            int index = 3;
            Mark mark = Mark.O;
            board.SetLocation(mark, index);
            Cell[] celltest = board.GetCells();
            Assert.AreEqual(Mark.O, celltest[3].GetMark());
        }
        [TestMethod]
        public void BoardisFull_isTrue()
        {
            Board board = new Board();
            for (int index = 0; index < 9; index++)
            {
                board.SetLocation(Mark.O, index);
            }
            Assert.AreEqual(true, board.IsBoardFull());



        }
        [TestMethod]
        public void AddingDifferentValueAtSameIndex_ThrowsException()
        {
            Board board = new Board();
            Exception expectedexception = null;
            try
            {
                board.SetLocation(Mark.O, 3);
                board.SetLocation(Mark.X, 3);
                Cell[] celltest = board.GetCells();
            }
            catch(Exception exception)
            {
                expectedexception = exception;
            }
            Assert.IsNotNull(expectedexception);
        }
        [TestMethod]
        public void AddingValueAtIndexGreaterThanCellSize_ThrowsException()
        {
            Board board = new Board();
            Exception expectedexception = null;
            try
            {
                board.SetLocation(Mark.O, 10);
                Cell[] celltest = board.GetCells();
            }
            catch (Exception exception)
            {
                expectedexception = exception;
            }

            Assert.IsNotNull(expectedexception);
        }

    }
}
