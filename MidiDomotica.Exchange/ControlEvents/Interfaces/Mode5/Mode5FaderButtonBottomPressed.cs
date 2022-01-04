using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode5FaderButtonBottomPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton9Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton10Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton11Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton12Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton13Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton14Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton15Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton16Pressed;
    }
}
