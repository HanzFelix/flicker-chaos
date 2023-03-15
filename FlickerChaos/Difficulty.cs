using System;

namespace FlickerChaos
{
    // Game's Difficulty has the necessary properties to set up the game and calculate the level score
    [Serializable]
    public class Difficulty
    {
        // name to be displayed when choosing difficulties, or displayed as highscore
        public string Name { get; }

        // for setting up the game's tablelayoutpanel 
        public int GridRows { get; }
        public int GridColumns { get; }

        // multiplier based on the difficulty of the sequence
        public float ScoreMultiplier { get; }

        // added number of lights per level
        public int LightIncrement { get; }

        // recover a life every specified number of levels
        public int LifeRecoveryInterval { get; }

        // initial number of lives at the start of the game
        public int StartingLives { get; }

        // maximum number of lives the player can hold
        public int MaxLives { get; }

        public Difficulty(string name, int gridRows, int gridColumns, float scoreMultiplier, int sequenceIncrementPerLevel, int lifeRecoveryInterval, int startingLives, int maxLives)
        {
            Name = name;
            GridRows = gridRows;
            GridColumns = gridColumns;
            ScoreMultiplier = scoreMultiplier;
            LightIncrement = sequenceIncrementPerLevel;
            LifeRecoveryInterval = lifeRecoveryInterval;
            StartingLives = startingLives;
            MaxLives = maxLives;
        }
    }
}
