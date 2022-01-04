using MidiDomotica.Exchange.ActionObjects;
using MidiDomotica.Remote.Windows.InputDevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Core.Actions.Interfaces
{
    public interface IInputDevices : IActions
    {
        void SetVolumeMainInputDevice(int volume);
        void ToggleMuteMainInputDevice();
        void SetVolumeInputDevice(string deviceName, int volume);

        void ToggleMuteInputDevice(string deviceName);
        void ToggleSoloInputDevice(string deviceName);
        void UnsoloInputDevices();
    }
}
