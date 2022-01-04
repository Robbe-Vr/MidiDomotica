using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ActionObjects
{
    public class AudioApplication
    {
        public int AppProcessId { get; set; }
        public string AppName { get; set; }
        public float Volume { get; set; }
        public bool Muted { get; set; }
        public bool Soloed { get; set; }
        public bool MuteBySolo { get; set; }
    }
}
