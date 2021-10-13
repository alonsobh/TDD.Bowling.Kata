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
            foreach (var rol in rolls)
                score += rol;
            return score;
        }
    }
}
