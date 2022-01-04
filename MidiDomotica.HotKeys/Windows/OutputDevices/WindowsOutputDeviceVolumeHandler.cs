using MidiDomotica.Exchange.ActionObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Remote.Windows.OutputDevices
{
    public class WindowsOutputDeviceVolumeHandler
    {
        public IEnumerable<AudioOutputDevice> AudioOutputDevices { get; private set; }
        public bool InSolo { get; set; }

        public bool VolumeChanging { get; private set; }

        public WindowsOutputDeviceVolumeHandler()
        {
            Start();
        }

        public enum VolumeUnit
        {
            Decibel,
            Scalar
        }

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern float GetMainOutputDeviceVolume(VolumeUnit vUnit);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern float GetVolumeOfOutputDevice(string deviceId, VolumeUnit vUnit);
        
        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void SetMainOutputDeviceVolume(float newVolume, VolumeUnit vUnit);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void SetVolumeForOutputDevice(string deviceId, float newVolume, VolumeUnit vUnit);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int GetMuteMainOutputDevice();

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int GetMuteOutputDevice(string deviceId);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void MuteMainOutputDevice(bool mute);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void MuteOutputDevice(string deviceId, bool mute);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void GetOutputDevices(StringBuilder devicesStr, int length);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void GetMainOutputDevice(StringBuilder deviceStr, int length);

        void Start()
        {
            StringBuilder strB = new StringBuilder(2000);
            GetOutputDevices(strB, strB.Capacity);

            string devicesStr = strB.ToString();

            Trace.WriteLine("\n-------Output Devices----------");

            AudioOutputDevices = devicesStr.Split(',').Select(s => { string[] str = s.Trim().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries); return new AudioOutputDevice() { DeviceId = str[1], DeviceName = str[0] }; }).ToList();

            strB = new StringBuilder(2000);
            GetMainOutputDevice(strB, strB.Capacity);

            string deviceStr = strB.ToString();

            var mstr = deviceStr.Trim().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            AudioOutputDevice mainDevice = new AudioOutputDevice() { DeviceId = mstr[1], DeviceName = mstr[0] };

            foreach (var device in AudioOutputDevices)
            {
                if (device.DeviceId == mainDevice.DeviceId)
                {
                    device.MainDevice = true;
                }

                float volume = GetVolumeOfOutputDevice(device.DeviceId, VolumeUnit.Scalar);
                device.Volume = volume;

                Trace.WriteLine("Volume for " + device.DeviceName + ": " + volume);
            }
        }

        private float GetMainVolume(VolumeUnit vUnit)
        {
            return GetMainOutputDeviceVolume(vUnit);
        }

        private float GetRecordingDeviceVolume(string deviceId, VolumeUnit vUnit)
        {
            return GetVolumeOfOutputDevice(deviceId, vUnit);
        }

        public void SetMainVolume(float volume)
        {
            VolumeChanging = true;

            SetMainOutputDeviceVolume(volume, VolumeUnit.Scalar);
            AudioOutputDevices.First(a => a.MainDevice).Volume = volume;

            VolumeChanging = false;
        }

        public void SetVolume(AudioOutputDevice device, float volume)
        {
            VolumeChanging = true;

            SetVolumeForOutputDevice(device.DeviceId, volume, VolumeUnit.Scalar);
            device.Volume = volume;

            VolumeChanging = false;
        }

        private bool GetMuteMain()
        {
            return GetMuteMainOutputDevice() == 1;
        }

        public void ToggleMuteMain()
        {
            bool mute = !GetMuteMain();

            MuteMainOutputDevice(mute);
            AudioOutputDevices.First(a => a.MainDevice).Muted = mute;
        }

        public void ToggleMuteDevice(AudioOutputDevice device)
        {
            bool mute = !(GetMuteOutputDevice(device.DeviceId) == 1);

            MuteOutputDevice(device.DeviceId, mute);
            device.Muted = mute;
        }

        public void ToggleSoloDevice(AudioOutputDevice targetDevice)
        {
            if (targetDevice.Soloed)
            {
                Unsolo();
            }
            else
            {
                SoloDevice(targetDevice);
            }
        }

        private void SoloDevice(AudioOutputDevice targetDevice)
        {
            foreach (var device in AudioOutputDevices)
            {
                if (device.DeviceId == targetDevice.DeviceId)
                {
                    device.Soloed = true;

                    if (device.Muted)
                    {
                        MuteOutputDevice(targetDevice.DeviceId, false);
                    }
                }
                else if (!device.Muted)
                {
                    MuteOutputDevice(device.DeviceId, true);
                    device.MuteBySolo = true;
                }
            }

            InSolo = true;
        }

        public void Unsolo()
        {
            foreach (var device in AudioOutputDevices)
            {
                if (device.Soloed) device.Soloed = false;

                if (device.MuteBySolo)
                {
                    if (!device.Muted)
                    {
                        MuteOutputDevice(device.DeviceId, false);
                    }
                    device.MuteBySolo = false;
                }
            }

            InSolo = false;
        }
    }
}
