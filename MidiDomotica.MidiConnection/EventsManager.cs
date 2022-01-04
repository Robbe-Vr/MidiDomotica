using MidiDomotica.Exchange.ControlEvents.Interfaces;
using MidiDomotica.MidiConnection.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MidiDomotica.MidiConnection
{
    public class EventsManager : EventsMapper, IMidiController
    {
        private MidiReciever midiReciever;

        public event EventHandler onDisconnect;
        public event EventHandler onConnect;

        public EventsManager()
        {
            midiReciever = new MidiReciever();

            midiReciever.onDisconnect += (sender, e) =>
            {
                onDisconnect?.Invoke(sender, e);
            };
            midiReciever.onConnect += (sender, e) =>
            {
                onConnect?.Invoke(sender, e);
            };
        }

        public string CurrentMidiDevice { get { return midiReciever.CurrentMidiDevice; } }
        public bool Connected { get { return midiReciever.Connected; } }

        public List<string> GetMidiDevices()
        {
            return midiReciever.GetMidiDevices();
        }

        public bool TrySetMidiDevice(string deviceName)
        {
            if (midiReciever.SetMidiDevice(deviceName))
            {
                midiReciever.MidiMessageRecieved += onMidiMessage;

                return true;
            }

            midiReciever.ManualDisconnect = false;

            return false;
        }

        public void StopRecieving(bool manual = false, bool dispose = false)
        {
            if (dispose)
            {
                midiReciever.onDisconnect -= (sender, e) =>
                {
                    onDisconnect?.Invoke(sender, e);
                };
                midiReciever.onConnect -= (sender, e) =>
                {
                    onConnect?.Invoke(sender, e);
                };

                midiReciever.StopRecieving(log: false);
                midiReciever = null;
            }
            else
            {
                midiReciever.ManualDisconnect = manual;

                if (midiReciever != null)
                {
                    midiReciever.StopRecieving(log: !manual);
                }
            }
        }
    }
}
