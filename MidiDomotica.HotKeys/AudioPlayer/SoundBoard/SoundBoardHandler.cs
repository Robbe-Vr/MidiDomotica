using MidiDomotica.Exchange;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MidiDomotica.Remote.AudioPlayer.SoundBoard
{
    internal class SoundBoardHandler
    {
        private string deviceName;
        private bool disposePrevious;

        private bool disposing = false;

        private List<SoundPlayer> soundPlayers = new List<SoundPlayer>();

        private float volume = 1.00f;

        private string _downloadsFolder;

        public SoundBoardHandler(AudioPlayerData audioPlayerData)
        {
            _downloadsFolder = audioPlayerData.AudioDownloadsFolder;

            deviceName = audioPlayerData.SoundBoardOutputDeviceName;
            disposePrevious = audioPlayerData.DisposePreviousSound;
        }

        private int FindDevice()
        {
            int deviceCount = WaveOut.DeviceCount;

            for (int i = 0; i < deviceCount; i++)
            {
                WaveOutCapabilities caps = WaveOut.GetCapabilities(i);

                if (caps.ProductName.Split('(')[0].Trim() == deviceName)
                {
                    return i;
                }
            }

            return 0;
        }

        public void PlaySound(string soundFilePath)
        {
            if (disposePrevious)
            {
                disposeWaves();
            }

            SoundPlayer player = new SoundPlayer();
            soundPlayers.Add(player);

            player.WaveOut = new WaveOut();
            player.WaveOut.DeviceNumber = FindDevice();

            Uri uri;
            if (Uri.TryCreate(soundFilePath, UriKind.Absolute, out uri) && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps))
            {
                UrlAudioDownloader downloader = new UrlAudioDownloader(_downloadsFolder);

                soundFilePath = downloader.DownloadMp3FromUrl(uri.AbsoluteUri);
            }

            if (Path.GetExtension(soundFilePath).ToLower() == ".mp3")
            {
                player.MP3Reader = new Mp3FileReader(soundFilePath);
                player.WaveOut.Init(player.MP3Reader);
            }
            else if (Path.GetExtension(soundFilePath).ToLower() == ".wav")
            {
                player.WaveReader = new WaveFileReader(soundFilePath);
                player.WaveOut.Init(player.WaveReader);
            }

            player.WaveOut.Volume = volume;
            player.WaveOut.PlaybackStopped += (sender, e) =>
            {
                player.Dispose();

                while (disposing)
                {
                    Thread.Sleep(5);
                }

                soundPlayers.Remove(player);
                player = null;
            };

            player.WaveOut.Play();
        }

        public void Pause()
        {
            try
            {
                foreach (SoundPlayer player in soundPlayers)
                {
                    player.WaveOut.Pause();
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine("Failed to pause sounds. Reason: " + e.Message);
            }
        }

        public void Stop()
        {
            try
            {
                foreach (SoundPlayer player in soundPlayers)
                {
                    player.WaveOut.Stop();
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine("Failed to stop sounds. Reason: " + e.Message);
            }
        }

        public void SetVolume(float volume)
        {
            this.volume = volume;

            foreach (SoundPlayer player in soundPlayers)
            {
                player.WaveOut.Volume = volume;
            }
        }

        private void disposeWaves()
        {
            disposing = true;
            foreach (SoundPlayer soundPlayer in soundPlayers)
            {
                soundPlayer.Dispose();
            }
            disposing = false;
        }

        private class SoundPlayer
        {
            public WaveOut WaveOut { get; set; }
            public Mp3FileReader MP3Reader { get; set; }
            public WaveFileReader WaveReader { get; set; }

            public void Dispose()
            {
                if (WaveOut != null)
                {
                    WaveOut.Stop();
                    //waveOut.Dispose();
                    WaveOut = null;
                }

                if (WaveReader != null)
                {
                    //waveReader.Dispose();
                    WaveReader = null;
                }

                if (MP3Reader != null)
                {
                    //mp3Reader.Dispose();
                    MP3Reader = null;
                }
            }
        }
    }
}
