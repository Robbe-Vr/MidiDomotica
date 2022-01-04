using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode7FaderButtonTopReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton1Released;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton2Released;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton3Released;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton4Released;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton5Released;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton6Released;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton7Released;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton8Released;
    }
}
