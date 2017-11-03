using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling_Game;

namespace BowlingGameTests
{
    [TestClass]
    public class GameTests
    {
        private BowlingGame game;

        [TestInitialize]
        public void Initialize()
        {
            game = new BowlingGame();
        }

        [TestMethod]
        public void CanRollGutterGame()
        {
            RollMany(0,20);
            Assert.AreEqual(0, game.Score);
        }
        [TestMethod]
        public void CanRollAllOnes()
        {
            RollMany(1, 20);
            Assert.AreEqual(20, game.Score);
        }
        [TestMethod]
        public void CanRollSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(0, 17);
            Assert.AreEqual(1, game.Score);
        }
        private void RollMany(int pins, int rolls)
        {
            for (var i = 0; i < rolls; i++)
            {
                game.Roll(pins);
            }
        }
    }
}
