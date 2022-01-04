using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode4SlideFader : IMidiEvents
    {
        event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader1Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader2Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader3Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader4Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader5Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader6Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader7Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode4SlideFader8Changed;
    }
}
