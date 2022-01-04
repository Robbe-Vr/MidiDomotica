using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode1SlideFader : IMidiEvents
    {
        event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader1Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader2Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader3Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader4Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader5Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader6Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader7Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode1SlideFader8Changed;
    }
}
