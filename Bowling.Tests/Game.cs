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
                if (IsSpare(firstInFrame))
                {
                    score += 10 + rolls[firstInFrame + 2];
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

        private bool IsSpare(int firstInFrame)
            => rolls[firstInFrame] + rolls[firstInFrame + 1] == 10;
    }
}
