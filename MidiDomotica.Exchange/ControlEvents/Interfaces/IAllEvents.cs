using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface IAllEvents : IGlobal, Mode1, Mode2, Mode3, Mode4, Mode5, Mode6, Mode7, Mode8
    {
    }
}
