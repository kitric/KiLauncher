using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace AppLauncher
{
    /// <summary>
    /// Representation of an app that will be launched when this class's button is clicked.
    /// </summary>
    [Serializable]
    public class App
    {
        #region fields

        /// <summary>
        /// The path to the .exe file.
        /// </summary>

        private Color _displayColor;

        public Color DisplayColor{ get; set; }

        public string ExecutablePath { get; set; }

        /// <summary>
        /// Given by the user, this will be the process' display name.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Used for identification.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// A process cover image [OPTIONAL]
        /// </summary>

        private string _coverImagePath;
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
        /// Might need to refactor this later.
        /// </summary>
        private void CreateID()
        {
            int rand;
            bool found = false;

            while (true)
            {
                rand = random.Next(int.MaxValue - 5);

                //Loops for all created buttons. Checks if the generated ID already exists.
                foreach (App x in MainScreen.Apps)
                {
                    if (x.ID == rand)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found) { break; }
            }
            this.ID = rand;
        }
    }
}
