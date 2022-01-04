using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode6KnobFader : IMidiEvents
    {
        event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader1Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader2Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader3Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader4Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader5Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader6Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader7Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode6KnobFader8Changed;
    }
}
