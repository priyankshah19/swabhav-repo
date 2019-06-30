using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;
namespace TicTacToeUnitTest
{
    [TestClass]
    public class GameTestClass
    {
        [TestMethod]
        public void GameWinMethod()
        {
            Board board = new Board();
            ResultAnalyzer result = new ResultAnalyzer(board);
            Player[] players = new Player[2];
            players[0] = new Player("akash", Mark.O);
            players[1] = new Player("dhruv", Mark.X);
            Game game = new Game(players, board, result);
            game.Play(0);
            game.Play(3);
            game.Play(1);
            game.Play(4);
            game.Play(2);
            game.Play(5);
            game.Play(6);
            game.Play(8);
            game.Play(7);
            Assert.AreEqual(Result.WIN, game.Status());
        }
        [TestMethod]
        public void GameDrawMethod()
        {
            Board board = new Board();
            ResultAnalyzer result = new ResultAnalyzer(board);
            Player[] players = new Player[2];
            players[0] = new Player("akash", Mark.O);
            players[1] = new Player("dhruv", Mark.X);
            Game game = new Game(players, board, result);
            game.Play(0);
            game.Play(3);
            game.Play(1);
            game.Play(4);
            game.Play(5);
            game.Play(2);
            game.Play(6);
            game.Play(7);
            game.Play(8);
            Assert.AreEqual(Result.DRAW, game.Status());
        }
        [TestMethod]
        public void GameProgressMethod()
        {
            Board board = new Board();
            ResultAnalyzer result = new ResultAnalyzer(board);
            Player[] players = new Player[2];
            players[0] = new Player("akash", Mark.O);
            players[1] = new Player("dhruv", Mark.X);
            Game game = new Game(players, board, result);
            game.Play(0);
            game.Play(3);
            game.Play(1);
            Assert.AreEqual(Mark.X,board.Getpositionmark(3));
           
            Assert.AreEqual(Result.PROGRESS, game.Status());
        }

    }
}
