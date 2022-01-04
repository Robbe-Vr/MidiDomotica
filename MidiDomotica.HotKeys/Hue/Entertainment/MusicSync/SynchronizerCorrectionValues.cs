using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Remote.Hue.Entertainment.MusicSync
{
    public static class SynchronizerCorrectionValues
    {
        public static double BrightnessAggression { get; set; }
        public static int BrightnessField { get; set; }
        public static double BrightnessThreshold { get; set; }

        public static double BassAggression { get; set; }
        public static double BassIntensityThreshold { get; set; }
        public static int BassIntensityField { get; set; }
        public static int[] BassIntensityColor { get; set; }

        public static double UpperIntensityThreshold { get; set; }

        public static void Reset()
        {
            BrightnessAggression = 0.02;
            BrightnessField = 8;
            BrightnessThreshold = 10.0;

            BassAggression = 0.08;
            BassIntensityThreshold = 10.0;
            BassIntensityField = 3;
            BassIntensityColor = new int[] { 255, 0, 0 };

            UpperIntensityThreshold = 4.00;
        }
    }
}
