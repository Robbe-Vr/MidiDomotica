using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode1FaderButtonBottomPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton9Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton10Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton11Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton12Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton13Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton14Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton15Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton16Pressed;
    }
}
