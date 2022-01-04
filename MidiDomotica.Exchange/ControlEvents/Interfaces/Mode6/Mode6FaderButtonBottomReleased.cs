using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode6FaderButtonBottomReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton9Released;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton10Released;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton11Released;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton12Released;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton13Released;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton14Released;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton15Released;
        event EventHandler<OnFaderButtonEventArgs> Mode6FaderButton16Released;
    }
}
