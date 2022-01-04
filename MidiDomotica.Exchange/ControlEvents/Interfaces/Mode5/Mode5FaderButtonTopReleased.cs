using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode5FaderButtonTopReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton1Released;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton2Released;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton3Released;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton4Released;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton5Released;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton6Released;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton7Released;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton8Released;
    }
}
