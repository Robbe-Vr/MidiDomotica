using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode3FaderButtonBottomPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton9Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton10Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton11Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton12Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton13Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton14Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton15Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton16Pressed;
    }
}
