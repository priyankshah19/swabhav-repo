using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;

namespace TicTacToeUnitTest
{
    [TestClass]
    public class PlayerTestClass
    {
        [TestMethod]
        public void PlayerTestMethod()
        {
            Player player = new Player("akash",Mark.O);
            Assert.AreEqual("akash", player.Name);
            Assert.AreEqual(Mark.O,player.MARk);
        }
    }
}
