namespace Bowling.Tests
{
    internal class Game
    {
        int score = 0;
        internal void Roll(int pins)
        {
            score += pins;
        }

        internal int Score()
        {
            return score;
        }
    }
}
