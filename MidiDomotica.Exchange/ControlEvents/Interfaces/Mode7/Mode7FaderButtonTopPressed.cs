using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode7FaderButtonTopPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton1Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton2Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton3Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton4Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton5Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton6Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton7Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton8Pressed;
    }
}
