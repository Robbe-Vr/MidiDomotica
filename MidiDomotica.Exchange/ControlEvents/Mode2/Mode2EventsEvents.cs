using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.MidiConnection.Event
{
    internal partial class Events : AbstractEvents
    {
        #region Mode2 Events Setup
        static readonly object Mode2PitchBendEventKey = new object();
        static readonly object Mode2ModulationBendEventKey = new object();

        static readonly object Mode2NoteOnEventKey = new object();
        static readonly object Mode2NoteHeldEventKey = new object();
        static readonly object Mode2NoteOffEventKey = new object();
        static readonly object Mode2NoteOffDelayedEventKey = new object();
        static readonly object Mode2NoteOffDoubleClickEventKey = new object();
        static readonly object Mode2NoteOnDoubleClickEventKey = new object();

        static readonly object Mode2SlideFader1ChangedEventKey = new object();
        static readonly object Mode2SlideFader2ChangedEventKey = new object();
        static readonly object Mode2SlideFader3ChangedEventKey = new object();
        static readonly object Mode2SlideFader4ChangedEventKey = new object();
        static readonly object Mode2SlideFader5ChangedEventKey = new object();
        static readonly object Mode2SlideFader6ChangedEventKey = new object();
        static readonly object Mode2SlideFader7ChangedEventKey = new object();
        static readonly object Mode2SlideFader8ChangedEventKey = new object();

        static readonly object Mode2KnobFader1ChangedEventKey = new object();
        static readonly object Mode2KnobFader2ChangedEventKey = new object();
        static readonly object Mode2KnobFader3ChangedEventKey = new object();
        static readonly object Mode2KnobFader4ChangedEventKey = new object();
        static readonly object Mode2KnobFader5ChangedEventKey = new object();
        static readonly object Mode2KnobFader6ChangedEventKey = new object();
        static readonly object Mode2KnobFader7ChangedEventKey = new object();
        static readonly object Mode2KnobFader8ChangedEventKey = new object();

        static readonly object Mode2FaderButton1PressedEventKey = new object();
        static readonly object Mode2FaderButton2PressedEventKey = new object();
        static readonly object Mode2FaderButton3PressedEventKey = new object();
        static readonly object Mode2FaderButton4PressedEventKey = new object();
        static readonly object Mode2FaderButton5PressedEventKey = new object();
        static readonly object Mode2FaderButton6PressedEventKey = new object();
        static readonly object Mode2FaderButton7PressedEventKey = new object();
        static readonly object Mode2FaderButton8PressedEventKey = new object();

        static readonly object Mode2FaderButton9PressedEventKey = new object();
        static readonly object Mode2FaderButton10PressedEventKey = new object();
        static readonly object Mode2FaderButton11PressedEventKey = new object();
        static readonly object Mode2FaderButton12PressedEventKey = new object();
        static readonly object Mode2FaderButton13PressedEventKey = new object();
        static readonly object Mode2FaderButton14PressedEventKey = new object();
        static readonly object Mode2FaderButton15PressedEventKey = new object();
        static readonly object Mode2FaderButton16PressedEventKey = new object();

        static readonly object Mode2FaderButton1ReleasedEventKey = new object();
        static readonly object Mode2FaderButton2ReleasedEventKey = new object();
        static readonly object Mode2FaderButton3ReleasedEventKey = new object();
        static readonly object Mode2FaderButton4ReleasedEventKey = new object();
        static readonly object Mode2FaderButton5ReleasedEventKey = new object();
        static readonly object Mode2FaderButton6ReleasedEventKey = new object();
        static readonly object Mode2FaderButton7ReleasedEventKey = new object();
        static readonly object Mode2FaderButton8ReleasedEventKey = new object();

        static readonly object Mode2FaderButton9ReleasedEventKey = new object();
        static readonly object Mode2FaderButton10ReleasedEventKey = new object();
        static readonly object Mode2FaderButton11ReleasedEventKey = new object();
        static readonly object Mode2FaderButton12ReleasedEventKey = new object();
        static readonly object Mode2FaderButton13ReleasedEventKey = new object();
        static readonly object Mode2FaderButton14ReleasedEventKey = new object();
        static readonly object Mode2FaderButton15ReleasedEventKey = new object();
        static readonly object Mode2FaderButton16ReleasedEventKey = new object();

        internal event EventHandler<OnPitchBendEventArgs> Mode2PitchBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode2PitchBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2PitchBendEventKey, value);
            }
        }

        internal event EventHandler<OnModulationBendEventArgs> Mode2ModulationBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode2ModulationBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2ModulationBendEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode2ControlPress
        {
            add
            {
                listEventDelegates.AddHandler(Mode2NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2NoteOnEventKey, value);
            }
        }

        internal event EventHandler<OnNoteHoldEventArgs> Mode2ControlHold
        {
            add
            {
                listEventDelegates.AddHandler(Mode2NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2NoteHeldEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode2ControlRelease
        {
            add
            {
                listEventDelegates.AddHandler(Mode2NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2NoteOffEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffDelayedEventArgs> Mode2ControlReleaseDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2NoteOffDelayedEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode2ControlReleaseDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode2NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2NoteOffDoubleClickEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode2ControlPressDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode2NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2NoteOnDoubleClickEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2SlideFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2SlideFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2SlideFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2SlideFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2SlideFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2SlideFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2SlideFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2SlideFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2SlideFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2SlideFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2SlideFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2SlideFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2SlideFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2SlideFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2SlideFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2SlideFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2KnobFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2KnobFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2KnobFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2KnobFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2KnobFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2KnobFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2KnobFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2KnobFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2KnobFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2KnobFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2KnobFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2KnobFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2KnobFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2KnobFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2KnobFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2KnobFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton1Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton1PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton1PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton2Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton2PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton2PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton3Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton3PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton3PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton4Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton4PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton4PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton5Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton5PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton5PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton6Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton6PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton6PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton7Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton7PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton7PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton8Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton8PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton8PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton9Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton9PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton9PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton10Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton10PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton10PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton11Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton11PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton11PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton12Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton12PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton12PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton13Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton13PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton13PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton14Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton14PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton14PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton15Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton15PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton15PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton16Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton16PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton16PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton1Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton1ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton1ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton2Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton2ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton2ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton3Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton3ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton3ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton4Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton4ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton4ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton5Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton5ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton5ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton6Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton6ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton6ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton7Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton7ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton7ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton8Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton8ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton8ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton9Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton9ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton9ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton10Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton10ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton10ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton11Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton11ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton11ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton12Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton12ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton12ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton13Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton13ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton13ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton14Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton14ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton14ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton15Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton15ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton15ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton16Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode2FaderButton16ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode2FaderButton16ReleasedEventKey, value);
            }
        }

        #endregion
    }
}
