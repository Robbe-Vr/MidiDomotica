using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode1FaderButtonBottomReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton9Released;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton10Released;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton11Released;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton12Released;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton13Released;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton14Released;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton15Released;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton16Released;
    }
}
