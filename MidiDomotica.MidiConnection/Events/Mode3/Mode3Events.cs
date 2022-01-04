using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiDomotica.Exchange.ControlEvents;

namespace MidiDomotica.MidiConnection.Events
{
    public partial class EventsMapper
    {
        public event EventHandler<OnPitchBendEventArgs> Mode3PitchBend
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

        public event EventHandler<OnModulationBendEventArgs> Mode3ModulationBend
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

        public event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader1Changed
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

        public event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader2Changed
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

        public event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader3Changed
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

        public event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader4Changed
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

        public event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader5Changed
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

        public event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader6Changed
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

        public event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader7Changed
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

        public event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader8Changed
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

        public event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader1Changed
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

        public event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader2Changed
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

        public event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader3Changed
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

        public event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader4Changed
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

        public event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader5Changed
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

        public event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader6Changed
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

        public event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader7Changed
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

        public event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader8Changed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton1Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton2Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton3Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton4Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton5Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton6Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton7Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton8Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton1Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton2Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton3Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton4Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton5Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton6Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton7Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton8Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton9Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton10Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton11Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton12Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton13Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton14Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton15Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton16Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton9Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton10Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton11Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton12Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton13Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton14Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton15Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton16Released
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

    }
}
