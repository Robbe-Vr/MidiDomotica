using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.MidiConnection.Event
{
    internal partial class Events : AbstractEvents
    {
        #region Mode8 Events Setup
        static readonly object Mode8PitchBendEventKey = new object();
        static readonly object Mode8ModulationBendEventKey = new object();

        static readonly object Mode8NoteOnEventKey = new object();
        static readonly object Mode8NoteHeldEventKey = new object();
        static readonly object Mode8NoteOffEventKey = new object();
        static readonly object Mode8NoteOffDelayedEventKey = new object();
        static readonly object Mode8NoteOffDoubleClickEventKey = new object();
        static readonly object Mode8NoteOnDoubleClickEventKey = new object();

        static readonly object Mode8SlideFader1ChangedEventKey = new object();
        static readonly object Mode8SlideFader2ChangedEventKey = new object();
        static readonly object Mode8SlideFader3ChangedEventKey = new object();
        static readonly object Mode8SlideFader4ChangedEventKey = new object();
        static readonly object Mode8SlideFader5ChangedEventKey = new object();
        static readonly object Mode8SlideFader6ChangedEventKey = new object();
        static readonly object Mode8SlideFader7ChangedEventKey = new object();
        static readonly object Mode8SlideFader8ChangedEventKey = new object();

        static readonly object Mode8KnobFader1ChangedEventKey = new object();
        static readonly object Mode8KnobFader2ChangedEventKey = new object();
        static readonly object Mode8KnobFader3ChangedEventKey = new object();
        static readonly object Mode8KnobFader4ChangedEventKey = new object();
        static readonly object Mode8KnobFader5ChangedEventKey = new object();
        static readonly object Mode8KnobFader6ChangedEventKey = new object();
        static readonly object Mode8KnobFader7ChangedEventKey = new object();
        static readonly object Mode8KnobFader8ChangedEventKey = new object();

        static readonly object Mode8FaderButton1PressedEventKey = new object();
        static readonly object Mode8FaderButton2PressedEventKey = new object();
        static readonly object Mode8FaderButton3PressedEventKey = new object();
        static readonly object Mode8FaderButton4PressedEventKey = new object();
        static readonly object Mode8FaderButton5PressedEventKey = new object();
        static readonly object Mode8FaderButton6PressedEventKey = new object();
        static readonly object Mode8FaderButton7PressedEventKey = new object();
        static readonly object Mode8FaderButton8PressedEventKey = new object();

        static readonly object Mode8FaderButton9PressedEventKey = new object();
        static readonly object Mode8FaderButton10PressedEventKey = new object();
        static readonly object Mode8FaderButton11PressedEventKey = new object();
        static readonly object Mode8FaderButton12PressedEventKey = new object();
        static readonly object Mode8FaderButton13PressedEventKey = new object();
        static readonly object Mode8FaderButton14PressedEventKey = new object();
        static readonly object Mode8FaderButton15PressedEventKey = new object();
        static readonly object Mode8FaderButton16PressedEventKey = new object();

        static readonly object Mode8FaderButton1ReleasedEventKey = new object();
        static readonly object Mode8FaderButton2ReleasedEventKey = new object();
        static readonly object Mode8FaderButton3ReleasedEventKey = new object();
        static readonly object Mode8FaderButton4ReleasedEventKey = new object();
        static readonly object Mode8FaderButton5ReleasedEventKey = new object();
        static readonly object Mode8FaderButton6ReleasedEventKey = new object();
        static readonly object Mode8FaderButton7ReleasedEventKey = new object();
        static readonly object Mode8FaderButton8ReleasedEventKey = new object();

        static readonly object Mode8FaderButton9ReleasedEventKey = new object();
        static readonly object Mode8FaderButton10ReleasedEventKey = new object();
        static readonly object Mode8FaderButton11ReleasedEventKey = new object();
        static readonly object Mode8FaderButton12ReleasedEventKey = new object();
        static readonly object Mode8FaderButton13ReleasedEventKey = new object();
        static readonly object Mode8FaderButton14ReleasedEventKey = new object();
        static readonly object Mode8FaderButton15ReleasedEventKey = new object();
        static readonly object Mode8FaderButton16ReleasedEventKey = new object();

        internal event EventHandler<OnPitchBendEventArgs> Mode8PitchBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode8PitchBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8PitchBendEventKey, value);
            }
        }

        internal event EventHandler<OnModulationBendEventArgs> Mode8ModulationBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode8ModulationBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8ModulationBendEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode8ControlPress
        {
            add
            {
                listEventDelegates.AddHandler(Mode8NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8NoteOnEventKey, value);
            }
        }

        internal event EventHandler<OnNoteHoldEventArgs> Mode8ControlHold
        {
            add
            {
                listEventDelegates.AddHandler(Mode8NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8NoteHeldEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode8ControlRelease
        {
            add
            {
                listEventDelegates.AddHandler(Mode8NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8NoteOffEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffDelayedEventArgs> Mode8ControlReleaseDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8NoteOffDelayedEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode8ControlReleaseDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode8NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8NoteOffDoubleClickEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode8ControlPressDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode8NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8NoteOnDoubleClickEventKey, value);
            }
        }


        internal event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8SlideFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8SlideFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8SlideFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8SlideFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8SlideFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8SlideFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8SlideFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8SlideFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8SlideFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8SlideFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8SlideFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8SlideFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8SlideFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8SlideFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8SlideFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8SlideFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8KnobFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8KnobFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8KnobFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8KnobFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8KnobFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8KnobFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8KnobFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8KnobFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8KnobFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8KnobFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8KnobFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8KnobFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8KnobFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8KnobFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8KnobFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8KnobFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton1Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton1PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton1PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton2Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton2PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton2PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton3Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton3PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton3PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton4Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton4PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton4PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton5Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton5PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton5PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton6Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton6PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton6PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton7Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton7PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton7PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton8Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton8PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton8PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton9Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton9PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton9PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton10Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton10PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton10PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton11Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton11PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton11PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton12Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton12PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton12PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton13Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton13PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton13PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton14Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton14PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton14PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton15Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton15PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton15PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton16Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton16PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton16PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton1Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton1ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton1ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton2Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton2ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton2ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton3Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton3ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton3ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton4Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton4ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton4ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton5Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton5ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton5ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton6Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton6ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton6ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton7Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton7ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton7ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton8Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton8ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton8ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton9Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton9ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton9ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton10Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton10ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton10ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton11Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton11ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton11ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton12Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton12ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton12ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton13Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton13ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton13ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton14Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton14ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton14ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton15Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton15ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton15ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton16Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode8FaderButton16ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode8FaderButton16ReleasedEventKey, value);
            }
        }

        #endregion
    }
}
