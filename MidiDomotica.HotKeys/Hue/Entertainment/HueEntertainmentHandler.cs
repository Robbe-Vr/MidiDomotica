using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MidiDomotica.Exchange;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.Streaming;
using Q42.HueApi.Streaming.Effects;
using Q42.HueApi.Streaming.Extensions;
using Q42.HueApi.Streaming.Models;
using static MidiDomotica.Remote.Hue.HueManager;

namespace MidiDomotica.Remote.Hue.Entertainment
{
    internal partial class HueEntertainmentHandler
    {
        private StreamingHueClient client;

        private Task runningTask;
        private CancellationTokenSource entertainmentTaskCancellationTokenSource;

        public bool EntertainmentBusy { get { return runningTask != null && (runningTask.IsCompleted || runningTask.IsCanceled || runningTask.IsFaulted); } }

        private Task autoUpdateTask;
        private CancellationTokenSource autoUpdateCancelationTokenSource;

        private EntertainmentLayer baseEntLayer;
        private EntertainmentLayer effectLayer;

        private StreamingGroup stream;

        private HueLightsData _settings;

        public HueEntertainmentHandler(HueLightsData settings)
        {
            _settings = settings;

            _musicSyncOutputDeviceName = settings.MusicSyncOutputDeviceName;
        }

        public async Task<bool> Init()
        {
            stream = await SetupBridge();

            if (stream == null) return false;

            baseEntLayer = stream.GetNewLayer(isBaseLayer: true);
            effectLayer = stream.GetNewLayer();

            baseEntLayer.AutoCalculateEffectUpdate(new CancellationToken());
            effectLayer.AutoCalculateEffectUpdate(new CancellationToken());

            SetupSides();

            return true;
        }

        private void SetupSides()
        {
            List<EntertainmentLight> midLights = new List<EntertainmentLight>();
            midLights.AddRange(baseEntLayer.GetFront().GetCenter());
            midLights.AddRange(baseEntLayer.GetCenter());
            midLights.AddRange(baseEntLayer.GetBack().GetCenter());
            
            HueEntertainmentCommands.Mid.AddRange(midLights.Distinct().ToList());

            HueEntertainmentCommands.Left.AddRange(baseEntLayer.GetLeft());
            HueEntertainmentCommands.Right.AddRange(baseEntLayer.GetRight());
        }

        private async Task<StreamingGroup> SetupBridge()
        {
            try
            {
                client = new StreamingHueClient(_settings.BridgeIP, _settings.AppKey, _settings.ClientKey);

                bool useSimulator = false;

                var all = await client.LocalHueClient.GetEntertainmentGroups();
                var group = all.FirstOrDefault(x => x.Name == "Robbe");

                if (group == null) return null;

                var stream = new StreamingGroup(group.Locations);

                stream.IsForSimulator = useSimulator;

                await client.Connect(group.Id, useSimulator);

                autoUpdateCancelationTokenSource = new CancellationTokenSource();
                autoUpdateTask = client.AutoUpdate(stream, autoUpdateCancelationTokenSource.Token, 50, onlySendDirtyStates: false);

                while (autoUpdateTask.Status != TaskStatus.RanToCompletion && autoUpdateTask.Status != TaskStatus.Canceled && autoUpdateTask.Status == TaskStatus.Running)
                {
                    Thread.Sleep(10);
                }

                var bridgeInfo = await client.LocalHueClient.GetBridgeAsync();
                Console.Out.WriteLine(bridgeInfo.IsStreamingActive ? "Streaming is active" : "Streaming is not active");
                return stream;
            }
            catch (Exception e)
            {
                Trace.WriteLine("Error connecting to bridge! Message: ", e.Message);
                return null;
            }
        }

        public void Cancel()
        {
            if (autoUpdateCancelationTokenSource != null && !autoUpdateCancelationTokenSource.IsCancellationRequested)
            {
                autoUpdateCancelationTokenSource.Cancel();
            }

            if (entertainmentTaskCancellationTokenSource != null && !entertainmentTaskCancellationTokenSource.IsCancellationRequested)
            {
                entertainmentTaskCancellationTokenSource.Cancel();
            }

            if (client != null)
            {
                client.Close();
                client = null;
            }

            if (stream != null)
            {
                stream.Clear();
                stream = null;
            }

            if (baseEntLayer != null)
            {
                baseEntLayer.Clear();
                baseEntLayer = null;
            }

            if (effectLayer != null)
            {
                effectLayer.Clear();
                effectLayer = null;
            }
        }

        public void SetBrightnessCeiling(int brightness)
        {
            HueEntertainmentCommands.brightnessCeiling = brightness / 100;
        }

        internal static class HueEntertainmentCommands
        {
            public static double brightnessCeiling { get; set; } = 1.00;

            public static List<EntertainmentLight> Mid { get; } = new List<EntertainmentLight>();
            public static List<EntertainmentLight> Left { get; } = new List<EntertainmentLight>();
            public static List<EntertainmentLight> Right { get; } = new List<EntertainmentLight>();

            public static void SetMid(double bri, double r, double g, double b, bool urgent = false)
            {
                Mid.SetState(CancellationToken.None, new RGBColor(r, g, b), bri * brightnessCeiling, transitionTime: (urgent ? default : TimeSpan.FromMilliseconds(100)));
            }

            public static void SetLeft(double bri, double r, double g, double b, bool urgent = false)
            {
                Left.SetState(CancellationToken.None, new RGBColor(r, g, b), bri * brightnessCeiling, transitionTime: (urgent ? default : TimeSpan.FromMilliseconds(100)));
            }

            public static void SetRight(double bri, double r, double g, double b, bool urgent = false)
            {
                Right.SetState(CancellationToken.None, new RGBColor(r, g, b), bri * brightnessCeiling, transitionTime: (urgent ? default : TimeSpan.FromMilliseconds(100)));
            }
        }
    }
}
