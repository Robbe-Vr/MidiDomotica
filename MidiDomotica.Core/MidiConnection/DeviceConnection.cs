using MidiDomotica.MidiConnection;
using MidiDomotica.Exchange.ControlEvents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using MidiDomotica.Core.Persistence;
using MidiDomotica.Core.Actions.Interfaces;
using MidiDomotica.Core.Actions;
using MidiDomotica.Exchange;
using MidiDomotica.Exchange.UserDataClasses;
using System.Runtime.InteropServices;

namespace MidiDomotica.Core.MidiConnection
{
    public class DeviceConnection
    {
        private IMidiController _events;

        private IAllActions _actions;

        public IEnumerable<EventSubscriptionData> Subscriptions { get { return Subscriber.Subscriptions; } }
        
        private EventSubscriber Subscriber { get; }

        private DefaultSettings _settings;

        private ProcessEvents processEvents;

        public event EventHandler<NotifyEventArgs> onNotify;
        public class NotifyEventArgs : EventArgs
        {
            public string Title { get; set; }
            public string MessageStringFormat { get; set; }
            public string[] Params { get; set; }
        }

        public event EventHandler onMusicSyncStarted;
        public event EventHandler onMusicSyncStopped;

        public DeviceConnection(string defaultDeviceName, PersistenceHandler persistence, DefaultSettings settings)
        {
            _settings = settings;

            _events = MidiHandler.GetMidiController();
            _actions = new ActionMapper(_settings);
            _actions.onMusicSyncStart += (sender, e) => { onMusicSyncStarted?.Invoke(sender, new EventArgs()); };
            _actions.onMusicSyncStop += (sender, e) => { onMusicSyncStopped?.Invoke(sender, new EventArgs()); };

            Connect(defaultDeviceName);

            Subscriber = new EventSubscriber(_events, _actions, persistence);

            Subscriber.onNotify += (sender, e) =>
            {
                onNotify?.Invoke(sender, e);
            };

            _events.onDisconnect += (sender, e) =>
            {
                onNotify?.Invoke(sender, new NotifyEventArgs()
                {
                    Title = "Midi device disconnected",
                    MessageStringFormat = "The midi device has disconnected, please reconnect the midi device and reconnect to the midi device in the app in order for the app to work.",
                });
            };
            _events.onConnect += (sender, e) =>
            {
                onNotify?.Invoke(sender, new NotifyEventArgs()
                {
                    Title = "Midi device connected",
                    MessageStringFormat = "MidiDomotica has connected to a midi device name '{0}'.",
                    Params = new string[] { _events?.CurrentMidiDevice, },
                });
            };
        }

        public EventSubscriber GetSubscriber()
        {
            return Subscriber;
        }

        public bool Connect(string deviceName)
        {
            bool connected =_events.TrySetMidiDevice(deviceName);

            if (connected)
            {
                if (processEvents != null)
                {
                    processEvents.Dispose();
                    processEvents = null;
                }

                processEvents = new ProcessEvents(_settings.StopByProcesses);

                processEvents.processStarted += (sender, e) =>
                {
                    if (_events.Connected)
                    {
                        Disconnect(manual: true);
                        onNotify.Invoke(this, new NotifyEventArgs()
                        {
                            Title = "Midi device disconnected",
                            MessageStringFormat = "The midi device has disconnected manually because another app using the midi device has started, close this app and MidiDomotica will reconnect itself with the midi device.",
                            Params = new string[] { _events.CurrentMidiDevice },
                        });
                    }
                };
                processEvents.processEnded += (sender, e) =>
                {
                    if (!_events.Connected)
                    {
                        TryReconnect();
                    }
                };
            }

            return connected;
        }

        public bool TryReconnect()
        {
            try
            {
                if (Connect(_events.CurrentMidiDevice))
                {
                    onNotify.Invoke(this, new NotifyEventArgs()
                    {
                        Title = "Midi device connected",
                        MessageStringFormat = "Successfully connected to midi device '{0}'.",
                        Params = new string[] { _events.CurrentMidiDevice },
                    });
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine("Error changing midi-device: " + e.Message);

                return false;
            }
        }

        public void Disconnect(bool manual = false)
        {
            _events.StopRecieving(manual);
        }

        public T Events<T>() where T : IMidiEvents
        {
            return (T)_events;
        }

        public T Actions<T>() where T : IActions
        {
            return (T)_actions;
        }

        public void Dispose()
        {
            Subscriber.onNotify -= (sender, e) =>
            {
                onNotify?.Invoke(sender, e);
            };
            _events.onDisconnect -= (sender, e) =>
            {
                onNotify?.Invoke(sender, new NotifyEventArgs()
                {
                    Title = "Midi device disconnected",
                    MessageStringFormat = "The midi device has disconnected, please reconnect the midi device and reconnect to the midi device in the app in order for the app to work.",
                });
            };
            _events.onConnect -= (sender, e) =>
            {
                onNotify?.Invoke(sender, new NotifyEventArgs()
                {
                    Title = "Midi device connected",
                    MessageStringFormat = "MidiDomotica has connected to a midi device name '{0}'.",
                    Params = new string[] { _events.CurrentMidiDevice, },
                });
            };

            if (_events != null)
            {
                _events.StopRecieving(dispose: true);
                _events = null;
            }

            if (processEvents != null)
            {
                processEvents.Dispose();
                processEvents = null;
            }
        }
    }
}
