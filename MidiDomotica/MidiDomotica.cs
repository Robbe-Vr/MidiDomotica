using Fasterflect;
using MidiDomotica.Core.Actions;
using MidiDomotica.Core.Actions.Interfaces;
using MidiDomotica.Core.MidiConnection;
using MidiDomotica.Core.Persistence;
using MidiDomotica.Core.Utils;
using MidiDomotica.Exchange;
using MidiDomotica.Exchange.ControlEvents.Interfaces;
using MidiDomotica.Exchange.UserDataClasses;
using ReflectionExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SYWPipeNetworkManager;
using static MidiDomotica.Core.MidiConnection.DeviceConnection;

namespace MidiDomotica
{
    public partial class MidiDomotica : Form
    {
        private PersistenceHandler _persistence;
        private DeviceConnection _connection;
        private DefaultSettings _default;

        private Form AssignmentForm;

        enum ActionMode
        {
            All = 0,
            AudioPlayer,
            Hotkeys,
            Hue,
            InputDevices,
            MixerVolumes,
            OutputDevices,
        }
        private ActionMode _actionMode = ActionMode.All;
        private ActionMode actionMode { get { return _actionMode; } set { _actionMode = value; Restructure(); } }
        private Type _actionsFilterType
        {
            get
            {
                switch (actionMode)
                {
                    case ActionMode.All: return typeof(IAllActions);
                    case ActionMode.AudioPlayer: return typeof(IAudioPlayer);
                    case ActionMode.Hotkeys: return typeof(IHotkeys);
                    case ActionMode.Hue: return typeof(IHue);
                    case ActionMode.InputDevices: return typeof(IInputDevices);
                    case ActionMode.MixerVolumes: return typeof(IMixerVolumes);
                    case ActionMode.OutputDevices: return typeof(IAllActions);

                    default: return typeof(IAllActions);
                };
            }
        }

        enum EventMode
        {
            Mode1 = 1,
            Mode2,
            Mode3,
            Mode4,
            Mode5,
            Mode6,
            Mode7,
            Mode8,
            Global,
        }
        enum EventControlMode
        {
            Notes,
            Pads,
            SlideFaders,
            KnobFaders,
            TopRowFaderButtons,
            BottomRowFaderButtons,
            Modulation,
            Pitch,
        }
        private EventMode _eventMode = EventMode.Mode1;
        private EventMode eventMode { get { return _eventMode; } set { _eventMode = value; Restructure(); } }
        private EventControlMode _eventControlMode = EventControlMode.Pads;
        private EventControlMode eventControlMode { get { return _eventControlMode; } set { _eventControlMode = value; Restructure(); } }
        private Type _eventsFilterType
        {
            get
            {
                switch (eventMode)
                {
                    case EventMode.Global: return typeof(IGlobal);
                    case EventMode.Mode1:
                        switch (eventControlMode)
                        {
                            case EventControlMode.Notes: return typeof(Mode1Control);
                            case EventControlMode.Pads: return typeof(Mode1Pads);
                            case EventControlMode.SlideFaders: return typeof(Mode1SlideFader);
                            case EventControlMode.KnobFaders: return typeof(Mode1KnobFader);
                            case EventControlMode.TopRowFaderButtons: return typeof(Mode1FaderButtonTop);
                            case EventControlMode.BottomRowFaderButtons: return typeof(Mode1FaderButtonBottom);
                            case EventControlMode.Modulation: return typeof(Mode1Modulation);
                            case EventControlMode.Pitch: return typeof(Mode1Pitch);

                            default: return typeof(Mode1Pads);
                        }
                    case EventMode.Mode2:
                        switch (eventControlMode)
                        {
                            case EventControlMode.Notes: return typeof(Mode2Control);
                            case EventControlMode.Pads: return typeof(Mode2Pads);
                            case EventControlMode.SlideFaders: return typeof(Mode2SlideFader);
                            case EventControlMode.KnobFaders: return typeof(Mode2KnobFader);
                            case EventControlMode.TopRowFaderButtons: return typeof(Mode2FaderButtonTop);
                            case EventControlMode.BottomRowFaderButtons: return typeof(Mode2FaderButtonBottom);
                            case EventControlMode.Modulation: return typeof(Mode2Modulation);
                            case EventControlMode.Pitch: return typeof(Mode2Pitch);

                            default: return typeof(Mode2Pads);
                        }
                    case EventMode.Mode3:
                        switch (eventControlMode)
                        {
                            case EventControlMode.Notes: return typeof(Mode3Control);
                            case EventControlMode.Pads: return typeof(Mode3Pads);
                            case EventControlMode.SlideFaders: return typeof(Mode3SlideFader);
                            case EventControlMode.KnobFaders: return typeof(Mode3KnobFader);
                            case EventControlMode.TopRowFaderButtons: return typeof(Mode3FaderButtonTop);
                            case EventControlMode.BottomRowFaderButtons: return typeof(Mode3FaderButtonBottom);
                            case EventControlMode.Modulation: return typeof(Mode3Modulation);
                            case EventControlMode.Pitch: return typeof(Mode3Pitch);

                            default: return typeof(Mode3Pads);
                        }
                    case EventMode.Mode4:
                        switch (eventControlMode)
                        {
                            case EventControlMode.Notes: return typeof(Mode4Control);
                            case EventControlMode.Pads: return typeof(Mode4Pads);
                            case EventControlMode.SlideFaders: return typeof(Mode4SlideFader);
                            case EventControlMode.KnobFaders: return typeof(Mode4KnobFader);
                            case EventControlMode.TopRowFaderButtons: return typeof(Mode4FaderButtonTop);
                            case EventControlMode.BottomRowFaderButtons: return typeof(Mode4FaderButtonBottom);
                            case EventControlMode.Modulation: return typeof(Mode4Modulation);
                            case EventControlMode.Pitch: return typeof(Mode4Pitch);

                            default: return typeof(Mode4Pads);
                        }
                    case EventMode.Mode5:
                        switch (eventControlMode)
                        {
                            case EventControlMode.Notes: return typeof(Mode5Control);
                            case EventControlMode.Pads: return typeof(Mode5Pads);
                            case EventControlMode.SlideFaders: return typeof(Mode5SlideFader);
                            case EventControlMode.KnobFaders: return typeof(Mode5KnobFader);
                            case EventControlMode.TopRowFaderButtons: return typeof(Mode5FaderButtonTop);
                            case EventControlMode.BottomRowFaderButtons: return typeof(Mode5FaderButtonBottom);
                            case EventControlMode.Modulation: return typeof(Mode5Modulation);
                            case EventControlMode.Pitch: return typeof(Mode5Pitch);

                            default: return typeof(Mode5Pads);
                        }
                    case EventMode.Mode6:
                        switch (eventControlMode)
                        {
                            case EventControlMode.Notes: return typeof(Mode6Control);
                            case EventControlMode.Pads: return typeof(Mode6Pads);
                            case EventControlMode.SlideFaders: return typeof(Mode6SlideFader);
                            case EventControlMode.KnobFaders: return typeof(Mode6KnobFader);
                            case EventControlMode.TopRowFaderButtons: return typeof(Mode6FaderButtonTop);
                            case EventControlMode.BottomRowFaderButtons: return typeof(Mode6FaderButtonBottom);
                            case EventControlMode.Modulation: return typeof(Mode6Modulation);
                            case EventControlMode.Pitch: return typeof(Mode6Pitch);

                            default: return typeof(Mode6Pads);
                        }
                    case EventMode.Mode7:
                        switch (eventControlMode)
                        {
                            case EventControlMode.Notes: return typeof(Mode7Control);
                            case EventControlMode.Pads: return typeof(Mode7Pads);
                            case EventControlMode.SlideFaders: return typeof(Mode7SlideFader);
                            case EventControlMode.KnobFaders: return typeof(Mode7KnobFader);
                            case EventControlMode.TopRowFaderButtons: return typeof(Mode7FaderButtonTop);
                            case EventControlMode.BottomRowFaderButtons: return typeof(Mode7FaderButtonBottom);
                            case EventControlMode.Modulation: return typeof(Mode7Modulation);
                            case EventControlMode.Pitch: return typeof(Mode7Pitch);

                            default: return typeof(Mode7Pads);
                        }
                    case EventMode.Mode8:
                        switch (eventControlMode)
                        {
                            case EventControlMode.Notes: return typeof(Mode8Control);
                            case EventControlMode.Pads: return typeof(Mode8Pads);
                            case EventControlMode.SlideFaders: return typeof(Mode8SlideFader);
                            case EventControlMode.KnobFaders: return typeof(Mode8KnobFader);
                            case EventControlMode.TopRowFaderButtons: return typeof(Mode8FaderButtonTop);
                            case EventControlMode.BottomRowFaderButtons: return typeof(Mode8FaderButtonBottom);
                            case EventControlMode.Modulation: return typeof(Mode8Modulation);
                            case EventControlMode.Pitch: return typeof(Mode8Pitch);

                            default: return typeof(Mode8Pads);
                        }

                    default: return typeof(Mode1Control);
                }
            }
        }

        public event EventHandler<NotifyEventArgs> onNotificationReady;

        private Button showMusicSycnConfigurerFormButton;

        public MidiDomotica()
        {
            InitializeComponent();

            CreateUI();

            ResizeUI();

            _persistence = new PersistenceHandler();

            _default = _persistence.GetDefaultSettings();

            _connection = new DeviceConnection(_default.DeviceName, _persistence, _default);

            _connection.onNotify += (sender, e) =>
            {
                onNotificationReady.Invoke(sender, e);
            };

            PipeMessageControl.Init(nameof(MidiDomotica));

            StaticValuesTunnel.ResetMusicSync();

            _connection.onMusicSyncStarted += (sender, e) =>
            {
                if (showMusicSycnConfigurerFormButton != null)
                    showMusicSycnConfigurerFormButton.Visible = true;

                Action showUI = () => { ShowMusicSyncConfigPanel(); };
                if (this.Visible && this.IsHandleCreated)
                {
                    if (InvokeRequired)
                        this.Invoke(new Action(() => { ShowMusicSyncConfigPanel(); }));
                    else
                        ShowMusicSyncConfigPanel();
                }
            };
            _connection.onMusicSyncStopped += (sender, e) =>
            {
                if (showMusicSycnConfigurerFormButton != null)
                    showMusicSycnConfigurerFormButton.Visible = false;

                Action closeUI = () =>
                {
                    musicSyncConfigurer?.Close();
                    musicSyncConfigurer?.Dispose();
                    musicSyncConfigurer = null;
                    this.Hide();
                };
                
                if (InvokeRequired)
                    this?.Invoke(closeUI);
                else
                    closeUI();
            };

            Restructure();
        }

        public void ToggleForm(bool show)
        {
            if (show)
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => { this.Show(); }));
                }
                else Show();
            }
            else
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => { this.Hide(); }));
                }
                else Hide();
            }
        }

        public void SearchMidiDevice()
        {
            if (!_connection.TryReconnect())
            {
                MessageBox.Show("Failed reconnecting to a midi device!\nThe app will not work properly without a midi device!", "No midi device connected!");
            }
        }

        private void Restructure()
        {
            Type eventsFilterType = _eventsFilterType;

            var method = typeof(MidiDomotica).GetMethod(nameof(MidiDomotica.StructureWithEvents), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            var genericMethod = method.MakeGenericMethod(eventsFilterType);
            genericMethod.Invoke(this, null);

            Update();
        }

        private void StructureWithEvents<T>() where T : IMidiEvents
        {
            ModeConfigButtonList.Controls.Clear();

            ModeConfigButtonList.Resize += (sender, e) =>
            {
                foreach (Panel panel in ModeConfigButtonList.Controls)
                {
                    panel.Location = new Point(2 + ((ModeConfigButtonList.Height - 2) * ModeConfigButtonList.Controls.IndexOf(panel)), 2);
                    panel.Size = new Size(ModeConfigButtonList.Height - 4, ModeConfigButtonList.Height - 25);
                }
            };

            EventInfo[] events = typeof(T).GetAllEvents();
            int count = 0;
            int row = 0;
            foreach (EventInfo eventInfo in events)
            {
                Panel assignEventPanel = CreateAssignEventPanel(eventInfo, count, row);

                ModeConfigButtonList.Controls.Add(assignEventPanel);

                count++;
                if (count % 24 == 0)
                {
                    row++;
                    count = 0;
                }
            }
        }

        private Panel CreateAssignEventPanel(EventInfo eventInfo, int count, int row)
        {
            Panel assignEventPanel = new Panel();

            assignEventPanel.Location = new Point(2 + ((ModeConfigButtonList.Height - 2) * count), 2 + ((ModeConfigButtonList.Height - 6) * row));
            assignEventPanel.Size = new Size(ModeConfigButtonList.Height - 4, ModeConfigButtonList.Height - 25);
            assignEventPanel.BackColor = Color.SandyBrown;

            Label eventName = new Label();
            assignEventPanel.Controls.Add(eventName);
            eventName.Location = new Point(2, 2);
            eventName.Size = new Size(assignEventPanel.Width, (int)(assignEventPanel.Height * 0.2));
            eventName.Text = eventInfo.Name;

            ListBox listBox = new ListBox();
            assignEventPanel.Controls.Add(listBox);
            listBox.Location = new Point(2, 4 + eventName.Height);
            listBox.Size = new Size(assignEventPanel.Width - 4, assignEventPanel.Height - (4 + eventName.Height + 50));
            var subscriptions = _connection.Subscriptions.Where(x => x.EventName == eventInfo.Name);
            listBox.Items.AddRange(subscriptions.Select(x => x.ActionName + $"({String.Join(", ", x.Parameters)})").ToArray());
            
            listBox.MouseDoubleClick += (sender, e) =>
            {
                if (listBox.SelectedItem == null) return;

                string item = listBox.SelectedItem as string;
                string actionName = item.Split('(')[0];
                string paramsStr = item.Substring(item.IndexOf('(') + 1);
                paramsStr = paramsStr.Substring(0, paramsStr.Length - 1);
                string[] parameters = paramsStr.Split(',').Select(x => x.Trim()).ToArray();

                EventSubscriptionData subscription = subscriptions.FirstOrDefault(x => { int index = -1; return x.ActionName == actionName && x.Parameters.All(p => { index++; return p == parameters[index]; }); });

                if (subscription != null && MessageBox.Show("Remove action.", "Are your sure you want to remove the action '" + item + "' from this event '" + subscription.EventName + "'?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _connection.GetSubscriber().Unsubscribe(subscription);

                    listBox.Items.Remove(item);
                }
            };

            ToolStrip ts = new ToolStrip();
            assignEventPanel.Controls.Add(ts);
            ts.Dock = DockStyle.Bottom;
            ts.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;

            ToolStripDropDownButton tsButton = new ToolStripDropDownButton();
            ts.Items.Add(tsButton);
            tsButton.Text = "Actions";
            tsButton.DisplayStyle = ToolStripItemDisplayStyle.Text;

            ContextMenuStrip tsButtonContextMenu = new ContextMenuStrip();
            tsButton.DropDown = tsButtonContextMenu;

            ToolStripDropDownButton audioPlayerActions = new ToolStripDropDownButton();
            tsButtonContextMenu.Items.Add(audioPlayerActions);
            audioPlayerActions.Text = "AudioPlayer";
            ContextMenuStrip audioPlayerActionsMenu = new ContextMenuStrip();
            audioPlayerActions.DropDown = audioPlayerActionsMenu;
            foreach (MethodInfo methodInfo in typeof(IAudioPlayer).GetMethods())
            {
                audioPlayerActionsMenu.Items.Add(methodInfo.Name, null, (sender, e) => { ShowAssignWindow(typeof(IAudioPlayer), methodInfo, eventInfo); });
            }

            ToolStripDropDownButton hueActions = new ToolStripDropDownButton();
            tsButtonContextMenu.Items.Add(hueActions);
            hueActions.Text = "Hue";
            ContextMenuStrip hueActionsMenu = new ContextMenuStrip();
            hueActions.DropDown = hueActionsMenu;
            foreach (MethodInfo methodInfo in typeof(IHue).GetMethods())
            {
                hueActionsMenu.Items.Add(methodInfo.Name, null, (sender, e) => { ShowAssignWindow(typeof(IHue), methodInfo, eventInfo); });
            }

            ToolStripDropDownButton hotkeysActions = new ToolStripDropDownButton();
            tsButtonContextMenu.Items.Add(hotkeysActions);
            hotkeysActions.Text = "Hotkeys";
            ContextMenuStrip hotkeysActionsMenu = new ContextMenuStrip();
            hotkeysActions.DropDown = hotkeysActionsMenu;
            foreach (MethodInfo methodInfo in typeof(IHotkeys).GetMethods())
            {
                hotkeysActionsMenu.Items.Add(methodInfo.Name, null, (sender, e) => { ShowAssignWindow(typeof(IHotkeys), methodInfo, eventInfo); });
            }

            ToolStripDropDownButton inputDevicesActions = new ToolStripDropDownButton();
            tsButtonContextMenu.Items.Add(inputDevicesActions);
            inputDevicesActions.Text = "Input Devices";
            ContextMenuStrip inputDevicesActionsMenu = new ContextMenuStrip();
            inputDevicesActions.DropDown = inputDevicesActionsMenu;
            foreach (MethodInfo methodInfo in typeof(IInputDevices).GetMethods())
            {
                inputDevicesActionsMenu.Items.Add(methodInfo.Name, null, (sender, e) => { ShowAssignWindow(typeof(IInputDevices), methodInfo, eventInfo); });
            }

            ToolStripDropDownButton mixersActions = new ToolStripDropDownButton();
            tsButtonContextMenu.Items.Add(mixersActions);
            mixersActions.Text = "Mixers";
            ContextMenuStrip mixersActionsMenu = new ContextMenuStrip();
            mixersActions.DropDown = mixersActionsMenu;
            foreach (MethodInfo methodInfo in typeof(IMixerVolumes).GetMethods())
            {
                mixersActionsMenu.Items.Add(methodInfo.Name, null, (sender, e) => { ShowAssignWindow(typeof(IMixerVolumes), methodInfo, eventInfo); });
            }

            ToolStripDropDownButton outputDevicesActions = new ToolStripDropDownButton();
            tsButtonContextMenu.Items.Add(outputDevicesActions);
            outputDevicesActions.Text = "Output Devices";
            ContextMenuStrip outputDevicesActionsMenu = new ContextMenuStrip();
            outputDevicesActions.DropDown = outputDevicesActionsMenu;
            foreach (MethodInfo methodInfo in typeof(IOutputDevices).GetMethods())
            {
                outputDevicesActionsMenu.Items.Add(methodInfo.Name, null, (sender, e) => { ShowAssignWindow(typeof(IOutputDevices), methodInfo, eventInfo); });
            }

            ToolStripDropDownButton powerModesActions = new ToolStripDropDownButton();
            tsButtonContextMenu.Items.Add(powerModesActions);
            powerModesActions.Text = "Power Modes";
            ContextMenuStrip powerModesActionsMenu = new ContextMenuStrip();
            powerModesActions.DropDown = powerModesActionsMenu;
            foreach (MethodInfo methodInfo in typeof(IPowerModes).GetMethods())
            {
                powerModesActionsMenu.Items.Add(methodInfo.Name, null, (sender, e) => { ShowAssignWindow(typeof(IPowerModes), methodInfo, eventInfo); });
            }

            return assignEventPanel;
        }

        private void ShowAssignWindow(Type actionType, MethodInfo methodInfo, EventInfo eventInfo)
        {
            if (AssignmentForm != null)
            {
                AssignmentForm.Close();
                AssignmentForm.Dispose();
                AssignmentForm = null;
            }

            AssignmentForm = new Form();
            AssignmentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            AssignmentForm.Size = new Size(500, 500);
            AssignmentForm.Width = 500;
            AssignmentForm.Height = 500;

            Label assignmentName = new Label();
            AssignmentForm.Controls.Add(assignmentName);
            assignmentName.Text = methodInfo.Name + " on " + eventInfo.Name;
            assignmentName.Location = new Point(10, 10);
            assignmentName.Width = AssignmentForm.Width - 20;

            Panel paramsPanel = new Panel();
            AssignmentForm.Controls.Add(paramsPanel);
            paramsPanel.Location = new Point(10, 75);
            paramsPanel.Size = new Size(AssignmentForm.Width - 20, AssignmentForm.Height - 200);
            paramsPanel.BackColor = Color.LightGray;
            paramsPanel.VerticalScroll.Visible = true;

            ParameterInfo[] parameters = methodInfo.GetParameters();

            foreach (ParameterInfo parameter in parameters)
            {
                Panel paramPanel = new Panel();
                paramsPanel.Controls.Add(paramPanel);
                paramPanel.BackColor = Color.RosyBrown;
                paramPanel.Location = new Point(10, 20 + ((5 + (paramsPanel.Height / 4)) * paramsPanel.Controls.Count));
                paramPanel.Size = new Size(paramsPanel.Width - 20, paramsPanel.Height / 4);

                Label paramName = new Label();
                paramPanel.Controls.Add(paramName);
                paramName.Location = new Point(10, 10);
                paramName.Height = 25;
                paramName.Text = parameter.Name;

                Label paramCurrentValue = new Label();
                paramPanel.Controls.Add(paramCurrentValue);
                paramCurrentValue.Location = new Point(paramPanel.Width / 2 + 10, 20 + paramName.Height);
                paramCurrentValue.Size = new Size(paramPanel.Width / 2 - 20, 30);

                ToolStrip ts = new ToolStrip();
                paramPanel.Controls.Add(ts);
                ts.Dock = DockStyle.Bottom;
                ts.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;

                ToolStripDropDownButton tsButton = new ToolStripDropDownButton();
                ts.Items.Add(tsButton);
                tsButton.Text = "Value Options";
                tsButton.DisplayStyle = ToolStripItemDisplayStyle.Text;

                ContextMenuStrip tsButtonContextMenu = new ContextMenuStrip();
                tsButton.DropDown = tsButtonContextMenu;

                foreach (PropertyInfo prop in eventInfo.EventHandlerType.GetGenericArguments()[0].GetProperties())
                {
                    tsButtonContextMenu.Items.Add(prop.Name, null, (sender, e) =>
                    {
                        TextBox input = new TextBox();
                        paramPanel.Controls.Add(input);
                        input.Name = "Value";
                        input.Location = new Point(10, 30);
                        input.Size = new Size(paramPanel.Width - 40, 30);
                        input.Visible = false;
                        input.Tag = "string";

                        input.Text = "{useEventProp(" + prop.Name + ")}";
                        paramCurrentValue.Text = input.Text;
                    });
                }

                ToolStripDropDownButton actionOptions = new ToolStripDropDownButton();
                tsButtonContextMenu.Items.Add(actionOptions);
                actionOptions.Text = "Action Options";

                ContextMenuStrip actionOptionsMenu = new ContextMenuStrip();
                actionOptions.DropDown = actionOptionsMenu;

                if (actionType.Name == nameof(IAudioPlayer))
                {
                    if (parameter.Name == "soundFilePath")
                    {
                        foreach (string audioFolder in _default.AudioPlayer.AudioFolders)
                        {
                            actionOptionsMenu.Items.Add(audioFolder.Split('/').Last(), null, (sender, e) =>
                            {
                                OpenFileDialog fileDialog = new OpenFileDialog();
                                fileDialog.Title = "Select a sound file";
                                fileDialog.InitialDirectory = audioFolder;
                                fileDialog.DefaultExt = ".mp3";
                                fileDialog.Filter = "Sound Files|*.wav;*.WAV;*.mp3;*.MP3";

                                if (fileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    TextBox input = new TextBox();
                                    paramPanel.Controls.Add(input);
                                    input.Name = "Value";
                                    input.Location = new Point(10, 30);
                                    input.Size = new Size(paramPanel.Width / 2, 30);
                                    input.Visible = false;
                                    input.Tag = "string";

                                    input.Text = fileDialog.FileName;
                                    paramCurrentValue.Text = input.Text;
                                }
                            });
                        }
                    }
                }
                else if (actionType.Name == nameof(IHue))
                {

                }
                else if (actionType.Name == nameof(IHotkeys))
                {

                }
                else if (actionType.Name == nameof(IInputDevices))
                {
                    if (parameter.Name == "deviceName")
                    {
                        foreach (var device in ActionMapper.InputDevices)
                        {
                            actionOptionsMenu.Items.Add(device.DeviceName, null, (sender, e) =>
                            {
                                TextBox input = new TextBox();
                                paramPanel.Controls.Add(input);
                                input.Name = "Value";
                                input.Location = new Point(10, 30);
                                input.Size = new Size(paramPanel.Width / 2, 30);
                                input.Visible = false;
                                input.Tag = "string";

                                input.Text = device.DeviceName;
                                paramCurrentValue.Text = input.Text;
                            });
                        }
                    }
                }
                else if (actionType.Name == nameof(IMixerVolumes))
                {
                    if (parameter.Name == "mixerName")
                    {
                        foreach (var mixer in ActionMapper.Mixers)
                        {
                            actionOptionsMenu.Items.Add(mixer.AppName, null, (sender, e) =>
                            {
                                TextBox input = new TextBox();
                                paramPanel.Controls.Add(input);
                                input.Name = "Value";
                                input.Location = new Point(10, 30);
                                input.Size = new Size(paramPanel.Width / 2, 30);
                                input.Visible = false;
                                input.Tag = "string";

                                input.Text = mixer.AppName;
                                paramCurrentValue.Text = input.Text;
                            });
                        }
                    }
                }
                else if (actionType.Name == nameof(IOutputDevices))
                {
                    if (parameter.Name == "deviceName")
                    {
                        foreach (var device in ActionMapper.OutputDevices)
                        {
                            actionOptionsMenu.Items.Add(device.DeviceName, null, (sender, e) =>
                            {
                                TextBox input = new TextBox();
                                paramPanel.Controls.Add(input);
                                input.Name = "Value";
                                input.Location = new Point(10, 30);
                                input.Size = new Size(paramPanel.Width / 2, 30);
                                input.Visible = false;
                                input.Tag = "string";

                                input.Text = device.DeviceName;
                                paramCurrentValue.Text = input.Text;
                            });
                        }
                    }
                }
                else if (actionType.Name == nameof(IPowerModes))
                {
                    if (parameter.Name == "powerModeName")
                    {
                        foreach (var powerMode in ActionMapper.PowerModes)
                        {
                            actionOptionsMenu.Items.Add(powerMode.Name, null, (sender, e) =>
                            {
                                TextBox input = new TextBox();
                                paramPanel.Controls.Add(input);
                                input.Name = "Value";
                                input.Location = new Point(10, 30);
                                input.Size = new Size(paramPanel.Width / 2, 30);
                                input.Visible = false;
                                input.Tag = "string";

                                input.Text = powerMode.Name;
                                paramCurrentValue.Text = input.Text;
                            });
                        }
                    }
                }

                tsButtonContextMenu.Items.Add("Custom", null, (sender, e) =>
                {
                    if (paramPanel.Controls.Cast<Control>().Any(x => x.Name == "Value"))
                    {
                        paramPanel.Controls.Remove(paramPanel.Controls.Find("Value", false)[0]);
                    }

                    if (parameter.ParameterType.Name.ToLower() == "string")
                    {
                        TextBox input = new TextBox();
                        paramPanel.Controls.Add(input);
                        input.Name = "Value";
                        input.Location = new Point(10, 10 + paramName.Height);
                        input.Size = new Size(paramPanel.Width / 2, 30);
                        input.Tag = parameter.ParameterType.Name.ToLower();
                        input.TextChanged += (sender1, e1) =>
                        {
                            paramCurrentValue.Text = input.Text;
                        };
                    }
                    else if (parameter.ParameterType.Name.ToLower() == "int")
                    {
                        NumericUpDown input = new NumericUpDown();
                        paramPanel.Controls.Add(input);
                        input.Name = "Value";
                        input.Location = new Point(10, 10 + paramName.Height);
                        input.Size = new Size(paramPanel.Width / 2, 30);
                        input.Increment = 1;
                        input.Tag = parameter.ParameterType.Name.ToLower();
                        input.TextChanged += (sender1, e1) =>
                        {
                            paramCurrentValue.Text = input.Value.ToString();
                        };
                    }
                    else if (parameter.ParameterType.Name.ToLower() == "float" || parameter.ParameterType.Name.ToLower() == "double")
                    {
                        NumericUpDown input = new NumericUpDown();
                        paramPanel.Controls.Add(input);
                        input.Name = "Value";
                        input.Location = new Point(10, 10 + paramName.Height);
                        input.Size = new Size(paramPanel.Width / 2, 30);
                        input.Increment = 0.01M;
                        input.Tag = parameter.ParameterType.Name.ToLower();
                        input.TextChanged += (sender1, e1) =>
                        {
                            paramCurrentValue.Text = input.Value.ToString();
                        };
                    }
                    else if (parameter.ParameterType.Name.ToLower() == "string[]")
                    {
                        TextBox input = new TextBox();
                        paramPanel.Controls.Add(input);
                        input.Name = "Value";
                        input.Location = new Point(10, 10 + paramName.Height);
                        input.Size = new Size(paramPanel.Width / 2, 30);
                        input.Tag = parameter.ParameterType.Name.ToLower();
                        input.TextChanged += (sender1, e1) =>
                        {
                            paramCurrentValue.Text = input.Text;
                        };
                    }
                    else if (parameter.ParameterType.Name.ToLower() == "int[]")
                    {
                        TextBox input = new TextBox();
                        paramPanel.Controls.Add(input);
                        input.Name = "Value";
                        input.Location = new Point(10, 10 + paramName.Height);
                        input.Size = new Size(paramPanel.Width / 2, 30);
                        input.Tag = parameter.ParameterType.Name.ToLower();
                        input.TextChanged += (sender1, e1) =>
                        {
                            paramCurrentValue.Text = input.Text;
                        };
                    }
                    else if (parameter.ParameterType.Name.ToLower() == "float[]")
                    {
                        TextBox input = new TextBox();
                        paramPanel.Controls.Add(input);
                        input.Name = "Value";
                        input.Location = new Point(10, 10 + paramName.Height);
                        input.Size = new Size(paramPanel.Width / 2, 30);
                        input.Tag = parameter.ParameterType.Name.ToLower();
                        input.TextChanged += (sender1, e1) =>
                        {
                            paramCurrentValue.Text = input.Text;
                        };
                    }
                    else if (parameter.ParameterType.Name.ToLower() == "double[]")
                    {
                        TextBox input = new TextBox();
                        paramPanel.Controls.Add(input);
                        input.Name = "Value";
                        input.Location = new Point(10, 10 + paramName.Height);
                        input.Size = new Size(paramPanel.Width / 2, 30);
                        input.Tag = parameter.ParameterType.Name.ToLower();
                        input.TextChanged += (sender1, e1) =>
                        {
                            paramCurrentValue.Text = input.Text;
                        };
                    }
                });
            }

            bool notify = false;
            CheckBox sendNotificationCheckBox = new CheckBox();
            AssignmentForm.Controls.Add(sendNotificationCheckBox);
            sendNotificationCheckBox.Location = new Point(AssignmentForm.Width / 2 + 10, 10 + assignmentName.Height);
            sendNotificationCheckBox.Text = "Send a notifcation: ";
            sendNotificationCheckBox.CheckedChanged += (sender, e) =>
            {
                notify = sendNotificationCheckBox.Checked;
            };

            Button submitAssignment = new Button();
            AssignmentForm.Controls.Add(submitAssignment);
            submitAssignment.Location = new Point(10, 10 + assignmentName.Height);
            submitAssignment.Size = new Size(AssignmentForm.Width / 2, 25);
            submitAssignment.Text = "Assign";
            submitAssignment.BackColor = Color.LightBlue;
            submitAssignment.Click += (sender, e) =>
            {
                EventSubscriber subscriber = _connection.GetSubscriber();

                Type eventType = eventInfo.EventHandlerType.GetGenericArguments()[0];

                List<object> parameterValues = new List<object>();

                foreach (Panel paramPanel in paramsPanel.Controls)
                {
                    if (paramPanel.Controls.Cast<Control>().Any(x => x.Name == "Value"))
                    {
                        Control valueControl = paramPanel.Controls.Find("Value", false)[0];

                        if (valueControl.GetType() == typeof(TextBox))
                        {
                            if ((valueControl.Tag as string).EndsWith("[]"))
                            {
                                if ((valueControl.Tag as string).StartsWith("string"))
                                {
                                    parameterValues.Add(Regex.Split(((TextBox)valueControl).Text, @"\s{1}\+{1}\s{1}|,{1}\s{1}").Select(x => x.Trim()).ToArray() as object);
                                }
                                else if ((valueControl.Tag as string).StartsWith("int"))
                                {
                                    parameterValues.Add(Regex.Split(((TextBox)valueControl).Text, @"\s{1}\+{1}\s{1}|,{1}\s{1}").Select(x => x.Trim()).ToArray() as object);
                                }
                                else if ((valueControl.Tag as string).StartsWith("float"))
                                {
                                    parameterValues.Add(Regex.Split(((TextBox)valueControl).Text, @"\s{1}\+{1}\s{1}|,{1}\s{1}").Select(x => x.Trim()).ToArray() as object);
                                }
                                else if ((valueControl.Tag as string).StartsWith("double"))
                                {
                                    parameterValues.Add(Regex.Split(((TextBox)valueControl).Text, @"\s{1}\+{1}\s{1}|,{1}\s{1}").Select(x => x.Trim()).ToArray() as object);
                                }
                            }
                            else
                            {
                                parameterValues.Add(((TextBox)valueControl).Text as object);
                            }
                        }
                        else if (valueControl.GetType() == typeof(NumericUpDown))
                        {
                            parameterValues.Add(((NumericUpDown)valueControl).Value as object);
                        }
                    }
                }

                var method = typeof(EventSubscriber).GetMethod(nameof(EventSubscriber.AddSubscription));
                var genericMethod = method.MakeGenericMethod(eventType);

                bool success = (bool)genericMethod.Invoke(subscriber, new object[] { eventInfo.Name, methodInfo.Name, notify, parameterValues.ToArray() });

                if (!success)
                {
                    MessageBox.Show("Failed to assign method!", "Failed to assign method!");
                }
                else
                {
                    AssignmentForm.Close();
                    AssignmentForm.Dispose();
                    AssignmentForm = null;

                    Restructure();
                }
            };

            AssignmentForm.Show();
        }
    }
}
