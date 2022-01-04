using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using MidiDomotica.MidiConnection.Events;
using Sanford.Collections;
using Sanford.Multimedia;
using Sanford.Multimedia.Midi;
using Timer = System.Timers.Timer;

namespace MidiDomotica.MidiConnection
{
    internal class MidiReciever
    {
        private InputDevice midiDevice;
        private ChannelStopper channelStopper;

        public string CurrentMidiDevice { get; private set; }
        public bool Connected { get { return midiDevice != null; } }
        public bool ManualDisconnect { get; set; }

        public event EventHandler onDisconnect;
        public event EventHandler onConnect;
        private Timer connectionCheckTimer;

        private DateTime lastActivity;

        private List<MessageData> eventsList;
        private Timer eventsPursuer;

        internal MidiReciever()
        {
            eventsList = new List<MessageData>();

            eventsPursuer = new Timer(5);
            eventsPursuer.AutoReset = false;
            eventsPursuer.Elapsed += onPursueNextEvent;

            connectionCheckTimer = new Timer(5000);
            connectionCheckTimer.AutoReset = false;
            connectionCheckTimer.Elapsed += (sender, e) =>
            {
                CheckDeviceHandle();
            };
        }

        private void CheckDeviceHandle()
        {
            if (lastActivity < DateTime.Now.AddMilliseconds(-500) && Connected)
            {
                StopRecieving();
            }
            else if(!ManualDisconnect && !Connected)
            {
                SetMidiDevice(CurrentMidiDevice);
            }

            connectionCheckTimer.Start();
        }

        internal List<string> GetMidiDevices()
        {
            List<string> list = new List<string>();

            for (int i = 0; i < InputDevice.DeviceCount; i++)
            {
                var caps = InputDevice.GetDeviceCapabilities(i);

                list.Add(caps.name);
            }

            return list;
        }

        internal bool SetMidiDevice(string deviceName)
        {
            int deviceId = -1;

            for (int i = 0; i < InputDevice.DeviceCount; i++)
            {
                var caps = InputDevice.GetDeviceCapabilities(i);

                Trace.WriteLine($"Device {i}:\n    Name = {caps.name}\n    Mid = {caps.mid}\n    Pid = {caps.pid}\n    Support = {caps.support}");

                if (caps.name == deviceName)
                {
                    deviceId = i;

                    CurrentMidiDevice = caps.name;
                }
            }

            if (deviceId > -1)
            {
                if (Connect(deviceId))
                {
                    onConnect?.Invoke(this, new EventArgs());
                    Trace.WriteLine("Midi logging started on midi device: " + deviceName + ".");
                    return true;
                }
                else
                {
                    Trace.WriteLine("Failed to connect to midi-device with name: " + deviceName);
                    return false;
                }
            }
            else
            {
                Trace.WriteLine("No midi-device found with name: " + deviceName);
                return false;
            }
        }

        private bool Connect(int deviceId)
        {
            connectionCheckTimer.Enabled = false;

            if (midiDevice != null)
            {
                StopRecieving(log: false);
            }

            string err = "Unspecified error.";
            int attemptsCount = 10;
            int attempt = 0;
            while (midiDevice == null && attempt < attemptsCount)
            {
                try
                {
                    midiDevice = new InputDevice(deviceId);
                }
                catch (Exception e)
                {
                    err = e.Message;
                    attempt++;

                    Thread.Sleep(100);
                }
            }

            if (midiDevice == null)
            {
                Trace.WriteLine(err);
                return false;
            }

            channelStopper = new ChannelStopper();

            midiDevice.ChannelMessageReceived += onChannelMessage;
            midiDevice.ShortMessageReceived += onShortMessage;
            midiDevice.SysCommonMessageReceived += onSysCommonMessage;
            midiDevice.SysExMessageReceived += onSysExMessage;
            midiDevice.SysRealtimeMessageReceived += onSysRealtimeMessage;
            midiDevice.Error += onError;
            midiDevice.InvalidShortMessageReceived += onInvalidShortMessage;
            midiDevice.InvalidSysExMessageReceived += onInvalidSysExMessage;

            midiDevice.StartRecording();

            connectionCheckTimer.Enabled = true;

            return true;
        }

        internal void StopRecieving(bool log = true)
        {
            connectionCheckTimer.Enabled = false;

            if (midiDevice != null)
            {
                try
                {
                    midiDevice.StopRecording();
                }
                catch (Exception e) { Trace.WriteLine(e.Message); }

                midiDevice.Close();
                midiDevice.Dispose();
                midiDevice = null;
            }
            if (channelStopper != null)
            {
                channelStopper.AllSoundOff();
                channelStopper.Reset();
                channelStopper = null;
            }

            if (log)
            {
                Trace.WriteLine("Midi logging stopped.");
                onDisconnect?.Invoke(this, new EventArgs());
            }

            connectionCheckTimer.Enabled = true;
        }

        private void onPursueNextEvent(object sender, ElapsedEventArgs ea)
        {
            if (eventsList.Count < 1) { return; }

            MessageData e = eventsList[0];

            eventsList.Remove(e);

            if (eventsList.Count > 0)
            {
                eventsPursuer.Start();
            }

            PursueEvent(e);
        }

        private void PursueEvent(MessageData messageData)
        {
            ((EventHandler<MidiMessageRecievedEventArgs>)listEventDelegates[midiMessageRecievedEventKey])?.Invoke(this, new MidiMessageRecievedEventArgs()
            {
                Message = messageData,
                TimeStamp = DateTime.Now.ToBinary(),
            });
        }

        private void TriggerEvent(int timeStamp, int midiChannel, string messageType, int status, string command, int data1, int data2, byte[] messageBytes)
        {
            lastActivity = DateTime.Now;

            MessageData e = new MessageData()
            {
                MsSinceStart = timeStamp,
                MidiChannel = midiChannel,
                MessageType = messageType,
                Status = status,
                Command = command,
                Data1 = data1,
                Data2 = data2,
                MessageBytes = messageBytes,
            };

            if (eventsList.Count > 0)
            {
                int eventIndex = eventsList.FindIndex(x => x.Status == status);
                if (eventIndex >= 0)
                {
                    if (eventsList.Count >= eventIndex - 1)
                        eventsList[eventIndex] = e;
                }
                else
                {
                    eventsList.Add(e);
                }

                if (eventsPursuer.Enabled == false)
                {
                    eventsPursuer.Start();
                }
            }
            else if (eventsPursuer.Enabled)
            {
                eventsList.Add(e);
            }
            else
            {
                eventsPursuer.Start();

                PursueEvent(e);
            }
        }

        private void onInvalidSysExMessage(object sender, InvalidSysExMessageEventArgs e)
        {
            string messages = "";

            foreach (var message in e.MessageData)
            {
                messages += message.ToString();
            }

            Trace.WriteLine("Invalid message! Count: " + e.MessageData.Count + "\n" +
                messages);
        }

        private void onInvalidShortMessage(object sender, InvalidShortMessageEventArgs e)
        {
            Trace.WriteLine("Invalid short message! Message: " + e.Message);
        }

        private void onError(object sender, ErrorEventArgs e)
        {
            Trace.WriteLine("Midi device error! Source: " + e.Error.Source +
                "Message: " + e.Error.Message + "\n" +
                "StackTrace: " + e.Error.StackTrace);
        }

        private void onSysRealtimeMessage(object sender, SysRealtimeMessageEventArgs e)
        {
            if (e.Message.SysRealtimeType == SysRealtimeType.Clock)
            {
                lastActivity = DateTime.Now;
                return;
            }

            TriggerEvent(e.Message.Timestamp, -1, e.Message.MessageType.ToString(), e.Message.Status,
                e.Message.SysRealtimeType.ToString(), -1, -1, e.Message.Bytes);
        }

        private void onSysExMessage(object sender, SysExMessageEventArgs e)
        {
            TriggerEvent(e.Message.Timestamp, -1, e.Message.MessageType.ToString(), e.Message.Status,
                 e.Message.SysExType.ToString(), -1, -1, null);
        }

        private void onSysCommonMessage(object sender, SysCommonMessageEventArgs e)
        {
            TriggerEvent(e.Message.Timestamp, -1, e.Message.MessageType.ToString(), e.Message.Status,
                e.Message.SysCommonType.ToString(), e.Message.Data1, e.Message.Data2, e.Message.Bytes);
        }

        private void onShortMessage(object sender, ShortMessageEventArgs e)
        {
            if (e.Message.Status == 248 && (e.Message.Bytes[0] == 248 && e.Message.Bytes[1] == 0 && e.Message.Bytes[2] == 0)) return;

            TriggerEvent(e.Message.Timestamp, -1, e.Message.MessageType.ToString(), e.Message.Status,
                null, -1, -1, e.Message.Bytes);
        }

        private void onChannelMessage(object sender, ChannelMessageEventArgs e)
        {
            TriggerEvent(e.Message.Timestamp, e.Message.MidiChannel, e.Message.MessageType.ToString(), e.Message.Status,
                null, e.Message.Data1, e.Message.Data2, e.Message.Bytes);

            channelStopper?.Process(e.Message);
        }

        protected EventHandlerList listEventDelegates = new EventHandlerList();

        static readonly object midiMessageRecievedEventKey = new object();

        internal event EventHandler<MidiMessageRecievedEventArgs> MidiMessageRecieved
        {
            add
            {
                listEventDelegates.AddHandler(midiMessageRecievedEventKey, value);
            }

            remove
            {
                listEventDelegates.RemoveHandler(midiMessageRecievedEventKey, value);
            }
        }
    }
}
