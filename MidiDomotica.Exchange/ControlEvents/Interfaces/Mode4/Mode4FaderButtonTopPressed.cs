using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode4FaderButtonTopPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton1Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton2Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton3Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton4Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton5Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton6Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton7Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton8Pressed;
    }
}
