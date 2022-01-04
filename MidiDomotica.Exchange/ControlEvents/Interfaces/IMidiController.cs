using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MidiDomotica.Exchange.ControlEvents.EventLogic;

namespace MidiDomotica.Exchange.ControlEvents.Interfaces
{
    public interface IMidiController : IAllEvents
    {
        event EventHandler onDisconnect;
        event EventHandler onConnect;

        Note NoteForIndex(int noteIndex);

        bool TrySetMidiDevice(string deviceName);
        List<string> GetMidiDevices();
        void StopRecieving(bool manual = false, bool dispose = false);

        string CurrentMidiDevice { get; }

        MidiControllerMode CurrentMode { get; }

        int MsForHold { get; }
        int MsForDoubleClick { get; }
        bool Connected { get; }
    }
}
