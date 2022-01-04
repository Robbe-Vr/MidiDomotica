using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface Mode5Control : Mode5Pads, IMidiEvents
    {
        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp0_8_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_GSharp0_8_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp0_8_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_GSharp0_8_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp0_8_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp0_8_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_A0_9_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_A0_9_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_A0_9_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_A0_9_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_A0_9_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_A0_9_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp0_10_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_ASharp0_10_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp0_10_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_ASharp0_10_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp0_10_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp0_10_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_B0_11_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_B0_11_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_B0_11_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_B0_11_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_B0_11_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_B0_11_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_C1_12_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_C1_12_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_C1_12_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_C1_12_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_C1_12_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_C1_12_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp1_13_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_CSharp1_13_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp1_13_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_CSharp1_13_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp1_13_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp1_13_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_D1_14_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_D1_14_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_D1_14_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_D1_14_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_D1_14_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_D1_14_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp1_15_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_DSharp1_15_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp1_15_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_DSharp1_15_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp1_15_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp1_15_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_E1_16_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_E1_16_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_E1_16_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_E1_16_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_E1_16_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_E1_16_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_F1_17_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_F1_17_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_F1_17_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_F1_17_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_F1_17_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_F1_17_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp1_18_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_FSharp1_18_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp1_18_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_FSharp1_18_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp1_18_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp1_18_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_G1_19_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_G1_19_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_G1_19_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_G1_19_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_G1_19_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_G1_19_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp1_20_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_GSharp1_20_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp1_20_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_GSharp1_20_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp1_20_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp1_20_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_A1_21_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_A1_21_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_A1_21_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_A1_21_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_A1_21_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_A1_21_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp1_22_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_ASharp1_22_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp1_22_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_ASharp1_22_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp1_22_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp1_22_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_B1_23_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_B1_23_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_B1_23_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_B1_23_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_B1_23_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_B1_23_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_C2_24_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_C2_24_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_C2_24_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_C2_24_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_C2_24_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_C2_24_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp2_25_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_CSharp2_25_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp2_25_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_CSharp2_25_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp2_25_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp2_25_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_D2_26_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_D2_26_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_D2_26_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_D2_26_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_D2_26_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_D2_26_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp2_27_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_DSharp2_27_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp2_27_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_DSharp2_27_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp2_27_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp2_27_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_E2_28_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_E2_28_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_E2_28_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_E2_28_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_E2_28_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_E2_28_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_F2_29_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_F2_29_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_F2_29_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_F2_29_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_F2_29_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_F2_29_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp2_30_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_FSharp2_30_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp2_30_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_FSharp2_30_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp2_30_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp2_30_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_G2_31_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_G2_31_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_G2_31_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_G2_31_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_G2_31_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_G2_31_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp2_32_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_GSharp2_32_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp2_32_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_GSharp2_32_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp2_32_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp2_32_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_A2_33_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_A2_33_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_A2_33_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_A2_33_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_A2_33_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_A2_33_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp2_34_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_ASharp2_34_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp2_34_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_ASharp2_34_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp2_34_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp2_34_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_B2_35_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_B2_35_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_B2_35_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_B2_35_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_B2_35_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_B2_35_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_C3_36_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_C3_36_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_C3_36_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_C3_36_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_C3_36_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_C3_36_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp3_37_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_CSharp3_37_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp3_37_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_CSharp3_37_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp3_37_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp3_37_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_D3_38_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_D3_38_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_D3_38_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_D3_38_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_D3_38_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_D3_38_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp3_39_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_DSharp3_39_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp3_39_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_DSharp3_39_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp3_39_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp3_39_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_E3_40_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_E3_40_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_E3_40_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_E3_40_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_E3_40_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_E3_40_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_F3_41_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_F3_41_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_F3_41_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_F3_41_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_F3_41_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_F3_41_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp3_42_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_FSharp3_42_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp3_42_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_FSharp3_42_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp3_42_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp3_42_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_G3_43_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_G3_43_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_G3_43_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_G3_43_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_G3_43_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_G3_43_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp3_44_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_GSharp3_44_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp3_44_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_GSharp3_44_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp3_44_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp3_44_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_A3_45_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_A3_45_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_A3_45_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_A3_45_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_A3_45_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_A3_45_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp3_46_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_ASharp3_46_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp3_46_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_ASharp3_46_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp3_46_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp3_46_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_B3_47_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_B3_47_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_B3_47_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_B3_47_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_B3_47_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_B3_47_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_C4_48_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_C4_48_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_C4_48_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_C4_48_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_C4_48_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_C4_48_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp4_49_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_CSharp4_49_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp4_49_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_CSharp4_49_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp4_49_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp4_49_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_D4_50_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_D4_50_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_D4_50_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_D4_50_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_D4_50_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_D4_50_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp4_51_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_DSharp4_51_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp4_51_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_DSharp4_51_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp4_51_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp4_51_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_E4_52_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_E4_52_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_E4_52_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_E4_52_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_E4_52_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_E4_52_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_F4_53_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_F4_53_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_F4_53_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_F4_53_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_F4_53_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_F4_53_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp4_54_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_FSharp4_54_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp4_54_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_FSharp4_54_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp4_54_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp4_54_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_G4_55_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_G4_55_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_G4_55_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_G4_55_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_G4_55_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_G4_55_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp4_56_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_GSharp4_56_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp4_56_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_GSharp4_56_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp4_56_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp4_56_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_A4_57_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_A4_57_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_A4_57_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_A4_57_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_A4_57_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_A4_57_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp4_58_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_ASharp4_58_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp4_58_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_ASharp4_58_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp4_58_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp4_58_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_B4_59_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_B4_59_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_B4_59_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_B4_59_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_B4_59_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_B4_59_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_C5_60_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_C5_60_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_C5_60_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_C5_60_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_C5_60_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_C5_60_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp5_61_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_CSharp5_61_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp5_61_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_CSharp5_61_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp5_61_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp5_61_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_D5_62_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_D5_62_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_D5_62_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_D5_62_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_D5_62_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_D5_62_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp5_63_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_DSharp5_63_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp5_63_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_DSharp5_63_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp5_63_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp5_63_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_E5_64_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_E5_64_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_E5_64_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_E5_64_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_E5_64_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_E5_64_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_F5_65_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_F5_65_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_F5_65_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_F5_65_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_F5_65_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_F5_65_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp5_66_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_FSharp5_66_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp5_66_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_FSharp5_66_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp5_66_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp5_66_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_G5_67_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_G5_67_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_G5_67_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_G5_67_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_G5_67_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_G5_67_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp5_68_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_GSharp5_68_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp5_68_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_GSharp5_68_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp5_68_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp5_68_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_A5_69_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_A5_69_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_A5_69_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_A5_69_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_A5_69_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_A5_69_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp5_70_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_ASharp5_70_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp5_70_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_ASharp5_70_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp5_70_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp5_70_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_B5_71_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_B5_71_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_B5_71_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_B5_71_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_B5_71_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_B5_71_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_C6_72_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_C6_72_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_C6_72_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_C6_72_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_C6_72_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_C6_72_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp6_73_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_CSharp6_73_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp6_73_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_CSharp6_73_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp6_73_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp6_73_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_D6_74_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_D6_74_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_D6_74_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_D6_74_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_D6_74_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_D6_74_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp6_75_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_DSharp6_75_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp6_75_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_DSharp6_75_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp6_75_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp6_75_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_E6_76_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_E6_76_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_E6_76_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_E6_76_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_E6_76_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_E6_76_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_F6_77_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_F6_77_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_F6_77_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_F6_77_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_F6_77_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_F6_77_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp6_78_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_FSharp6_78_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp6_78_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_FSharp6_78_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp6_78_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp6_78_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_G6_79_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_G6_79_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_G6_79_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_G6_79_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_G6_79_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_G6_79_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp6_80_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_GSharp6_80_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp6_80_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_GSharp6_80_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp6_80_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp6_80_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_A6_81_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_A6_81_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_A6_81_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_A6_81_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_A6_81_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_A6_81_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp6_82_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_ASharp6_82_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp6_82_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_ASharp6_82_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp6_82_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp6_82_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_B6_83_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_B6_83_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_B6_83_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_B6_83_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_B6_83_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_B6_83_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_C7_84_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_C7_84_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_C7_84_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_C7_84_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_C7_84_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_C7_84_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp7_85_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_CSharp7_85_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp7_85_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_CSharp7_85_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp7_85_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp7_85_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_D7_86_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_D7_86_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_D7_86_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_D7_86_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_D7_86_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_D7_86_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp7_87_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_DSharp7_87_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp7_87_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_DSharp7_87_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp7_87_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp7_87_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_E7_88_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_E7_88_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_E7_88_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_E7_88_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_E7_88_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_E7_88_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_F7_89_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_F7_89_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_F7_89_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_F7_89_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_F7_89_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_F7_89_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp7_90_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_FSharp7_90_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp7_90_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_FSharp7_90_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp7_90_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp7_90_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_G7_91_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_G7_91_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_G7_91_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_G7_91_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_G7_91_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_G7_91_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp7_92_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_GSharp7_92_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp7_92_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_GSharp7_92_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp7_92_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp7_92_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_A7_93_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_A7_93_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_A7_93_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_A7_93_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_A7_93_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_A7_93_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp7_94_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_ASharp7_94_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp7_94_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_ASharp7_94_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp7_94_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp7_94_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_B7_95_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_B7_95_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_B7_95_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_B7_95_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_B7_95_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_B7_95_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_C8_96_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_C8_96_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_C8_96_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_C8_96_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_C8_96_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_C8_96_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp8_97_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_CSharp8_97_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp8_97_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_CSharp8_97_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp8_97_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp8_97_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_D8_98_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_D8_98_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_D8_98_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_D8_98_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_D8_98_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_D8_98_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp8_99_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_DSharp8_99_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp8_99_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_DSharp8_99_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp8_99_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp8_99_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_E8_100_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_E8_100_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_E8_100_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_E8_100_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_E8_100_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_E8_100_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_F8_101_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_F8_101_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_F8_101_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_F8_101_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_F8_101_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_F8_101_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp8_102_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_FSharp8_102_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp8_102_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_FSharp8_102_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp8_102_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp8_102_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_G8_103_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_G8_103_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_G8_103_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_G8_103_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_G8_103_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_G8_103_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp8_104_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_GSharp8_104_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp8_104_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_GSharp8_104_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp8_104_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp8_104_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_A8_105_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_A8_105_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_A8_105_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_A8_105_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_A8_105_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_A8_105_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp8_106_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_ASharp8_106_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp8_106_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_ASharp8_106_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp8_106_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp8_106_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_B8_107_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_B8_107_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_B8_107_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_B8_107_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_B8_107_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_B8_107_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_C9_108_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_C9_108_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_C9_108_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_C9_108_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_C9_108_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_C9_108_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp9_109_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_CSharp9_109_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp9_109_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_CSharp9_109_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_CSharp9_109_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_CSharp9_109_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_D9_110_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_D9_110_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_D9_110_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_D9_110_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_D9_110_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_D9_110_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp9_111_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_DSharp9_111_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp9_111_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_DSharp9_111_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_DSharp9_111_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_DSharp9_111_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_E9_112_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_E9_112_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_E9_112_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_E9_112_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_E9_112_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_E9_112_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_F9_113_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_F9_113_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_F9_113_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_F9_113_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_F9_113_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_F9_113_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp9_114_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_FSharp9_114_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp9_114_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_FSharp9_114_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_FSharp9_114_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_FSharp9_114_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_G9_115_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_G9_115_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_G9_115_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_G9_115_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_G9_115_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_G9_115_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp9_116_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_GSharp9_116_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp9_116_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_GSharp9_116_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_GSharp9_116_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_GSharp9_116_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_A9_117_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_A9_117_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_A9_117_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_A9_117_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_A9_117_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_A9_117_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp9_118_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_ASharp9_118_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp9_118_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_ASharp9_118_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_ASharp9_118_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_ASharp9_118_NoteOnDoubleClick;

        event EventHandler<OnNoteOnEventArgs> Mode5_B9_119_NoteOn;
        event EventHandler<OnNoteHoldEventArgs> Mode5_B9_119_NoteHeld;
        event EventHandler<OnNoteOffEventArgs> Mode5_B9_119_NoteOff;
        event EventHandler<OnNoteOffDelayedEventArgs> Mode5_B9_119_NoteOffDelayed;
        event EventHandler<OnNoteOffEventArgs> Mode5_B9_119_NoteOffDoubleClick;
        event EventHandler<OnNoteOnEventArgs> Mode5_B9_119_NoteOnDoubleClick;
    }
}
