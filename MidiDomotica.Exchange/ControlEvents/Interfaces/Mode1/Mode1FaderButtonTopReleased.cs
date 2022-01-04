using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode1FaderButtonTopReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton1Released;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton2Released;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton3Released;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton4Released;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton5Released;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton6Released;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton7Released;
        event EventHandler<OnFaderButtonEventArgs> Mode1FaderButton8Released;
    }
}
