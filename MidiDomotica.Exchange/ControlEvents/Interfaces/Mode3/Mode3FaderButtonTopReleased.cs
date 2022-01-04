using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode3FaderButtonTopReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton1Released;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton2Released;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton3Released;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton4Released;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton5Released;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton6Released;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton7Released;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton8Released;
    }
}
