using MidiDomotica.Remote.Windows.Hotkeys;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Core.Actions
{
    public partial class ActionMapper
    {
        private WindowsHotkeysHandler hotkeysHandler = new WindowsHotkeysHandler();

        public void PerformKeyPress(string key)
        {
            WindowsHotkeysHandler.Keys hotkey;

            if (Enum.TryParse(key.ToUpper(), out hotkey))
            {
                hotkeysHandler.PerformKeyPress(hotkey);
            }
            else
            {
                Trace.WriteLine("Unable to parse '" + key + "' to a hotkey!");
            }
        }

        private void PressKey(string key)
        {
            WindowsHotkeysHandler.Keys hotkey;

            if (Enum.TryParse(key.ToUpper(), out hotkey))
            {
                hotkeysHandler.PressKey(hotkey);
            }
            else
            {
                Trace.WriteLine("Unable to parse '" + key + "' to a hotkey!");
            }
        }

        public void PerformKeyPressCombi(params string[] keys)
        {
            foreach (string key in keys)
            {
                PressKey(key);
            }

            hotkeysHandler.ReleaseAll();
        }
    }
}
