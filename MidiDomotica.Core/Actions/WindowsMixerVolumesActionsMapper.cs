using MidiDomotica.Exchange.ActionObjects;
using MidiDomotica.Remote.Windows.MixerVolumes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Core.Actions
{
    public partial class ActionMapper
    {
        private static WindowsMixerVolumeHandler mixerHandler = new WindowsMixerVolumeHandler();

        public static IEnumerable<AudioApplication> Mixers { get { return mixerHandler.AudioApplications; } }

        public void SetVolumeMixer(string mixerName, int volume)
        {
            float vol = volume / 100.00f;

            var app = mixerHandler.AudioApplications.FirstOrDefault(x => x.AppName == mixerName);
            if (app == null)
            {
                Trace.WriteLine($"Unable to find a mixer by name '{mixerName}'.");
                return;
            }

            mixerHandler.SetVolumeForApp(app, vol);
        }

        public void ToggleMuteMixer(string mixerName)
        {
            var app = mixerHandler.AudioApplications.FirstOrDefault(x => x.AppName == mixerName);
            if (app == null)
            {
                Trace.WriteLine($"Unable to find a mixer by name '{mixerName}'.");
                return;
            }

            mixerHandler.ToggleMuteApp(app);
        }

        public void ToggleSoloMixer(string mixerName)
        {
            var app = mixerHandler.AudioApplications.FirstOrDefault(x => x.AppName == mixerName);
            if (app == null)
            {
                Trace.WriteLine($"Unable to find a mixer by name '{mixerName}'.");
                return;
            }

            mixerHandler.ToggleSoloApp(app);
        }

        public void UnsoloMixers()
        {
            mixerHandler.Unsolo();
        }
    }
}
