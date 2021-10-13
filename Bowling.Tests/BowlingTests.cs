using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bowling.Tests
{
    [TestClass]
    public class BowlingTests
    {
        Game g;

        [TestInitialize]
        public void TestInitialize()
        {
            g = new Game();
        }


        private void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
                g.Roll(pins);
        }


        [TestMethod]
        public void GutterGame()
        {
            RollMany(20, 0);

            Assert.AreEqual(0, g.Score());
        }

        [TestMethod]
        public void AllOnes()
        {
            RollMany(20, 1);

            Assert.AreEqual(20, g.Score());
        }

        [TestMethod]
        public void OneSpare()
        {
            g.Roll(5);
            g.Roll(5); //Spare
            g.Roll(3);
            RollMany(17, 0);

            Assert.AreEqual(16, g.Score());
        }


        /*
        Rules
            Game has 10 frames
            Frames 1-9 have 2 rolls that can addup to 10
            Frame 10 has up to 3 Rolls if 2nd roll is Spare or Strike
            Spare: Frame adds to 10 in the 2 attemps
            Strike: First shot in Frame is 10
        Points
            Frame: Sum of pins in the 2 rolls
            Spare: 10 + next roll
            Strike: 10 + next 2 rolls
        */
    }
}
