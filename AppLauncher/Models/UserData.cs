using System;
using System.Collections.Generic;

namespace AppLauncher.Models
{
    [Serializable]
    public class UserData
    {
        public List<App> Apps { get; set; }
        public Settings Settings { get; set; }

        public UserData() {
            this.Apps = new List<App>();
            this.Settings = new Settings("Light");
        }
    }
}
