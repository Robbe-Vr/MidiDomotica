using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.MidiConnection.Event
{
    internal partial class Events : AbstractEvents
    {
        #region Mode3 Events Setup
        static readonly object Mode3PitchBendEventKey = new object();
        static readonly object Mode3ModulationBendEventKey = new object();

        static readonly object Mode3NoteOnEventKey = new object();
        static readonly object Mode3NoteHeldEventKey = new object();
        static readonly object Mode3NoteOffEventKey = new object();
        static readonly object Mode3NoteOffDelayedEventKey = new object();
        static readonly object Mode3NoteOffDoubleClickEventKey = new object();
        static readonly object Mode3NoteOnDoubleClickEventKey = new object();

        static readonly object Mode3SlideFader1ChangedEventKey = new object();
        static readonly object Mode3SlideFader2ChangedEventKey = new object();
        static readonly object Mode3SlideFader3ChangedEventKey = new object();
        static readonly object Mode3SlideFader4ChangedEventKey = new object();
        static readonly object Mode3SlideFader5ChangedEventKey = new object();
        static readonly object Mode3SlideFader6ChangedEventKey = new object();
        static readonly object Mode3SlideFader7ChangedEventKey = new object();
        static readonly object Mode3SlideFader8ChangedEventKey = new object();

        static readonly object Mode3KnobFader1ChangedEventKey = new object();
        static readonly object Mode3KnobFader2ChangedEventKey = new object();
        static readonly object Mode3KnobFader3ChangedEventKey = new object();
        static readonly object Mode3KnobFader4ChangedEventKey = new object();
        static readonly object Mode3KnobFader5ChangedEventKey = new object();
        static readonly object Mode3KnobFader6ChangedEventKey = new object();
        static readonly object Mode3KnobFader7ChangedEventKey = new object();
        static readonly object Mode3KnobFader8ChangedEventKey = new object();

        static readonly object Mode3FaderButton1PressedEventKey = new object();
        static readonly object Mode3FaderButton2PressedEventKey = new object();
        static readonly object Mode3FaderButton3PressedEventKey = new object();
        static readonly object Mode3FaderButton4PressedEventKey = new object();
        static readonly object Mode3FaderButton5PressedEventKey = new object();
        static readonly object Mode3FaderButton6PressedEventKey = new object();
        static readonly object Mode3FaderButton7PressedEventKey = new object();
        static readonly object Mode3FaderButton8PressedEventKey = new object();

        static readonly object Mode3FaderButton9PressedEventKey = new object();
        static readonly object Mode3FaderButton10PressedEventKey = new object();
        static readonly object Mode3FaderButton11PressedEventKey = new object();
        static readonly object Mode3FaderButton12PressedEventKey = new object();
        static readonly object Mode3FaderButton13PressedEventKey = new object();
        static readonly object Mode3FaderButton14PressedEventKey = new object();
        static readonly object Mode3FaderButton15PressedEventKey = new object();
        static readonly object Mode3FaderButton16PressedEventKey = new object();

        static readonly object Mode3FaderButton1ReleasedEventKey = new object();
        static readonly object Mode3FaderButton2ReleasedEventKey = new object();
        static readonly object Mode3FaderButton3ReleasedEventKey = new object();
        static readonly object Mode3FaderButton4ReleasedEventKey = new object();
        static readonly object Mode3FaderButton5ReleasedEventKey = new object();
        static readonly object Mode3FaderButton6ReleasedEventKey = new object();
        static readonly object Mode3FaderButton7ReleasedEventKey = new object();
        static readonly object Mode3FaderButton8ReleasedEventKey = new object();

        static readonly object Mode3FaderButton9ReleasedEventKey = new object();
        static readonly object Mode3FaderButton10ReleasedEventKey = new object();
        static readonly object Mode3FaderButton11ReleasedEventKey = new object();
        static readonly object Mode3FaderButton12ReleasedEventKey = new object();
        static readonly object Mode3FaderButton13ReleasedEventKey = new object();
        static readonly object Mode3FaderButton14ReleasedEventKey = new object();
        static readonly object Mode3FaderButton15ReleasedEventKey = new object();
        static readonly object Mode3FaderButton16ReleasedEventKey = new object();

        internal event EventHandler<OnPitchBendEventArgs> Mode3PitchBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode3PitchBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3PitchBendEventKey, value);
            }
        }

        internal event EventHandler<OnModulationBendEventArgs> Mode3ModulationBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode3ModulationBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3ModulationBendEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode3ControlPress
        {
            add
            {
                listEventDelegates.AddHandler(Mode3NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3NoteOnEventKey, value);
            }
        }

        internal event EventHandler<OnNoteHoldEventArgs> Mode3ControlHold
        {
            add
            {
                listEventDelegates.AddHandler(Mode3NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3NoteHeldEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode3ControlRelease
        {
            add
            {
                listEventDelegates.AddHandler(Mode3NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3NoteOffEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffDelayedEventArgs> Mode3ControlReleaseDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3NoteOffDelayedEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode3ControlReleaseDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode3NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3NoteOffDoubleClickEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode3ControlPressDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode3NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3NoteOnDoubleClickEventKey, value);
            }
        }


        internal event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3SlideFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3SlideFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3SlideFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3SlideFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3SlideFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3SlideFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3SlideFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3SlideFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3SlideFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3SlideFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3SlideFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3SlideFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3SlideFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3SlideFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3SlideFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3SlideFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3KnobFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3KnobFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3KnobFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3KnobFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3KnobFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3KnobFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3KnobFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3KnobFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3KnobFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3KnobFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3KnobFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3KnobFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3KnobFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3KnobFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3KnobFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3KnobFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton1Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton1PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton1PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton2Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton2PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton2PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton3Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton3PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton3PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton4Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton4PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton4PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton5Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton5PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton5PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton6Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton6PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton6PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton7Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton7PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton7PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton8Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton8PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton8PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton9Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton9PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton9PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton10Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton10PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton10PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton11Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton11PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton11PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton12Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton12PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton12PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton13Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton13PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton13PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton14Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton14PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton14PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton15Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton15PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton15PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton16Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton16PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton16PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton1Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton1ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton1ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton2Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton2ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton2ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton3Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton3ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton3ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton4Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton4ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton4ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton5Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton5ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton5ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton6Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton6ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton6ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton7Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton7ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton7ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton8Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton8ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton8ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton9Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton9ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton9ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton10Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton10ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton10ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton11Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton11ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton11ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton12Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton12ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton12ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton13Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton13ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton13ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton14Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton14ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton14ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton15Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton15ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton15ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton16Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode3FaderButton16ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode3FaderButton16ReleasedEventKey, value);
            }
        }

        #endregion
    }
}
