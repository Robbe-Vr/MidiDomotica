using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode7SlideFader : IMidiEvents
    {
        event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader1Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader2Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader3Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader4Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader5Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader6Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader7Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode7SlideFader8Changed;
    }
}
