using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode4FaderButtonBottomReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton9Released;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton10Released;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton11Released;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton12Released;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton13Released;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton14Released;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton15Released;
        event EventHandler<OnFaderButtonEventArgs> Mode4FaderButton16Released;
    }
}
