using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlickerChaos
{
    // Prompts the user to enter their name for the top highscores.
    // Appears only when the player's score made it to the top highscores.
    public partial class NewHighscoreForm : Form
    {
        // Instance of the game, which includes the highscores
        GameInstance instance;

        // Details in saving a highscore
        int score;
        int level;
        Difficulty difficulty;

        public NewHighscoreForm(int score, int level, Difficulty difficulty)
        {
            InitializeComponent();

            instance = GameInstance.GetInstance();

            // Preload the labels with the player's game details
            this.score = score;
            this.level = level;
            this.difficulty = difficulty;

            scoreLabel.Text = score.ToString("#,##0");
            levelLabel.Text = level.ToString();
            difficultyLabel.Text = difficulty.Name;

            Shown += new EventHandler(NewHighscoreForm_Shown);
            FormClosing += new FormClosingEventHandler(NewHighscoreForm_FormClosing);
            okButton.Click += new EventHandler(OkButton_Click);
        }

        // NewHighScoreForm Shown Event. Gains focus on the nameTextBox to let the player
        // enter their name immediately upon displaying the form.
        private void NewHighscoreForm_Shown(object sender, EventArgs e)
        {
            nameTextBox.Focus();
            nameTextBox.SelectAll();
        }

        // OkButton Click Event. Closes the form.
        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // NewHighscoreForm FormClosing Event. Saves the new highscore to the list of top highscores upon closing the form.
        private void NewHighscoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Reset to default name when entered name is blank
            Console.WriteLine(nameTextBox.Text);
            string name = nameTextBox.Text == "" ? "ChaosPlayer" : nameTextBox.Text;
            Highscore hs = new Highscore(name, score, level, difficulty);

            // Add to highscore list and remove the lowest highscore
            for (int i = 0; i < instance.Highscores.Count; i++)
            {
                if (instance.Highscores[i].Score < score)
                {
                    instance.Highscores.Insert(i, hs);
                    instance.Highscores.RemoveAt(instance.Highscores.Count - 1);
                    break;
                }
            }
        }
    }
}
