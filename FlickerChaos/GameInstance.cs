using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace FlickerChaos
{
    [Serializable]
    internal class GameInstance
    {
        // Game difficulty to start with upon opening the application
        public Difficulty RecentDifficulty { get; set; }

        public List<Difficulty> Difficulties { get; set; }
        public List<Highscore> Highscores { get; set; }
        private static GameInstance instance = null;

        private GameInstance()
        {
            Highscores = new List<Highscore>();
            Difficulties = new List<Difficulty>();

            // Default difficulty settings
            Difficulty easy = new Difficulty("Easy", 2, 2, 0.75F, 1, 25, 3, 7);
            Difficulty normal = new Difficulty("Normal", 3, 3, 1F, 1, 10, 3, 7);
            Difficulty difficult = new Difficulty("Difficult", 4, 4, 2F, 2, 5, 3, 7);

            Difficulties.Add(easy);
            Difficulties.Add(normal);
            Difficulties.Add(difficult);

            RecentDifficulty = normal;

            // Default highscores
            Highscores.Add(new Highscore("UMR", 10000, 10, difficult));
            Highscores.Add(new Highscore("TSF", 5000, 7, difficult));
            Highscores.Add(new Highscore("CMD", 2000, 10, normal));
            Highscores.Add(new Highscore("DEF", 1000, 5, easy));
            Highscores.Add(new Highscore("LOW", 500, 3, normal));

        }

        // Retrieve the instance of the game, create one if none exists yet
        public static GameInstance GetInstance()
        {
            if (instance == null)
                instance = new GameInstance();

            return instance;
        }

        // Loads the instance from a file
        public static void ReadGameInstance()
        {
            try
            {
                string path = "FlickerChaos.dat";
                if (File.Exists(path))
                {
                    FileStream f = File.OpenRead(path);
                    BinaryFormatter bf = new BinaryFormatter();
                    instance = (GameInstance)bf.Deserialize(f);
                    f.Close();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // Saves the instance in a file
        public static void WriteGameInstance()
        {
            try
            {
                string path = "FlickerChaos.dat";
                FileStream f = File.OpenWrite(path);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, instance);
                f.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
