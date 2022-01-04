using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode3KnobFader : IMidiEvents
    {
        event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader1Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader2Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader3Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader4Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader5Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader6Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader7Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode3KnobFader8Changed;
    }
}
