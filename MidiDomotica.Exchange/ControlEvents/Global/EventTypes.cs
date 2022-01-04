using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.MidiConnection.Event
{
    internal class OnPitchBendEventArgs : EventArgs
    {
        internal string DeviceName { get; set; }
        internal int PitchBendValue { get; set; }
    }

    internal class OnModulationBendEventArgs : EventArgs
    {
        internal string DeviceName { get; set; }
        internal int ModulationBendValue { get; set; }
    }

    internal class OnNoteOnEventArgs : EventArgs
    {
        internal string DeviceName { get; set; }
        internal int NoteIndex { get; set; }
        internal string Note { get; set; }
        internal int Intensity { get; set; }
    }

    internal class OnNoteOffEventArgs : EventArgs
    {
        internal string DeviceName { get; set; }
        internal int NoteIndex { get; set; }
        internal string Note { get; set; }
        internal TimeSpan TimeHeld { get; set; }
    }

    internal class OnNoteOffDelayedEventArgs : EventArgs
    {
        internal string DeviceName { get; set; }
        internal int NoteIndex { get; set; }
        internal string Note { get; set; }
        internal TimeSpan TimeHeld { get; set; }
    }

    internal class OnNoteHoldEventArgs : EventArgs
    {
        internal string DeviceName { get; set; }
        internal int NoteIndex { get; set; }
        internal string Note { get; set; }
        internal int Intensity { get; set; }
    }

    internal class OnSlideFaderEventArgs : EventArgs
    {
        internal string DeviceName { get; set; }
        internal int SlideFaderIndex { get; set; }
        internal int Value { get; set; }
    }

    internal class OnKnobFaderEventArgs : EventArgs
    {
        internal string DeviceName { get; set; }
        internal int KnobFaderIndex { get; set; }
        internal int Value { get; set; }
    }

    internal class OnFaderButtonEventArgs : EventArgs
    {
        internal string DeviceName { get; set; }
        internal int FaderButtonIndex { get; set; }
        internal int Value { get; set; }
    }

    internal class OnMediaButtonEventArgs : EventArgs
    {
        internal string DeviceName { get; set; }
        internal string Command { get; set; }
    }
}
