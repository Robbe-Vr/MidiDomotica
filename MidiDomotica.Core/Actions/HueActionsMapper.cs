using MidiDomotica.Remote.Hue;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYWPipeNetworkManager;

namespace MidiDomotica.Core.Actions
{
    public partial class ActionMapper
    {
        private HueManager hueManager;

        public void ToggleAllLights()
        {
            hueManager.ToggleAllLights();
        }

        public void ToggleLeftLights()
        {
            hueManager.ToggleLeftLights();
        }
        public void ToggleMidLights()
        {
            hueManager.ToggleMidLights();
        }
        public void ToggleRightLights()
        {
            hueManager.ToggleRightLights();
        }
        public void ToggleFrontLights()
        {
            hueManager.ToggleFrontLights();
        }
        public void ToggleBackLights()
        {
            hueManager.ToggleBackLights();
        }

        public void SetLightsBrightness(int brightness)
        {
            hueManager.SetBrightness(brightness);
        }

        public void SetEntertainmentMaxBrightness(int brightness)
        {
            hueManager.SetEntertainmentMaxBrightness(brightness);
        }

        public void StartMusicSyncMode()
        {
            hueManager.RunMusicSync();

            onMusicSyncStart?.Invoke(this, new EventArgs());
        }

        public void StartEntertainmentExample()
        {
            hueManager.RunExample();
        }

        public void StopEntertainment()
        {
            hueManager.CancelEntertainment();

            onMusicSyncStop?.Invoke(this, new EventArgs());
        }

        public event EventHandler onMusicSyncStart;
        public event EventHandler onMusicSyncStop;
    }
}
