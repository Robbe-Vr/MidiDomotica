using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Exchange
{
    public class DefaultSettings
    {
        public string DeviceName { get; set; }

        public string UserDataFolder { get; set; }
        public string[] StopByProcesses { get; set; }

        // Audio Player Data
        public AudioPlayerData AudioPlayer { get; set; }

        // Hue Lights Data
        public HueLightsData Hue { get; set; }


    }

    public class AudioPlayerData
    {
        // SoundBoard Data
        public string[] AudioFolders { get; set; }
        public string AudioDownloadsFolder { get; set; }
        public string SoundBoardOutputDeviceName { get; set; }
        public bool DisposePreviousSound { get; set; }

        // Recording Data
        public string AudioRecordingInputDeviceName { get; set; }
        public string AudioRecordingsSamplesTemporaryFolder { get; set; }
        public string AudioRecordingsFolder { get; set; }
        public string AudioRecordingsFileExt { get; set; }
        public int AudioRecordingsDurationInMs { get; set; }
        public int AudioRecordingsMaxSampleCount { get; set; }
    }

    public class HueLightsData
    {
        public string BridgeIP { get; set; }

        public string DefaultColor { get; set; }

        public string[] LightIds { get; set; }
        public string[] LeftLightIds { get; set; }
        public string[] MidLightIds { get; set; }
        public string[] RightLightIds { get; set; }
        public string[] FrontLightIds { get; set; }
        public string[] BackLightIds { get; set; }

        public string EntertainmentRoomName { get; set; }

        public string AppKey { get; set; }
        public string ClientKey { get; set; }

        public bool Registered { get; set; }

        // Music Sync
        public string MusicSyncOutputDeviceName { get; set; }
    }
}
