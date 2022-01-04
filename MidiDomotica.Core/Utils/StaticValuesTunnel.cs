using MidiDomotica.Remote.Hue.Entertainment.MusicSync;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Core.Utils
{
    public static class StaticValuesTunnel
    {
        public static double MusicSync_BrightnessAgression { get { return SynchronizerCorrectionValues.BrightnessAggression; } set { SynchronizerCorrectionValues.BrightnessAggression = value; } }
        public static int MusicSync_BrightnessField { get { return SynchronizerCorrectionValues.BrightnessField; } set { SynchronizerCorrectionValues.BrightnessField = value; } }
        public static double MusicSync_BrightnessThreshold { get { return SynchronizerCorrectionValues.BrightnessThreshold; } set { SynchronizerCorrectionValues.BrightnessThreshold = value; } }

        public static double MusicSync_BassIntensityAgression { get { return SynchronizerCorrectionValues.BassAggression; } set { SynchronizerCorrectionValues.BassAggression = value; } }
        public static int MusicSync_BassIntensityField { get { return SynchronizerCorrectionValues.BassIntensityField; } set { SynchronizerCorrectionValues.BassIntensityField = value; } }
        public static double MusicSync_BassIntensityThreshold { get { return SynchronizerCorrectionValues.BassIntensityThreshold; } set { SynchronizerCorrectionValues.BassIntensityThreshold = value; } }
        public static int[] MusicSync_BassIntensityColor { get { return SynchronizerCorrectionValues.BassIntensityColor; } set { SynchronizerCorrectionValues.BassIntensityColor = value; } }

        public static double MusicSync_UpperIntensityThreshold { get { return SynchronizerCorrectionValues.UpperIntensityThreshold; } set { SynchronizerCorrectionValues.UpperIntensityThreshold = value; } }

        public static void ResetMusicSync()
        {
            SynchronizerCorrectionValues.Reset();
        }
    }
}
