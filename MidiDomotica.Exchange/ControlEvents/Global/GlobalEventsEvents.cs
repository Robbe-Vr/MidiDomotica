using MidiDomotica.MidiConnection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MidiDomotica.MidiConnection.Event
{
    internal partial class Events
    {
        static readonly object StopButtonEventKey = new object();
        static readonly object PlayButtonEventKey = new object();

        internal event EventHandler<OnMediaButtonEventArgs> StopButton
        {
            add
            {
                listEventDelegates.AddHandler(StopButtonEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(StopButtonEventKey, value);
            }
        }

        internal event EventHandler<OnMediaButtonEventArgs> PlayButton
        {
            add
            {
                listEventDelegates.AddHandler(PlayButtonEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(PlayButtonEventKey, value);
            }
        }
    }
}
