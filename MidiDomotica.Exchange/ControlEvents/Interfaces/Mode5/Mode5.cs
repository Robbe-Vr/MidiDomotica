using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode5 : Mode5Control, Mode5FaderButton, Mode5Pitch, Mode5Modulation, Mode5SlideFader, Mode5KnobFader
    {
    }
}
