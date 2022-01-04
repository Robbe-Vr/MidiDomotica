using MidiDomotica.Remote.Hue.Entertainment.MusicSync;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MidiDomotica.Remote.Hue.Entertainment
{
    internal partial class HueEntertainmentHandler
    {
        private string _musicSyncOutputDeviceName;

        public void StartMusicSync()
        {
            if (EntertainmentBusy) return;

            entertainmentTaskCancellationTokenSource = new CancellationTokenSource();

            Task.Run(async () =>
            {
                await Init();

                MusicSyncManager musicSyncManager = new MusicSyncManager(_musicSyncOutputDeviceName);

                musicSyncManager.Start();

                while (!entertainmentTaskCancellationTokenSource.IsCancellationRequested)
                {
                    Thread.Sleep(50);
                }

                musicSyncManager.Stop();
            }, entertainmentTaskCancellationTokenSource.Token);
        }
    }
}
