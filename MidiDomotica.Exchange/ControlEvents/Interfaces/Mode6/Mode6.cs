using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode6 : Mode6Control, Mode6FaderButton, Mode6Pitch, Mode6Modulation, Mode6SlideFader, Mode6KnobFader
    {
    }
}
