using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode2KnobFader : IMidiEvents
    {
        event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader1Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader2Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader3Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader4Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader5Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader6Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader7Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode2KnobFader8Changed;
    }
}
