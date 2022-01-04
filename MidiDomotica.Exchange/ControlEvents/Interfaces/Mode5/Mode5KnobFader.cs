using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode5KnobFader : IMidiEvents
    {
        event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader1Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader2Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader3Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader4Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader5Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader6Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader7Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode5KnobFader8Changed;
    }
}
