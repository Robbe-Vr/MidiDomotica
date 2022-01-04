using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode4FaderButtonTopReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton1Released;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton2Released;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton3Released;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton4Released;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton5Released;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton6Released;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton7Released;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton8Released;
    }
}
