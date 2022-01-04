using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Core.Actions.Interfaces
{
    public interface IAllActions : IAudioPlayer, IHotkeys, IHue, IInputDevices, IMixerVolumes, IOutputDevices, IPowerModes
    {
    }
}
