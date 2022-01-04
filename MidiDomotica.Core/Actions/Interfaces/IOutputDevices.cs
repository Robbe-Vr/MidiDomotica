using MidiDomotica.Exchange.ActionObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Core.Actions.Interfaces
{
    public interface IOutputDevices : IActions
    {
        void SetVolumeMainOutputDevice(int volume);
        void ToggleMuteMainOutputDevice();
        void SetVolumeOutputDevice(string deviceName, int volume);

        void ToggleMuteOutputDevice(string deviceName);
        void ToggleSoloOutputDevice(string deviceName);
        void UnsoloOutputDevices();
    }
}
