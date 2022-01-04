using MidiDomotica.Exchange.ActionObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Core.Actions.Interfaces
{
    public interface IMixerVolumes : IActions
    {
        void SetVolumeMixer(string mixerName, int volume);
        void ToggleMuteMixer(string mixerName);
        void ToggleSoloMixer(string mixerName);
        void UnsoloMixers();
    }
}
