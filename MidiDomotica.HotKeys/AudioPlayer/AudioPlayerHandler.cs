using MidiDomotica.Exchange;
using MidiDomotica.Remote.AudioPlayer.Recording;
using MidiDomotica.Remote.AudioPlayer.SoundBoard;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MidiDomotica.Remote.AudioPlayer
{
    public class AudioPlayerHandler
    {
        private SoundBoardHandler soundBoard;
        private RecordingHandler recording;

        public AudioPlayerHandler(AudioPlayerData audioPlayerData)
        {
            soundBoard = new SoundBoardHandler(audioPlayerData);
            recording = new RecordingHandler(audioPlayerData);
        }

        // SoundBoard
        public void PlaySound(string soundFilePath)
        {
            soundBoard.PlaySound(soundFilePath);
        }

        public void Pause()
        {
            soundBoard.Pause();
        }

        public void Stop()
        {
            soundBoard.Stop();
        }

        public void SetVolume(float volume)
        {
            soundBoard.SetVolume(volume);
        }

        // Recording
        public void StartAudioRecording()
        {
            recording.StartAudioRecording();
        }

        public void StopAudioRecording()
        {
            recording.StopAudioRecording();
        }

        public void StopAndSaveAudioRecording()
        {
            recording.StopAndSaveAudioRecording();
        }
    }
}
