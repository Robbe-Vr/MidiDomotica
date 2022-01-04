using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode2 : Mode2Control, Mode2FaderButton, Mode2Pitch, Mode2Modulation, Mode2SlideFader, Mode2KnobFader
    {
    }
}
