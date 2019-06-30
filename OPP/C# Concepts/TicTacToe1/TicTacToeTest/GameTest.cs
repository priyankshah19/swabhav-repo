using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;
namespace TicTacToeTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void TestingOnGoing()
        {
            Game game = new TicTacToeLib.Game();
            game.Play(0);
            game.Play(2);
            game.Play(3);
            var result = game.Status;
            Assert.AreEqual(Result.ONGOING, result);
        }
        [TestMethod]
        public void TestingWiningCase()
        {
            Game game = new TicTacToeLib.Game();
            game.Play(1);
            game.Play(2);
            game.Play(3);
            game.Play(4);
            game.Play(8);
            game.Play(6);

            var result = game.Status;
            Assert.AreEqual(Result.WIN, result);
        }

        [TestMethod]
        public void TestingDrawCase()
        {
            Game game = new TicTacToeLib.Game();
            game.Play(0);
            game.Play(1);
            game.Play(2);
            game.Play(4);
            game.Play(3);
            game.Play(5);
            game.Play(7);
            game.Play(6);
            game.Play(8);
            var result = game.Status;
            Assert.AreEqual(Result.DRAW, result);
        }
        [TestMethod]
        public void TestingExceptionForSameClick()
        {
            Game game = new TicTacToeLib.Game();
            Exception expectedexception = null;
            try
            {
                game.Play(0);
                game.Play(1);
                game.Play(2);
                game.Play(4);
                game.Play(3);
                game.Play(5);
                game.Play(1);
            }
            catch (Exception exception)
            {
                expectedexception = exception;
            }

            Assert.IsNotNull(expectedexception);
        }

        [TestMethod]
        public void TestingCurentPlayerName_IsSameOrNot()
        {
            Game game = new TicTacToeLib.Game();
            game.Play(0);
            game.Play(1);
            game.Play(2);
            var result = game.Player.Name;
            Assert.AreEqual("priyank", result);
        }

        [TestMethod]
        public void TestingCurentPlayerNameMark_IsSameORNot()
        {
            Game game = new TicTacToeLib.Game();
            game.Play(0);
            game.Play(1);
            game.Play(2);
            var result = game.Player.Mark;
            Assert.AreEqual(Mark.O, result);
        }
       
    }
}
