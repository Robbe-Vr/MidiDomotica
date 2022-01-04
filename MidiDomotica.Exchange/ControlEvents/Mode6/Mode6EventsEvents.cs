using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.MidiConnection.Event
{
    internal partial class Events : AbstractEvents
    {
        #region Mode6 Events Setup
        static readonly object Mode6PitchBendEventKey = new object();
        static readonly object Mode6ModulationBendEventKey = new object();

        static readonly object Mode6NoteOnEventKey = new object();
        static readonly object Mode6NoteHeldEventKey = new object();
        static readonly object Mode6NoteOffEventKey = new object();
        static readonly object Mode6NoteOffDelayedEventKey = new object();
        static readonly object Mode6NoteOffDoubleClickEventKey = new object();
        static readonly object Mode6NoteOnDoubleClickEventKey = new object();

        static readonly object Mode6SlideFader1ChangedEventKey = new object();
        static readonly object Mode6SlideFader2ChangedEventKey = new object();
        static readonly object Mode6SlideFader3ChangedEventKey = new object();
        static readonly object Mode6SlideFader4ChangedEventKey = new object();
        static readonly object Mode6SlideFader5ChangedEventKey = new object();
        static readonly object Mode6SlideFader6ChangedEventKey = new object();
        static readonly object Mode6SlideFader7ChangedEventKey = new object();
        static readonly object Mode6SlideFader8ChangedEventKey = new object();

        static readonly object Mode6KnobFader1ChangedEventKey = new object();
        static readonly object Mode6KnobFader2ChangedEventKey = new object();
        static readonly object Mode6KnobFader3ChangedEventKey = new object();
        static readonly object Mode6KnobFader4ChangedEventKey = new object();
        static readonly object Mode6KnobFader5ChangedEventKey = new object();
        static readonly object Mode6KnobFader6ChangedEventKey = new object();
        static readonly object Mode6KnobFader7ChangedEventKey = new object();
        static readonly object Mode6KnobFader8ChangedEventKey = new object();

        static readonly object Mode6FaderButton1PressedEventKey = new object();
        static readonly object Mode6FaderButton2PressedEventKey = new object();
        static readonly object Mode6FaderButton3PressedEventKey = new object();
        static readonly object Mode6FaderButton4PressedEventKey = new object();
        static readonly object Mode6FaderButton5PressedEventKey = new object();
        static readonly object Mode6FaderButton6PressedEventKey = new object();
        static readonly object Mode6FaderButton7PressedEventKey = new object();
        static readonly object Mode6FaderButton8PressedEventKey = new object();

        static readonly object Mode6FaderButton9PressedEventKey = new object();
        static readonly object Mode6FaderButton10PressedEventKey = new object();
        static readonly object Mode6FaderButton11PressedEventKey = new object();
        static readonly object Mode6FaderButton12PressedEventKey = new object();
        static readonly object Mode6FaderButton13PressedEventKey = new object();
        static readonly object Mode6FaderButton14PressedEventKey = new object();
        static readonly object Mode6FaderButton15PressedEventKey = new object();
        static readonly object Mode6FaderButton16PressedEventKey = new object();

        static readonly object Mode6FaderButton1ReleasedEventKey = new object();
        static readonly object Mode6FaderButton2ReleasedEventKey = new object();
        static readonly object Mode6FaderButton3ReleasedEventKey = new object();
        static readonly object Mode6FaderButton4ReleasedEventKey = new object();
        static readonly object Mode6FaderButton5ReleasedEventKey = new object();
        static readonly object Mode6FaderButton6ReleasedEventKey = new object();
        static readonly object Mode6FaderButton7ReleasedEventKey = new object();
        static readonly object Mode6FaderButton8ReleasedEventKey = new object();

        static readonly object Mode6FaderButton9ReleasedEventKey = new object();
        static readonly object Mode6FaderButton10ReleasedEventKey = new object();
        static readonly object Mode6FaderButton11ReleasedEventKey = new object();
        static readonly object Mode6FaderButton12ReleasedEventKey = new object();
        static readonly object Mode6FaderButton13ReleasedEventKey = new object();
        static readonly object Mode6FaderButton14ReleasedEventKey = new object();
        static readonly object Mode6FaderButton15ReleasedEventKey = new object();
        static readonly object Mode6FaderButton16ReleasedEventKey = new object();

        internal event EventHandler<OnPitchBendEventArgs> Mode6PitchBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode6PitchBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6PitchBendEventKey, value);
            }
        }

        internal event EventHandler<OnModulationBendEventArgs> Mode6ModulationBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode6ModulationBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6ModulationBendEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode6ControlPress
        {
            add
            {
                listEventDelegates.AddHandler(Mode6NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6NoteOnEventKey, value);
            }
        }

        internal event EventHandler<OnNoteHoldEventArgs> Mode6ControlHold
        {
            add
            {
                listEventDelegates.AddHandler(Mode6NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6NoteHeldEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode6ControlRelease
        {
            add
            {
                listEventDelegates.AddHandler(Mode6NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6NoteOffEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffDelayedEventArgs> Mode6ControlReleaseDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6NoteOffDelayedEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode6ControlReleaseDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6NoteOffDoubleClickEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode6ControlPressDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6NoteOnDoubleClickEventKey, value);
            }
        }


        internal event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6SlideFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6SlideFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6SlideFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6SlideFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6SlideFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6SlideFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6SlideFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6SlideFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6SlideFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6SlideFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6SlideFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6SlideFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6SlideFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6SlideFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6SlideFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6SlideFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6KnobFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6KnobFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6KnobFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6KnobFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6KnobFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6KnobFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6KnobFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6KnobFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6KnobFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6KnobFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6KnobFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6KnobFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6KnobFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6KnobFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6KnobFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6KnobFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton1Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton1PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton1PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton2Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton2PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton2PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton3Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton3PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton3PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton4Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton4PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton4PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton5Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton5PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton5PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton6Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton6PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton6PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton7Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton7PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton7PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton8Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton8PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton8PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton9Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton9PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton9PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton10Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton10PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton10PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton11Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton11PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton11PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton12Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton12PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton12PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton13Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton13PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton13PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton14Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton14PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton14PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton15Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton15PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton15PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton16Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton16PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton16PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton1Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton1ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton1ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton2Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton2ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton2ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton3Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton3ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton3ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton4Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton4ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton4ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton5Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton5ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton5ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton6Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton6ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton6ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton7Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton7ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton7ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton8Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton8ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton8ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton9Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton9ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton9ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton10Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton10ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton10ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton11Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton11ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton11ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton12Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton12ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton12ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton13Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton13ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton13ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton14Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton14ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton14ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton15Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton15ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton15ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton16Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode6FaderButton16ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6FaderButton16ReleasedEventKey, value);
            }
        }

        #endregion
    }
}
