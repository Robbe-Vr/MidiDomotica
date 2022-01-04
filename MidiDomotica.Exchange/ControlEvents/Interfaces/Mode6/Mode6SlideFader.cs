using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode6SlideFader : IMidiEvents
    {
        event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader1Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader2Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader3Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader4Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader5Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader6Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader7Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode6SlideFader8Changed;
    }
}
