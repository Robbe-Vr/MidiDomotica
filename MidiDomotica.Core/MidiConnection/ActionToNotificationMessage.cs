using MidiDomotica.Core.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Core.MidiConnection
{
    internal class ActionToNotificationMessage
    {
       public string this[string value] { get { return actionsToNotificationMessage.FirstOrDefault(x => x.Key == value).Value; } }

        private Dictionary<string, string> actionsToNotificationMessage = new Dictionary<string, string>();

        public ActionToNotificationMessage()
        {
            actionsToNotificationMessage.Add(nameof(ActionMapper.PerformKeyPress), "Performed keypress '{0}'.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.PerformKeyPressCombi), "Performed macro keypress for '{0}'.");

            actionsToNotificationMessage.Add(nameof(ActionMapper.SetSoundBoardVolume), "Set volume for the soundboard to '{0}'.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.PlaySound), "Playing a sound '{0}'.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.PauseSounds), "Pausing all playing soundboard sounds.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.StopSounds), "Stopping all playing soundboard sounds.");
            
            actionsToNotificationMessage.Add(nameof(ActionMapper.SetPowerMode), "Changed windows power mode to '{0}'.");

            actionsToNotificationMessage.Add(nameof(ActionMapper.SetVolumeInputDevice), "Set volume for input device '{0}' to '{1}'.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.SetVolumeMainInputDevice), "Set volume for main input device to '{0}'.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.ToggleMuteMainInputDevice), "Switched mute state for for main input device.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.ToggleSoloInputDevice), "Switched solo state for for input device '{0}'.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.UnsoloInputDevices), "Turned off solo state for any soloed input device.");
            
            actionsToNotificationMessage.Add(nameof(ActionMapper.SetVolumeOutputDevice), "Set volume for output device '{0}' to '{1}'.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.SetVolumeMainOutputDevice), "Set volume for main output device to '{0}'.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.ToggleMuteMainOutputDevice), "Switched mute state for for main output device.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.ToggleSoloOutputDevice), "Switched solo state for for output device '{0}'.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.UnsoloOutputDevices), "Turned off solo state for any soloed output device.");

            actionsToNotificationMessage.Add(nameof(ActionMapper.SetVolumeMixer), "Set volume for mixer '{0}' to '{1}'.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.ToggleMuteMixer), "Switched mute state for mixer '{0}'.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.ToggleSoloMixer), "Switched solo state for mixer '{0}'.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.UnsoloMixers), "Turned off solo state for any soloed mixer.");

            actionsToNotificationMessage.Add(nameof(ActionMapper.StartAudioRecording), "Started recording output from main output device.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.StopAudioRecording), "Stopped recording output from main output device.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.StopAndSaveAudioRecording), "Saving the recorded audio from your main output device.");

            actionsToNotificationMessage.Add(nameof(ActionMapper.StartEntertainmentExample), "Starting the Hue Entertainment room example event.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.StartMusicSyncMode), "Starting 'Music Synchronisation' in your hue entertainment room.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.StopEntertainment), "Stopping all currently active Hue entertainment jobs.");

            actionsToNotificationMessage.Add(nameof(ActionMapper.SetEntertainmentMaxBrightness), "Set Hue max brightness to '{0}'.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.SetLightsBrightness), "Set Hue max brightness to '{0}'.");

            actionsToNotificationMessage.Add(nameof(ActionMapper.ToggleAllLights), "Switched on/off all Hue lights in your room.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.ToggleBackLights), "Switched on/off all Hue lights in the back of your room.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.ToggleFrontLights), "Switched on/off all Hue lights in the front of your room.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.ToggleMidLights), "Switched on/off all Hue lights in the middle of your room.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.ToggleLeftLights), "Switched on/off all Hue lights in the left side of your room.");
            actionsToNotificationMessage.Add(nameof(ActionMapper.ToggleRightLights), "Switched on/off all Hue lights in the right side of your room.");

        }
    }
}
