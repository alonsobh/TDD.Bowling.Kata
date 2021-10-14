using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bowling.Tests
{
    [TestClass]
    public class AcceptanceBowlingTest
    {
        // _____ _____ _____ _____ _____ _____ _____ _____ _____ _______
        //| 1 |4| 4 |5| 6 |/| 5 |/|   |X| 0 |1| 7 |/| 6 |/|   |X| 2 |/|6|
        //|  5  |  14 |  29 |  49 |  60 |  61 |  77 |  97 | 117 |  133  |

        [TestMethod]
        public void MyTestMethod()
        {
            var game = GetNewGame();
            RollFrame(1, 4, game);
            RollFrame(4, 5, game);
            RollSpare(6, game);
            RollSpare(5, game);
            RollStrike(game);
            RollFrame(0, 1, game);
            RollSpare(7, game);
            RollSpare(6, game);
            RollStrike(game);
            RollSpare(2, game);
            Roll(6, game);


            Assert.AreEqual(133, GetScore(game));
        }

        private int GetScore(Game game)
            => game.Score();

        private Game GetNewGame()
            => new Game();

        private void RollFrame(int first, int second, Game game)
        {
            Roll(first, game);
            Roll(second, game);
        }

        private void RollSpare(int pins, Game game)
        {
            Roll(pins, game);
            Roll(10 - pins, game);
        }

        private void RollStrike(Game game)
            => Roll(10, game);

        private void Roll(int pins, Game game)
            => game.Roll(pins);
    }
}
