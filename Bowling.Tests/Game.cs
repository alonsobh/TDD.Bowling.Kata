namespace Bowling.Tests
{
    internal class Game
    {
        int[] rolls = new int[21];
        int currentRoll = 0;
        internal void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        internal int Score()
        {
            var score = 0;
            var firstInFrame = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(firstInFrame))
                {
                    score += 10 + NextTwoRollsForStrike(firstInFrame);
                    firstInFrame += 1;
                }
                else
                if (IsSpare(firstInFrame))
                {
                    score += 10 + NextRollForSpare(firstInFrame);
                    firstInFrame += 2;
                }
                else
                {
                    score += rolls[firstInFrame] + rolls[firstInFrame + 1];
                    firstInFrame += 2;
                }
            }
            return score;
        }
        private bool IsStrike(int firstInFrame)
            => rolls[firstInFrame] == 10;

        private int NextTwoRollsForStrike(int firstInFrame)
            => rolls[firstInFrame + 1] + rolls[firstInFrame + 2];

        private bool IsSpare(int firstInFrame)
            => rolls[firstInFrame] + rolls[firstInFrame + 1] == 10;

        private int NextRollForSpare(int firstInFrame)
            => rolls[firstInFrame + 2];
    }
}
