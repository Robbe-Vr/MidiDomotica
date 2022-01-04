using MidiDomotica.Exchange;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MidiDomotica.Remote.AudioPlayer.Recording
{
    internal class RecordingHandler
    {
        private string _recordingsFolder;
        private string _samplesTempFolder;

        private int _sampleFileCount;
        private int _sampleDuration;

        private IEnumerable<string> _sampleFileNames;

        private string _fileExtension;

        private string _deviceName;

        private WasapiLoopbackCapture capture;

        private MemoryStream memoryStream;
        private int capacity = 0;

        private Timer memoryTimer;

        public RecordingHandler(AudioPlayerData audioPlayerData)
        {
            _samplesTempFolder = audioPlayerData.AudioRecordingsSamplesTemporaryFolder;
            _recordingsFolder = audioPlayerData.AudioRecordingsFolder;

            _sampleFileCount = audioPlayerData.AudioRecordingsMaxSampleCount;
            _sampleDuration = audioPlayerData.AudioRecordingsDurationInMs;

            _fileExtension = audioPlayerData.AudioRecordingsFileExt;

            _deviceName = audioPlayerData.AudioRecordingInputDeviceName;

            string[] sampleFileNames = new string[_sampleFileCount];
            for (int i = 0; i < _sampleFileCount; i++)
            {
                sampleFileNames[i] = $"TempRec-{i + 1}";
            }
            _sampleFileNames = sampleFileNames;
        }

        public void StartAudioRecording()
        {
            memoryTimer = new Timer(_sampleDuration);
            memoryTimer.AutoReset = true;
            memoryTimer.Elapsed += memoryTimerElapsed;

            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();

            MMDevice device = _deviceName == "Default" ? enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia) : enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).FirstOrDefault(d => d.DeviceFriendlyName == _deviceName);

            capture = new WasapiLoopbackCapture(device);

            if (capacity == 0) capacity = (int)(capture.WaveFormat.AverageBytesPerSecond * (_sampleDuration / 1000.00));

            capture.DataAvailable += onDataAvailable;

            memoryTimer.Start();
            capture.StartRecording();
        }

        private void memoryTimerElapsed(object sender, ElapsedEventArgs e)
        {
            SaveTempFile();
        }

        private void onDataAvailable(object sender, WaveInEventArgs e)
        {
            if (memoryStream.CanWrite)
            {
                memoryStream.Write(e.Buffer, 0, e.BytesRecorded);
            }
        }

        public void StopAudioRecording()
        {
            Dispose();
        }

        public string StopAndSaveAudioRecording()
        {
            memoryTimer.Enabled = false;

            capture.DataAvailable -= onDataAvailable;

            SaveTempFile();

            memoryStream.Close();

            memoryStream = new MemoryStream(capacity);

            memoryStream.Position = 0;

            WaveStream waveStream1 = null;

            if (File.Exists(Path.Combine(_samplesTempFolder, _sampleFileNames.Last())))
            {
                WaveFileReader waveReader1 = new WaveFileReader(Path.Combine(_samplesTempFolder, _sampleFileNames.Last()));

                waveReader1.Position = 0;

                waveStream1 = new RawSourceWaveStream(waveReader1, waveReader1.WaveFormat);
            }

            WaveStream waveStream2 = null;

            WaveFileReader waveReader2 = new WaveFileReader(Path.Combine(_samplesTempFolder, _sampleFileNames.First()));

            waveReader2.Position = 0;

            waveStream2 = new RawSourceWaveStream(waveReader2, waveReader2.WaveFormat);

            if (waveStream1 != null)
            {
                double millisecondsLeft = (_sampleDuration - waveStream2.TotalTime.TotalMilliseconds);
                double start = _sampleDuration - millisecondsLeft;

                Tuple<int, int> tuple = Tuple.Create(TimeSpanToOffset(TimeSpan.FromMilliseconds(start), waveStream1.WaveFormat), TimeSpanToOffset(TimeSpan.FromMilliseconds(millisecondsLeft), waveStream1.WaveFormat));

                byte[] buffer = new byte[waveStream1.Length];
                ReadSegment(buffer, tuple, waveStream1);

                memoryStream.Write(buffer, 0, buffer.Length);
            };

            waveStream2.CopyTo(memoryStream);

            string fileName = String.Format("Recording-({0})" + _fileExtension, DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss"));
            string filePath = Path.Combine(_recordingsFolder, fileName);

            SaveToFile(filePath);

            capture.DataAvailable += onDataAvailable;

            memoryTimer.Enabled = true;

            return filePath;
        }

        private void SaveTempFile()
        {
            if (File.Exists(Path.Combine(_samplesTempFolder, _sampleFileNames.Last())))
            {
                try
                {
                    File.Delete(Path.Combine(_samplesTempFolder, _sampleFileNames.Last()));
                }
                catch (Exception e)
                {
                    Trace.WriteLine(e.Message);
                }
            }

            if (File.Exists(Path.Combine(_samplesTempFolder, _sampleFileNames.First())))
            {
                try
                {
                    File.Move(Path.Combine(_samplesTempFolder, _sampleFileNames.First()), Path.Combine(_samplesTempFolder, _sampleFileNames.Last()));
                }
                catch (Exception e)
                {
                    Trace.WriteLine(e.Message);
                }
            }

            try
            {
                string filePath = Path.Combine(_samplesTempFolder, _sampleFileNames.First());

                SaveToFile(filePath);
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        private void SaveToFile(string filePath)
        {
            using (RawSourceWaveStream waveStream = new RawSourceWaveStream(memoryStream, capture.WaveFormat))
            {
                waveStream.Position = 0;
                using (WaveFileWriter writer = new WaveFileWriter(filePath, capture.WaveFormat))
                {
                    waveStream.CopyTo(writer);
                    memoryStream.Close();
                    memoryStream = new MemoryStream(capacity);
                };
            };
        }

        private int ReadSegment(byte[] buffer, Tuple<int, int> tuple, WaveStream sourceStream)
        {
            var (segmentStart, segmentLength) = tuple;
            var bytesAvailable = (int)(segmentStart + segmentLength - sourceStream.Position);

            return sourceStream.Read(buffer, 0, bytesAvailable);
        }

        private int TimeSpanToOffset(TimeSpan ts, WaveFormat waveFormat)
        {
            var bytes = (int)(waveFormat.AverageBytesPerSecond * ts.TotalSeconds);
            bytes -= (bytes % waveFormat.BlockAlign);
            return bytes;
        }

        public void Dispose()
        {
            if (memoryTimer != null)
            {
                memoryTimer.Stop();
                memoryTimer.Close();
                memoryTimer.Dispose();
                memoryTimer = null;
            }

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
        }
    }
}
