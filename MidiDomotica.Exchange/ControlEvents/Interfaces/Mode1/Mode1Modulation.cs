﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode1Modulation : IMidiEvents
    {
        event EventHandler<OnModulationBendEventArgs> Mode1ModulationBend;
    }
}