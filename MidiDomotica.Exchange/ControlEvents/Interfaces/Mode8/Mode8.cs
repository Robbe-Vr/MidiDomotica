using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode8 : Mode8Control, Mode8FaderButton, Mode8Pitch, Mode8Modulation, Mode8SlideFader, Mode8KnobFader
    {
    }
}
