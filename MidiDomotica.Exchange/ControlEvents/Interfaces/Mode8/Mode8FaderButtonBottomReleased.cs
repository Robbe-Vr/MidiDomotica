using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode8FaderButtonBottomReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton9Released;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton10Released;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton11Released;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton12Released;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton13Released;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton14Released;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton15Released;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton16Released;
    }
}
