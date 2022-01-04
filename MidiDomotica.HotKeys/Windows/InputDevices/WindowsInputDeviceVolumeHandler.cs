using MidiDomotica.Exchange.ActionObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Remote.Windows.InputDevices
{
    public class WindowsInputDeviceVolumeHandler
    {
        public IEnumerable<AudioRecordingDevice> AudioRecordingDevices { get; private set; }
        public bool InSolo { get; set; }

        public bool VolumeChanging { get; private set; }

        public WindowsInputDeviceVolumeHandler()
        {
            Start();
        }

        public enum VolumeUnit
        {
            Decibel,
            Scalar
        }

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern float GetMainRecordingDeviceVolume(VolumeUnit vUnit);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern float GetVolumeOfRecordingDevice(string deviceId, VolumeUnit vUnit);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void SetMainRecordingDeviceVolume(float newVolume, VolumeUnit vUnit);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void SetVolumeForRecordingDevice(string deviceId, float newVolume, VolumeUnit vUnit);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int GetMuteMainRecordingDevice();

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int GetMuteRecordingDevice(string deviceId);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void MuteMainRecordingDevice(bool mute);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void MuteRecordingDevice(string deviceId, bool mute);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void GetRecordingDevices(StringBuilder devicesStr, int length);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void GetMainRecordingDevice(StringBuilder deviceStr, int length);

        void Start()
        {
            StringBuilder strB = new StringBuilder(2000);
            GetRecordingDevices(strB, strB.Capacity);

            string devicesStr = strB.ToString();

            Trace.WriteLine("\n-------Recording Devices----------");

            AudioRecordingDevices = devicesStr.Split(',').Select(s => { string[] str = s.Trim().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries); return new AudioRecordingDevice() { DeviceId = str[1], DeviceName = str[0] }; }).ToList();

            strB = new StringBuilder(2000);
            GetMainRecordingDevice(strB, strB.Capacity);

            string deviceStr = strB.ToString();

            var mstr = deviceStr.Trim().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            AudioRecordingDevice mainDevice = new AudioRecordingDevice() { DeviceId = mstr[1], DeviceName = mstr[0] };

            foreach (var device in AudioRecordingDevices)
            {
                if (device.DeviceId == mainDevice.DeviceId)
                {
                    device.MainDevice = true;
                }

                float volume = GetVolumeOfRecordingDevice(device.DeviceId, VolumeUnit.Scalar);
                device.Volume = volume;

                Trace.WriteLine("Volume for " + device.DeviceName + ": " + volume);
            }
        }

        private float GetMainVolume(VolumeUnit vUnit)
        {
            return GetMainRecordingDeviceVolume(vUnit);
        }

        private float GetRecordingDeviceVolume(string deviceId, VolumeUnit vUnit)
        {
            return GetVolumeOfRecordingDevice(deviceId, vUnit);
        }

        public void SetMainVolume(float volume)
        {
            VolumeChanging = true;

            SetMainRecordingDeviceVolume(volume, VolumeUnit.Scalar);
            AudioRecordingDevices.First(a => a.MainDevice).Volume = volume;

            VolumeChanging = false;
        }

        public void SetVolume(AudioRecordingDevice device, float volume)
        {
            VolumeChanging = true;

            SetVolumeForRecordingDevice(device.DeviceId, volume, VolumeUnit.Scalar);
            device.Volume = volume;

            VolumeChanging = false;
        }

        private bool GetMuteMain()
        {
            return GetMuteMainRecordingDevice() == 1;
        }

        public void ToggleMuteMain()
        {
            bool mute = !GetMuteMain();

            MuteMainRecordingDevice(mute);
            AudioRecordingDevices.First(a => a.MainDevice).Muted = mute;
        }

        private bool GetRecordingDeviceMute(string deviceId)
        {
            return GetMuteRecordingDevice(deviceId) == 1;
        }

        public void MuteDevice(AudioRecordingDevice device)
        {
            bool mute = !GetRecordingDeviceMute(device.DeviceId);

            MuteRecordingDevice(device.DeviceId, mute);
            device.Muted = mute;
        }

        public void ToggleSoloDevice(AudioRecordingDevice targetDevice)
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

        private void SoloDevice(AudioRecordingDevice targetDevice)
        {
            foreach (var device in AudioRecordingDevices)
            {
                if (device.DeviceId == targetDevice.DeviceId)
                {
                    device.Soloed = true;

                    if (device.Muted)
                    {
                        MuteRecordingDevice(targetDevice.DeviceId, false);
                    }
                }
                else if (!device.Muted)
                {
                    MuteRecordingDevice(device.DeviceId, true);
                    device.MuteBySolo = true;
                }
            }

            InSolo = true;
        }

        public void Unsolo()
        {
            foreach (var device in AudioRecordingDevices)
            {
                if (device.Soloed) device.Soloed = false;

                if (device.MuteBySolo)
                {
                    if (!device.Muted)
                    {
                        MuteRecordingDevice(device.DeviceId, false);
                    }
                    device.MuteBySolo = false;
                }
            }

            InSolo = false;
        }
    }
}
