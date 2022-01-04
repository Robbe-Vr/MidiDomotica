using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode8FaderButtonTopReleased : IMidiEvents
    {
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton1Released;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton2Released;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton3Released;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton4Released;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton5Released;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton6Released;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton7Released;
        event EventHandler<OnFaderButtonEventArgs> Mode8FaderButton8Released;
    }
}
