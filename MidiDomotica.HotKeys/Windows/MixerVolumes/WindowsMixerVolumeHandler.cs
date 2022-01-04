using MidiDomotica.Exchange.ActionObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MidiDomotica.Remote.Windows.MixerVolumes
{
    public class WindowsMixerVolumeHandler
    {
        public List<AudioApplication> AudioApplications { get; private set; }
        public bool InSolo { get; set; }

        private Timer mixerCheck;

        public WindowsMixerVolumeHandler()
        {
            Start();
        }

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern float GetVolumeOfMixer(int mixerId);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void SetVolumeForMixer(int mixerId, float newVolume);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int GetMuteMixer(int mixerId);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void MuteMixer(int mixerId, bool mute);

        [DllImport(@"C:\\Users\\Robbe\source\\repos\WindowsVolumeChangerDLL\\Debug\\WindowsVolumeChangerDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void GetMixers(StringBuilder mixersStr, int length);

        void Start()
        {
            mixerCheck = new Timer(10000);
            mixerCheck.Elapsed += CheckMixers;

            AudioApplications = GetApplications();

            Trace.WriteLine("\n-------Mixers/Applications----------");
            foreach (var app in AudioApplications)
            {
                float volume = GetVolumeOfApp(app);
                app.Volume = volume;

                Trace.WriteLine("Volume for " + app.AppProcessId + "/" + app.AppName + ": " + volume);
            }

            mixerCheck.Start();
        }

        private void CheckMixers(object sender, ElapsedEventArgs e)
        {
            var newApps = GetApplications();

            List<int> processIds = AudioApplications.Select(a => a.AppProcessId).ToList();

            for(int i = 0; i < newApps.Count; i++)
            {
                var app = AudioApplications.FirstOrDefault(a => a.AppProcessId == newApps[i].AppProcessId);
                if (app == null)
                {
                    if (i > AudioApplications.Count())
                    {
                        AudioApplications.Add(newApps[i]);
                        processIds.Add(newApps[i].AppProcessId);
                    }
                    else
                    {
                        AudioApplications.Insert(i, newApps[i]);
                        processIds.Insert(i, newApps[i].AppProcessId);
                    }
                }
                else if (newApps[i].AppName != app.AppName)
                {
                    app.AppName = newApps[i].AppName;
                }
            }

            AudioApplications = AudioApplications.Where(a => processIds.Contains(a.AppProcessId)).ToList();

            mixerCheck.Start();
        }

        private List<AudioApplication> GetApplications()
        {
            StringBuilder strB = new StringBuilder(2000);
            GetMixers(strB, strB.Capacity);

            string mixersStr = strB.ToString();

            var apps = mixersStr.Split(new string[] { ", " }, StringSplitOptions.None).Select(s => { string[] str = s.Trim().Split(new string[] { " -", "- ", " - " }, StringSplitOptions.None); 
                return new AudioApplication() { AppProcessId = str[0].Trim().All(c => char.IsDigit(c)) ? int.Parse(str[0].Trim()) : -1, AppName = str.Length == 2 && str[1].Length > 1 ? str[1] : "%UNKNOWN%" }; }).ToList();

            apps.ForEach((app) =>
            {
                if (app.AppName.Length < 2 || app.AppName == "%UNKNOWN%")
                {
                    app.AppName = GetProcessName(app.AppProcessId);
                }
            });

            return apps;
        }

        private string GetProcessName(int processId)
        {
            try
            {
                Process process = Process.GetProcessById(processId);

                if (process == null) { return "%UNKNOWN%"; }

                return process.ProcessName;
            }
            catch (Exception e)
            {
                Trace.WriteLine("Error. Could not get process name for " + processId + ": " + e.Message);
                return GetProcessName(processId);
            }
        }

        private float GetVolumeOfApp(AudioApplication app)
        {
            return GetVolumeOfMixer(app.AppProcessId);
        }

        public void SetVolumeForApp(AudioApplication app, float volume)
        {
            SetVolumeForMixer(app.AppProcessId, volume);

            app.Volume = volume;
        }

        public void ToggleMuteApp(AudioApplication app)
        {
            bool mute = !(GetMuteMixer(app.AppProcessId) == 1);

            MuteMixer(app.AppProcessId, mute);
        }

        public void ToggleSoloApp(AudioApplication targetApp)
        {
            if (targetApp.Soloed)
            {
                Unsolo();
            }
            else
            {
                SoloApp(targetApp);
            }
        }

        private void SoloApp(AudioApplication targetApp)
        {
            foreach (var app in AudioApplications)
            {
                if (app.AppProcessId == targetApp.AppProcessId)
                {
                    app.Soloed = true;

                    if (app.Muted)
                    {
                        MuteMixer(app.AppProcessId, false);
                    }
                }
                else if (!app.Muted)
                {
                    MuteMixer(app.AppProcessId, true);
                    app.MuteBySolo = true;
                }
            }

            InSolo = true;
        }

        public void Unsolo()
        {
            foreach (var app in AudioApplications)
            {
                if (app.Soloed) app.Soloed = false;

                if (app.MuteBySolo)
                {
                    if (!app.Muted)
                    {
                        MuteMixer(app.AppProcessId, false);
                    }
                    app.MuteBySolo = false;
                }
            }

            InSolo = false;
        }
    }
}
