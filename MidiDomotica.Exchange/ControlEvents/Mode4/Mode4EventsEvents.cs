using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.MidiConnection.Event
{
    internal partial class Events : AbstractEvents
    {
        #region Mode4 Events Setup
        static readonly object Mode4PitchBendEventKey = new object();
        static readonly object Mode4ModulationBendEventKey = new object();

        static readonly object Mode4NoteOnEventKey = new object();
        static readonly object Mode4NoteHeldEventKey = new object();
        static readonly object Mode4NoteOffEventKey = new object();
        static readonly object Mode4NoteOffDelayedEventKey = new object();
        static readonly object Mode4NoteOffDoubleClickEventKey = new object();
        static readonly object Mode4NoteOnDoubleClickEventKey = new object();

        static readonly object Mode4SlideFader1ChangedEventKey = new object();
        static readonly object Mode4SlideFader2ChangedEventKey = new object();
        static readonly object Mode4SlideFader3ChangedEventKey = new object();
        static readonly object Mode4SlideFader4ChangedEventKey = new object();
        static readonly object Mode4SlideFader5ChangedEventKey = new object();
        static readonly object Mode4SlideFader6ChangedEventKey = new object();
        static readonly object Mode4SlideFader7ChangedEventKey = new object();
        static readonly object Mode4SlideFader8ChangedEventKey = new object();

        static readonly object Mode4KnobFader1ChangedEventKey = new object();
        static readonly object Mode4KnobFader2ChangedEventKey = new object();
        static readonly object Mode4KnobFader3ChangedEventKey = new object();
        static readonly object Mode4KnobFader4ChangedEventKey = new object();
        static readonly object Mode4KnobFader5ChangedEventKey = new object();
        static readonly object Mode4KnobFader6ChangedEventKey = new object();
        static readonly object Mode4KnobFader7ChangedEventKey = new object();
        static readonly object Mode4KnobFader8ChangedEventKey = new object();

        static readonly object Mode4FaderButton1PressedEventKey = new object();
        static readonly object Mode4FaderButton2PressedEventKey = new object();
        static readonly object Mode4FaderButton3PressedEventKey = new object();
        static readonly object Mode4FaderButton4PressedEventKey = new object();
        static readonly object Mode4FaderButton5PressedEventKey = new object();
        static readonly object Mode4FaderButton6PressedEventKey = new object();
        static readonly object Mode4FaderButton7PressedEventKey = new object();
        static readonly object Mode4FaderButton8PressedEventKey = new object();

        static readonly object Mode4FaderButton9PressedEventKey = new object();
        static readonly object Mode4FaderButton10PressedEventKey = new object();
        static readonly object Mode4FaderButton11PressedEventKey = new object();
        static readonly object Mode4FaderButton12PressedEventKey = new object();
        static readonly object Mode4FaderButton13PressedEventKey = new object();
        static readonly object Mode4FaderButton14PressedEventKey = new object();
        static readonly object Mode4FaderButton15PressedEventKey = new object();
        static readonly object Mode4FaderButton16PressedEventKey = new object();

        static readonly object Mode4FaderButton1ReleasedEventKey = new object();
        static readonly object Mode4FaderButton2ReleasedEventKey = new object();
        static readonly object Mode4FaderButton3ReleasedEventKey = new object();
        static readonly object Mode4FaderButton4ReleasedEventKey = new object();
        static readonly object Mode4FaderButton5ReleasedEventKey = new object();
        static readonly object Mode4FaderButton6ReleasedEventKey = new object();
        static readonly object Mode4FaderButton7ReleasedEventKey = new object();
        static readonly object Mode4FaderButton8ReleasedEventKey = new object();

        static readonly object Mode4FaderButton9ReleasedEventKey = new object();
        static readonly object Mode4FaderButton10ReleasedEventKey = new object();
        static readonly object Mode4FaderButton11ReleasedEventKey = new object();
        static readonly object Mode4FaderButton12ReleasedEventKey = new object();
        static readonly object Mode4FaderButton13ReleasedEventKey = new object();
        static readonly object Mode4FaderButton14ReleasedEventKey = new object();
        static readonly object Mode4FaderButton15ReleasedEventKey = new object();
        static readonly object Mode4FaderButton16ReleasedEventKey = new object();

        internal event EventHandler<OnPitchBendEventArgs> Mode4PitchBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode4PitchBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4PitchBendEventKey, value);
            }
        }

        internal event EventHandler<OnModulationBendEventArgs> Mode4ModulationBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode4ModulationBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4ModulationBendEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode4ControlPress
        {
            add
            {
                listEventDelegates.AddHandler(Mode4NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4NoteOnEventKey, value);
            }
        }

        internal event EventHandler<OnNoteHoldEventArgs> Mode4ControlHold
        {
            add
            {
                listEventDelegates.AddHandler(Mode4NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4NoteHeldEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode4ControlRelease
        {
            add
            {
                listEventDelegates.AddHandler(Mode4NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4NoteOffEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffDelayedEventArgs> Mode4ControlReleaseDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4NoteOffDelayedEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode4ControlReleaseDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode4NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4NoteOffDoubleClickEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode4ControlPressDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode4NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4NoteOnDoubleClickEventKey, value);
            }
        }


        internal event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4SlideFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4SlideFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4SlideFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4SlideFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4SlideFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4SlideFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4SlideFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4SlideFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4SlideFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4SlideFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4SlideFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4SlideFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4SlideFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4SlideFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4SlideFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4SlideFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4KnobFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4KnobFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4KnobFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4KnobFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4KnobFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4KnobFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4KnobFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4KnobFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4KnobFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4KnobFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4KnobFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4KnobFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4KnobFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4KnobFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4KnobFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4KnobFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton1Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton1PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton1PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton2Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton2PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton2PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton3Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton3PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton3PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton4Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton4PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton4PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton5Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton5PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton5PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton6Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton6PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton6PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton7Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton7PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton7PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton8Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton8PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton8PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton9Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton9PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton9PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton10Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton10PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton10PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton11Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton11PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton11PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton12Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton12PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton12PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton13Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton13PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton13PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton14Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton14PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton14PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton15Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton15PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton15PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton16Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton16PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton16PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton1Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton1ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton1ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton2Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton2ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton2ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton3Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton3ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton3ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton4Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton4ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton4ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton5Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton5ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton5ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton6Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton6ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton6ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton7Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton7ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton7ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton8Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton8ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton8ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton9Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton9ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton9ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton10Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton10ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton10ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton11Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton11ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton11ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton12Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton12ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton12ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton13Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton13ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton13ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton14Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton14ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton14ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton15Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton15ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton15ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton16Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode4FaderButton16ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode4FaderButton16ReleasedEventKey, value);
            }
        }

        #endregion
    }
}
