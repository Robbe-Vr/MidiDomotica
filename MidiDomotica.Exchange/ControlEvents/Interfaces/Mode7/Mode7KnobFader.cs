using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode7KnobFader : IMidiEvents
    {
        event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader1Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader2Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader3Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader4Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader5Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader6Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader7Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode7KnobFader8Changed;
    }
}
