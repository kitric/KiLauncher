using System;

namespace AppLauncher.Models
{
    [Serializable]
    public class Settings
    {
        public string Theme;

        public Settings(string theme = "Default")
        {
            this.Theme = theme;
        }
    }
}
