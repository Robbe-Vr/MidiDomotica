using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode5SlideFader : IMidiEvents
    {
        event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader1Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader2Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader3Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader4Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader5Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader6Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader7Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode5SlideFader8Changed;
    }
}
