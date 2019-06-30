using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;
namespace TicTacToeTest
{
    [TestClass]
    public class ResultAnalyzerTest
    {
        [TestMethod]
        public void TestingWinCase_Verically()
        {
              
            Board board1 = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board1);
            board1.SetLocation(Mark.X, 0);
            board1.SetLocation(Mark.O, 1);
            board1.SetLocation(Mark.X, 3);
            board1.SetLocation(Mark.O, 4);
            board1.SetLocation(Mark.O, 5);
            board1.SetLocation(Mark.X, 6);

            Assert.AreEqual(Result.WIN, analyzer.AnalyzeResult());
        }
        [TestMethod]
        public void TestingWinCase_Horizontally()
        {

            Board board1 = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board1);
            board1.SetLocation(Mark.X, 1);
            board1.SetLocation(Mark.X, 0);
            board1.SetLocation(Mark.X, 2); 
            board1.SetLocation(Mark.O, 3); 
            board1.SetLocation(Mark.X, 4);
            board1.SetLocation(Mark.O, 5);

            Assert.AreEqual(Result.WIN, analyzer.AnalyzeResult());
        }
        [TestMethod]
        public void TestingWinCase_Diagonally()
        {

            Board board1 = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board1);
            board1.SetLocation(Mark.X, 2);
            board1.SetLocation(Mark.O, 4);
            board1.SetLocation(Mark.O, 5);
            board1.SetLocation(Mark.O, 8);
            board1.SetLocation(Mark.O, 0);
            board1.SetLocation(Mark.X, 1);

            Assert.AreEqual(Result.WIN, analyzer.AnalyzeResult());
        }
        [TestMethod]
        public void GameGoingOn_IfThereisNowinnerOrBoardIsNotFull()
        {

            Board board1 = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board1);
            board1.SetLocation(Mark.X, 0);
            board1.SetLocation(Mark.O, 1);
            board1.SetLocation(Mark.X, 2);
            board1.SetLocation(Mark.O, 7);
            board1.SetLocation(Mark.X, 5);

            Assert.AreEqual(Result.ONGOING, analyzer.AnalyzeResult());
        }
        [TestMethod]
        public void DrawTestCase()
        {

            Board board1 = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board1);
            board1.SetLocation(Mark.X, 0);
            board1.SetLocation(Mark.O, 1);
            board1.SetLocation(Mark.X, 2);
            board1.SetLocation(Mark.O, 3);
            board1.SetLocation(Mark.X, 4);
            board1.SetLocation(Mark.O, 5);
            board1.SetLocation(Mark.O, 6);
            board1.SetLocation(Mark.X, 7);
            board1.SetLocation(Mark.O, 8);


            Assert.AreEqual(Result.DRAW, analyzer.AnalyzeResult());
        }
        [TestMethod]
        public void FullBoardWithOneWinCase()
        {

            Board board1 = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board1);
            board1.SetLocation(Mark.O, 0);
            board1.SetLocation(Mark.O, 1);
            board1.SetLocation(Mark.O, 2);
            board1.SetLocation(Mark.O, 3);
            board1.SetLocation(Mark.X, 4);
            board1.SetLocation(Mark.O, 5);
            board1.SetLocation(Mark.X, 6);
            board1.SetLocation(Mark.X, 7);
            board1.SetLocation(Mark.O, 8);


            Assert.AreEqual(Result.WIN, analyzer.AnalyzeResult());
        }

    }
}
