using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.MidiConnection.Event
{
    internal partial class Events : AbstractEvents
    {
        #region Mode7 Events Setup
        static readonly object Mode7PitchBendEventKey = new object();
        static readonly object Mode7ModulationBendEventKey = new object();

        static readonly object Mode7NoteOnEventKey = new object();
        static readonly object Mode7NoteHeldEventKey = new object();
        static readonly object Mode7NoteOffEventKey = new object();
        static readonly object Mode7NoteOffDelayedEventKey = new object();
        static readonly object Mode7NoteOffDoubleClickEventKey = new object();
        static readonly object Mode7NoteOnDoubleClickEventKey = new object();

        static readonly object Mode7SlideFader1ChangedEventKey = new object();
        static readonly object Mode7SlideFader2ChangedEventKey = new object();
        static readonly object Mode7SlideFader3ChangedEventKey = new object();
        static readonly object Mode7SlideFader4ChangedEventKey = new object();
        static readonly object Mode7SlideFader5ChangedEventKey = new object();
        static readonly object Mode7SlideFader6ChangedEventKey = new object();
        static readonly object Mode7SlideFader7ChangedEventKey = new object();
        static readonly object Mode7SlideFader8ChangedEventKey = new object();

        static readonly object Mode7KnobFader1ChangedEventKey = new object();
        static readonly object Mode7KnobFader2ChangedEventKey = new object();
        static readonly object Mode7KnobFader3ChangedEventKey = new object();
        static readonly object Mode7KnobFader4ChangedEventKey = new object();
        static readonly object Mode7KnobFader5ChangedEventKey = new object();
        static readonly object Mode7KnobFader6ChangedEventKey = new object();
        static readonly object Mode7KnobFader7ChangedEventKey = new object();
        static readonly object Mode7KnobFader8ChangedEventKey = new object();

        static readonly object Mode7FaderButton1PressedEventKey = new object();
        static readonly object Mode7FaderButton2PressedEventKey = new object();
        static readonly object Mode7FaderButton3PressedEventKey = new object();
        static readonly object Mode7FaderButton4PressedEventKey = new object();
        static readonly object Mode7FaderButton5PressedEventKey = new object();
        static readonly object Mode7FaderButton6PressedEventKey = new object();
        static readonly object Mode7FaderButton7PressedEventKey = new object();
        static readonly object Mode7FaderButton8PressedEventKey = new object();

        static readonly object Mode7FaderButton9PressedEventKey = new object();
        static readonly object Mode7FaderButton10PressedEventKey = new object();
        static readonly object Mode7FaderButton11PressedEventKey = new object();
        static readonly object Mode7FaderButton12PressedEventKey = new object();
        static readonly object Mode7FaderButton13PressedEventKey = new object();
        static readonly object Mode7FaderButton14PressedEventKey = new object();
        static readonly object Mode7FaderButton15PressedEventKey = new object();
        static readonly object Mode7FaderButton16PressedEventKey = new object();

        static readonly object Mode7FaderButton1ReleasedEventKey = new object();
        static readonly object Mode7FaderButton2ReleasedEventKey = new object();
        static readonly object Mode7FaderButton3ReleasedEventKey = new object();
        static readonly object Mode7FaderButton4ReleasedEventKey = new object();
        static readonly object Mode7FaderButton5ReleasedEventKey = new object();
        static readonly object Mode7FaderButton6ReleasedEventKey = new object();
        static readonly object Mode7FaderButton7ReleasedEventKey = new object();
        static readonly object Mode7FaderButton8ReleasedEventKey = new object();

        static readonly object Mode7FaderButton9ReleasedEventKey = new object();
        static readonly object Mode7FaderButton10ReleasedEventKey = new object();
        static readonly object Mode7FaderButton11ReleasedEventKey = new object();
        static readonly object Mode7FaderButton12ReleasedEventKey = new object();
        static readonly object Mode7FaderButton13ReleasedEventKey = new object();
        static readonly object Mode7FaderButton14ReleasedEventKey = new object();
        static readonly object Mode7FaderButton15ReleasedEventKey = new object();
        static readonly object Mode7FaderButton16ReleasedEventKey = new object();

        internal event EventHandler<OnPitchBendEventArgs> Mode7PitchBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode7PitchBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7PitchBendEventKey, value);
            }
        }

        internal event EventHandler<OnModulationBendEventArgs> Mode7ModulationBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode7ModulationBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7ModulationBendEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode7ControlPress
        {
            add
            {
                listEventDelegates.AddHandler(Mode7NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7NoteOnEventKey, value);
            }
        }

        internal event EventHandler<OnNoteHoldEventArgs> Mode7ControlHold
        {
            add
            {
                listEventDelegates.AddHandler(Mode7NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7NoteHeldEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode7ControlRelease
        {
            add
            {
                listEventDelegates.AddHandler(Mode7NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7NoteOffEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffDelayedEventArgs> Mode7ControlReleaseDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7NoteOffDelayedEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode7ControlReleaseDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode7NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7NoteOffDoubleClickEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode7ControlPressDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode7NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7NoteOnDoubleClickEventKey, value);
            }
        }


        internal event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7SlideFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7SlideFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7SlideFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7SlideFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7SlideFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7SlideFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7SlideFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7SlideFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7SlideFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7SlideFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7SlideFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7SlideFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7SlideFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7SlideFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7SlideFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7SlideFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7KnobFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7KnobFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7KnobFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7KnobFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7KnobFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7KnobFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7KnobFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7KnobFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7KnobFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7KnobFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7KnobFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7KnobFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7KnobFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7KnobFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7KnobFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7KnobFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton1Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton1PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton1PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton2Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton2PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton2PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton3Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton3PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton3PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton4Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton4PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton4PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton5Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton5PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton5PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton6Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton6PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton6PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton7Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton7PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton7PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton8Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton8PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton8PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton9Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton9PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton9PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton10Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton10PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton10PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton11Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton11PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton11PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton12Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton12PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton12PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton13Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton13PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton13PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton14Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton14PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton14PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton15Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton15PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton15PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton16Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton16PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton16PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton1Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton1ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton1ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton2Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton2ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton2ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton3Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton3ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton3ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton4Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton4ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton4ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton5Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton5ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton5ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton6Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton6ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton6ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton7Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton7ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton7ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton8Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton8ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton8ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton9Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton9ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton9ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton10Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton10ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton10ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton11Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton11ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton11ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton12Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton12ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton12ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton13Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton13ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton13ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton14Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton14ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton14ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton15Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton15ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton15ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton16Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode7FaderButton16ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode7FaderButton16ReleasedEventKey, value);
            }
        }

        #endregion
    }
}
