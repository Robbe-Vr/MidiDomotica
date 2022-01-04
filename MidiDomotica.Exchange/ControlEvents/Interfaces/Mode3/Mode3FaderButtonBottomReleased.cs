using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode3FaderButtonBottomReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton9Released;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton10Released;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton11Released;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton12Released;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton13Released;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton14Released;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton15Released;
        event EventHandler<OnFaderButtonEventArgs> Mode3FaderButton16Released;
    }
}
