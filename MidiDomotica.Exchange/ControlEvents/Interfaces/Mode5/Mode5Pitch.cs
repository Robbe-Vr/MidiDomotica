﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode5Pitch : IMidiEvents
    {
        event EventHandler<OnPitchBendEventArgs> Mode5PitchBend;
    }
}