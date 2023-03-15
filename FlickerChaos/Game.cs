using System;
using System.Collections.Generic;
using System.Linq;

namespace FlickerChaos
{
    internal class Game
    {
        // instance to retrieve the recent difficulty used.
        private GameInstance instance;

        // list of lights' indices
        private List<int> lightSequence;

        // Current difficulty of the game
        public Difficulty CDifficulty { get; }

        // other details of the game worth tracking throughout the game progression
        public int Level { get; private set; }
        public int Score { get; private set; }
        public int Lives { get; private set; }

        // Current position of the game's light sequence progress
        // to sync with player's progress at MainForm 
        public int SequencePosition { get; private set; }
        public Game(Difficulty d)
        {
            this.instance = GameInstance.GetInstance();
            this.instance.RecentDifficulty = d;

            CDifficulty = d;
            Level = 1;
            Score = 0;
            Lives = d.StartingLives;
            SequencePosition = 0;

            lightSequence = new List<int>();
            FillSequence();
        }

        // Reset to the start of the light sequence progress
        public void ReloadSequence()
        {
            SequencePosition = 0;
        }

        // Proceed to the next light index of light sequence
        public void NextLight()
        {
            SequencePosition++;
        }

        // Check whether the game has reached the end of the sequence or not
        public bool EndOfSequence()
        {
            return SequencePosition == lightSequence.Count();
        }

        // Size of light sequence
        public int GetSequenceSize()
        {
            return lightSequence.Count();
        }

        // Light's index at current progress of light sequence
        public int GetCurrentLight()
        {
            return lightSequence.ElementAt(SequencePosition);
        }

        // Deduct a life when level failed and reset light sequence progress
        public void FailLevel()
        {
            Lives--;
            SequencePosition = 0;
        }

        // Proceed to the next level after increasing the sequence length,
        // calculating the score and possibly recovering a life.
        public void NextLevel()
        {
            if ((Lives < CDifficulty.MaxLives) && ((Level % CDifficulty.LifeRecoveryInterval) == 0))
                Lives++;

            SequencePosition = 0;
            Score += (int)(Level * ((100 * CDifficulty.ScoreMultiplier) - (5 * (3 - Lives))));
            FillSequence();
            Level++;
        }

        // Add randomized indices of Light in MainForm based on game's grid size
        private void FillSequence()
        {
            Random r = new Random();
            for (int i = CDifficulty.LightIncrement; i > 0; i--)
            {
                lightSequence.Add(r.Next(CDifficulty.GridRows * CDifficulty.GridColumns));
            }
        }
    }
}
