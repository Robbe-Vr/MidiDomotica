using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface IGlobal : IMidiEvents
    {
        event EventHandler<OnMediaButtonEventArgs> StopButton;
        event EventHandler<OnMediaButtonEventArgs> PlayButton;
    }
}
