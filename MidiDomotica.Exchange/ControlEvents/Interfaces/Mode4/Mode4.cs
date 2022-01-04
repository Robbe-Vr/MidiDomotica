using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode4 : Mode4Control, Mode4FaderButton, Mode4Pitch, Mode4Modulation, Mode4SlideFader, Mode4KnobFader
    {
    }
}
