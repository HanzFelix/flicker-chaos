using System;
using System.Windows.Forms;

namespace FlickerChaos
{
    // Shows the top highscores the game has recorded.
    public partial class HighscoreForm : Form
    {
        public HighscoreForm()
        {
            InitializeComponent();

            // Instance of the game, which includes the highscores
            GameInstance instance = GameInstance.GetInstance();

            // loads every highscore to tablelayoutpanel, starting from row index 1
            int row = 1;
            foreach (Highscore h in instance.Highscores)
            {
                Label nameLabel = new Label();
                Label scoreLabel = new Label();
                Label levelLabel = new Label();
                Label difficultyLabel = new Label();

                nameLabel.Text = h.Name;
                scoreLabel.Text = h.Score.ToString("#,##0");
                levelLabel.Text = h.Level.ToString();
                difficultyLabel.Text = h.BeatenDifficulty.Name;

                tableHighscores.Controls.Add(nameLabel, 0, row);
                tableHighscores.Controls.Add(scoreLabel, 1, row);
                tableHighscores.Controls.Add(levelLabel, 2, row);
                tableHighscores.Controls.Add(difficultyLabel, 3, row);

                row++;
            }

            closeButton.Click += new EventHandler(CloseButton_Click);
        }

        // CloseButton Click Event. Closes the HighscoreForm
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
