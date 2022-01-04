using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiDomotica.Exchange.ControlEvents;

namespace MidiDomotica.MidiConnection.Events
{
    public partial class EventsMapper
    {
        static readonly object Mode6_C0_0_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C0_0_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C0_0_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C0_0_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_C0_0_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_C0_0_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C0_0_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C0_0_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_C0_0_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C0_0_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C0_0_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C0_0_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_C0_0_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_C0_0_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C0_0_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C0_0_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_C0_0_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C0_0_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C0_0_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C0_0_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_C0_0_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C0_0_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C0_0_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C0_0_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_CSharp0_1_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp0_1_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp0_1_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp0_1_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_CSharp0_1_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_CSharp0_1_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp0_1_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp0_1_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_CSharp0_1_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp0_1_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp0_1_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp0_1_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_CSharp0_1_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_CSharp0_1_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp0_1_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp0_1_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_CSharp0_1_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp0_1_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp0_1_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp0_1_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_CSharp0_1_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp0_1_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp0_1_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp0_1_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D0_2_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D0_2_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D0_2_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D0_2_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_D0_2_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_D0_2_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D0_2_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D0_2_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_D0_2_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D0_2_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D0_2_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D0_2_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_D0_2_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_D0_2_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D0_2_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D0_2_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_D0_2_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D0_2_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D0_2_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D0_2_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D0_2_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D0_2_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D0_2_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D0_2_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_DSharp0_3_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp0_3_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp0_3_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp0_3_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_DSharp0_3_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_DSharp0_3_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp0_3_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp0_3_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_DSharp0_3_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp0_3_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp0_3_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp0_3_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_DSharp0_3_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_DSharp0_3_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp0_3_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp0_3_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_DSharp0_3_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp0_3_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp0_3_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp0_3_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_DSharp0_3_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp0_3_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp0_3_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp0_3_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E0_4_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E0_4_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E0_4_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E0_4_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_E0_4_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_E0_4_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E0_4_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E0_4_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_E0_4_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E0_4_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E0_4_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E0_4_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_E0_4_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_E0_4_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E0_4_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E0_4_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_E0_4_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E0_4_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E0_4_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E0_4_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E0_4_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E0_4_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E0_4_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E0_4_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_F0_5_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F0_5_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F0_5_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F0_5_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_F0_5_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_F0_5_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F0_5_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F0_5_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_F0_5_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F0_5_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F0_5_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F0_5_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_F0_5_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_F0_5_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F0_5_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F0_5_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_F0_5_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F0_5_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F0_5_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F0_5_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_F0_5_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F0_5_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F0_5_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F0_5_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_FSharp0_6_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp0_6_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp0_6_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp0_6_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_FSharp0_6_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_FSharp0_6_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp0_6_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp0_6_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_FSharp0_6_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp0_6_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp0_6_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp0_6_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_FSharp0_6_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_FSharp0_6_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp0_6_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp0_6_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_FSharp0_6_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp0_6_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp0_6_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp0_6_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_FSharp0_6_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp0_6_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp0_6_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp0_6_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G0_7_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G0_7_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G0_7_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G0_7_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_G0_7_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_G0_7_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G0_7_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G0_7_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_G0_7_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G0_7_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G0_7_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G0_7_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_G0_7_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_G0_7_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G0_7_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G0_7_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_G0_7_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G0_7_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G0_7_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G0_7_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G0_7_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G0_7_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G0_7_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G0_7_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_GSharp0_8_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp0_8_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp0_8_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp0_8_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_GSharp0_8_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_GSharp0_8_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp0_8_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp0_8_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_GSharp0_8_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp0_8_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp0_8_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp0_8_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_GSharp0_8_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_GSharp0_8_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp0_8_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp0_8_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_GSharp0_8_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp0_8_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp0_8_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp0_8_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_GSharp0_8_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp0_8_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp0_8_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp0_8_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A0_9_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A0_9_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A0_9_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A0_9_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_A0_9_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_A0_9_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A0_9_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A0_9_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_A0_9_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A0_9_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A0_9_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A0_9_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_A0_9_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_A0_9_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A0_9_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A0_9_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_A0_9_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A0_9_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A0_9_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A0_9_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A0_9_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A0_9_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A0_9_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A0_9_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_ASharp0_10_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp0_10_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp0_10_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp0_10_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_ASharp0_10_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_ASharp0_10_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp0_10_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp0_10_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_ASharp0_10_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp0_10_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp0_10_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp0_10_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_ASharp0_10_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_ASharp0_10_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp0_10_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp0_10_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_ASharp0_10_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp0_10_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp0_10_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp0_10_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_ASharp0_10_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp0_10_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp0_10_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp0_10_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B0_11_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B0_11_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B0_11_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B0_11_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_B0_11_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_B0_11_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B0_11_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B0_11_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_B0_11_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B0_11_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B0_11_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B0_11_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_B0_11_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_B0_11_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B0_11_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B0_11_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_B0_11_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B0_11_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B0_11_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B0_11_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B0_11_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B0_11_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B0_11_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B0_11_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_C1_12_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C1_12_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C1_12_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C1_12_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_C1_12_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_C1_12_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C1_12_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C1_12_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_C1_12_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C1_12_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C1_12_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C1_12_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_C1_12_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_C1_12_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C1_12_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C1_12_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_C1_12_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C1_12_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C1_12_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C1_12_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_C1_12_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C1_12_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C1_12_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C1_12_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_CSharp1_13_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp1_13_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp1_13_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp1_13_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_CSharp1_13_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_CSharp1_13_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp1_13_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp1_13_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_CSharp1_13_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp1_13_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp1_13_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp1_13_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_CSharp1_13_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_CSharp1_13_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp1_13_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp1_13_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_CSharp1_13_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp1_13_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp1_13_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp1_13_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_CSharp1_13_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp1_13_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp1_13_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp1_13_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D1_14_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D1_14_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D1_14_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D1_14_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_D1_14_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_D1_14_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D1_14_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D1_14_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_D1_14_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D1_14_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D1_14_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D1_14_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_D1_14_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_D1_14_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D1_14_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D1_14_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_D1_14_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D1_14_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D1_14_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D1_14_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D1_14_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D1_14_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D1_14_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D1_14_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_DSharp1_15_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp1_15_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp1_15_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp1_15_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_DSharp1_15_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_DSharp1_15_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp1_15_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp1_15_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_DSharp1_15_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp1_15_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp1_15_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp1_15_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_DSharp1_15_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_DSharp1_15_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp1_15_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp1_15_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_DSharp1_15_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp1_15_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp1_15_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp1_15_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_DSharp1_15_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp1_15_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp1_15_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp1_15_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E1_16_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E1_16_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E1_16_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E1_16_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_E1_16_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_E1_16_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E1_16_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E1_16_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_E1_16_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E1_16_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E1_16_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E1_16_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_E1_16_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_E1_16_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E1_16_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E1_16_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_E1_16_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E1_16_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E1_16_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E1_16_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E1_16_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E1_16_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E1_16_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E1_16_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_F1_17_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F1_17_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F1_17_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F1_17_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_F1_17_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_F1_17_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F1_17_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F1_17_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_F1_17_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F1_17_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F1_17_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F1_17_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_F1_17_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_F1_17_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F1_17_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F1_17_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_F1_17_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F1_17_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F1_17_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F1_17_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_F1_17_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F1_17_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F1_17_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F1_17_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_FSharp1_18_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp1_18_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp1_18_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp1_18_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_FSharp1_18_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_FSharp1_18_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp1_18_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp1_18_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_FSharp1_18_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp1_18_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp1_18_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp1_18_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_FSharp1_18_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_FSharp1_18_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp1_18_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp1_18_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_FSharp1_18_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp1_18_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp1_18_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp1_18_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_FSharp1_18_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp1_18_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp1_18_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp1_18_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G1_19_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G1_19_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G1_19_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G1_19_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_G1_19_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_G1_19_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G1_19_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G1_19_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_G1_19_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G1_19_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G1_19_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G1_19_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_G1_19_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_G1_19_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G1_19_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G1_19_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_G1_19_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G1_19_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G1_19_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G1_19_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G1_19_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G1_19_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G1_19_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G1_19_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_GSharp1_20_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp1_20_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp1_20_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp1_20_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_GSharp1_20_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_GSharp1_20_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp1_20_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp1_20_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_GSharp1_20_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp1_20_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp1_20_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp1_20_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_GSharp1_20_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_GSharp1_20_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp1_20_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp1_20_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_GSharp1_20_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp1_20_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp1_20_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp1_20_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_GSharp1_20_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp1_20_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp1_20_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp1_20_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A1_21_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A1_21_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A1_21_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A1_21_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_A1_21_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_A1_21_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A1_21_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A1_21_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_A1_21_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A1_21_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A1_21_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A1_21_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_A1_21_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_A1_21_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A1_21_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A1_21_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_A1_21_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A1_21_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A1_21_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A1_21_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A1_21_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A1_21_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A1_21_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A1_21_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_ASharp1_22_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp1_22_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp1_22_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp1_22_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_ASharp1_22_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_ASharp1_22_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp1_22_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp1_22_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_ASharp1_22_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp1_22_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp1_22_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp1_22_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_ASharp1_22_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_ASharp1_22_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp1_22_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp1_22_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_ASharp1_22_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp1_22_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp1_22_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp1_22_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_ASharp1_22_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp1_22_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp1_22_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp1_22_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B1_23_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B1_23_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B1_23_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B1_23_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_B1_23_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_B1_23_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B1_23_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B1_23_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_B1_23_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B1_23_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B1_23_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B1_23_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_B1_23_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_B1_23_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B1_23_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B1_23_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_B1_23_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B1_23_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B1_23_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B1_23_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B1_23_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B1_23_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B1_23_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B1_23_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_C2_24_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C2_24_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C2_24_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C2_24_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_C2_24_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_C2_24_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C2_24_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C2_24_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_C2_24_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C2_24_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C2_24_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C2_24_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_C2_24_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_C2_24_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C2_24_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C2_24_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_C2_24_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C2_24_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C2_24_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C2_24_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_C2_24_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C2_24_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C2_24_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C2_24_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_CSharp2_25_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp2_25_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp2_25_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp2_25_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_CSharp2_25_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_CSharp2_25_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp2_25_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp2_25_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_CSharp2_25_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp2_25_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp2_25_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp2_25_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_CSharp2_25_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_CSharp2_25_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp2_25_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp2_25_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_CSharp2_25_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp2_25_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp2_25_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp2_25_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_CSharp2_25_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp2_25_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp2_25_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp2_25_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D2_26_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D2_26_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D2_26_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D2_26_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_D2_26_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_D2_26_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D2_26_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D2_26_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_D2_26_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D2_26_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D2_26_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D2_26_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_D2_26_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_D2_26_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D2_26_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D2_26_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_D2_26_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D2_26_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D2_26_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D2_26_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D2_26_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D2_26_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D2_26_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D2_26_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_DSharp2_27_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp2_27_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp2_27_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp2_27_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_DSharp2_27_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_DSharp2_27_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp2_27_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp2_27_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_DSharp2_27_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp2_27_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp2_27_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp2_27_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_DSharp2_27_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_DSharp2_27_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp2_27_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp2_27_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_DSharp2_27_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp2_27_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp2_27_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp2_27_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_DSharp2_27_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp2_27_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp2_27_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp2_27_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E2_28_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E2_28_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E2_28_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E2_28_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_E2_28_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_E2_28_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E2_28_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E2_28_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_E2_28_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E2_28_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E2_28_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E2_28_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_E2_28_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_E2_28_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E2_28_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E2_28_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_E2_28_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E2_28_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E2_28_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E2_28_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E2_28_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E2_28_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E2_28_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E2_28_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_F2_29_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F2_29_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F2_29_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F2_29_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_F2_29_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_F2_29_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F2_29_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F2_29_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_F2_29_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F2_29_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F2_29_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F2_29_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_F2_29_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_F2_29_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F2_29_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F2_29_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_F2_29_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F2_29_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F2_29_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F2_29_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_F2_29_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F2_29_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F2_29_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F2_29_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_FSharp2_30_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp2_30_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp2_30_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp2_30_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_FSharp2_30_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_FSharp2_30_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp2_30_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp2_30_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_FSharp2_30_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp2_30_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp2_30_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp2_30_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_FSharp2_30_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_FSharp2_30_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp2_30_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp2_30_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_FSharp2_30_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp2_30_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp2_30_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp2_30_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_FSharp2_30_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp2_30_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp2_30_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp2_30_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G2_31_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G2_31_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G2_31_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G2_31_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_G2_31_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_G2_31_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G2_31_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G2_31_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_G2_31_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G2_31_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G2_31_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G2_31_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_G2_31_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_G2_31_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G2_31_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G2_31_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_G2_31_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G2_31_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G2_31_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G2_31_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G2_31_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G2_31_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G2_31_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G2_31_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_GSharp2_32_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp2_32_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp2_32_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp2_32_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_GSharp2_32_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_GSharp2_32_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp2_32_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp2_32_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_GSharp2_32_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp2_32_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp2_32_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp2_32_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_GSharp2_32_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_GSharp2_32_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp2_32_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp2_32_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_GSharp2_32_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp2_32_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp2_32_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp2_32_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_GSharp2_32_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp2_32_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp2_32_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp2_32_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A2_33_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A2_33_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A2_33_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A2_33_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_A2_33_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_A2_33_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A2_33_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A2_33_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_A2_33_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A2_33_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A2_33_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A2_33_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_A2_33_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_A2_33_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A2_33_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A2_33_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_A2_33_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A2_33_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A2_33_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A2_33_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A2_33_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A2_33_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A2_33_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A2_33_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_ASharp2_34_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp2_34_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp2_34_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp2_34_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_ASharp2_34_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_ASharp2_34_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp2_34_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp2_34_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_ASharp2_34_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp2_34_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp2_34_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp2_34_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_ASharp2_34_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_ASharp2_34_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp2_34_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp2_34_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_ASharp2_34_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp2_34_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp2_34_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp2_34_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_ASharp2_34_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp2_34_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp2_34_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp2_34_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B2_35_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B2_35_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B2_35_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B2_35_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_B2_35_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_B2_35_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B2_35_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B2_35_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_B2_35_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B2_35_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B2_35_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B2_35_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_B2_35_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_B2_35_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B2_35_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B2_35_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_B2_35_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B2_35_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B2_35_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B2_35_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B2_35_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B2_35_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B2_35_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B2_35_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_C3_36_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C3_36_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C3_36_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C3_36_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_C3_36_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_C3_36_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C3_36_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C3_36_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_C3_36_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C3_36_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C3_36_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C3_36_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_C3_36_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_C3_36_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C3_36_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C3_36_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_C3_36_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C3_36_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C3_36_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C3_36_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_C3_36_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C3_36_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C3_36_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C3_36_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_CSharp3_37_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp3_37_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp3_37_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp3_37_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_CSharp3_37_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_CSharp3_37_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp3_37_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp3_37_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_CSharp3_37_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp3_37_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp3_37_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp3_37_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_CSharp3_37_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_CSharp3_37_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp3_37_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp3_37_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_CSharp3_37_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp3_37_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp3_37_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp3_37_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_CSharp3_37_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp3_37_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp3_37_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp3_37_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D3_38_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D3_38_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D3_38_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D3_38_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_D3_38_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_D3_38_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D3_38_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D3_38_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_D3_38_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D3_38_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D3_38_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D3_38_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_D3_38_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_D3_38_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D3_38_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D3_38_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_D3_38_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D3_38_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D3_38_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D3_38_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D3_38_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D3_38_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D3_38_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D3_38_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_DSharp3_39_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp3_39_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp3_39_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp3_39_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_DSharp3_39_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_DSharp3_39_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp3_39_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp3_39_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_DSharp3_39_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp3_39_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp3_39_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp3_39_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_DSharp3_39_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_DSharp3_39_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp3_39_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp3_39_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_DSharp3_39_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp3_39_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp3_39_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp3_39_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_DSharp3_39_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp3_39_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp3_39_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp3_39_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E3_40_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E3_40_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E3_40_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E3_40_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_E3_40_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_E3_40_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E3_40_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E3_40_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_E3_40_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E3_40_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E3_40_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E3_40_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_E3_40_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_E3_40_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E3_40_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E3_40_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_E3_40_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E3_40_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E3_40_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E3_40_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E3_40_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E3_40_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E3_40_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E3_40_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_F3_41_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F3_41_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F3_41_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F3_41_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_F3_41_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_F3_41_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F3_41_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F3_41_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_F3_41_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F3_41_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F3_41_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F3_41_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_F3_41_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_F3_41_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F3_41_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F3_41_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_F3_41_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F3_41_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F3_41_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F3_41_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_F3_41_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F3_41_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F3_41_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F3_41_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_FSharp3_42_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp3_42_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp3_42_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp3_42_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_FSharp3_42_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_FSharp3_42_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp3_42_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp3_42_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_FSharp3_42_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp3_42_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp3_42_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp3_42_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_FSharp3_42_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_FSharp3_42_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp3_42_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp3_42_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_FSharp3_42_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp3_42_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp3_42_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp3_42_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_FSharp3_42_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp3_42_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp3_42_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp3_42_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G3_43_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G3_43_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G3_43_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G3_43_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_G3_43_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_G3_43_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G3_43_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G3_43_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_G3_43_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G3_43_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G3_43_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G3_43_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_G3_43_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_G3_43_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G3_43_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G3_43_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_G3_43_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G3_43_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G3_43_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G3_43_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G3_43_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G3_43_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G3_43_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G3_43_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_GSharp3_44_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp3_44_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp3_44_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp3_44_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_GSharp3_44_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_GSharp3_44_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp3_44_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp3_44_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_GSharp3_44_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp3_44_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp3_44_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp3_44_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_GSharp3_44_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_GSharp3_44_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp3_44_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp3_44_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_GSharp3_44_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp3_44_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp3_44_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp3_44_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_GSharp3_44_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp3_44_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp3_44_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp3_44_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A3_45_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A3_45_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A3_45_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A3_45_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_A3_45_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_A3_45_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A3_45_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A3_45_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_A3_45_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A3_45_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A3_45_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A3_45_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_A3_45_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_A3_45_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A3_45_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A3_45_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_A3_45_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A3_45_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A3_45_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A3_45_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A3_45_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A3_45_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A3_45_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A3_45_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_ASharp3_46_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp3_46_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp3_46_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp3_46_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_ASharp3_46_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_ASharp3_46_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp3_46_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp3_46_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_ASharp3_46_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp3_46_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp3_46_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp3_46_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_ASharp3_46_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_ASharp3_46_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp3_46_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp3_46_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_ASharp3_46_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp3_46_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp3_46_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp3_46_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_ASharp3_46_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp3_46_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp3_46_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp3_46_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B3_47_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B3_47_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B3_47_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B3_47_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_B3_47_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_B3_47_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B3_47_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B3_47_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_B3_47_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B3_47_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B3_47_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B3_47_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_B3_47_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_B3_47_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B3_47_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B3_47_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_B3_47_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B3_47_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B3_47_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B3_47_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B3_47_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B3_47_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B3_47_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B3_47_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_C4_48_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C4_48_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C4_48_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C4_48_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_C4_48_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_C4_48_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C4_48_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C4_48_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_C4_48_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C4_48_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C4_48_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C4_48_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_C4_48_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_C4_48_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C4_48_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C4_48_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_C4_48_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C4_48_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C4_48_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C4_48_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_C4_48_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C4_48_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C4_48_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C4_48_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_CSharp4_49_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp4_49_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp4_49_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp4_49_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_CSharp4_49_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_CSharp4_49_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp4_49_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp4_49_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_CSharp4_49_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp4_49_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp4_49_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp4_49_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_CSharp4_49_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_CSharp4_49_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp4_49_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp4_49_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_CSharp4_49_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp4_49_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp4_49_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp4_49_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_CSharp4_49_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp4_49_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp4_49_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp4_49_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D4_50_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D4_50_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D4_50_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D4_50_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_D4_50_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_D4_50_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D4_50_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D4_50_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_D4_50_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D4_50_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D4_50_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D4_50_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_D4_50_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_D4_50_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D4_50_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D4_50_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_D4_50_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D4_50_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D4_50_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D4_50_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D4_50_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D4_50_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D4_50_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D4_50_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_DSharp4_51_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp4_51_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp4_51_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp4_51_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_DSharp4_51_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_DSharp4_51_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp4_51_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp4_51_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_DSharp4_51_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp4_51_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp4_51_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp4_51_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_DSharp4_51_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_DSharp4_51_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp4_51_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp4_51_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_DSharp4_51_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp4_51_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp4_51_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp4_51_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_DSharp4_51_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp4_51_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp4_51_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp4_51_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E4_52_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E4_52_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E4_52_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E4_52_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_E4_52_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_E4_52_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E4_52_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E4_52_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_E4_52_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E4_52_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E4_52_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E4_52_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_E4_52_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_E4_52_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E4_52_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E4_52_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_E4_52_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E4_52_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E4_52_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E4_52_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E4_52_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E4_52_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E4_52_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E4_52_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_F4_53_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F4_53_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F4_53_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F4_53_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_F4_53_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_F4_53_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F4_53_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F4_53_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_F4_53_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F4_53_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F4_53_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F4_53_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_F4_53_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_F4_53_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F4_53_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F4_53_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_F4_53_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F4_53_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F4_53_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F4_53_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_F4_53_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F4_53_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F4_53_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F4_53_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_FSharp4_54_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp4_54_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp4_54_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp4_54_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_FSharp4_54_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_FSharp4_54_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp4_54_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp4_54_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_FSharp4_54_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp4_54_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp4_54_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp4_54_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_FSharp4_54_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_FSharp4_54_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp4_54_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp4_54_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_FSharp4_54_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp4_54_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp4_54_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp4_54_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_FSharp4_54_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp4_54_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp4_54_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp4_54_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G4_55_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G4_55_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G4_55_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G4_55_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_G4_55_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_G4_55_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G4_55_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G4_55_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_G4_55_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G4_55_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G4_55_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G4_55_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_G4_55_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_G4_55_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G4_55_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G4_55_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_G4_55_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G4_55_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G4_55_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G4_55_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G4_55_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G4_55_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G4_55_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G4_55_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_GSharp4_56_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp4_56_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp4_56_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp4_56_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_GSharp4_56_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_GSharp4_56_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp4_56_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp4_56_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_GSharp4_56_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp4_56_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp4_56_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp4_56_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_GSharp4_56_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_GSharp4_56_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp4_56_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp4_56_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_GSharp4_56_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp4_56_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp4_56_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp4_56_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_GSharp4_56_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp4_56_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp4_56_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp4_56_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A4_57_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A4_57_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A4_57_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A4_57_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_A4_57_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_A4_57_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A4_57_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A4_57_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_A4_57_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A4_57_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A4_57_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A4_57_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_A4_57_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_A4_57_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A4_57_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A4_57_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_A4_57_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A4_57_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A4_57_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A4_57_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A4_57_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A4_57_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A4_57_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A4_57_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_ASharp4_58_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp4_58_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp4_58_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp4_58_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_ASharp4_58_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_ASharp4_58_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp4_58_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp4_58_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_ASharp4_58_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp4_58_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp4_58_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp4_58_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_ASharp4_58_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_ASharp4_58_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp4_58_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp4_58_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_ASharp4_58_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp4_58_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp4_58_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp4_58_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_ASharp4_58_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp4_58_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp4_58_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp4_58_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B4_59_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B4_59_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B4_59_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B4_59_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_B4_59_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_B4_59_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B4_59_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B4_59_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_B4_59_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B4_59_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B4_59_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B4_59_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_B4_59_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_B4_59_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B4_59_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B4_59_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_B4_59_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B4_59_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B4_59_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B4_59_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B4_59_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B4_59_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B4_59_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B4_59_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_C5_60_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C5_60_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C5_60_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C5_60_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_C5_60_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_C5_60_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C5_60_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C5_60_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_C5_60_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C5_60_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C5_60_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C5_60_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_C5_60_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_C5_60_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C5_60_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C5_60_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_C5_60_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C5_60_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C5_60_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C5_60_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_C5_60_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C5_60_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C5_60_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C5_60_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_CSharp5_61_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp5_61_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp5_61_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp5_61_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_CSharp5_61_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_CSharp5_61_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp5_61_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp5_61_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_CSharp5_61_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp5_61_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp5_61_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp5_61_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_CSharp5_61_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_CSharp5_61_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp5_61_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp5_61_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_CSharp5_61_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp5_61_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp5_61_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp5_61_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_CSharp5_61_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp5_61_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp5_61_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp5_61_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D5_62_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D5_62_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D5_62_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D5_62_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_D5_62_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_D5_62_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D5_62_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D5_62_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_D5_62_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D5_62_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D5_62_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D5_62_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_D5_62_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_D5_62_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D5_62_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D5_62_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_D5_62_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D5_62_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D5_62_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D5_62_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D5_62_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D5_62_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D5_62_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D5_62_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_DSharp5_63_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp5_63_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp5_63_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp5_63_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_DSharp5_63_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_DSharp5_63_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp5_63_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp5_63_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_DSharp5_63_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp5_63_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp5_63_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp5_63_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_DSharp5_63_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_DSharp5_63_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp5_63_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp5_63_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_DSharp5_63_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp5_63_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp5_63_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp5_63_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_DSharp5_63_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp5_63_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp5_63_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp5_63_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E5_64_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E5_64_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E5_64_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E5_64_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_E5_64_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_E5_64_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E5_64_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E5_64_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_E5_64_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E5_64_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E5_64_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E5_64_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_E5_64_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_E5_64_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E5_64_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E5_64_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_E5_64_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E5_64_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E5_64_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E5_64_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E5_64_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E5_64_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E5_64_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E5_64_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_F5_65_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F5_65_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F5_65_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F5_65_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_F5_65_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_F5_65_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F5_65_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F5_65_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_F5_65_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F5_65_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F5_65_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F5_65_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_F5_65_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_F5_65_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F5_65_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F5_65_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_F5_65_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F5_65_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F5_65_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F5_65_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_F5_65_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F5_65_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F5_65_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F5_65_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_FSharp5_66_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp5_66_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp5_66_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp5_66_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_FSharp5_66_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_FSharp5_66_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp5_66_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp5_66_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_FSharp5_66_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp5_66_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp5_66_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp5_66_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_FSharp5_66_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_FSharp5_66_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp5_66_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp5_66_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_FSharp5_66_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp5_66_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp5_66_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp5_66_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_FSharp5_66_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp5_66_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp5_66_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp5_66_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G5_67_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G5_67_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G5_67_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G5_67_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_G5_67_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_G5_67_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G5_67_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G5_67_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_G5_67_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G5_67_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G5_67_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G5_67_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_G5_67_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_G5_67_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G5_67_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G5_67_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_G5_67_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G5_67_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G5_67_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G5_67_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G5_67_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G5_67_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G5_67_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G5_67_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_GSharp5_68_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp5_68_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp5_68_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp5_68_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_GSharp5_68_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_GSharp5_68_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp5_68_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp5_68_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_GSharp5_68_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp5_68_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp5_68_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp5_68_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_GSharp5_68_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_GSharp5_68_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp5_68_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp5_68_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_GSharp5_68_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp5_68_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp5_68_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp5_68_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_GSharp5_68_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp5_68_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp5_68_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp5_68_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A5_69_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A5_69_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A5_69_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A5_69_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_A5_69_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_A5_69_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A5_69_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A5_69_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_A5_69_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A5_69_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A5_69_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A5_69_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_A5_69_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_A5_69_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A5_69_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A5_69_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_A5_69_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A5_69_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A5_69_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A5_69_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A5_69_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A5_69_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A5_69_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A5_69_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_ASharp5_70_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp5_70_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp5_70_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp5_70_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_ASharp5_70_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_ASharp5_70_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp5_70_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp5_70_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_ASharp5_70_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp5_70_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp5_70_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp5_70_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_ASharp5_70_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_ASharp5_70_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp5_70_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp5_70_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_ASharp5_70_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp5_70_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp5_70_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp5_70_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_ASharp5_70_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp5_70_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp5_70_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp5_70_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B5_71_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B5_71_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B5_71_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B5_71_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_B5_71_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_B5_71_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B5_71_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B5_71_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_B5_71_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B5_71_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B5_71_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B5_71_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_B5_71_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_B5_71_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B5_71_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B5_71_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_B5_71_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B5_71_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B5_71_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B5_71_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B5_71_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B5_71_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B5_71_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B5_71_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_C6_72_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C6_72_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C6_72_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C6_72_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_C6_72_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_C6_72_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C6_72_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C6_72_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_C6_72_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C6_72_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C6_72_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C6_72_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_C6_72_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_C6_72_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C6_72_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C6_72_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_C6_72_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C6_72_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C6_72_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C6_72_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_C6_72_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C6_72_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C6_72_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C6_72_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_CSharp6_73_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp6_73_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp6_73_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp6_73_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_CSharp6_73_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_CSharp6_73_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp6_73_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp6_73_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_CSharp6_73_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp6_73_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp6_73_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp6_73_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_CSharp6_73_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_CSharp6_73_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp6_73_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp6_73_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_CSharp6_73_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp6_73_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp6_73_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp6_73_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_CSharp6_73_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp6_73_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp6_73_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp6_73_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D6_74_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D6_74_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D6_74_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D6_74_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_D6_74_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_D6_74_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D6_74_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D6_74_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_D6_74_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D6_74_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D6_74_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D6_74_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_D6_74_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_D6_74_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D6_74_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D6_74_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_D6_74_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D6_74_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D6_74_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D6_74_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D6_74_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D6_74_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D6_74_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D6_74_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_DSharp6_75_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp6_75_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp6_75_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp6_75_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_DSharp6_75_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_DSharp6_75_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp6_75_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp6_75_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_DSharp6_75_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp6_75_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp6_75_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp6_75_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_DSharp6_75_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_DSharp6_75_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp6_75_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp6_75_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_DSharp6_75_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp6_75_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp6_75_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp6_75_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_DSharp6_75_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp6_75_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp6_75_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp6_75_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E6_76_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E6_76_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E6_76_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E6_76_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_E6_76_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_E6_76_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E6_76_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E6_76_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_E6_76_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E6_76_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E6_76_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E6_76_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_E6_76_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_E6_76_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E6_76_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E6_76_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_E6_76_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E6_76_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E6_76_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E6_76_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E6_76_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E6_76_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E6_76_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E6_76_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_F6_77_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F6_77_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F6_77_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F6_77_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_F6_77_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_F6_77_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F6_77_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F6_77_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_F6_77_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F6_77_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F6_77_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F6_77_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_F6_77_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_F6_77_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F6_77_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F6_77_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_F6_77_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F6_77_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F6_77_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F6_77_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_F6_77_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F6_77_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F6_77_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F6_77_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_FSharp6_78_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp6_78_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp6_78_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp6_78_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_FSharp6_78_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_FSharp6_78_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp6_78_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp6_78_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_FSharp6_78_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp6_78_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp6_78_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp6_78_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_FSharp6_78_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_FSharp6_78_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp6_78_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp6_78_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_FSharp6_78_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp6_78_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp6_78_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp6_78_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_FSharp6_78_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp6_78_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp6_78_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp6_78_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G6_79_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G6_79_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G6_79_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G6_79_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_G6_79_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_G6_79_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G6_79_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G6_79_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_G6_79_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G6_79_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G6_79_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G6_79_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_G6_79_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_G6_79_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G6_79_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G6_79_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_G6_79_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G6_79_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G6_79_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G6_79_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G6_79_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G6_79_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G6_79_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G6_79_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_GSharp6_80_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp6_80_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp6_80_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp6_80_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_GSharp6_80_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_GSharp6_80_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp6_80_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp6_80_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_GSharp6_80_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp6_80_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp6_80_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp6_80_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_GSharp6_80_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_GSharp6_80_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp6_80_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp6_80_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_GSharp6_80_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp6_80_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp6_80_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp6_80_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_GSharp6_80_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp6_80_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp6_80_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp6_80_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A6_81_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A6_81_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A6_81_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A6_81_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_A6_81_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_A6_81_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A6_81_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A6_81_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_A6_81_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A6_81_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A6_81_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A6_81_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_A6_81_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_A6_81_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A6_81_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A6_81_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_A6_81_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A6_81_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A6_81_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A6_81_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A6_81_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A6_81_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A6_81_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A6_81_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_ASharp6_82_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp6_82_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp6_82_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp6_82_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_ASharp6_82_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_ASharp6_82_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp6_82_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp6_82_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_ASharp6_82_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp6_82_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp6_82_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp6_82_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_ASharp6_82_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_ASharp6_82_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp6_82_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp6_82_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_ASharp6_82_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp6_82_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp6_82_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp6_82_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_ASharp6_82_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp6_82_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp6_82_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp6_82_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B6_83_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B6_83_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B6_83_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B6_83_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_B6_83_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_B6_83_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B6_83_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B6_83_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_B6_83_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B6_83_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B6_83_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B6_83_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_B6_83_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_B6_83_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B6_83_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B6_83_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_B6_83_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B6_83_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B6_83_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B6_83_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B6_83_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B6_83_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B6_83_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B6_83_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_C7_84_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C7_84_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C7_84_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C7_84_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_C7_84_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_C7_84_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C7_84_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C7_84_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_C7_84_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C7_84_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C7_84_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C7_84_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_C7_84_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_C7_84_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C7_84_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C7_84_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_C7_84_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C7_84_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C7_84_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C7_84_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_C7_84_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C7_84_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C7_84_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C7_84_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_CSharp7_85_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp7_85_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp7_85_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp7_85_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_CSharp7_85_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_CSharp7_85_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp7_85_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp7_85_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_CSharp7_85_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp7_85_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp7_85_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp7_85_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_CSharp7_85_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_CSharp7_85_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp7_85_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp7_85_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_CSharp7_85_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp7_85_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp7_85_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp7_85_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_CSharp7_85_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp7_85_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp7_85_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp7_85_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D7_86_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D7_86_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D7_86_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D7_86_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_D7_86_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_D7_86_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D7_86_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D7_86_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_D7_86_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D7_86_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D7_86_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D7_86_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_D7_86_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_D7_86_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D7_86_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D7_86_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_D7_86_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D7_86_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D7_86_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D7_86_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D7_86_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D7_86_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D7_86_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D7_86_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_DSharp7_87_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp7_87_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp7_87_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp7_87_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_DSharp7_87_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_DSharp7_87_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp7_87_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp7_87_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_DSharp7_87_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp7_87_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp7_87_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp7_87_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_DSharp7_87_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_DSharp7_87_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp7_87_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp7_87_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_DSharp7_87_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp7_87_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp7_87_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp7_87_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_DSharp7_87_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp7_87_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp7_87_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp7_87_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E7_88_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E7_88_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E7_88_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E7_88_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_E7_88_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_E7_88_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E7_88_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E7_88_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_E7_88_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E7_88_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E7_88_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E7_88_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_E7_88_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_E7_88_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E7_88_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E7_88_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_E7_88_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E7_88_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E7_88_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E7_88_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E7_88_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E7_88_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E7_88_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E7_88_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_F7_89_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F7_89_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F7_89_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F7_89_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_F7_89_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_F7_89_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F7_89_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F7_89_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_F7_89_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F7_89_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F7_89_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F7_89_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_F7_89_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_F7_89_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F7_89_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F7_89_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_F7_89_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F7_89_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F7_89_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F7_89_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_F7_89_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F7_89_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F7_89_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F7_89_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_FSharp7_90_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp7_90_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp7_90_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp7_90_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_FSharp7_90_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_FSharp7_90_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp7_90_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp7_90_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_FSharp7_90_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp7_90_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp7_90_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp7_90_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_FSharp7_90_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_FSharp7_90_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp7_90_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp7_90_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_FSharp7_90_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp7_90_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp7_90_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp7_90_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_FSharp7_90_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp7_90_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp7_90_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp7_90_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G7_91_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G7_91_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G7_91_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G7_91_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_G7_91_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_G7_91_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G7_91_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G7_91_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_G7_91_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G7_91_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G7_91_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G7_91_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_G7_91_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_G7_91_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G7_91_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G7_91_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_G7_91_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G7_91_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G7_91_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G7_91_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G7_91_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G7_91_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G7_91_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G7_91_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_GSharp7_92_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp7_92_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp7_92_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp7_92_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_GSharp7_92_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_GSharp7_92_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp7_92_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp7_92_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_GSharp7_92_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp7_92_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp7_92_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp7_92_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_GSharp7_92_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_GSharp7_92_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp7_92_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp7_92_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_GSharp7_92_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp7_92_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp7_92_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp7_92_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_GSharp7_92_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp7_92_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp7_92_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp7_92_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A7_93_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A7_93_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A7_93_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A7_93_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_A7_93_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_A7_93_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A7_93_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A7_93_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_A7_93_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A7_93_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A7_93_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A7_93_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_A7_93_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_A7_93_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A7_93_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A7_93_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_A7_93_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A7_93_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A7_93_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A7_93_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A7_93_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A7_93_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A7_93_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A7_93_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_ASharp7_94_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp7_94_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp7_94_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp7_94_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_ASharp7_94_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_ASharp7_94_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp7_94_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp7_94_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_ASharp7_94_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp7_94_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp7_94_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp7_94_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_ASharp7_94_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_ASharp7_94_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp7_94_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp7_94_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_ASharp7_94_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp7_94_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp7_94_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp7_94_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_ASharp7_94_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp7_94_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp7_94_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp7_94_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B7_95_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B7_95_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B7_95_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B7_95_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_B7_95_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_B7_95_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B7_95_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B7_95_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_B7_95_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B7_95_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B7_95_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B7_95_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_B7_95_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_B7_95_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B7_95_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B7_95_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_B7_95_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B7_95_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B7_95_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B7_95_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B7_95_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B7_95_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B7_95_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B7_95_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_C8_96_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C8_96_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C8_96_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C8_96_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_C8_96_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_C8_96_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C8_96_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C8_96_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_C8_96_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C8_96_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C8_96_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C8_96_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_C8_96_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_C8_96_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C8_96_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C8_96_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_C8_96_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C8_96_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C8_96_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C8_96_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_C8_96_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C8_96_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C8_96_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C8_96_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_CSharp8_97_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp8_97_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp8_97_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp8_97_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_CSharp8_97_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_CSharp8_97_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp8_97_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp8_97_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_CSharp8_97_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp8_97_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp8_97_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp8_97_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_CSharp8_97_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_CSharp8_97_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp8_97_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp8_97_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_CSharp8_97_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp8_97_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp8_97_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp8_97_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_CSharp8_97_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp8_97_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp8_97_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp8_97_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D8_98_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D8_98_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D8_98_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D8_98_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_D8_98_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_D8_98_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D8_98_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D8_98_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_D8_98_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D8_98_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D8_98_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D8_98_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_D8_98_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_D8_98_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D8_98_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D8_98_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_D8_98_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D8_98_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D8_98_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D8_98_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D8_98_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D8_98_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D8_98_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D8_98_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_DSharp8_99_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp8_99_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp8_99_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp8_99_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_DSharp8_99_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_DSharp8_99_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp8_99_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp8_99_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_DSharp8_99_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp8_99_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp8_99_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp8_99_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_DSharp8_99_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_DSharp8_99_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp8_99_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp8_99_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_DSharp8_99_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp8_99_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp8_99_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp8_99_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_DSharp8_99_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp8_99_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp8_99_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp8_99_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E8_100_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E8_100_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E8_100_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E8_100_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_E8_100_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_E8_100_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E8_100_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E8_100_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_E8_100_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E8_100_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E8_100_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E8_100_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_E8_100_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_E8_100_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E8_100_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E8_100_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_E8_100_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E8_100_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E8_100_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E8_100_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E8_100_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E8_100_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E8_100_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E8_100_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_F8_101_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F8_101_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F8_101_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F8_101_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_F8_101_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_F8_101_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F8_101_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F8_101_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_F8_101_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F8_101_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F8_101_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F8_101_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_F8_101_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_F8_101_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F8_101_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F8_101_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_F8_101_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F8_101_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F8_101_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F8_101_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_F8_101_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F8_101_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F8_101_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F8_101_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_FSharp8_102_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp8_102_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp8_102_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp8_102_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_FSharp8_102_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_FSharp8_102_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp8_102_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp8_102_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_FSharp8_102_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp8_102_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp8_102_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp8_102_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_FSharp8_102_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_FSharp8_102_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp8_102_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp8_102_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_FSharp8_102_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp8_102_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp8_102_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp8_102_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_FSharp8_102_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp8_102_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp8_102_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp8_102_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G8_103_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G8_103_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G8_103_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G8_103_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_G8_103_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_G8_103_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G8_103_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G8_103_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_G8_103_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G8_103_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G8_103_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G8_103_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_G8_103_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_G8_103_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G8_103_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G8_103_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_G8_103_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G8_103_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G8_103_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G8_103_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G8_103_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G8_103_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G8_103_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G8_103_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_GSharp8_104_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp8_104_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp8_104_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp8_104_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_GSharp8_104_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_GSharp8_104_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp8_104_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp8_104_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_GSharp8_104_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp8_104_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp8_104_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp8_104_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_GSharp8_104_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_GSharp8_104_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp8_104_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp8_104_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_GSharp8_104_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp8_104_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp8_104_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp8_104_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_GSharp8_104_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp8_104_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp8_104_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp8_104_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A8_105_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A8_105_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A8_105_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A8_105_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_A8_105_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_A8_105_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A8_105_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A8_105_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_A8_105_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A8_105_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A8_105_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A8_105_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_A8_105_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_A8_105_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A8_105_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A8_105_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_A8_105_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A8_105_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A8_105_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A8_105_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A8_105_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A8_105_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A8_105_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A8_105_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_ASharp8_106_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp8_106_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp8_106_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp8_106_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_ASharp8_106_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_ASharp8_106_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp8_106_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp8_106_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_ASharp8_106_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp8_106_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp8_106_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp8_106_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_ASharp8_106_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_ASharp8_106_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp8_106_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp8_106_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_ASharp8_106_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp8_106_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp8_106_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp8_106_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_ASharp8_106_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp8_106_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp8_106_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp8_106_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B8_107_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B8_107_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B8_107_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B8_107_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_B8_107_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_B8_107_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B8_107_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B8_107_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_B8_107_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B8_107_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B8_107_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B8_107_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_B8_107_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_B8_107_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B8_107_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B8_107_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_B8_107_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B8_107_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B8_107_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B8_107_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B8_107_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B8_107_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B8_107_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B8_107_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_C9_108_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C9_108_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C9_108_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C9_108_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_C9_108_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_C9_108_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C9_108_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C9_108_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_C9_108_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C9_108_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C9_108_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C9_108_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_C9_108_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_C9_108_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C9_108_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C9_108_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_C9_108_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C9_108_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C9_108_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C9_108_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_C9_108_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C9_108_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C9_108_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C9_108_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_CSharp9_109_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp9_109_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp9_109_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp9_109_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_CSharp9_109_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_CSharp9_109_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp9_109_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp9_109_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_CSharp9_109_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp9_109_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp9_109_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp9_109_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_CSharp9_109_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_CSharp9_109_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp9_109_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp9_109_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_CSharp9_109_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp9_109_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp9_109_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp9_109_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_CSharp9_109_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp9_109_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp9_109_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp9_109_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D9_110_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D9_110_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D9_110_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D9_110_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_D9_110_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_D9_110_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D9_110_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D9_110_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_D9_110_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D9_110_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D9_110_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D9_110_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_D9_110_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_D9_110_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D9_110_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D9_110_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_D9_110_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D9_110_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D9_110_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D9_110_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D9_110_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D9_110_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D9_110_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D9_110_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_DSharp9_111_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp9_111_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp9_111_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp9_111_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_DSharp9_111_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_DSharp9_111_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp9_111_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp9_111_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_DSharp9_111_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp9_111_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp9_111_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp9_111_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_DSharp9_111_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_DSharp9_111_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp9_111_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp9_111_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_DSharp9_111_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp9_111_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp9_111_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp9_111_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_DSharp9_111_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp9_111_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp9_111_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp9_111_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E9_112_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E9_112_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E9_112_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E9_112_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_E9_112_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_E9_112_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E9_112_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E9_112_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_E9_112_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E9_112_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E9_112_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E9_112_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_E9_112_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_E9_112_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E9_112_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E9_112_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_E9_112_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E9_112_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E9_112_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E9_112_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E9_112_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E9_112_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E9_112_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E9_112_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_F9_113_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F9_113_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F9_113_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F9_113_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_F9_113_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_F9_113_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F9_113_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F9_113_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_F9_113_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F9_113_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F9_113_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F9_113_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_F9_113_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_F9_113_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F9_113_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F9_113_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_F9_113_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F9_113_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F9_113_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F9_113_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_F9_113_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F9_113_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F9_113_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F9_113_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_FSharp9_114_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp9_114_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp9_114_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp9_114_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_FSharp9_114_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_FSharp9_114_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp9_114_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp9_114_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_FSharp9_114_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp9_114_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp9_114_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp9_114_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_FSharp9_114_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_FSharp9_114_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp9_114_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp9_114_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_FSharp9_114_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp9_114_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp9_114_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp9_114_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_FSharp9_114_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp9_114_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp9_114_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp9_114_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G9_115_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G9_115_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G9_115_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G9_115_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_G9_115_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_G9_115_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G9_115_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G9_115_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_G9_115_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G9_115_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G9_115_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G9_115_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_G9_115_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_G9_115_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G9_115_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G9_115_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_G9_115_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G9_115_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G9_115_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G9_115_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G9_115_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G9_115_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G9_115_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G9_115_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_GSharp9_116_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp9_116_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp9_116_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp9_116_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_GSharp9_116_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_GSharp9_116_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp9_116_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp9_116_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_GSharp9_116_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp9_116_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp9_116_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp9_116_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_GSharp9_116_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_GSharp9_116_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp9_116_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp9_116_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_GSharp9_116_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_GSharp9_116_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp9_116_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp9_116_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_GSharp9_116_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_GSharp9_116_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_GSharp9_116_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_GSharp9_116_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A9_117_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A9_117_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A9_117_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A9_117_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_A9_117_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_A9_117_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A9_117_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A9_117_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_A9_117_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A9_117_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A9_117_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A9_117_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_A9_117_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_A9_117_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A9_117_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A9_117_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_A9_117_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_A9_117_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A9_117_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A9_117_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_A9_117_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_A9_117_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_A9_117_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_A9_117_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_ASharp9_118_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp9_118_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp9_118_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp9_118_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_ASharp9_118_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_ASharp9_118_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp9_118_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp9_118_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_ASharp9_118_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp9_118_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp9_118_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp9_118_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_ASharp9_118_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_ASharp9_118_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp9_118_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp9_118_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_ASharp9_118_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_ASharp9_118_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp9_118_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp9_118_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_ASharp9_118_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_ASharp9_118_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_ASharp9_118_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_ASharp9_118_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B9_119_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B9_119_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B9_119_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B9_119_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_B9_119_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_B9_119_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B9_119_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B9_119_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_B9_119_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B9_119_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B9_119_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B9_119_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_B9_119_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_B9_119_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B9_119_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B9_119_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_B9_119_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_B9_119_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B9_119_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B9_119_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_B9_119_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_B9_119_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_B9_119_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_B9_119_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_C10_120_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C10_120_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C10_120_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C10_120_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_C10_120_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_C10_120_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C10_120_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C10_120_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_C10_120_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C10_120_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C10_120_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C10_120_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_C10_120_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_C10_120_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C10_120_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C10_120_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_C10_120_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_C10_120_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C10_120_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C10_120_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_C10_120_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_C10_120_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_C10_120_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_C10_120_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_CSharp10_121_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp10_121_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp10_121_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp10_121_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_CSharp10_121_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_CSharp10_121_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp10_121_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp10_121_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_CSharp10_121_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp10_121_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp10_121_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp10_121_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_CSharp10_121_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_CSharp10_121_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp10_121_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp10_121_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_CSharp10_121_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_CSharp10_121_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp10_121_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp10_121_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_CSharp10_121_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_CSharp10_121_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_CSharp10_121_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_CSharp10_121_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D10_122_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D10_122_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D10_122_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D10_122_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_D10_122_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_D10_122_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D10_122_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D10_122_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_D10_122_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D10_122_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D10_122_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D10_122_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_D10_122_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_D10_122_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D10_122_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D10_122_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_D10_122_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_D10_122_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D10_122_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D10_122_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_D10_122_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_D10_122_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_D10_122_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_D10_122_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_DSharp10_123_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp10_123_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp10_123_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp10_123_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_DSharp10_123_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_DSharp10_123_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp10_123_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp10_123_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_DSharp10_123_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp10_123_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp10_123_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp10_123_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_DSharp10_123_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_DSharp10_123_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp10_123_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp10_123_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_DSharp10_123_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_DSharp10_123_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp10_123_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp10_123_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_DSharp10_123_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_DSharp10_123_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_DSharp10_123_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_DSharp10_123_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E10_124_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E10_124_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E10_124_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E10_124_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_E10_124_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_E10_124_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E10_124_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E10_124_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_E10_124_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E10_124_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E10_124_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E10_124_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_E10_124_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_E10_124_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E10_124_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E10_124_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_E10_124_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_E10_124_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E10_124_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E10_124_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_E10_124_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_E10_124_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_E10_124_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_E10_124_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_F10_125_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F10_125_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F10_125_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F10_125_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_F10_125_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_F10_125_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F10_125_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F10_125_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_F10_125_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F10_125_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F10_125_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F10_125_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_F10_125_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_F10_125_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F10_125_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F10_125_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_F10_125_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_F10_125_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F10_125_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F10_125_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_F10_125_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_F10_125_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_F10_125_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_F10_125_NoteOnDoubleClickEventKey, value);
            }
        }


        static readonly object Mode6_FSharp10_126_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp10_126_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp10_126_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp10_126_NoteOnEventKey, value);
            }
        }
        static readonly object Mode6_FSharp10_126_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_FSharp10_126_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp10_126_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp10_126_NoteHeldEventKey, value);
            }
        }
        static readonly object Mode6_FSharp10_126_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp10_126_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp10_126_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp10_126_NoteOffEventKey, value);
            }
        }
        static readonly object Mode6_FSharp10_126_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_FSharp10_126_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp10_126_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp10_126_NoteOffDelayedEventKey, value);
            }
        }
        static readonly object Mode6_FSharp10_126_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_FSharp10_126_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp10_126_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp10_126_NoteOffDoubleClickEventKey, value);
            }
        }
        static readonly object Mode6_FSharp10_126_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_FSharp10_126_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_FSharp10_126_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_FSharp10_126_NoteOnDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G10_127_NoteOnEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G10_127_NoteOn
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G10_127_NoteOnEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G10_127_NoteOnEventKey, value);
            }
        }

        static readonly object Mode6_G10_127_NoteHeldEventKey = new object();
        public event EventHandler<OnNoteHoldEventArgs> Mode6_G10_127_NoteHeld
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G10_127_NoteHeldEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G10_127_NoteHeldEventKey, value);
            }
        }

        static readonly object Mode6_G10_127_NoteOffEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G10_127_NoteOff
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G10_127_NoteOffEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G10_127_NoteOffEventKey, value);
            }
        }

        static readonly object Mode6_G10_127_NoteOffDelayedEventKey = new object();
        public event EventHandler<OnNoteOffDelayedEventArgs> Mode6_G10_127_NoteOffDelayed
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G10_127_NoteOffDelayedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G10_127_NoteOffDelayedEventKey, value);
            }
        }

        static readonly object Mode6_G10_127_NoteOffDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOffEventArgs> Mode6_G10_127_NoteOffDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G10_127_NoteOffDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G10_127_NoteOffDoubleClickEventKey, value);
            }
        }

        static readonly object Mode6_G10_127_NoteOnDoubleClickEventKey = new object();
        public event EventHandler<OnNoteOnEventArgs> Mode6_G10_127_NoteOnDoubleClick
        {
            add
            {
                listEventDelegates.AddHandler(Mode6_G10_127_NoteOnDoubleClickEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(Mode6_G10_127_NoteOnDoubleClickEventKey, value);
            }
        }

    }
}
