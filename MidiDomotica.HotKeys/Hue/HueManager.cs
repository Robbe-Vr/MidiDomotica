
using MidiDomotica.Exchange;
using MidiDomotica.Exchange.UserDataClasses;
using MidiDomotica.Remote.Hue.Entertainment;
using MidiDomotica.Remote.Hue.Lights;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MidiDomotica.Remote.Hue
{
    public class HueManager
    {
        private HueLightsHandler lights;
        private HueEntertainmentHandler entertainment;

        public HueManager(HueLightsData settings)
        {
            lights = new HueLightsHandler(settings);
            entertainment = new HueEntertainmentHandler(settings);
        }

        public void ToggleLeftLights()
        {
            lights.ToggleLeftLights();
        }

        public void ToggleMidLights()
        {
            lights.ToggleMidLights();
        }

        public void ToggleRightLights()
        {
            lights.ToggleRightLights();
        }

        public void ToggleFrontLights()
        {
            lights.ToggleFrontLights();
        }

        public void ToggleBackLights()
        {
            lights.ToggleBackLights();
        }

        public void ToggleAllLights()
        {
            lights.ToggleAllLights();
        }


        public void SetBrightness(int brightness)
        {
            lights.SetBrightness(brightness);
        }

        public void SetEntertainmentMaxBrightness(int brightness)
        {
            entertainment.SetBrightnessCeiling(brightness);
        }

        public void RunMusicSync()
        {
            SaveStates();

            entertainment.StartMusicSync();
        }

        public void RunExample()
        {
            entertainment.RunExample();
        }

        public void CancelEntertainment()
        {
            entertainment.Cancel();

            ResetStates();
        }

        private void SaveStates()
        {
            lights.SaveStates();
        }

        private void ResetStates()
        {
            lights.ResetStates();
        }
    }
}
