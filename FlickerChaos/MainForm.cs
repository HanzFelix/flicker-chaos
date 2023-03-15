using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlickerChaos
{
    // Form that the player sees when opening the application.
    // Most of the player interaction with the game takes place here
    public partial class MainForm : Form
    {
        private GameInstance instance;
        private List<Light> lights;
        private Timer SequencePreparationTimer;
        private Timer SequenceDemoTimer;
        private Game game;
        public MainForm()
        {
            InitializeComponent();

            // Load game instance, including highscores and recently used difficulty
            GameInstance.ReadGameInstance();
            instance = GameInstance.GetInstance();

            // Delay for starting the light sequence demonstration
            SequencePreparationTimer = new Timer();
            SequencePreparationTimer.Interval = 1200;
            SequencePreparationTimer.Tick += new EventHandler(SequencePreparation_Tick);

            // Animation for light sequence demonstration
            SequenceDemoTimer = new Timer();
            SequenceDemoTimer.Interval = 400;
            SequenceDemoTimer.Tick += new EventHandler(SequenceDemo_Tick);

            // Add event handlers to form controls
            startButton.Click += new EventHandler(StartButton_Click);
            gameToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(GameToolStrip_DropDownItemClicked);
            FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            
            // Set checkstate for recently used difficulty
            switch (instance.RecentDifficulty.Name)
            {
                case "Easy":
                    easyToolStripMenuItem.Checked = true;
                    break;
                case "Normal":
                    normalToolStripMenuItem.Checked = true;
                    break;
                case "Difficult":
                    difficultToolStripMenuItem.Checked = true;
                    break;
            }

            PrepareNewGame();

        }


        // Create the interactive light grid based on the chosen difficulty
        private void PrepareNewGame()
        {
            // resets and clears out previous game progress
            lights = new List<Light>();
            SequenceDemoTimer.Stop();
            SequencePreparationTimer.Stop();
            game = new Game(instance.RecentDifficulty);

            tableLights.RowStyles.Clear();
            tableLights.ColumnStyles.Clear();
            tableLights.Controls.Clear();
            tableLights.RowCount = 0;
            tableLights.ColumnCount = 0;

            GC.Collect();

            // prepare the tableLights
            while (tableLights.RowCount < game.CDifficulty.GridRows)
            {
                tableLights.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tableLights.RowCount++;
            }

            while (tableLights.ColumnCount < game.CDifficulty.GridColumns)
            {
                tableLights.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tableLights.ColumnCount++;
            }

            // add the Lights to the tableLights
            int id = 0;
            for (int i = 0; i < game.CDifficulty.GridRows; i++)
            {
                for (int j = 0; j < game.CDifficulty.GridColumns; j++)
                {
                    Light l = new Light(id);
                    l.MouseClick += new MouseEventHandler(Light_MouseClick);
                    l.MouseDoubleClick += new MouseEventHandler(Light_MouseClick);
                    tableLights.Controls.Add(l, j, i);
                    lights.Add(l);
                    id++;
                }
            }

            // ready the new game
            startButton.Text = "START";
            startButton.Enabled = true;
            scoreLabel.Text = game.Score.ToString();
            levelLabel.Text = game.Level.ToString();
            livesLabel.Text = game.Lives.ToString();
        }

        // Check whether the player's clicked light matches the game's light in the sequence
        // Activate the Light with a LightState based on the conditions.
        private void ValidateSelectedLight(Light light)
        {
            if (lights.IndexOf(light) == game.GetCurrentLight())
            {
                game.NextLight();
                levelProgress.PerformStep();

                if (game.EndOfSequence())
                {
                    EnableLights(false);
                    light.Activate(LightState.Complete);
                    game.NextLevel();
                    scoreLabel.Text = game.Score.ToString("#,##0");
                    levelLabel.Text = game.Level.ToString();
                    livesLabel.Text = game.Lives.ToString();

                    SequencePreparationTimer.Start();
                }
                else
                {
                    light.Activate(LightState.Valid);
                    startButton.Enabled = false;
                }
            }
            else
            {
                EnableLights(false);
                light.Activate(LightState.Invalid);
                game.FailLevel();
                livesLabel.Text = game.Lives.ToString();
                levelProgress.Value = 0;

                if (game.Lives == 0)
                {
                    startButton.Text = "NEW GAME";
                    startButton.Enabled = true;
                    if (game.Score > instance.Highscores[4].Score)
                    {
                        MessageBox.Show("New Highscore!", "Game Over!");
                        new NewHighscoreForm(game.Score, game.Level, game.CDifficulty).ShowDialog();
                        new HighscoreForm().ShowDialog();
                    }
                }
                else
                {
                    SequencePreparationTimer.Start();
                }
            }
        }

        // Enables or disables all the Lights of the game to control interaction to the Lights and startButton
        private void EnableLights(bool status)
        {
            foreach (Light light in lights)
            {
                light.Enabled = status;
            }
            startButton.Enabled = status;
        }
        

        // GameToolStrip DropDownItemClicked Event. Performs the action based on the selected dropdownitem:
        // Prepare a new game, change the difficulty, view highscores, or close the application.
        private void GameToolStrip_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.ToString())
            {
                case "New Game":
                    PrepareNewGame();
                    break;
                case "Easy":
                    instance.RecentDifficulty = instance.Difficulties[0];
                    easyToolStripMenuItem.Checked = false;
                    normalToolStripMenuItem.Checked = false;
                    difficultToolStripMenuItem.Checked = false;
                    PrepareNewGame();
                    break;
                case "Normal":
                    instance.RecentDifficulty = instance.Difficulties[1];
                    easyToolStripMenuItem.Checked = false;
                    normalToolStripMenuItem.Checked = false;
                    difficultToolStripMenuItem.Checked = false;
                    PrepareNewGame();
                    break;
                case "Difficult":
                    instance.RecentDifficulty = instance.Difficulties[2];
                    easyToolStripMenuItem.Checked = false;
                    normalToolStripMenuItem.Checked = false;
                    difficultToolStripMenuItem.Checked = false;
                    PrepareNewGame();
                    break;
                case "Highscores":
                    new HighscoreForm().ShowDialog();
                    break;
                case "Exit":
                    Application.Exit();
                    break;
            }
        }

        // SequencePreparation Tick Event. Starts the SequenceDemoTimer to begin the light sequence animation.
        private void SequencePreparation_Tick(object sender, EventArgs e)
        {
            SequencePreparationTimer.Stop();
            SequenceDemoTimer.Start();
        }

        // SequenceDemo Tick Event. Activates the animation sequence of lights in an interval of ticks.
        // Stops the SequenceDemoTimer when the game reached the end of the light sequence.
        private void SequenceDemo_Tick(object sender, EventArgs e)
        {
            if (!game.EndOfSequence())
            {
                lights[game.GetCurrentLight()].Activate(LightState.Demo);
                game.NextLight();
            }
            else
            {
                EnableLights(true);
                game.ReloadSequence();
                SequenceDemoTimer.Stop();
                levelProgress.Value = 0;
                levelProgress.Maximum = game.GetSequenceSize();
            }
        }

        // StartButton Click Event. Either prepares a new game or replays the light sequence 
        // depending on whether the game is in progress or not.
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (game.Lives != 0)
            {
                EnableLights(false);
                game.ReloadSequence();
                startButton.Text = "REPLAY";
                SequencePreparationTimer.Start();
            }
            else
            {
                PrepareNewGame();
            }
        }

        // Light MouseClick Event. Calls the ValidateSelectedLight method with the object sender for validation.
        private void Light_MouseClick(object sender, EventArgs e)
        {
            ValidateSelectedLight(sender as Light);
        }

        // MainForm FormClosing Event. Saves the game's instance when the user exits the application.
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameInstance.WriteGameInstance();
        }
    }
}
