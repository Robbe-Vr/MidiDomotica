using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode1KnobFader : IMidiEvents
    {
        event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader1Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader2Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader3Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader4Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader5Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader6Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader7Changed;
        event EventHandler<OnKnobFaderEventArgs> Mode1KnobFader8Changed;
    }
}
