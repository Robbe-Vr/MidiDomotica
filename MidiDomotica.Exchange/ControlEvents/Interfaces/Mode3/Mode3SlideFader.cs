using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode3SlideFader : IMidiEvents
    {
        event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader1Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader2Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader3Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader4Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader5Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader6Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader7Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode3SlideFader8Changed;
    }
}
