using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode8KnobFader : IMidiEvents
    {
        event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader1Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader2Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader3Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader4Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader5Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader6Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader7Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode8KnobFader8Changed;
    }
}
