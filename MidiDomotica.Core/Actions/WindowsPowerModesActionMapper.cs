using MidiDomotica.Exchange.ActionObjects;
using MidiDomotica.Remote.Windows.PowerModes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Core.Actions
{
    public partial class ActionMapper
    {
        private static WindowsPowerModesHandler powerModesHandler = new WindowsPowerModesHandler();

        public static IEnumerable<WindowsPowerMode> PowerModes { get { powerModesHandler = new WindowsPowerModesHandler(); return powerModesHandler.WindowsPowerModes; } }

        public void SetPowerMode(string powerModeName)
        {
            powerModesHandler = new WindowsPowerModesHandler();
            var powerMode = powerModesHandler.WindowsPowerModes?.FirstOrDefault(p => p.Name == powerModeName);
            if (powerMode == null)
            {
                throw new ArgumentException($"Unable to find a power mode by name '{powerModeName}'.");
            }

            powerModesHandler.SetPowerMode(powerMode);
        }
    }
}
