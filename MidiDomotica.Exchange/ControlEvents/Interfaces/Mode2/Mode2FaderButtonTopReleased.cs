using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode2FaderButtonTopReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton1Released;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton2Released;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton3Released;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton4Released;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton5Released;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton6Released;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton7Released;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton8Released;
    }
}
