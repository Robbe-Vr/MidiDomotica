using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents
{
    public class OnPitchBendEventArgs : EventArgs
    {
        public string DeviceName { get; set; }
        public int PitchBendValue { get; set; }
    }

    public class OnModulationBendEventArgs : EventArgs
    {
        public string DeviceName { get; set; }
        public int ModulationBendValue { get; set; }
    }

    public class OnNoteOnEventArgs : EventArgs
    {
        public string DeviceName { get; set; }
        public int NoteIndex { get; set; }
        public string Note { get; set; }
        public int Intensity { get; set; }
    }

    public class OnNoteOffEventArgs : EventArgs
    {
        public string DeviceName { get; set; }
        public int NoteIndex { get; set; }
        public string Note { get; set; }
        public TimeSpan TimeHeld { get; set; }
    }

    public class OnNoteOffDelayedEventArgs : EventArgs
    {
        public string DeviceName { get; set; }
        public int NoteIndex { get; set; }
        public string Note { get; set; }
        public TimeSpan TimeHeld { get; set; }
    }

    public class OnNoteHoldEventArgs : EventArgs
    {
        public string DeviceName { get; set; }
        public int NoteIndex { get; set; }
        public string Note { get; set; }
        public int Intensity { get; set; }
    }

    public class OnSlideFaderEventArgs : EventArgs
    {
        public string DeviceName { get; set; }
        public int SlideFaderIndex { get; set; }
        public int Value { get; set; }
    }

    public class OnKnobFaderEventArgs : EventArgs
    {
        public string DeviceName { get; set; }
        public int KnobFaderIndex { get; set; }
        public int Value { get; set; }
    }

    public class OnFaderButtonEventArgs : EventArgs
    {
        public string DeviceName { get; set; }
        public int FaderButtonIndex { get; set; }
        public int Value { get; set; }
    }

    public class OnMediaButtonEventArgs : EventArgs
    {
        public string DeviceName { get; set; }
        public string Command { get; set; }
    }
}
