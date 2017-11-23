using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatroomDB
{
    public class Settings
    {
        public int SettingsId { get; set; }
        public bool darkMode { get; set; }
        public bool soundOn { get; set; }
        public virtual User UserSettings { get; set; }
    }
}
