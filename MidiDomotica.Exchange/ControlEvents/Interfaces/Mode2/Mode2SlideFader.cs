using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode2SlideFader : IMidiEvents
    {
        event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader1Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader2Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader3Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader4Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader5Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader6Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader7Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode2SlideFader8Changed;
    }
}
