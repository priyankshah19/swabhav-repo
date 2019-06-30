using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;
namespace TicTacToeUnitTest
{
    [TestClass]
    public class ResultAnalyzerTestClass
    {
        [TestMethod]
        public void WinRow1testMethod()
        {
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            board.SetPosition(0, Mark.O);
            board.SetPosition(1, Mark.O);
            board.SetPosition(2, Mark.O);
            Assert.AreEqual(Result.WIN, analyzer.resultGenerator());
        }
        
       
        [TestMethod]
        public void WinRow2testMethod()
        {
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            board.SetPosition(3, Mark.O);
            board.SetPosition(4, Mark.O);
            board.SetPosition(5, Mark.O);
            Assert.AreEqual(Result.WIN, analyzer.resultGenerator());
        }
        [TestMethod]
        public void WinRow3testMethod()
        {
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            board.SetPosition(6, Mark.O);
            board.SetPosition(7, Mark.O);
            board.SetPosition(8, Mark.O);
            Assert.AreEqual(Result.WIN, analyzer.resultGenerator());
        }
        [TestMethod]
        public void Wincol1testMethod()
        {
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            board.SetPosition(0, Mark.O);
            board.SetPosition(3, Mark.O);
            board.SetPosition(6, Mark.O);
            Assert.AreEqual(Result.WIN, analyzer.resultGenerator());
        }
        [TestMethod]
        public void Wincol2testMethod()
        {
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            board.SetPosition(1, Mark.O);
            board.SetPosition(4, Mark.O);
            board.SetPosition(7, Mark.O);
            Assert.AreEqual(Result.WIN, analyzer.resultGenerator());
        }
        [TestMethod]
        public void Wincol3testMethod()
        {
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            board.SetPosition(2, Mark.O);
            board.SetPosition(5, Mark.O);
            board.SetPosition(8, Mark.O);
            Assert.AreEqual(Result.WIN, analyzer.resultGenerator());
        }
        [TestMethod]
        public void Wincross1testMethod()
        {
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            board.SetPosition(0, Mark.O);
            board.SetPosition(4, Mark.O);
            board.SetPosition(8, Mark.O);
            Assert.AreEqual(Result.WIN, analyzer.resultGenerator());
        }
        [TestMethod]
        public void Wincross2testMethod()
        {
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            board.SetPosition(2, Mark.O);
            board.SetPosition(4, Mark.O);
            board.SetPosition(6, Mark.O);
            Assert.AreEqual(Result.WIN, analyzer.resultGenerator());
        }

    }
}
