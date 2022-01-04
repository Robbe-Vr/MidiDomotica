using MidiDomotica.Exchange.ControlEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.MidiConnection.Events
{
    public partial class EventsMapper
    {
        static readonly object StopButtonEventKey = new object();
        static readonly object PlayButtonEventKey = new object();

        public event EventHandler<OnMediaButtonEventArgs> StopButton
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
        public event EventHandler<OnMediaButtonEventArgs> PlayButton
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
