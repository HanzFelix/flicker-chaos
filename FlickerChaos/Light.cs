using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace FlickerChaos
{
    // Interactive control of the game
    public class Light : PictureBox
    {
        // Either enabled/disabled image after animation.
        private Image defaultImage;

        // Animation-related resources after activating light
        private Timer activatedTimer;
        private SoundPlayer audioDemo, audioError, audioComplete, audioPlayerClick;
        public Light(int id)
        {
            // Initialized Properties
            Name = "light" + id;
            Margin = new Padding(8);
            Size = new Size(96, 96);
            MaximumSize = new Size(96, 96);
            Cursor = Cursors.Hand;
            defaultImage = Properties.Resources.light_disabled;
            Image = Properties.Resources.light_disabled;
            Enabled = false;

            // Light Events
            EnabledChanged += new EventHandler(Light_EnabledChanged);
            MouseEnter += new EventHandler(Light_MouseEnter);
            MouseDown += new MouseEventHandler(Light_MouseDown);
            MouseLeave += new EventHandler(Light_MouseLeave);

            // Each Light has their own SoundPlayer to allow overlapping of audio
            audioDemo = new SoundPlayer(Properties.Resources.audio_demo_press);
            audioError = new SoundPlayer(Properties.Resources.audio_error);
            audioComplete = new SoundPlayer(Properties.Resources.audio_complete);
            audioPlayerClick = new SoundPlayer(Properties.Resources.audio_player_click);

            // Animation for various light-up states
            activatedTimer = new Timer();
            activatedTimer.Tick += new EventHandler(Activated_Tick);
        }

        // Plays the specifed light-up animation and audio with their respective duration
        public void Activate(LightState state)
        {
            activatedTimer.Stop();
            switch (state)
            {
                case LightState.Valid:
                    Image = Properties.Resources.light_player_click;
                    activatedTimer.Interval = 800;
                    audioPlayerClick.Play();
                    break;
                case LightState.Invalid:
                    Image = Properties.Resources.light_error;
                    activatedTimer.Interval = 1200;
                    audioError.Play();
                    break;
                case LightState.Complete:
                    Image = Properties.Resources.light_complete;
                    activatedTimer.Interval = 1200;
                    audioComplete.Play();
                    break;
                case LightState.Demo:
                    Image = Properties.Resources.light_demo_press;
                    activatedTimer.Interval = 300;
                    audioDemo.Play();
                    break;
                default:
                    break;
            }
            activatedTimer.Start();
        }

        // Light EnabledChanged Event. Updates the Light's image to the matching enabled/disabled state upon enable/disable.
        private void Light_EnabledChanged(object sender, EventArgs e)
        {
            defaultImage = Enabled ? Properties.Resources.light_default : Properties.Resources.light_disabled;

            Image = defaultImage;
        }

        // Light MouseEnter Event. Updates the Light's Image when the Light is being hovered by a mouse.
        // Only visually updated when no light-up animation is playing
        private void Light_MouseEnter(object sender, EventArgs e)
        {
            if (!activatedTimer.Enabled)
                Image = Properties.Resources.light_player_hover;
        }

        // Light MouseLeave Event. Reverts to default visual state when the mouse just passed by the Light
        // Only visually updated when no light-up animation is playing
        private void Light_MouseLeave(object sender, EventArgs e)
        {
            if (!activatedTimer.Enabled)
                Image = Properties.Resources.light_default;
        }

        // Light MouseDown Event.  Updates the Light's Image when the Light is being pressed down with a mouse
        private void Light_MouseDown(object sender, MouseEventArgs e)
        {
            Image = Properties.Resources.light_player_press;
        }

        // Activated Tick Event. Reverts to default visual state once the "Activated" animation timer has ended. 
        private void Activated_Tick(object sender, EventArgs e)
        {
            activatedTimer.Stop();
            Image = defaultImage;
        }
    }
}
