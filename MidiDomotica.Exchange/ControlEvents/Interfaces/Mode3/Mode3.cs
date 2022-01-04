using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode3 : Mode3Control, Mode3Pitch, Mode3Modulation, Mode3SlideFader, Mode3KnobFader, Mode3FaderButton
    {
    }
}
