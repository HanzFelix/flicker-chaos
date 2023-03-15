using System;

namespace FlickerChaos
{
    [Serializable]
    internal class Highscore
    {
        public string Name { get; }
        public int Score { get; }
        public int Level { get; }
        public Difficulty BeatenDifficulty { get; }

        public Highscore(string name, int score, int level, Difficulty beatenDifficulty)
        {
            Name = name;
            Score = score;
            Level = level;
            BeatenDifficulty = beatenDifficulty;
        }
    }
}
