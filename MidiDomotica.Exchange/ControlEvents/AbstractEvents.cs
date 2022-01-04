using MidiDomotica.MidiConnection;
using MidiDomotica.MidiConnection.Event.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MidiDomotica.MidiConnection.Event
{
    public abstract class AbstractEvents
    {
        private MidiReciever midiReciever;

        public enum Note
        {
            C0 = 0,
            CSharp0,
            DFlat0 = CSharp0,
            D0,
            DSharp0,
            EFlat0 = DSharp0,
            E0,
            F0,
            FSharp0,
            GFlat0 = FSharp0,
            G0,
            GSharp0,
            AFlat0 = GSharp0,
            A0,
            ASharp0,
            BFlat0 = ASharp0,
            B0,

            C1,
            CSharp1,
            DFlat1 = CSharp1,
            D1,
            DSharp1,
            EFlat1 = DSharp1,
            E1,
            F1,
            FSharp1,
            GFlat1 = FSharp1,
            G1,
            GSharp1,
            AFlat1 = GSharp1,
            A1,
            ASharp1,
            BFlat1 = ASharp1,
            B1,

            C2,
            CSharp2,
            DFlat2 = CSharp2,
            D2,
            DSharp2,
            EFlat2 = DSharp2,
            E2,
            F2,
            FSharp2,
            GFlat2 = FSharp2,
            G2,
            GSharp2,
            AFlat2 = GSharp2,
            A2,
            ASharp2,
            BFlat2 = ASharp2,
            B2,

            C3,
            CSharp3,
            DFlat3 = CSharp3,
            D3,
            DSharp3,
            EFlat3 = DSharp3,
            E3,
            F3,
            FSharp3,
            GFlat3 = FSharp3,
            G3,
            GSharp3,
            AFlat3 = GSharp3,
            A3,
            ASharp3,
            BFlat3 = ASharp3,
            B3,

            C4,
            CSharp4,
            DFlat4 = CSharp4,
            D4,
            DSharp4,
            EFlat4 = DSharp4,
            E4,
            F4,
            FSharp4,
            GFlat4 = FSharp4,
            G4,
            GSharp4,
            AFlat4 = GSharp4,
            A4,
            ASharp4,
            BFlat4 = ASharp4,
            B4,

            C5,
            CSharp5,
            DFlat5 = CSharp5,
            D5,
            DSharp5,
            EFlat5 = DSharp5,
            E5,
            F5,
            FSharp5,
            GFlat5 = FSharp5,
            G5,
            GSharp5,
            AFlat5 = GSharp5,
            A5,
            ASharp5,
            BFlat5 = ASharp5,
            B5,

            C6,
            CSharp6,
            DFlat6 = CSharp6,
            D6,
            DSharp6,
            EFlat6 = DSharp6,
            E6,
            F6,
            FSharp6,
            GFlat6 = FSharp6,
            G6,
            GSharp6,
            AFlat6 = GSharp6,
            A6,
            ASharp6,
            BFlat6 = ASharp6,
            B6,

            C7,
            CSharp7,
            DFlat7 = CSharp7,
            D7,
            DSharp7,
            EFlat7 = DSharp7,
            E7,
            F7,
            FSharp7,
            GFlat7 = FSharp7,
            G7,
            GSharp7,
            AFlat7 = GSharp7,
            A7,
            ASharp7,
            BFlat7 = ASharp7,
            B7,

            C8,
            CSharp8,
            DFlat8 = CSharp8,
            D8,
            DSharp8,
            EFlat8 = DSharp8,
            E8,
            F8,
            FSharp8,
            GFlat8 = FSharp8,
            G8,
            GSharp8,
            AFlat8 = GSharp8,
            A8,
            ASharp8,
            BFlat8 = ASharp8,
            B8,

            C9,
            CSharp9,
            DFlat9 = CSharp9,
            D9,
            DSharp9,
            EFlat9 = DSharp9,
            E9,
            F9,
            FSharp9,
            GFlat9 = FSharp9,
            G9,
            GSharp9,
            AFlat9 = GSharp9,
            A9,
            ASharp9,
            BFlat9 = ASharp9,
            B9,

            C10,
            CSharp10,
            DFlat10 = CSharp10,
            D10,
            DSharp10,
            EFlat10 = DSharp10,
            E10,
            F10,
            FSharp10,
            GFlat10 = FSharp10,
            G10,
        }

        private const int msForHold = 120;
        internal int MsForHold { get { return msForHold; } }

        private const int msForDoubleClick = 500;
        internal int MsForDoubleClick { get { return msForDoubleClick; } }

        internal class NotePressedData
        {
            internal int NoteIndex { get; set; }
            internal string Note { get; set; }
            internal int Intensity { get; set; }
            internal DateTime TimeStamp { get; set; }
        }

        public enum MidiControllerMode
        {
            Mode1 = 1,
            Mode2,
            Mode3,
            Mode4,
            Mode5,
            Mode6,
            Mode7,
            Mode8,
        }

        private MidiControllerMode currentMode = MidiControllerMode.Mode1;
        internal MidiControllerMode CurrentMode { get { return currentMode; } set { currentMode = value; } }

        public string CurrentMidiDevice { get; private set; }
        internal bool MidiRecievingActive { get; private set; }

        internal AbstractEvents()
        {
            midiReciever = new MidiReciever();
        }

        internal List<string> GetMidiDevices()
        {
            return midiReciever.GetMidiDevices();
        }

        internal bool SetMidiDevice(string deviceName)
        {
            if (midiReciever.SetMidiDevice(deviceName))
            {
                CurrentMidiDevice = deviceName;
                return true;
            }

            return false;
        }

        internal void StartRecievingMidi()
        {
            midiReciever.StartRecieving();
            MidiRecievingActive = true;

            midiReciever.MidiMessageRecieved += onMidiMessage;
        }

        internal void StopRecievingMidi()
        {
            midiReciever.StopRecieving();
            MidiRecievingActive = false;
        }

        internal abstract void onMidiMessage(object sender, MidiMessageRecievedEventArgs e);

        internal Note NoteForIndex(int noteIndex)
        {
            return (Note)noteIndex;
        }

        internal EventHandlerList listEventDelegates { get; } = new EventHandlerList();
    }
}
