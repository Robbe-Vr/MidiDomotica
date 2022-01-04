using MidiDomotica.Core.MidiConnection;
using MidiDomotica.Core.Persistence;
using MidiDomotica.Core.Utils;
using MidiDomotica.Exchange;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiDomotica
{
    public partial class MidiDomotica
    {
        private Form musicSyncConfigurer;

        private Panel musicSyncConfigPanel;

        

        private void ShowMusicSyncConfigPanel()
        {
            musicSyncConfigurer = new Form();
            musicSyncConfigurer.FormBorderStyle = FormBorderStyle.FixedSingle;
            musicSyncConfigurer.Size = new Size(800, 500);
            musicSyncConfigurer.Width = 800;
            musicSyncConfigurer.Height = 500;

            musicSyncConfigurer.FormClosing += (sender, e) => { e.Cancel = true; (sender as Form).WindowState = FormWindowState.Minimized; };

            musicSyncConfigPanel = new Panel();
            musicSyncConfigurer.Controls.Add(musicSyncConfigPanel);
            musicSyncConfigPanel.Location = new Point(0, 0);
            musicSyncConfigPanel.Size = new Size(musicSyncConfigurer.Width - 20, musicSyncConfigurer.Height -10);
            musicSyncConfigPanel.BorderStyle = BorderStyle.FixedSingle;
            musicSyncConfigPanel.AutoScroll = true;

            // Brightness Correction
            Label brightnessCorrectionSliderText = new Label();
            musicSyncConfigPanel.Controls.Add(brightnessCorrectionSliderText);
            brightnessCorrectionSliderText.Location = new Point(0, (musicSyncConfigPanel.Height / 6) + 22);
            brightnessCorrectionSliderText.Size = new Size(musicSyncConfigPanel.Width / 2, musicSyncConfigPanel.Height / 6 + 22);
            brightnessCorrectionSliderText.Text = "Brightness Threshold:";

            TrackBar brightnessCorrectionSlider = new TrackBar();
            musicSyncConfigPanel.Controls.Add(brightnessCorrectionSlider);
            brightnessCorrectionSlider.Location = new Point(musicSyncConfigPanel.Width / 2, (musicSyncConfigPanel.Height / 6) + 22);
            brightnessCorrectionSlider.Size = new Size(musicSyncConfigPanel.Width / 2, musicSyncConfigPanel.Height / 6 + 22);
            brightnessCorrectionSlider.Minimum = 1;
            brightnessCorrectionSlider.Maximum = 40;
            brightnessCorrectionSlider.Value = (int)(StaticValuesTunnel.MusicSync_BrightnessThreshold * 2);
            brightnessCorrectionSlider.ValueChanged += (object sender, EventArgs e) =>
            {
                StaticValuesTunnel.MusicSync_BrightnessThreshold = brightnessCorrectionSlider.Value / 2.00;
            };

            // Brightness Aggression
            Label brightnessAgressionSliderText = new Label();
            musicSyncConfigPanel.Controls.Add(brightnessAgressionSliderText);
            brightnessAgressionSliderText.Location = new Point(0, ((musicSyncConfigPanel.Height / 6) * 2) + 22);
            brightnessAgressionSliderText.Size = new Size(musicSyncConfigPanel.Width / 2, musicSyncConfigPanel.Height / 6);
            brightnessAgressionSliderText.Text = "Brightness Agression:";

            TrackBar brightnessAgressionSlider = new TrackBar();
            musicSyncConfigPanel.Controls.Add(brightnessAgressionSlider);
            brightnessAgressionSlider.Location = new Point(musicSyncConfigPanel.Width / 2, ((musicSyncConfigPanel.Height / 6) * 2) + 22);
            brightnessAgressionSlider.Size = new Size(musicSyncConfigPanel.Width / 2, musicSyncConfigPanel.Height / 6);
            brightnessAgressionSlider.Minimum = 1;
            brightnessAgressionSlider.Maximum = 100;
            brightnessAgressionSlider.Value = (int)(StaticValuesTunnel.MusicSync_BrightnessAgression * 100);
            brightnessAgressionSlider.ValueChanged += (object sender, EventArgs e) =>
            {
                StaticValuesTunnel.MusicSync_BrightnessAgression = brightnessAgressionSlider.Value / 100.00;
            };

            // Brightness Field
            Label brightnessFieldSliderText = new Label();
            musicSyncConfigPanel.Controls.Add(brightnessFieldSliderText);
            brightnessFieldSliderText.Location = new Point(0, ((musicSyncConfigPanel.Height / 6) * 3) + 22);
            brightnessFieldSliderText.Size = new Size(musicSyncConfigPanel.Width / 2, musicSyncConfigPanel.Height / 6);
            brightnessFieldSliderText.Text = "Brightness Detection Field:";

            TrackBar brightnessFieldSlider = new TrackBar();
            musicSyncConfigPanel.Controls.Add(brightnessFieldSlider);
            brightnessFieldSlider.Location = new Point(musicSyncConfigPanel.Width / 2, ((musicSyncConfigPanel.Height / 6) * 3) + 22);
            brightnessFieldSlider.Size = new Size(musicSyncConfigPanel.Width / 2, musicSyncConfigPanel.Height / 6);
            brightnessFieldSlider.Minimum = 2;
            brightnessFieldSlider.Maximum = 50;
            brightnessFieldSlider.Value = StaticValuesTunnel.MusicSync_BrightnessField;
            brightnessFieldSlider.ValueChanged += (object sender, EventArgs e) =>
            {
                StaticValuesTunnel.MusicSync_BrightnessField = brightnessFieldSlider.Value;
            };

            // Bass Intensity Correction
            Label bassIntensityCorrectionSliderText = new Label();
            musicSyncConfigPanel.Controls.Add(bassIntensityCorrectionSliderText);
            bassIntensityCorrectionSliderText.Location = new Point(0, ((musicSyncConfigPanel.Height / 6) * 4) + 22);
            bassIntensityCorrectionSliderText.Size = new Size(musicSyncConfigPanel.Width / 2, musicSyncConfigPanel.Height / 6);
            bassIntensityCorrectionSliderText.Text = "Bass Intensity Threshold:";

            TrackBar bassIntensityCorrectionSlider = new TrackBar();
            musicSyncConfigPanel.Controls.Add(bassIntensityCorrectionSlider);
            bassIntensityCorrectionSlider.Location = new Point(musicSyncConfigPanel.Width / 2, ((musicSyncConfigPanel.Height / 6) * 4) + 22);
            bassIntensityCorrectionSlider.Size = new Size(musicSyncConfigPanel.Width / 2, musicSyncConfigPanel.Height / 6);
            bassIntensityCorrectionSlider.Minimum = 1;
            bassIntensityCorrectionSlider.Maximum = 40;
            bassIntensityCorrectionSlider.Value = (int)(StaticValuesTunnel.MusicSync_BassIntensityThreshold * 2);
            bassIntensityCorrectionSlider.ValueChanged += (object sender, EventArgs e) =>
            {
                StaticValuesTunnel.MusicSync_BassIntensityThreshold = bassIntensityCorrectionSlider.Value / 2.00;
            };

            // Bass Field
            Label bassFieldSliderText = new Label();
            musicSyncConfigPanel.Controls.Add(bassFieldSliderText);
            bassFieldSliderText.Location = new Point(0, ((musicSyncConfigPanel.Height / 6) * 5) + 22);
            bassFieldSliderText.Size = new Size(musicSyncConfigPanel.Width / 2, musicSyncConfigPanel.Height / 6);
            bassFieldSliderText.Text = "Bass Intensity Detection Field:";

            TrackBar bassFieldSlider = new TrackBar();
            musicSyncConfigPanel.Controls.Add(bassFieldSlider);
            bassFieldSlider.Location = new Point(musicSyncConfigPanel.Width / 2, ((musicSyncConfigPanel.Height / 6) * 5) + 22);
            bassFieldSlider.Size = new Size(musicSyncConfigPanel.Width / 2, musicSyncConfigPanel.Height / 6);
            bassFieldSlider.Minimum = 2;
            bassFieldSlider.Maximum = 25;
            bassFieldSlider.Value = StaticValuesTunnel.MusicSync_BassIntensityField;
            bassFieldSlider.ValueChanged += (object sender, EventArgs e) =>
            {
                StaticValuesTunnel.MusicSync_BassIntensityField = bassFieldSlider.Value;
            };

            // Bass Agression
            Label bassAgressionSliderText = new Label();
            musicSyncConfigPanel.Controls.Add(bassAgressionSliderText);
            bassAgressionSliderText.Location = new Point(0, ((musicSyncConfigPanel.Height / 6) * 6) + 22);
            bassAgressionSliderText.Size = new Size(musicSyncConfigPanel.Width / 2, musicSyncConfigPanel.Height / 6);
            bassAgressionSliderText.Text = "Bass Agression:";

            TrackBar bassAgressionSlider = new TrackBar();
            musicSyncConfigPanel.Controls.Add(bassAgressionSlider);
            bassAgressionSlider.Location = new Point(musicSyncConfigPanel.Width / 2, ((musicSyncConfigPanel.Height / 6) * 6) + 22);
            bassAgressionSlider.Size = new Size(musicSyncConfigPanel.Width / 2, musicSyncConfigPanel.Height / 6);
            bassAgressionSlider.Minimum = 1;
            bassAgressionSlider.Maximum = 100;
            bassAgressionSlider.Value = (int)(StaticValuesTunnel.MusicSync_BassIntensityAgression * 100);
            bassAgressionSlider.ValueChanged += (object sender, EventArgs e) =>
            {
                StaticValuesTunnel.MusicSync_BassIntensityAgression = bassAgressionSlider.Value / 100.00;
            };

            // Bass Color
            Label bassColorRGBInputText = new Label();
            musicSyncConfigPanel.Controls.Add(bassColorRGBInputText);
            bassColorRGBInputText.Location = new Point(0, ((musicSyncConfigPanel.Height / 6) * 7) + 22);
            bassColorRGBInputText.Size = new Size(musicSyncConfigPanel.Width / 2, musicSyncConfigPanel.Height / 6);
            bassColorRGBInputText.Text = "Bass RGB Color: (ineffective)";

            TrackBar bassColorRGBInputRed = new TrackBar();
            musicSyncConfigPanel.Controls.Add(bassColorRGBInputRed);
            bassColorRGBInputRed.Location = new Point(musicSyncConfigPanel.Width / 2, ((musicSyncConfigPanel.Height / 6) * 7) + 22);
            bassColorRGBInputRed.Size = new Size((musicSyncConfigPanel.Width / 6) - 10, musicSyncConfigPanel.Height / 6);
            bassColorRGBInputRed.Minimum = 0;
            bassColorRGBInputRed.Maximum = 255;
            bassColorRGBInputRed.Value = StaticValuesTunnel.MusicSync_BassIntensityColor[0];

            TrackBar bassColorRGBInputGreen = new TrackBar();
            musicSyncConfigPanel.Controls.Add(bassColorRGBInputGreen);
            bassColorRGBInputGreen.Location = new Point((musicSyncConfigPanel.Width / 2) + (musicSyncConfigPanel.Width / 6 /* (x / 2) / 3 == x / 6 */), ((musicSyncConfigPanel.Height / 6) * 7) + 22);
            bassColorRGBInputGreen.Size = new Size((musicSyncConfigPanel.Width / 6) - 10, musicSyncConfigPanel.Height / 6);
            bassColorRGBInputGreen.Minimum = 0;
            bassColorRGBInputGreen.Maximum = 255;
            bassColorRGBInputGreen.Value = StaticValuesTunnel.MusicSync_BassIntensityColor[1];

            TrackBar bassColorRGBInputBlue = new TrackBar();
            musicSyncConfigPanel.Controls.Add(bassColorRGBInputBlue);
            bassColorRGBInputBlue.Location = new Point((musicSyncConfigPanel.Width / 2) + (musicSyncConfigPanel.Width / 3 /* (x / 6) * 2 == x / 3 */), ((musicSyncConfigPanel.Height / 6) * 7) + 22);
            bassColorRGBInputBlue.Size = new Size((musicSyncConfigPanel.Width / 6) - 10, musicSyncConfigPanel.Height / 6);
            bassColorRGBInputBlue.Minimum = 0;
            bassColorRGBInputBlue.Maximum = 255;
            bassColorRGBInputBlue.Value = StaticValuesTunnel.MusicSync_BassIntensityColor[2];

            Action setBassColor = () =>
            {
                StaticValuesTunnel.MusicSync_BassIntensityColor = new int[] { bassColorRGBInputRed.Value, bassColorRGBInputGreen.Value, bassColorRGBInputBlue.Value };
            };

            bassColorRGBInputRed.ValueChanged += (object sender, EventArgs e) =>
            {
                setBassColor();
            };

            // Bass Field
            Label upperIntensityCorrectionSliderText = new Label();
            musicSyncConfigPanel.Controls.Add(upperIntensityCorrectionSliderText);
            upperIntensityCorrectionSliderText.Location = new Point(0, ((musicSyncConfigPanel.Height / 6) * 8) + 22);
            upperIntensityCorrectionSliderText.Size = new Size(musicSyncConfigPanel.Width / 2, musicSyncConfigPanel.Height / 6);
            upperIntensityCorrectionSliderText.Text = "Upper Intensity Threshold:";

            TrackBar upperIntensityCorrectionSlider = new TrackBar();
            musicSyncConfigPanel.Controls.Add(upperIntensityCorrectionSlider);
            upperIntensityCorrectionSlider.Location = new Point(musicSyncConfigPanel.Width / 2, ((musicSyncConfigPanel.Height / 6) * 8) + 22);
            upperIntensityCorrectionSlider.Size = new Size(musicSyncConfigPanel.Width / 2, musicSyncConfigPanel.Height / 6);
            upperIntensityCorrectionSlider.Minimum = 1;
            upperIntensityCorrectionSlider.Maximum = 20;
            upperIntensityCorrectionSlider.Value = (int)(StaticValuesTunnel.MusicSync_UpperIntensityThreshold * 2);
            upperIntensityCorrectionSlider.ValueChanged += (object sender, EventArgs e) =>
            {
                StaticValuesTunnel.MusicSync_UpperIntensityThreshold = upperIntensityCorrectionSlider.Value / 2.0;
            };

            // Reset Button
            Button resetButton = new Button();
            musicSyncConfigPanel.Controls.Add(resetButton);
            resetButton.Location = new Point(2, 2);
            resetButton.Size = new Size(musicSyncConfigPanel.Width / 2, 60);
            resetButton.Text = "Reset to Default";
            resetButton.Click += (sender, e) =>
            {
                StaticValuesTunnel.ResetMusicSync();

                brightnessCorrectionSlider.Value = (int)StaticValuesTunnel.MusicSync_BrightnessThreshold;
                brightnessFieldSlider.Value = StaticValuesTunnel.MusicSync_BrightnessField;

                bassIntensityCorrectionSlider.Value = (int)StaticValuesTunnel.MusicSync_BassIntensityThreshold;
                bassFieldSlider.Value = StaticValuesTunnel.MusicSync_BassIntensityField;

                bassColorRGBInputRed.Value = StaticValuesTunnel.MusicSync_BassIntensityColor[0];
                bassColorRGBInputGreen.Value = StaticValuesTunnel.MusicSync_BassIntensityColor[1];
                bassColorRGBInputBlue.Value = StaticValuesTunnel.MusicSync_BassIntensityColor[2];

                upperIntensityCorrectionSlider.Value = (int)StaticValuesTunnel.MusicSync_UpperIntensityThreshold;
            };

            musicSyncConfigPanel.Update();
            musicSyncConfigurer.Update();

            musicSyncConfigurer.Show();
        }
    }
}
