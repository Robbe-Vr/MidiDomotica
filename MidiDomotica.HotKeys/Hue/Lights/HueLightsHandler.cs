using MidiDomotica.Exchange;
using Q42.HueApi;
using Q42.HueApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MidiDomotica.Remote.Hue.Lights
{
    internal class HueLightsHandler
    {
        public bool Connected { get; private set; }

        private HueLightsData _settings;

        private ILocalHueClient client;

        private IEnumerable<Light> lightStates;

        private Timer commandQueueTimer = new Timer(100);
        private List<QueuedLightCommand> commandQueue = new List<QueuedLightCommand>();

        public HueLightsHandler(HueLightsData settings)
        {
            Connected = false;

            _settings = settings;

            Task.Run(Setup);

            commandQueueTimer.Elapsed += QueueTimerElapsed;
            commandQueueTimer.AutoReset = false;
        }

        private void QueueTimerElapsed(object sender, ElapsedEventArgs e)
        {
            QueuedLightCommand command = commandQueue.FirstOrDefault();
            if (command != null)
            {
                Task.Run(async () =>
                {
                    await client.SendCommandAsync(command.Command, command.Targets);
                });

                commandQueue.Remove(command);

                if (commandQueue.Count > 0)
                {
                    commandQueueTimer.Start();
                }
            }
        }

        private async Task Setup()
        {
            try
            {
                client = new LocalHueClient(_settings.BridgeIP);

                if (_settings.Registered)
                {
                    client.Initialize(_settings.AppKey);
                }
                else
                {
                    _settings.AppKey = await client.RegisterAsync("MidiDomotica", Environment.MachineName);
                }

                Connected = true;
            }
            catch (Exception e)
            {
                Trace.WriteLine("Error connecting to Hue Bridge: " + e.Message);
            }
        }

        public void SaveStates()
        {
            Task.Run(async () =>
            {
                lightStates = await client.GetLightsAsync();
            });
        }

        public void ResetStates()
        {
            Task.Run(async () =>
            {
                string[] lights = GetLightsInPosition("All");

                foreach (string light in lights)
                {
                    State state = lightStates.FirstOrDefault(l => l.Id == light).State;
                    if (state != null)
                    {
                        LightCommand command = new LightCommand()
                        {
                            Saturation = state.Saturation,
                            Brightness = state.Brightness,
                            ColorCoordinates = state.ColorCoordinates,
                            ColorTemperature = state.ColorTemperature,
                            Effect = state.Effect,
                            Hue = state.Hue,
                            On = state.On,
                        };

                        await client.SendCommandAsync(command, new string[] { light });
                    }
                }
            });
        }

        public void SetBrightness(int brightness)
        {
            Task.Run(() =>
            {
                string[] lights = GetLightsInPosition("All");

                LightCommand command = new LightCommand();

                command.Brightness = Convert.ToByte((int)(brightness / 100.00 * 255));

                commandQueue.Add(new QueuedLightCommand()
                {
                    Command = command,
                    Targets = lights,
                });

                if (!commandQueueTimer.Enabled)
                {
                    commandQueueTimer.Start();
                }
            });
        }

        public void ToggleLeftLights()
        {
            Task.Run(async () =>
            {
                string[] lights = GetLightsInPosition("Left");

                bool on = (await client.GetLightsAsync()).Where(l => lights.Any(x => x == l.Id)).All(l => !l.State.On);

                LightCommand command = new LightCommand();

                command.On = on;

                commandQueue.Add(new QueuedLightCommand()
                {
                    Command = command,
                    Targets = lights,
                });

                if (!commandQueueTimer.Enabled)
                {
                    commandQueueTimer.Start();
                }
            });
        }

        public void ToggleMidLights()
        {
            Task.Run(async () =>
            {
                string[] lights = GetLightsInPosition("Mid");

                bool on = (await client.GetLightsAsync()).Where(l => lights.Any(x => x == l.Id)).All(l => !l.State.On);

                LightCommand command = new LightCommand();

                command.On = on;

                commandQueue.Add(new QueuedLightCommand()
                {
                    Command = command,
                    Targets = lights,
                });

                if (!commandQueueTimer.Enabled)
                {
                    commandQueueTimer.Start();
                }
            });
        }

        public void ToggleRightLights()
        {
            Task.Run(async () =>
            {
                string[] lights = GetLightsInPosition("Right");

                bool on = (await client.GetLightsAsync()).Where(l => lights.Any(x => x == l.Id)).All(l => !l.State.On);

                LightCommand command = new LightCommand();

                command.On = on;

                commandQueue.Add(new QueuedLightCommand()
                {
                    Command = command,
                    Targets = lights,
                });

                if (!commandQueueTimer.Enabled)
                {
                    commandQueueTimer.Start();
                }
            });
        }

        public void ToggleFrontLights()
        {
            Task.Run(async () =>
            {
                string[] lights = GetLightsInPosition("Front");

                bool on = (await client.GetLightsAsync()).Where(l => lights.Any(x => x == l.Id)).All(l => !l.State.On);

                LightCommand command = new LightCommand();

                command.On = on;

                commandQueue.Add(new QueuedLightCommand()
                {
                    Command = command,
                    Targets = lights,
                });

                if (!commandQueueTimer.Enabled)
                {
                    commandQueueTimer.Start();
                }
            });
        }

        public void ToggleBackLights()
        {
            Task.Run(async () =>
            {
                string[] lights = GetLightsInPosition("Back");

                bool on = (await client.GetLightsAsync()).Where(l => lights.Any(x => x == l.Id)).All(l => !l.State.On);

                LightCommand command = new LightCommand();

                command.On = on;

                commandQueue.Add(new QueuedLightCommand()
                {
                    Command = command,
                    Targets = lights,
                });

                if (!commandQueueTimer.Enabled)
                {
                    commandQueueTimer.Start();
                }
            });
        }

        public void ToggleAllLights()
        {
            Task.Run(async () =>
            {
                string[] lights = GetLightsInPosition("All");

                bool on = (await client.GetLightsAsync()).Where(l => lights.Any(x => x == l.Id)).All(l => !l.State.On);

                LightCommand command = new LightCommand();

                command.On = on;

                commandQueue.Add(new QueuedLightCommand()
                {
                    Command = command,
                    Targets = lights,
                });

                if (!commandQueueTimer.Enabled)
                {
                    commandQueueTimer.Start();
                }
            });
        }

        private string[] GetLightsInPosition(string position)
        {
            switch (position.ToLower())
            {
                case "all":
                    return _settings.LightIds;

                case "left":
                    return _settings.LeftLightIds;

                case "mid":
                    return _settings.MidLightIds;

                case "right":
                    return _settings.RightLightIds;

                case "front":
                    return _settings.FrontLightIds;

                case "back":
                    return _settings.BackLightIds;

                default:
                    return new string[0];
            }
        }

        private class QueuedLightCommand
        {
            public LightCommand Command { get; set; }
            public IEnumerable<string> Targets { get; set; }
        }
    }
}
