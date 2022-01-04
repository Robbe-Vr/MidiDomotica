using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode8SlideFader : IMidiEvents
    {
        event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader1Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader2Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader3Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader4Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader5Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader6Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader7Changed;
        event EventHandler<OnSlideFaderEventArgs> Mode8SlideFader8Changed;
    }
}
