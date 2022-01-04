using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode2FaderButtonBottomPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton9Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton10Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton11Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton12Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton13Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton14Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton15Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton16Pressed;
    }
}
