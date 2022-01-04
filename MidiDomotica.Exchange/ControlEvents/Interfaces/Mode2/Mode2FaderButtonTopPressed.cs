using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode2FaderButtonTopPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton1Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton2Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton3Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton4Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton5Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton6Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton7Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton8Pressed;
    }
}
