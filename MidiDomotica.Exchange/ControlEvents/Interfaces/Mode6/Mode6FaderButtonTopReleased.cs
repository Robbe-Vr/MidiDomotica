using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode6FaderButtonTopReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton1Released;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton2Released;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton3Released;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton4Released;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton5Released;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton6Released;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton7Released;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton8Released;
    }
}
