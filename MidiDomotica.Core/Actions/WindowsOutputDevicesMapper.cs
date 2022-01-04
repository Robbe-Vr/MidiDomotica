using MidiDomotica.Exchange.ActionObjects;
using MidiDomotica.Remote.Windows.OutputDevices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MidiDomotica.Core.Actions
{
    public partial class ActionMapper
    {
        private static WindowsOutputDeviceVolumeHandler outputDeviceHandler = new WindowsOutputDeviceVolumeHandler();

        public static IEnumerable<AudioOutputDevice> OutputDevices { get { return outputDeviceHandler.AudioOutputDevices; } }

        public void SetVolumeMainOutputDevice(int volume)
        {
            while (outputDeviceHandler.VolumeChanging)
            {
                Thread.Sleep(5);
            }

            float vol = volume / 100.00f;

            outputDeviceHandler.SetMainVolume(vol);
        }

        public void ToggleMuteMainOutputDevice()
        {
            outputDeviceHandler.ToggleMuteMain();
        }

        public void SetVolumeOutputDevice(string deviceName, int volume)
        {
            while (outputDeviceHandler.VolumeChanging)
            {
                Thread.Sleep(5);
            }

            float vol = volume / 100.00f;

            var device = outputDeviceHandler.AudioOutputDevices.FirstOrDefault(x => x.DeviceName == deviceName);
            if (device == null)
            {
                Trace.WriteLine($"Unable to find an audio device by name '{deviceName}'.");
                return;
            }

            outputDeviceHandler.SetVolume(device, vol);
        }

        public void ToggleMuteOutputDevice(string deviceName)
        {
            var device = outputDeviceHandler.AudioOutputDevices.FirstOrDefault(x => x.DeviceName == deviceName);
            if (device == null)
            {
                Trace.WriteLine($"Unable to find an audio device by name '{deviceName}'.");
                return;
            }

            outputDeviceHandler.ToggleMuteDevice(device);
        }

        public void ToggleSoloOutputDevice(string deviceName)
        {
            var device = outputDeviceHandler.AudioOutputDevices.FirstOrDefault(x => x.DeviceName == deviceName);
            if (device == null)
            {
                Trace.WriteLine($"Unable to find an audio device by name '{deviceName}'.");
                return;
            }

            outputDeviceHandler.ToggleSoloDevice(device);
        }

        public void UnsoloOutputDevices()
        {
            outputDeviceHandler.Unsolo();
        }
    }
}
