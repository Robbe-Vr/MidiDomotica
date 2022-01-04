using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode1FaderButtonTopPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton1Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton2Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton3Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton4Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton5Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton6Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton7Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton8Pressed;
    }
}
