using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode4KnobFader : IMidiEvents
    {
        event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader1Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader2Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader3Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader4Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader5Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader6Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader7Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode4KnobFader8Changed;
    }
}
