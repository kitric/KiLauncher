using System;
using System.Drawing;

namespace AppLauncher
{
    /// <summary>
    /// Representation of an app that will be launched when this class's button is clicked.
    /// </summary>
    [Serializable]
    public class App
    {
        #region fields
        public Color DisplayColor { get; set; }

        public string ExecutablePath { get; set; }

        /// <summary>
        /// Given by the user, this will be the process' display name.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Used for identification.
        /// </summary>
        public int ID { get; set; }

        public string ImagePath { get; set; }

        private readonly Random random = new Random();

        #endregion

        public App(string path, string displayName, Color displayColor, string imagePath = "")
        {
            this.ExecutablePath = path;
            this.DisplayName = displayName;
            this.ImagePath = imagePath;
            this.DisplayColor = displayColor;
            this.CreateID();
        }

        /// <summary>
        /// Creates an unique ID for each shortcut.
        /// </summary>
        private void CreateID()
        {
            bool found;
            int rand;
            
            do
            {
                found = false;
                rand = random.Next(int.MaxValue - 5);

                //Loops for all created buttons. Checks if the generated ID already exists.
                foreach (App x in MainScreen.Data.Apps)
                {
                    if (x.ID == rand)
                    {
                        found = true;
                        break;
                    }
                }

            } while (found);

            this.ID = rand;
        }
    }
}
