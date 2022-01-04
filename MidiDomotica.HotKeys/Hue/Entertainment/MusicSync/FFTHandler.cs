using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Remote.Hue.Entertainment.MusicSync
{
    internal class FFTHandler
    {
        private const int RATE = 44100; // sample rate of the sound card
        private const int power = 15;
        private readonly int BUFFERSIZE = (int)Math.Pow(2, power); // must be a multiple of 2

        public MemoryStream MemoryStream { get; private set; }
        public int BufferSize { get { return BUFFERSIZE; } }

        public FFTHandler()
        {
            MemoryStream = new MemoryStream(BUFFERSIZE);
        }

        public double[][] PerformFFT(WaveFormat waveFormat)
        {
            int frameSize = BUFFERSIZE;
            var audioBytes = new byte[frameSize];

            using (RawSourceWaveStream stream = new RawSourceWaveStream(MemoryStream, waveFormat))
            {
                stream.Position = 0;
                stream.Read(audioBytes, 0, frameSize);
                MemoryStream.Close();
                MemoryStream = new MemoryStream(BUFFERSIZE);
            }

            // incoming data is 32-bit (4 bytes per audio point)
            int BYTES_PER_POINT = waveFormat.BitsPerSample / 4;

            // return if there's nothing new to plot
            if (audioBytes.Length == 0)
                return new double[0][];
            //if (audioBytes.Take(BYTES_PER_POINT).Max() == 0)
            //    return;

            // create a (32-bit) int array ready to fill with the 16-bit data
            int graphPointCount = audioBytes.Length / BYTES_PER_POINT;

            // create double arrays to hold the data we will graph
            double[] pcmL = new double[graphPointCount];
            double[] pcmR = new double[graphPointCount];

            double[] fftL;
            double[] fftR;

            double[] fftRealL = new double[graphPointCount / BYTES_PER_POINT];
            double[] fftRealR = new double[graphPointCount / BYTES_PER_POINT];

            // populate Xs and Ys with double data
            for (int i = 0; i < graphPointCount; i++)
            {
                // read the int16 from the two bytes
                Int16 valL = BitConverter.ToInt16(audioBytes, i * 2);
                Int16 valR = BitConverter.ToInt16(audioBytes, (i * 2) + waveFormat.BitsPerSample / 4);

                // store the value in Ys as a percent (+/- 100% = 200%)
                pcmL[i] = (double)(valL) / Math.Pow(2, 16) * 200.0;
                pcmR[i] = (double)(valR) / Math.Pow(2, 16) * 200.0;
            }

            // calculate the full FFT
            fftL = DoFastFourierTransformation(pcmL);
            fftR = DoFastFourierTransformation(pcmR);

            // just keep the real half (the other half imaginary)
            Array.Copy(fftL, fftRealL, fftRealL.Length);
            Array.Copy(fftR, fftRealR, fftRealR.Length);

            return new double[][] { fftRealL, fftRealR };
        }

        private double[] DoFastFourierTransformation(double[] data)
        {
            double[] fft = new double[data.Length];
            System.Numerics.Complex[] fftComplex = new System.Numerics.Complex[data.Length];
            for (int i = 0; i < data.Length; i++)
                fftComplex[i] = new System.Numerics.Complex(data[i], 0.0);
            Accord.Math.FourierTransform.FFT(fftComplex, Accord.Math.FourierTransform.Direction.Forward);
            for (int i = 0; i < data.Length; i++)
                fft[i] = fftComplex[i].Magnitude;
            return fft;
        }

        public void Dispose()
        {

        }
    }
}
