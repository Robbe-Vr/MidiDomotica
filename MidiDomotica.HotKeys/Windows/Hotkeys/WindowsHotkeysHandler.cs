using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MidiDomotica.Remote.Windows.Hotkeys
{
    public class WindowsHotkeysHandler
    {
        private List<Keys> PressedKeys = new List<Keys>();

        private Timer releaseTimer;
        private int rerelease = 0;

        public WindowsHotkeysHandler()
        {

        }

        public enum Keys
        {
            NUM_1, NUM_2, NUM_3, NUM_4, NUM_5, NUM_6, NUM_7, NUM_8, NUM_9,

            A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z,

            LMOUSE, RMOUSE, CANCEL, MMOUSE, X1MOUSE, X2MOUSE, BACKSPACE,
            TAB, CLEAR, ENTER, SHIFT, CTRL, ALT, PAUSE, CAPSLOCK, SPACE,

            PAGEUP, PAGEDOWN, END, HOME,

            LEFTARROW, UPARROW, RIGHTARROW, DOWNARROW,

            SELECT, PRINT, EXECUTE, PRINTSCREEN, INSERT, DELETE, HELP,

            WINLEFT, WINRIGHT, APPS,

            SLEEP,

            MULTIPLY, ADD, SEPARATOR, SUBSTRACT, DECIMAL, DIVIDE,

            F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12, F13, F14, F15, F16, F17, F18, F19, F20, F21, F22, F23, F24,

            NUMLOCK, SCROLLLOCK, LSHIFT, RSHIFT, LCONTROL, RCONTROL, LMENU, RMENU,

            VOLUMEMUTE, VOLUMEDOWN, VOLUMEUP,

            MEDIANEXTTRACK, MEDIAPREVTRACK, MEDIASTOP, MEDIAPLAYPAUSE,

            STARTAPP1, STARTAPP2,
        }

        [DllImport(@"C:\\Users\\Robbe\\source\\repos\\PerformKeystroke\\Debug\\PerformKeystroke.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PressKey(string keyName);
        [DllImport(@"C:\\Users\\Robbe\\source\\repos\\PerformKeystroke\\Debug\\PerformKeystroke.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ReleaseKey(string keyName);
        [DllImport(@"C:\\Users\\Robbe\\source\\repos\\PerformKeystroke\\Debug\\PerformKeystroke.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PerformKey(string keyName);

        public void PerformKeyPress(Keys key)
        {
            if (PressedKeys.Contains(key))
            {
                ReleaseKey(key);
            }

            PerformKey(key.ToString());
        }

        public void PressKey(Keys key)
        {
            if (PressedKeys.Contains(key))
            {
                ReleaseKey(key);
            }

            string kbKey = (int)key < 9 ? key.ToString().Replace("NUM_", "") : key.ToString();

            PressKey(kbKey);

            PressedKeys.Add(key);

            releaseTimer = new Timer(5000);
            releaseTimer.Elapsed += releaseTimerElapsed;
            releaseTimer.Start();
        }
        public void ReleaseKey(Keys key)
        {
            ReleaseKey(key.ToString().Replace("NUM_", ""));

            PressedKeys.Remove(key);
        }

        private void releaseTimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (PressedKeys.Count > 0)
            {
                ReleaseAll();
            }
        }

        public void ReleaseAll()
        {
            try
            {
                foreach (Keys key in PressedKeys)
                {
                    string kbKey = (int)key < 9 ? key.ToString().Replace("NUM_", "") : key.ToString();

                    ReleaseKey(kbKey);
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine("Failed tp release pressed keys: " + e.Message + "; Retrying...");
                if (rerelease < 10)
                {
                    System.Threading.Thread.Sleep(5);
                    rerelease++;
                    ReleaseAll();
                }
                else rerelease = 0;
            }
        }
    }
}
