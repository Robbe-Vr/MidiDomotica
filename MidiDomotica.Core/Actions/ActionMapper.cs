using MidiDomotica.Core.Actions.Interfaces;
using MidiDomotica.Exchange;
using MidiDomotica.Remote.AudioPlayer;
using MidiDomotica.Remote.Hue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Core.Actions
{
    public partial class ActionMapper : IAllActions
    {
        public ActionMapper(DefaultSettings settings)
        {
            hueManager = new HueManager(settings.Hue);
            audioPlayerHandler = new AudioPlayerHandler(settings.AudioPlayer);
        }
    }
}
