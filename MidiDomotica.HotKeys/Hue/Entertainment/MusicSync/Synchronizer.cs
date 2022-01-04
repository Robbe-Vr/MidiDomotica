using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Remote.Hue.Entertainment.MusicSync
{
    internal class Synchronizer
    {
        private double brightnessHis;
        private double maxbriJumpDown { get { return brightnessHis - SynchronizerCorrectionValues.BrightnessAggression; } }

        private double bassHis;
        private double maxbassJumpDown { get { return bassHis - SynchronizerCorrectionValues.BassAggression; } }

        public Synchronizer()
        {
        }

        public SyncJob CreateNextJob(double[] fftDataL, double[] fftDataR)
        {
            SyncJob job = new SyncJob
            {
                Left = new PositionedSyncJob(),
                Mid = new PositionedSyncJob(),
                Right = new PositionedSyncJob()
            };

            double briL = fftDataL?.Length > 0 ? GetBrightness(fftDataL) : 0.0;
            double briR = fftDataR?.Length > 0 ? GetBrightness(fftDataR) : 0.0;

            job.Left.Brightness = briL;
            job.Mid.Brightness = Math.Min(briL, briR);
            job.Right.Brightness = briR;

            double intensityL = fftDataL?.Length > 0 ? GetIntensity(fftDataL) : 0.0;
            double intensityR = fftDataR?.Length > 0 ? GetIntensity(fftDataR) : 0.0;

            double upperPeakL = fftDataL?.Length > 0 ? GetUpperPeak(fftDataL) * 0.92 : 0.0;;
            double upperPeakR = fftDataR?.Length > 0 ? GetUpperPeak(fftDataR) * 0.92 : 0.0;;

            job.Left.Blue = upperPeakL;
            job.Left.Green = upperPeakL * 0.74;
            job.Left.Red = intensityL;

            double upperPeakM = Math.Max(upperPeakL, upperPeakR);
            double intensityM = Math.Max(intensityL, intensityR);
            job.Mid.Blue = upperPeakM;
            job.Mid.Green = upperPeakM * 0.74;
            job.Mid.Red = intensityM;

            job.Right.Blue = upperPeakR;
            job.Right.Green = upperPeakR * 0.74;
            job.Right.Red = intensityR;

            return job;
        }

        private double GetUpperPeak(double[] fftData)
        {
            return (fftData.Skip(10).Max() / (SynchronizerCorrectionValues.UpperIntensityThreshold));
        }

        private double GetIntensity(double[] fftData)
        {
            double newIntensity = (fftData.Take(SynchronizerCorrectionValues.BassIntensityField).Average() / SynchronizerCorrectionValues.BassIntensityThreshold);

            if (newIntensity < maxbassJumpDown)
                newIntensity = maxbassJumpDown;

            bassHis = newIntensity;
            return newIntensity;
        }

        private double GetBrightness(double[] fftData)
        {
            double newBri = (fftData.Take(8).Max() / SynchronizerCorrectionValues.BrightnessThreshold);

            if (newBri < maxbriJumpDown)
                newBri = maxbriJumpDown;

            brightnessHis = newBri;
            return newBri;
        }

        public void Dispose()
        {

        }

        internal class SyncJob
        {
            public PositionedSyncJob Left { get; set; }
            public PositionedSyncJob Mid { get; set; }
            public PositionedSyncJob Right { get; set; }
        }

        internal class PositionedSyncJob
        {
            public double Brightness { get; set; }
            public double Red { get; set; }
            public double Green { get; set; }
            public double Blue { get; set; }
            public bool Urgent { get; set; }
        }
    }
}
