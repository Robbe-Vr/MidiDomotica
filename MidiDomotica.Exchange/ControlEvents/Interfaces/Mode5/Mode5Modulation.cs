using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode5Modulation : IMidiEvents
    {
        event EventHandler<OnModulationBendEventArgs> Mode5ModulationBend;
    }
}
