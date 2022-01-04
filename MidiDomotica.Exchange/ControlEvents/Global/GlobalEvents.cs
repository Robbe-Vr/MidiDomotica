using MidiDomotica.MidiConnection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MidiDomotica.MidiConnection.Event
{
    internal partial class Events : AbstractEvents
    {
        private Timer timer;

        private List<NotePressedData> notePressHistory = new List<NotePressedData>(50);
        private List<NotePressedData> noteReleaseHistory = new List<NotePressedData>(50);
        private bool repeating;

        internal Events()
        {
            repeating = false;
        }

        internal void SetMode(int mode)
        {
            if (mode < 1 || mode > 8) return;

            if ((MidiControllerMode)mode == CurrentMode) return;

            CurrentMode = (MidiControllerMode)mode;

            notePressHistory.Clear();
            noteReleaseHistory.Clear();

            if (timer != null && timer.Enabled)
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }
        }

        internal override void onMidiMessage(object sender, MidiMessageRecievedEventArgs e)
        {
            if (e.Message.MessageType == "Short") return;

            switch (e.Message.Status)
            {
                // Mode 1
                case 144: // Note, Pad - Pressed
                    NotePressedMode1(e);
                    break;
                case 128: // Note, Pad - Released
                    NoteReleasedMode1(e);
                    break;
                case 160: // Pad - Held

                    break;
                case 176: // Control Changed
                    ControlChangedMode1(e);
                    break;
                case 224: // Pitch Wheel
                    PitchWheelChangedMode1(e);
                    break;

                // Mode 2
                case 145: // Note, Pad - Pressed
                    NotePressedMode2(e);
                    break;
                case 129: // Note, Pad - Released
                    NoteReleasedMode2(e);
                    break;
                case 161: // Pad - Held

                    break;
                case 177: // Control Changed
                    ControlChangedMode2(e);
                    break;
                case 225: // Pitch Wheel
                    PitchWheelChangedMode2(e);
                    break;

                // Mode 3
                case 146: // Note, Pad - Pressed
                    NotePressedMode3(e);
                    break;
                case 130: // Note, Pad - Released
                    NoteReleasedMode3(e);
                    break;
                case 162: // Pad - Held

                    break;
                case 178: // Control Changed
                    ControlChangedMode3(e);
                    break;
                case 226: // Pitch Wheel
                    PitchWheelChangedMode3(e);
                    break;

                // Mode 4
                case 147: // Note, Pad - Pressed
                    NotePressedMode4(e);
                    break;
                case 131: // Note, Pad - Released
                    NoteReleasedMode4(e);
                    break;
                case 163: // Pad - Held

                    break;
                case 179: // Control Changed
                    ControlChangedMode4(e);
                    break;
                case 227: // Pitch Wheel
                    PitchWheelChangedMode4(e);
                    break;

                // Mode 5
                case 148: // Note, Pad - Pressed
                    NotePressedMode5(e);
                    break;
                case 132: // Note, Pad - Released
                    NoteReleasedMode5(e);
                    break;
                case 164: // Pad - Held

                    break;
                case 180: // Control Changed
                    ControlChangedMode5(e);
                    break;
                case 228: // Pitch Wheel
                    PitchWheelChangedMode5(e);
                    break;

                // Mode 6
                case 149: // Note, Pad - Pressed
                    NotePressedMode6(e);
                    break;
                case 133: // Note, Pad - Released
                    NoteReleasedMode6(e);
                    break;
                case 165: // Pad - Held

                    break;
                case 181: // Control Changed
                    ControlChangedMode6(e);
                    break;
                case 229: // Pitch Wheel
                    PitchWheelChangedMode6(e);
                    break;

                // Mode 7
                case 150: // Note, Pad - Pressed
                    NotePressedMode7(e);
                    break;
                case 134: // Note, Pad - Released
                    NoteReleasedMode7(e);
                    break;
                case 166: // Pad - Held

                    break;
                case 182: // Control Changed
                    ControlChangedMode7(e);
                    break;
                case 230: // Pitch Wheel
                    PitchWheelChangedMode7(e);
                    break;

                // Mode 8
                case 151: // Note, Pad - Pressed
                    NotePressedMode8(e);
                    break;
                case 135: // Note, Pad - Released
                    NoteReleasedMode8(e);
                    break;
                case 167: // Pad - Held

                    break;
                case 183: // Control Changed
                    ControlChangedMode8(e);
                    break;
                case 231: // Pitch Wheel
                    PitchWheelChangedMode8(e);
                    break;

                // Global
                case 250: // Left Media Play Button - Start Command
                    ((EventHandler<OnMediaButtonEventArgs>)listEventDelegates[PlayButtonEventKey])?.Invoke(this, new OnMediaButtonEventArgs()
                    {
                        DeviceName = "Novation SL MK3",
                        Command = e.Message.Command,
                    });

                    break;
                case 252: // Left Media Stop Button - Stop Command (Play button if already playing - will be followed by Start Command immediatly)
                    ((EventHandler<OnMediaButtonEventArgs>)listEventDelegates[StopButtonEventKey])?.Invoke(this, new OnMediaButtonEventArgs()
                    {
                        DeviceName = "Novation SL MK3",
                        Command = e.Message.Command,
                    });

                    break;

                default: // Unknown Control
                    UnknownControl(e);

                    break;
            }
        }

        private void UnknownControl(MidiMessageRecievedEventArgs e)
        {
            Trace.WriteLine("New Midi Control foudn with Status Index: " + e.Message.Status);
            Trace.WriteLine("Control Info: Status: " + e.Message.Status + ", Data1: " + e.Message.Data1 + ", Data2: " + e.Message.Data2 + ", Type: " + e.Message.MessageType.ToString() + ", Found at ms: " + e.Message.MsSinceStart);
        }
    }
}
