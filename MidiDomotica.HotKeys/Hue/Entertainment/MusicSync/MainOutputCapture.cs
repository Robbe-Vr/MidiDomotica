using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Remote.Hue.Entertainment.MusicSync
{
    internal class MainOutputCapture
    {
        // prepare class objects
        private MemoryStream memoryStream;

        private WasapiLoopbackCapture capture;

        private FFTHandler fft;

        private double[][] FFTData;

        internal MainOutputCapture(string deviceName)
        {
            fft = new FFTHandler();

            var enumerator = new MMDeviceEnumerator();

            MMDevice device = deviceName == "Default" ? enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia) : enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).FirstOrDefault(d => d.DeviceFriendlyName == deviceName);
            if (device == null)
            {
                Trace.WriteLine($"Could not find an output device by the name '{deviceName}'!\nSwitching to default device!");
                device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            }

            capture = new WasapiLoopbackCapture(device);

            capture.DataAvailable += onDataAvailable;

            capture.StartRecording();
        }

        private void onDataAvailable(object sender, WaveInEventArgs e)
        {
            if (capture.CaptureState == CaptureState.Capturing)
            {
                fft.MemoryStream.Write(e.Buffer, 0, e.BytesRecorded);
            }

            FFTData = fft.PerformFFT(capture.WaveFormat);
        }

        public double[][] GetFFT()
        {
            return FFTData;
        }

        public void Dispose()
        {
            if (capture != null)
            {
                capture.StopRecording();
                capture.Dispose();
                capture = null;
            }

            if (memoryStream != null)
            {
                memoryStream.Close();
                memoryStream.Dispose();
                memoryStream = null;
            }

            if (fft != null)
            {
                fft.Dispose();
                fft = null;
            }
        }
    }
}
