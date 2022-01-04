using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode4FaderButtonBottomPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton9Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton10Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton11Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton12Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton13Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton14Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton15Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton16Pressed;
    }
}
