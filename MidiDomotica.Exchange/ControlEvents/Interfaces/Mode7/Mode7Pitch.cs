using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode7Pitch : IMidiEvents
    {
        event EventHandler<OnPitchBendEventArgs> Mode7PitchBend;
    }
}
