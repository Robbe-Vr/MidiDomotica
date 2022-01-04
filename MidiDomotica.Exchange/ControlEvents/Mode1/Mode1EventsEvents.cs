using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.MidiConnection.Event
{
    internal partial class Events : AbstractEvents
    {
        #region Mode1 Events Setup
        static readonly object Mode1PitchBendEventKey = new object();
        static readonly object Mode1ModulationBendEventKey = new object();

        static readonly object Mode1NoteOnEventKey = new object();
        static readonly object Mode1NoteHeldEventKey = new object();
        static readonly object Mode1NoteOffEventKey = new object();
        static readonly object Mode1NoteOffDelayedEventKey = new object();
        static readonly object Mode1NoteOffDoubleClickEventKey = new object();
        static readonly object Mode1NoteOnDoubleClickEventKey = new object();

        static readonly object Mode1SlideFader1ChangedEventKey = new object();
        static readonly object Mode1SlideFader2ChangedEventKey = new object();
        static readonly object Mode1SlideFader3ChangedEventKey = new object();
        static readonly object Mode1SlideFader4ChangedEventKey = new object();
        static readonly object Mode1SlideFader5ChangedEventKey = new object();
        static readonly object Mode1SlideFader6ChangedEventKey = new object();
        static readonly object Mode1SlideFader7ChangedEventKey = new object();
        static readonly object Mode1SlideFader8ChangedEventKey = new object();

        static readonly object Mode1KnobFader1ChangedEventKey = new object();
        static readonly object Mode1KnobFader2ChangedEventKey = new object();
        static readonly object Mode1KnobFader3ChangedEventKey = new object();
        static readonly object Mode1KnobFader4ChangedEventKey = new object();
        static readonly object Mode1KnobFader5ChangedEventKey = new object();
        static readonly object Mode1KnobFader6ChangedEventKey = new object();
        static readonly object Mode1KnobFader7ChangedEventKey = new object();
        static readonly object Mode1KnobFader8ChangedEventKey = new object();

        static readonly object Mode1FaderButton1PressedEventKey = new object();
        static readonly object Mode1FaderButton2PressedEventKey = new object();
        static readonly object Mode1FaderButton3PressedEventKey = new object();
        static readonly object Mode1FaderButton4PressedEventKey = new object();
        static readonly object Mode1FaderButton5PressedEventKey = new object();
        static readonly object Mode1FaderButton6PressedEventKey = new object();
        static readonly object Mode1FaderButton7PressedEventKey = new object();
        static readonly object Mode1FaderButton8PressedEventKey = new object();

        static readonly object Mode1FaderButton9PressedEventKey = new object();
        static readonly object Mode1FaderButton10PressedEventKey = new object();
        static readonly object Mode1FaderButton11PressedEventKey = new object();
        static readonly object Mode1FaderButton12PressedEventKey = new object();
        static readonly object Mode1FaderButton13PressedEventKey = new object();
        static readonly object Mode1FaderButton14PressedEventKey = new object();
        static readonly object Mode1FaderButton15PressedEventKey = new object();
        static readonly object Mode1FaderButton16PressedEventKey = new object();

        static readonly object Mode1FaderButton1ReleasedEventKey = new object();
        static readonly object Mode1FaderButton2ReleasedEventKey = new object();
        static readonly object Mode1FaderButton3ReleasedEventKey = new object();
        static readonly object Mode1FaderButton4ReleasedEventKey = new object();
        static readonly object Mode1FaderButton5ReleasedEventKey = new object();
        static readonly object Mode1FaderButton6ReleasedEventKey = new object();
        static readonly object Mode1FaderButton7ReleasedEventKey = new object();
        static readonly object Mode1FaderButton8ReleasedEventKey = new object();

        static readonly object Mode1FaderButton9ReleasedEventKey = new object();
        static readonly object Mode1FaderButton10ReleasedEventKey = new object();
        static readonly object Mode1FaderButton11ReleasedEventKey = new object();
        static readonly object Mode1FaderButton12ReleasedEventKey = new object();
        static readonly object Mode1FaderButton13ReleasedEventKey = new object();
        static readonly object Mode1FaderButton14ReleasedEventKey = new object();
        static readonly object Mode1FaderButton15ReleasedEventKey = new object();
        static readonly object Mode1FaderButton16ReleasedEventKey = new object();

        internal event EventHandler<OnPitchBendEventArgs> Mode1PitchBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode1PitchBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1PitchBendEventKey, value);
            }
        }

        internal event EventHandler<OnModulationBendEventArgs> Mode1ModulationBend
        {
            add
            {
                listEventDelegates.AddHandler(Mode1ModulationBendEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1ModulationBendEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode1ControlPress
        {
            add
            {
                listEventDelegates.AddHandler(Mode1NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1NoteOnEventKey, value);
            }
        }

        internal event EventHandler<OnNoteHoldEventArgs> Mode1ControlHold
        {
            add
            {
                listEventDelegates.AddHandler(Mode1NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1NoteHeldEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode1ControlRelease
        {
            add
            {
                listEventDelegates.AddHandler(Mode1NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1NoteOffEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffDelayedEventArgs> Mode1ControlReleaseDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1NoteOffDelayedEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOffEventArgs> Mode1ControlReleaseDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode1NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1NoteOffDoubleClickEventKey, value);
            }
        }

        internal event EventHandler<OnNoteOnEventArgs> Mode1ControlPressDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode1NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1NoteOnDoubleClickEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1SlideFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1SlideFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1SlideFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1SlideFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1SlideFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1SlideFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1SlideFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1SlideFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1SlideFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1SlideFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1SlideFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1SlideFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1SlideFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1SlideFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1SlideFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1SlideFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader1Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1KnobFader1ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1KnobFader1ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader2Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1KnobFader2ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1KnobFader2ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader3Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1KnobFader3ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1KnobFader3ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader4Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1KnobFader4ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1KnobFader4ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader5Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1KnobFader5ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1KnobFader5ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader6Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1KnobFader6ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1KnobFader6ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader7Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1KnobFader7ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1KnobFader7ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader8Changed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1KnobFader8ChangedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1KnobFader8ChangedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton1Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton1PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton1PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton2Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton2PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton2PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton3Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton3PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton3PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton4Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton4PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton4PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton5Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton5PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton5PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton6Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton6PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton6PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton7Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton7PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton7PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton8Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton8PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton8PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton9Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton9PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton9PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton10Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton10PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton10PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton11Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton11PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton11PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton12Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton12PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton12PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton13Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton13PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton13PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton14Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton14PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton14PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton15Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton15PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton15PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton16Pressed
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton16PressedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton16PressedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton1Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton1ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton1ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton2Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton2ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton2ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton3Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton3ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton3ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton4Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton4ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton4ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton5Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton5ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton5ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton6Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton6ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton6ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton7Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton7ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton7ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton8Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton8ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton8ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton9Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton9ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton9ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton10Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton10ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton10ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton11Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton11ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton11ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton12Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton12ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton12ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton13Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton13ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton13ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton14Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton14ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton14ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton15Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton15ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton15ReleasedEventKey, value);
            }
        }

        internal event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton16Released
        {
            add
            {
                listEventDelegates.AddHandler(Mode1FaderButton16ReleasedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode1FaderButton16ReleasedEventKey, value);
            }
        }

        #endregion
    }
}
