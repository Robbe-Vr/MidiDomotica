﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode2Pads : IMidiEvents
    {
        event EventHandler<OnNoteOnEventArgs> Mode2_C0_0_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_C0_0_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_C0_0_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_C0_0_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_C0_0_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_C0_0_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode2_CSharp0_1_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_CSharp0_1_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_CSharp0_1_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_CSharp0_1_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_CSharp0_1_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_CSharp0_1_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode2_D0_2_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_D0_2_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_D0_2_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_D0_2_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_D0_2_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_D0_2_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode2_DSharp0_3_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_DSharp0_3_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_DSharp0_3_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_DSharp0_3_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_DSharp0_3_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_DSharp0_3_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode2_E0_4_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_E0_4_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_E0_4_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_E0_4_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_E0_4_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_E0_4_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode2_F0_5_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_F0_5_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_F0_5_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_F0_5_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_F0_5_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_F0_5_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode2_FSharp0_6_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_FSharp0_6_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_FSharp0_6_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_FSharp0_6_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_FSharp0_6_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_FSharp0_6_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode2_G0_7_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_G0_7_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_G0_7_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_G0_7_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_G0_7_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_G0_7_NoteOnDoubleClick;


        event EventHandler<OnNoteOnEventArgs> Mode2_C10_120_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_C10_120_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_C10_120_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_C10_120_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_C10_120_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_C10_120_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode2_CSharp10_121_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_CSharp10_121_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_CSharp10_121_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_CSharp10_121_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_CSharp10_121_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_CSharp10_121_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode2_D10_122_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_D10_122_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_D10_122_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_D10_122_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_D10_122_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_D10_122_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode2_DSharp10_123_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_DSharp10_123_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_DSharp10_123_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_DSharp10_123_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_DSharp10_123_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_DSharp10_123_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode2_E10_124_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_E10_124_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_E10_124_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_E10_124_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_E10_124_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_E10_124_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode2_F10_125_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_F10_125_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_F10_125_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_F10_125_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_F10_125_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_F10_125_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode2_FSharp10_126_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_FSharp10_126_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_FSharp10_126_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_FSharp10_126_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_FSharp10_126_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_FSharp10_126_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode2_G10_127_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode2_G10_127_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode2_G10_127_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode2_G10_127_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode2_G10_127_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode2_G10_127_NoteOnDoubleClick;
    }
}
