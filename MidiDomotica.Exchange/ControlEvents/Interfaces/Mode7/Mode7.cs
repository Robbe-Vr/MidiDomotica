using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode7 : Mode7Control, Mode7FaderButton, Mode7Pitch, Mode7Modulation, Mode7SlideFader, Mode7KnobFader
    {
    }
}
