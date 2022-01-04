using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode8FaderButtonTopPressed : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton1Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton2Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton3Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton4Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton5Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton6Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton7Pressed;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton8Pressed;
    }
}
