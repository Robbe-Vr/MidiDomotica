using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode2FaderButtonBottomReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton9Released;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton10Released;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton11Released;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton12Released;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton13Released;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton14Released;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton15Released;
        event EventHandler<OnFaderButtonEventArgs> Mode2FaderButton16Released;
    }
}
