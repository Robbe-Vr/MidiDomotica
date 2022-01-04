using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Core.Actions.Interfaces
{
    public interface IAudioPlayer : IActions
    {
        void PlaySound(string soundFilePath);
        void PauseSounds();
        void StopSounds();
        void SetSoundBoardVolume(int volume);

        void StartAudioRecording();
        void StopAudioRecording();
        void StopAndSaveAudioRecording();
    }
}
