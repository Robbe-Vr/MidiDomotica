using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode5FaderButtonTopPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton1Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton2Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton3Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton4Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton5Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton6Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton7Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton8Pressed;
    }
}
