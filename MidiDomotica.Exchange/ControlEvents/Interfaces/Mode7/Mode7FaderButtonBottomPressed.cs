using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode7FaderButtonBottomPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton9Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton10Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton11Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton12Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton13Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton14Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton15Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton16Pressed;
    }
}
