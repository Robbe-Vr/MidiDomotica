using MidiDomotica.Exchange;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MidiDomotica.Persistence
{
    internal class AppDataHandler
    {
        private string appDataFolder;
        private string defaultDataFileName = "default.json";

        public DefaultSettings DefaultSettings { get { return GetDefaultData(); } set { OverwriteDefaultData(value); } }

        internal AppDataHandler()
        {
            var task = Task.Run(() =>
            {
                appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), nameof(MidiDomotica), "Data");

                if (!Directory.Exists(appDataFolder))
                {
                    Directory.CreateDirectory(appDataFolder);
                }

                string filePath = Path.Combine(appDataFolder, defaultDataFileName);

                if (!File.Exists(filePath))
                {
                    OverwriteDefaultData(
                        new DefaultSettings()
                        {
                            DeviceName = "Novation SL MkIII",
                            UserDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), nameof(MidiDomotica), "User"),
                            StopByProcesses = new string[] { },
                            AudioPlayer = new AudioPlayerData()
                            {
                                AudioRecordingsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "MidiDomotica", "Recordings"),
                                AudioRecordingsSamplesTemporaryFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "MidiDomotica", "Recordings-Temp"),
                                AudioDownloadsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "MidiDomotica", "Downloads"),
                                AudioFolders = new string[]
                                {
                                    Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
                                },
                                AudioRecordingInputDeviceName = "Default",
                                AudioRecordingsDurationInMs = 5000,
                                AudioRecordingsFileExt = ".wav",
                                AudioRecordingsMaxSampleCount = 2,

                                SoundBoardOutputDeviceName = "Default",
                                DisposePreviousSound = false,
                            },
                            Hue = new HueLightsData()
                            {
                                BridgeIP = "192.168.2.50",
                                DefaultColor = "0, 130, 165",
                                EntertainmentRoomName = "Robbe",
                                LightIds = new string[]
                                {
                                    "4", "3", "5",
                                },
                                LeftLightIds = new string[]
                                {
                                    "4",
                                },
                                MidLightIds = new string[]
                                {
                                    "3",
                                },
                                RightLightIds = new string[]
                                {
                                    "5",
                                },
                                FrontLightIds = new string[]
                                {
                                    "4", "3", "5",
                                },
                                BackLightIds = new string[]
                                {
                                    
                                },
                                AppKey = "SFM0zbWutfb-f5h0tGFa2OtEdkMAg9Rbh74RpD8N",
                                ClientKey = "C09BCE3E49ABAE36361D3848BA80591F",
                                Registered = true,

                                MusicSyncOutputDeviceName = "Default",
                            },
                        }
                    );
                }
            });

            while (!task.IsCompleted && !task.IsCanceled && !task.IsFaulted)
            {
                Thread.Sleep(10);
            }
        }

        internal DefaultSettings GetDefaultData()
        {
            string data = File.ReadAllText(Path.Combine(appDataFolder, defaultDataFileName));

            return JsonConvert.DeserializeObject<DefaultSettings>(data);
        }

        private void OverwriteDefaultData(DefaultSettings data)
        {
            if (data.DeviceName.Length < 2 || !Directory.Exists(data.UserDataFolder) ||
                !Directory.Exists(data.AudioPlayer.AudioDownloadsFolder) || data.AudioPlayer.AudioFolders.Any(f => !Directory.Exists(f)) ||
                data.Hue.BridgeIP.Length < 5)
            {
                Trace.WriteLine("Not overwriting default settings! Given data might crash the application!");

                return;
            }

            string filePath = Path.Combine(appDataFolder, defaultDataFileName);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            JObject settingsJSON = JObject.FromObject(data);

            using (StreamWriter file = File.CreateText(filePath))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                settingsJSON.WriteTo(writer);
            }
        }
    }
}
