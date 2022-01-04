using MidiDomotica.MidiConnection.Events;
using MidiDomotica.Exchange.ControlEvents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.MidiConnection
{
    public static class MidiHandler
    {
        public static IMidiController GetMidiController()
        {
            return new EventsManager();
        }
    }
}
