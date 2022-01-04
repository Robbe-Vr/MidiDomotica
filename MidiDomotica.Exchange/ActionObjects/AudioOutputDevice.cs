using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange.ActionObjects
{
    public class AudioOutputDevice
    {
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public float Volume { get; set; }
        public bool Muted { get; set; }
        public bool Soloed { get; set; }
        public bool MuteBySolo { get; set; }
        public bool MainDevice { get; set; }
    }
}
