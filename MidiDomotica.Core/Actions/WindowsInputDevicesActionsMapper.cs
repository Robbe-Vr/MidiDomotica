using MidiDomotica.Exchange.ActionObjects;
using MidiDomotica.Remote.Windows.InputDevices;
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
        private static WindowsInputDeviceVolumeHandler inputDeviceHandler = new WindowsInputDeviceVolumeHandler();

        public static IEnumerable<AudioRecordingDevice> InputDevices { get { return inputDeviceHandler.AudioRecordingDevices; } }

        public void SetVolumeMainInputDevice(int volume)
        {
            while (inputDeviceHandler.VolumeChanging)
            {
                Thread.Sleep(5);
            }

            float vol = volume / 100.00f;

            inputDeviceHandler.SetMainVolume(vol);
        }

        public void ToggleMuteMainInputDevice()
        {
            inputDeviceHandler.ToggleMuteMain();
        }

        public void SetVolumeInputDevice(string deviceName, int volume)
        {
            while (inputDeviceHandler.VolumeChanging)
            {
                Thread.Sleep(5);
            }

            float vol = volume / 100.00f;

            var device = inputDeviceHandler.AudioRecordingDevices.FirstOrDefault(x => x.DeviceName == deviceName);
            if (device == null)
            {
                Trace.WriteLine($"Unable to find an audio device by name '{deviceName}'.");
                return;
            }

            inputDeviceHandler.SetVolume(device, vol);
        }

        public void ToggleMuteInputDevice(string deviceName)
        {
            var device = inputDeviceHandler.AudioRecordingDevices.FirstOrDefault(x => x.DeviceName == deviceName);
            if (device == null)
            {
                Trace.WriteLine($"Unable to find an audio device by name '{deviceName}'.");
                return;
            }

            inputDeviceHandler.MuteDevice(device);
        }

        public void ToggleSoloInputDevice(string deviceName)
        {
            var device = inputDeviceHandler.AudioRecordingDevices.FirstOrDefault(x => x.DeviceName == deviceName);
            if (device == null)
            {
                Trace.WriteLine($"Unable to find an audio device by name '{deviceName}'.");
                return;
            }

            inputDeviceHandler.ToggleSoloDevice(device);
        }

        public void UnsoloInputDevices()
        {
            inputDeviceHandler.Unsolo();
        }
    }
}
