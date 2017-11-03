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
        public void Initialize() {
          game = new BowlingGame();
        }
        [TestMethod]
        public void CanRollGutterGame()
        {
            RollMany(0, 20);
            Assert.AreEqual(0, game.Score);
        }
        [TestMethod]
        public void CanRollAllOnes() {
            RollMany(1,20);
            Assert.AreEqual(20, game.Score);
        }
        [TestMethod]
        public void CanRollSpare() {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(0, 17);
            Assert.AreEqual(16, game.Score);
        }
        [TestMethod]
        public void CanRollStrike() {
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            RollMany(0, 16);
            Assert.AreEqual(24, game.Score);
        }
        [TestMethod]
        public void SpareNextnotStrike() {
            RollMany(5,2);
            RollMany(4,2);
            RollMany(0, 16);
            Assert.AreEqual(18, game.Score);
        }
        [TestMethod]
        public void SpareNextStrike()
        {
            RollMany(5, 2);
            RollMany(10, 1);
            RollMany(0, 16);
            Assert.AreEqual(30, game.Score);
        }
        private void RollMany(int pins, int rolls) {
            for (var i = 0; i < rolls; i++) {
                game.Roll(pins);
            }
        }
    }
}
