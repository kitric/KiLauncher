using System;

namespace AppLauncher.Models
{
    [Serializable]
    public class Settings
    {
        public string Theme;
        public bool Animations;

        public Settings(string theme, bool useAnimations = true)
        {
            this.Theme = theme;
            this.Animations = useAnimations;
        }
    }
}
