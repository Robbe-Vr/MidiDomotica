using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode1 : Mode1Control, Mode1FaderButton, Mode1Pitch, Mode1Modulation, Mode1SlideFader, Mode1KnobFader
    {
    }
}
