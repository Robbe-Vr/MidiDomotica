using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.MidiConnection.Event
{
    internal partial class Events : AbstractEvents
    {
        #region Mode5 Events Setup
        static readonly object Mode5PitchBendEventKey = new object();
        static readonly object Mode5ModulationBendEventKey = new object();

        static readonly object Mode5NoteOnEventKey = new object();
        static readonly object Mode5NoteHeldEventKey = new object();
        static readonly object Mode5NoteOffEventKey = new object();
        static readonly object Mode5NoteOffDelayedEventKey = new object();
        static readonly object Mode5NoteOffDoubleClickEventKey = new object();
        static readonly object Mode5NoteOnDoubleClickEventKey = new object();

        static readonly object Mode5SlideFader1ChangedEventKey = new object();
        static readonly object Mode5SlideFader2ChangedEventKey = new object();
        static readonly object Mode5SlideFader3ChangedEventKey = new object();
        static readonly object Mode5SlideFader4ChangedEventKey = new object();
        static readonly object Mode5SlideFader5ChangedEventKey = new object();
        static readonly object Mode5SlideFader6ChangedEventKey = new object();
        static readonly object Mode5SlideFader7ChangedEventKey = new object();
        static readonly object Mode5SlideFader8ChangedEventKey = new object();

        static readonly object Mode5KnobFader1ChangedEventKey = new object();
        static readonly object Mode5KnobFader2ChangedEventKey = new object();
        static readonly object Mode5KnobFader3ChangedEventKey = new object();
        static readonly object Mode5KnobFader4ChangedEventKey = new object();
        static readonly object Mode5KnobFader5ChangedEventKey = new object();
        static readonly object Mode5KnobFader6ChangedEventKey = new object();
        static readonly object Mode5KnobFader7ChangedEventKey = new object();
        static readonly object Mode5KnobFader8ChangedEventKey = new object();

        static readonly object Mode5FaderButton1PressedEventKey = new object();
        static readonly object Mode5FaderButton2PressedEventKey = new object();
        static readonly object Mode5FaderButton3PressedEventKey = new object();
        static readonly object Mode5FaderButton4PressedEventKey = new object();
        static readonly object Mode5FaderButton5PressedEventKey = new object();
        static readonly object Mode5FaderButton6PressedEventKey = new object();
        static readonly object Mode5FaderButton7PressedEventKey = new object();
        static readonly object Mode5FaderButton8PressedEventKey = new object();

        static readonly object Mode5FaderButton9PressedEventKey = new object();
        static readonly object Mode5FaderButton10PressedEventKey = new object();
        static readonly object Mode5FaderButton11PressedEventKey = new object();
        static readonly object Mode5FaderButton12PressedEventKey = new object();
        static readonly object Mode5FaderButton13PressedEventKey = new object();
        static readonly object Mode5FaderButton14PressedEventKey = new object();
        static readonly object Mode5FaderButton15PressedEventKey = new object();
        static readonly object Mode5FaderButton16PressedEventKey = new object();

        static readonly object Mode5FaderButton1ReleasedEventKey = new object();
        static readonly object Mode5FaderButton2ReleasedEventKey = new object();
        static readonly object Mode5FaderButton3ReleasedEventKey = new object();
        static readonly object Mode5FaderButton4ReleasedEventKey = new object();
        static readonly object Mode5FaderButton5ReleasedEventKey = new object();
        static readonly object Mode5FaderButton6ReleasedEventKey = new object();
        static readonly object Mode5FaderButton7ReleasedEventKey = new object();
        static readonly object Mode5FaderButton8ReleasedEventKey = new object();

        static readonly object Mode5FaderButton9ReleasedEventKey = new object();
        static readonly object Mode5FaderButton10ReleasedEventKey = new object();
        static readonly object Mode5FaderButton11ReleasedEventKey = new object();
        static readonly object Mode5FaderButton12ReleasedEventKey = new object();
        static readonly object Mode5FaderButton13ReleasedEventKey = new object();
        static readonly object Mode5FaderButton14ReleasedEventKey = new object();
        static readonly object Mode5FaderButton15ReleasedEventKey = new object();
        static readonly object Mode5FaderButton16ReleasedEventKey = new object();

        internal event EventHandler<OnPitchBendEventArgs> Mode5PitchBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode5PitchBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5PitchBendEventKey, value);
            }
        }

        internal event EventHandler<OnModulationBendEventArgs> Mode5ModulationBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode5ModulationBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5ModulationBendEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode5ControlPress
        {
            add
            {
                listEventDelegates.AddHandler(Mode5NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5NoteOnEventKey, value);
            }
        }

        internal event EventHandler<OnNoteHoldEventArgs> Mode5ControlHold
        {
            add
            {
                listEventDelegates.AddHandler(Mode5NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5NoteHeldEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode5ControlRelease
        {
            add
            {
                listEventDelegates.AddHandler(Mode5NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5NoteOffEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffDelayedEventArgs> Mode5ControlReleaseDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5NoteOffDelayedEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode5ControlReleaseDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode5NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5NoteOffDoubleClickEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode5ControlPressDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode5NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5NoteOnDoubleClickEventKey, value);
            }
        }


        internal event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5SlideFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5SlideFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5SlideFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5SlideFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5SlideFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5SlideFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5SlideFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5SlideFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5SlideFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5SlideFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5SlideFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5SlideFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5SlideFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5SlideFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5SlideFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5SlideFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5KnobFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5KnobFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5KnobFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5KnobFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5KnobFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5KnobFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5KnobFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5KnobFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5KnobFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5KnobFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5KnobFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5KnobFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5KnobFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5KnobFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5KnobFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5KnobFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton1Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton1PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton1PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton2Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton2PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton2PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton3Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton3PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton3PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton4Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton4PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton4PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton5Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton5PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton5PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton6Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton6PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton6PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton7Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton7PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton7PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton8Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton8PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton8PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton9Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton9PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton9PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton10Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton10PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton10PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton11Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton11PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton11PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton12Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton12PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton12PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton13Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton13PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton13PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton14Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton14PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton14PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton15Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton15PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton15PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton16Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton16PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton16PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton1Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton1ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton1ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton2Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton2ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton2ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton3Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton3ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton3ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton4Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton4ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton4ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton5Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton5ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton5ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton6Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton6ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton6ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton7Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton7ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton7ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton8Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton8ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton8ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton9Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton9ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton9ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton10Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton10ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton10ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton11Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton11ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton11ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton12Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton12ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton12ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton13Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton13ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton13ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton14Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton14ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton14ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton15Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton15ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton15ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton16Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode5FaderButton16ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode5FaderButton16ReleasedEventKey, value);
            }
        }

        #endregion
    }
}
