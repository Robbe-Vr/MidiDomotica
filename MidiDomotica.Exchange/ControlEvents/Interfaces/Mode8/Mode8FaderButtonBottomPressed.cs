using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode8FaderButtonBottomPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton9Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton10Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton11Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton12Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton13Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton14Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton15Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton16Pressed;
    }
}
