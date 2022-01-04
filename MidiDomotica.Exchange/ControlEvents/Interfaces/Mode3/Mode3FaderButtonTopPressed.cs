using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode3FaderButtonTopPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton1Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton2Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton3Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton4Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton5Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton6Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton7Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton8Pressed;
    }
}
