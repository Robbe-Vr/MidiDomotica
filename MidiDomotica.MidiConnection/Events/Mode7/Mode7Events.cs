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
        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton1Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton2Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton3Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton4Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton5Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton6Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton7Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton8Pressed
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


        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton1Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton2Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton3Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton4Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton5Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton6Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton7Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton8Released
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


        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton9Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton10Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton11Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton12Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton13Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton14Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton15Pressed
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton16Pressed
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


        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton9Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton10Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton11Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton12Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton13Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton14Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton15Released
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

        public event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton16Released
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


        public event EventHandler<OnPitchBendEventArgs> Mode7PitchBend
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

        public event EventHandler<OnModulationBendEventArgs> Mode7ModulationBend
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


        public event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader1Changed
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

        public event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader2Changed
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

        public event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader3Changed
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

        public event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader4Changed
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

        public event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader5Changed
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

        public event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader6Changed
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

        public event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader7Changed
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

        public event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader8Changed
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


        public event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader1Changed
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

        public event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader2Changed
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

        public event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader3Changed
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

        public event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader4Changed
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

        public event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader5Changed
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

        public event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader6Changed
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

        public event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader7Changed
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

        public event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader8Changed
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

    }
}
