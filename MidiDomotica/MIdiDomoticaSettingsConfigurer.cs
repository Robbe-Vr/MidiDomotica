using MidiDomotica.Core.MidiConnection;
using MidiDomotica.Core.Persistence;
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
        private Form defaultSettingsConfigurer;

        private Panel configPanel;

        enum SettingsMode
        {
            Default = 0,
            AudioPlayer,
            Hue,
        }
        private SettingsMode _settingsMode = SettingsMode.Default;
        private SettingsMode settingsMode { get { return _settingsMode; } set { _settingsMode = value; StructureSettingsConfigurer(); } }
        private Type _settingsFilterType
        {
            get
            {
                switch (settingsMode)
                {
                    case SettingsMode.Default: return typeof(DefaultSettings);
                    case SettingsMode.AudioPlayer: return typeof(AudioPlayerData);
                    case SettingsMode.Hue: return typeof(HueLightsData);
                    default: return typeof(DefaultSettings);
                }
            }
        }

        private void ShowSettingsConfigPanel()
        {
            defaultSettingsConfigurer = new Form();
            defaultSettingsConfigurer.FormBorderStyle = FormBorderStyle.FixedSingle;
            defaultSettingsConfigurer.Size = new Size(800, 500);
            defaultSettingsConfigurer.Width = 800;
            defaultSettingsConfigurer.Height = 500;

            Panel optionsPanel = new Panel();
            defaultSettingsConfigurer.Controls.Add(optionsPanel);
            optionsPanel.Location = new Point(0, 0);
            optionsPanel.Size = new Size(defaultSettingsConfigurer.Width - 20, defaultSettingsConfigurer.Height / 5);
            optionsPanel.BorderStyle = BorderStyle.FixedSingle;

            configPanel = new Panel();
            defaultSettingsConfigurer.Controls.Add(configPanel);
            configPanel.Location = new Point(0, defaultSettingsConfigurer.Height / 5);
            configPanel.Size = new Size(defaultSettingsConfigurer.Width - 20, (int)(defaultSettingsConfigurer.Height * 0.7));
            configPanel.BorderStyle = BorderStyle.FixedSingle;
            configPanel.VerticalScroll.Visible = true;
            configPanel.VerticalScroll.Enabled = true;
            configPanel.AutoScroll = true;

            Button defaultOption = new Button();
            optionsPanel.Controls.Add(defaultOption);
            defaultOption.Location = new Point(2, 2);
            defaultOption.Size = new Size(optionsPanel.Width / 3, optionsPanel.Height - 4);
            defaultOption.Text = "Default";
            defaultOption.Click += (sender, e) => { settingsMode = SettingsMode.Default; };

            Button audioPlayerOption = new Button();
            optionsPanel.Controls.Add(audioPlayerOption);
            audioPlayerOption.Location = new Point(2 + optionsPanel.Width / 3, 2);
            audioPlayerOption.Size = new Size(optionsPanel.Width / 3, optionsPanel.Height - 4);
            audioPlayerOption.Text = "Audio Player";
            audioPlayerOption.Click += (sender, e) => { settingsMode = SettingsMode.AudioPlayer; };

            Button hueOption = new Button();
            optionsPanel.Controls.Add(hueOption);
            hueOption.Location = new Point(2 + ((optionsPanel.Width / 3) * 2), 2);
            hueOption.Size = new Size(optionsPanel.Width / 3, optionsPanel.Height - 4);
            hueOption.Text = "Hue";
            hueOption.Click += (sender, e) => { settingsMode = SettingsMode.Hue; };

            StructureSettingsConfigurer();

            defaultSettingsConfigurer.Show();
        }

        private void StructureSettingsConfigurer()
        {
            configPanel.Controls.Clear();

            Type settingsType = _settingsFilterType;
            List<PropertyInfo> props = settingsType.GetProperties().ToList();

            DefaultSettings newDefaultSettings = _default;

            if (settingsMode == SettingsMode.Default)
            {
                props.RemoveAll(p => p.Name == nameof(DefaultSettings.AudioPlayer) || p.Name == nameof(DefaultSettings.Hue));
            }
            else if (settingsMode == SettingsMode.AudioPlayer)
            {
                
            }
            else if (settingsMode == SettingsMode.Hue)
            {
                
            }

            Button saveSettings = new Button()
            {
                Text = "Save",
                BackColor = Color.SkyBlue,
                Location = new Point(5, 5),
                Size = new Size(configPanel.Width / 4, (int)(configPanel.Height * 0.10)),
            };
            saveSettings.Click += (sender, e) =>
            {
                _persistence.SetDefaultSettings(newDefaultSettings);

                _persistence = new PersistenceHandler();

                _default = _persistence.GetDefaultSettings();

                _connection.Dispose();
                _connection = null;
                _connection = new DeviceConnection(_default.DeviceName, _persistence, _default);

                Restructure();

                defaultSettingsConfigurer.Close();
            };
            configPanel.Controls.Add(saveSettings);

            dynamic defaultValues = _default;
            if (settingsMode == SettingsMode.Default) defaultValues = _default;
            else if (settingsMode == SettingsMode.AudioPlayer) defaultValues = _default.AudioPlayer;
            else if (settingsMode == SettingsMode.Hue) defaultValues = _default.Hue;

            int index = -1;
            foreach (PropertyInfo prop in props)
            {
                index++;

                Panel propValuePanel = new Panel();
                configPanel.Controls.Add(propValuePanel);
                propValuePanel.Location = new Point(0, (int)((50 * index) + configPanel.Height * 0.15));
                propValuePanel.Size = new Size(configPanel.Width - 20, 50);
                propValuePanel.BorderStyle = BorderStyle.FixedSingle;

                Label valueLabel = new Label();
                propValuePanel.Controls.Add(valueLabel);
                valueLabel.Location = new Point(propValuePanel.Width / 2, 2);
                valueLabel.Size = new Size(propValuePanel.Width / 2 - 10, 20);
                valueLabel.Text = prop.GetValue(defaultValues).ToString();

                Label propName = new Label()
                {
                    Text = prop.Name,
                    Location = new Point(5, 2),
                    Size = new Size(propValuePanel.Width / 2 - 10, 20),
                };
                propValuePanel.Controls.Add(propName);

                if (prop.PropertyType == typeof(bool))
                {
                    CheckBox control = new CheckBox()
                    {
                        Location = new Point(5, 22),
                        Size = new Size(propValuePanel.Width / 2 - 5, propValuePanel.Height - 25),
                        Checked = prop.GetValue(defaultValues),
                    };
                    propValuePanel.Controls.Add(control);
                    control.CheckedChanged += (sender, e) =>
                    {
                        valueLabel.Text = control.Checked.ToString();
                        if (settingsMode == SettingsMode.Default)
                        {
                            prop.SetValue(newDefaultSettings, control.Checked);
                        }
                        else if (settingsMode == SettingsMode.AudioPlayer)
                        {
                            prop.SetValue(newDefaultSettings.AudioPlayer, control.Checked);
                        }
                        else if (settingsMode == SettingsMode.Hue)
                        {
                            prop.SetValue(newDefaultSettings.Hue, control.Checked);
                        }

                        Update();
                    };
                }
                else if (prop.PropertyType == typeof(string[]))
                {
                    valueLabel.Text = String.Join(", ", prop.GetValue(defaultValues));

                    if (prop.Name.Contains("Folder"))
                    {
                        Button browseButton = new Button()
                        {
                            Text = "Find a Folder",
                            Location = new Point(5, 22),
                            Size = new Size((propValuePanel.Width / 2 - 5) / 2, propValuePanel.Height - 25),
                        };
                        propValuePanel.Controls.Add(browseButton);

                        Button resetButton = new Button()
                        {
                            Text = "Remove last selected folder",
                            Location = new Point(5 + propValuePanel.Width / 4, 22),
                            Size = new Size((propValuePanel.Width / 2 - 5) / 2, propValuePanel.Height - 25),
                        };
                        propValuePanel.Controls.Add(resetButton);
                        resetButton.Click += (sender, e) =>
                        {
                            string[] folders = valueLabel.Text.Split(',');

                            folders = folders.Take(folders.Length - 1).ToArray();

                            valueLabel.Text = String.Join(", ", folders.Select(x => x.Trim()));
                            if (settingsMode == SettingsMode.Default)
                            {
                                prop.SetValue(newDefaultSettings, folders);
                            }
                            else if (settingsMode == SettingsMode.AudioPlayer)
                            {
                                prop.SetValue(newDefaultSettings.AudioPlayer, folders);
                            }
                            else if (settingsMode == SettingsMode.Hue)
                            {
                                prop.SetValue(newDefaultSettings.Hue, folders);
                            }

                            Update();
                        };

                        browseButton.Click += (sender, e) =>
                        {
                            FolderBrowserDialog fileDialog = new FolderBrowserDialog()
                            {
                                Description = "Select a folder",
                            };

                            if (fileDialog.ShowDialog() == DialogResult.OK)
                            {
                                valueLabel.Text = valueLabel.Text + ", " + fileDialog.SelectedPath;

                                string[] folders = valueLabel.Text.Split(',').Select(x => x.Trim()).ToArray();

                                if (settingsMode == SettingsMode.Default)
                                {
                                    prop.SetValue(newDefaultSettings, folders);
                                }
                                else if (settingsMode == SettingsMode.AudioPlayer)
                                {
                                    prop.SetValue(newDefaultSettings.AudioPlayer, folders);
                                }
                                else if (settingsMode == SettingsMode.Hue)
                                {
                                    prop.SetValue(newDefaultSettings.Hue, folders);
                                }
                            }

                            Update();
                        };
                    }
                    else
                    {
                        TextBox control = new TextBox()
                        {
                            Location = new Point(5, 22),
                            Size = new Size(propValuePanel.Width / 2 - 5, propValuePanel.Height - 25),
                            Text = String.Join(", ", prop.GetValue(defaultValues)),
                        };
                        control.TextChanged += (sender, e) =>
                        {
                            valueLabel.Text = control.Text;
                            string[] data = valueLabel.Text.Split(',').Select(x => x.Trim()).ToArray();

                            if (settingsMode == SettingsMode.Default)
                            {
                                prop.SetValue(newDefaultSettings, data);
                            }
                            else if (settingsMode == SettingsMode.AudioPlayer)
                            {
                                prop.SetValue(newDefaultSettings.AudioPlayer, data);
                            }
                            else if (settingsMode == SettingsMode.Hue)
                            {
                                prop.SetValue(newDefaultSettings.Hue, data);
                            }

                            Update();
                        };
                        propValuePanel.Controls.Add(control);
                    }
                }
                else if (prop.PropertyType == typeof(string))
                {
                    if (prop.Name.Contains("Folder"))
                    {
                        Button browseButton = new Button()
                        {
                            Text = "Find Folder",
                            Location = new Point(5, 22),
                            Size = new Size(propValuePanel.Width / 2 - 5, propValuePanel.Height - 25),
                        };
                        propValuePanel.Controls.Add(browseButton);

                        browseButton.Click += (sender, e) =>
                        {
                            FolderBrowserDialog fileDialog = new FolderBrowserDialog()
                            {
                                Description = "Select a folder",
                            };

                            if (fileDialog.ShowDialog() == DialogResult.OK)
                            {
                                valueLabel.Text = fileDialog.SelectedPath;

                                if (settingsMode == SettingsMode.Default)
                                {
                                    prop.SetValue(newDefaultSettings, valueLabel.Text);
                                }
                                else if (settingsMode == SettingsMode.AudioPlayer)
                                {
                                    prop.SetValue(newDefaultSettings.AudioPlayer, valueLabel.Text);
                                }
                                else if (settingsMode == SettingsMode.Hue)
                                {
                                    prop.SetValue(newDefaultSettings.Hue, valueLabel.Text);
                                }
                            }

                            Update();
                        };
                    }
                    else
                    {
                        TextBox control = new TextBox()
                        {
                            Location = new Point(5, 22),
                            Size = new Size(propValuePanel.Width / 2 - 5, propValuePanel.Height - 25),
                            Text = prop.GetValue(defaultValues).ToString(),
                    };
                        control.TextChanged += (sender, e) =>
                        {
                            valueLabel.Text = control.Text;

                            if (settingsMode == SettingsMode.Default)
                            {
                                prop.SetValue(newDefaultSettings, valueLabel.Text);
                            }
                            else if (settingsMode == SettingsMode.AudioPlayer)
                            {
                                prop.SetValue(newDefaultSettings.AudioPlayer, valueLabel.Text);
                            }
                            else if (settingsMode == SettingsMode.Hue)
                            {
                                prop.SetValue(newDefaultSettings.Hue, valueLabel.Text);
                            }

                            Update();
                        };
                        propValuePanel.Controls.Add(control);
                    }
                }
                else if (prop.PropertyType == typeof(int))
                {
                    NumericUpDown control = new NumericUpDown()
                    {
                        Minimum = -10000,
                        Maximum = 10000,
                        Increment = 1,
                        Location = new Point(5, 22),
                        Size = new Size(propValuePanel.Width / 2 - 5, propValuePanel.Height - 25),
                        Value = (int)prop.GetValue(defaultValues),
                    };
                    control.ValueChanged += (sender, e) =>
                    {
                        valueLabel.Text = control.Value.ToString();

                        if (settingsMode == SettingsMode.Default)
                        {
                            prop.SetValue(newDefaultSettings, valueLabel.Text);
                        }
                        else if (settingsMode == SettingsMode.AudioPlayer)
                        {
                            prop.SetValue(newDefaultSettings.AudioPlayer, valueLabel.Text);
                        }
                        else if (settingsMode == SettingsMode.Hue)
                        {
                            prop.SetValue(newDefaultSettings.Hue, valueLabel.Text);
                        }

                        Update();
                    };
                    propValuePanel.Controls.Add(control);
                }
            }
        }
    }
}
