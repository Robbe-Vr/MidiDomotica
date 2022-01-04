using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode7FaderButtonBottomReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton9Released;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton10Released;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton11Released;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton12Released;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton13Released;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton14Released;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton15Released;
        event EventHandler<OnFaderButtonEventArgs> Mode7FaderButton16Released;
    }
}
