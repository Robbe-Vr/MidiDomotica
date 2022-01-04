using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Core.Actions.Interfaces
{
    public interface IHue : IActions
    {
        void ToggleAllLights();
        void ToggleLeftLights();
        void ToggleMidLights();
        void ToggleRightLights();
        void ToggleFrontLights();
        void ToggleBackLights();

        void SetLightsBrightness(int brightness);

        void SetEntertainmentMaxBrightness(int brightness);

        void StartMusicSyncMode();
        void StopEntertainment();

        event EventHandler onMusicSyncStart;
        event EventHandler onMusicSyncStop;
    }
}
