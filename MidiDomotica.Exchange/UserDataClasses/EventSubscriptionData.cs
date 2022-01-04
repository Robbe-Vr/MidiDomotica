using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.UserDataClasses
{
    public class EventSubscriptionData
    {
        public string EventName { get; set; }
        public string ActionName { get; set; }
        public List<string> Parameters { get; set; }
        public bool Notify { get; set; }
    }
}
