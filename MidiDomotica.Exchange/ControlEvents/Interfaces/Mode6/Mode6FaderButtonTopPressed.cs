using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode6FaderButtonTopPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton1Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton2Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton3Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton4Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton5Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton6Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton7Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton8Pressed;
    }
}
