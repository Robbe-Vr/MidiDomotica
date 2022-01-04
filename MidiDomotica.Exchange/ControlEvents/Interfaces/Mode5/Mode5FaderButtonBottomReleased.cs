using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode5FaderButtonBottomReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton9Released;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton10Released;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton11Released;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton12Released;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton13Released;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton14Released;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton15Released;
        event EventHandler<OnFaderButtonEventArgs> Mode5FaderButton16Released;
    }
}
