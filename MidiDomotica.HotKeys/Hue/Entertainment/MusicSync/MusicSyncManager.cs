using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using static MidiDomotica.Remote.Hue.Entertainment.MusicSync.Synchronizer;
using static MidiDomotica.Remote.Hue.Entertainment.HueEntertainmentHandler;

namespace MidiDomotica.Remote.Hue.Entertainment.MusicSync
{
    internal class MusicSyncManager
    {
        private Timer syncTimer = new Timer(25);

        private MainOutputCapture capture;
        private Synchronizer synchronizer;

        private string _deviceName;

        internal MusicSyncManager(string outputDeviceName)
        {
            syncTimer.Elapsed += onSyncTimerElapsed;

            _deviceName = outputDeviceName;
        }

        private void onSyncTimerElapsed(object sender, ElapsedEventArgs e)
        {
            double[][] fft = capture.GetFFT();

            SyncJob job = synchronizer.CreateNextJob(fft?[0], fft?[1]);

            HueEntertainmentCommands.SetLeft(job.Left.Brightness, job.Left.Red, job.Left.Green, job.Left.Blue, job.Left.Urgent);

            HueEntertainmentCommands.SetMid(job.Mid.Brightness, job.Mid.Red, job.Mid.Green, job.Mid.Blue, job.Mid.Urgent);

            HueEntertainmentCommands.SetRight(job.Right.Brightness, job.Right.Red, job.Right.Green, job.Right.Blue, job.Right.Urgent);
        }

        public void Start()
        {
            capture = new MainOutputCapture(_deviceName);
            synchronizer = new Synchronizer();

            syncTimer.Start();
        }

        public void Stop()
        {
            if (syncTimer != null)
            {
                syncTimer.Stop();
                syncTimer.Dispose();
                syncTimer = null;
            }

            if (capture != null)
            {
                capture.Dispose();
                capture = null;
            }

            if (synchronizer != null)
            {
                synchronizer.Dispose();
                synchronizer = null;
            }
        }
    }
}
