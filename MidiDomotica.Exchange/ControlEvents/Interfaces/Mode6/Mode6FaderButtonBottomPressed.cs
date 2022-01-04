using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode6FaderButtonBottomPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton9Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton10Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton11Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton12Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton13Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton14Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton15Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton16Pressed;
    }
}
