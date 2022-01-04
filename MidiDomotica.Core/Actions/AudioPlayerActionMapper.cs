using MidiDomotica.Remote.AudioPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Core.Actions
{
    public partial class ActionMapper
    {
        private AudioPlayerHandler audioPlayerHandler;

        public void PlaySound(string soundFilePath)
        {
            audioPlayerHandler.PlaySound(soundFilePath);
        }

        public void PauseSounds()
        {
            audioPlayerHandler.Pause();
        }

        public void StopSounds()
        {
            audioPlayerHandler.Stop();
        }

        public void SetSoundBoardVolume(int volume)
        {
            float vol = volume / 100.00f;

            audioPlayerHandler.SetVolume(vol);
        }

        public void StartAudioRecording()
        {

        }

        public void StopAudioRecording()
        {

        }

        public void StopAndSaveAudioRecording()
        {

        }
    }
}
