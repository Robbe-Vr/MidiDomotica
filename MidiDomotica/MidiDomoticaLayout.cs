using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiDomotica
{
    public partial class MidiDomotica
    {
        private ToolStrip AppBar;

        private ToolStripDropDownButton AppBarOptions;
        private ContextMenuStrip AppBarOptionsContextMenuStrip;

        private Panel FormPanel;

        private Panel Main;

        private Panel InfoPanel;
        private Button settingsConfigurerButton;

        private Panel ModeConfigSelection;
        private Button Mode1ConfigSelector;
        private Button Mode2ConfigSelector;
        private Button Mode3ConfigSelector;
        private Button Mode4ConfigSelector;
        private Button Mode5ConfigSelector;
        private Button Mode6ConfigSelector;
        private Button Mode7ConfigSelector;
        private Button Mode8ConfigSelector;
        private Button GlobalConfigSelector;

        private Panel ModeConfigControlPanel;
        private Panel ModeConfigButtonTypeSelection;
        private Button TypeKeys;
        private Button TypePads;
        private Button TypeKnobFaders;
        private Button TypeSlideFaders;
        private Button TypeFaderButtons;
        private Panel ModeConfigButtonList;

        public void CreateUI()
        {
            this.ResizeEnd += new EventHandler((sender, e) =>
            {
                ResizeUI();
            });

            this.MinimumSize = new Size(250, 250);

            this.FormBorderStyle = FormBorderStyle.Sizable;

            FormPanel = new Panel();
            this.Controls.Add(FormPanel);
            FormPanel.Location = new Point(0, 0);
            FormPanel.Size = new Size(this.Width - 20, this.Height - 40);

            AppBar = new ToolStrip();
            AppBar.Name = "AppBar";

            Main = new Panel();
            Main.Name = "Main";

            FormPanel.Controls.Add(AppBar);
            FormPanel.Controls.Add(Main);

            // AppBar
            AppBar.BackColor = Color.LightGray;
            AppBar.Dock = DockStyle.Top;
            AppBar.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;

            AppBarOptions = new ToolStripDropDownButton();
            AppBar.Items.Add(AppBarOptions);

            AppBarOptions.Name = "AppBarOptions";
            AppBarOptions.Text = "options";
            AppBarOptions.DisplayStyle = ToolStripItemDisplayStyle.Text;

            AppBarOptionsContextMenuStrip = new ContextMenuStrip();
            AppBarOptions.DropDown = AppBarOptionsContextMenuStrip;

            AppBarOptionsContextMenuStrip.Items.Add("Search Midi Device", null, (sender, e) => { SearchMidiDevice(); });
            AppBarOptionsContextMenuStrip.Items.Add("Settings");

            // Main
            Main.Location = new Point(0, AppBar.Height);
            Main.Size = new Size(FormPanel.Width - 20, FormPanel.Height - AppBar.Height);

            InfoPanel = new Panel();
            Main.Controls.Add(InfoPanel);
            InfoPanel.Name = "Info";
            InfoPanel.Location = new Point(0, 0);
            InfoPanel.Size = new Size(Main.Width, (int)(Main.Height * 0.2));
            InfoPanel.BackColor = Color.AntiqueWhite;

            settingsConfigurerButton = new Button();
            InfoPanel.Controls.Add(settingsConfigurerButton);
            settingsConfigurerButton.Location = new Point(5, 5);
            settingsConfigurerButton.Size = new Size(InfoPanel.Width / 6, InfoPanel.Height - 10);
            settingsConfigurerButton.Text = "Change settings";
            settingsConfigurerButton.Click += (sender, e) => { ShowSettingsConfigPanel(); };

            showMusicSycnConfigurerFormButton = new Button();
            InfoPanel.Controls.Add(showMusicSycnConfigurerFormButton);
            showMusicSycnConfigurerFormButton.Visible = showMusicSycnConfigurerFormButton != null ? showMusicSycnConfigurerFormButton.Visible : false;
            showMusicSycnConfigurerFormButton.Location = new Point(5 + (InfoPanel.Width / 6), 5);
            showMusicSycnConfigurerFormButton.Size = new Size(InfoPanel.Width / 6, InfoPanel.Height - 10);
            showMusicSycnConfigurerFormButton.Text = "MusicSync Control";
            showMusicSycnConfigurerFormButton.Click += (sender, e) =>
            {
                if (!musicSyncConfigurer.Visible)
                {
                    Action showUI = () => { ShowMusicSyncConfigPanel(); };
                    if (IsHandleCreated)
                    {
                        if (InvokeRequired)
                            this.Invoke(showUI);
                        else
                            showUI();
                    }
                }
            };

            ModeConfigSelection = new Panel();
            Main.Controls.Add(ModeConfigSelection);
            ModeConfigSelection.Location = new Point(0, (int)(Main.Height * 0.2));
            ModeConfigSelection.Size = new Size(Main.Width, (int)(Main.Height * 0.1));
            ModeConfigSelection.BackColor = Color.DarkGray;

            Mode1ConfigSelector = new Button();
            ModeConfigSelection.Controls.Add(Mode1ConfigSelector);
            Mode1ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 0) + (10 * 0), 5);
            Mode1ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 100) / 9), (int)(ModeConfigSelection.Height - 10));
            Mode1ConfigSelector.Text = "Mode 1";
            Mode1ConfigSelector.Click += (sender, e) => { eventMode = EventMode.Mode1; };

            Mode2ConfigSelector = new Button();
            ModeConfigSelection.Controls.Add(Mode2ConfigSelector);
            Mode2ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 1) + (10 * 1), 5);
            Mode2ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));
            Mode2ConfigSelector.Text = "Mode 2";
            Mode2ConfigSelector.Click += (sender, e) => { eventMode = EventMode.Mode2; };

            Mode3ConfigSelector = new Button();
            ModeConfigSelection.Controls.Add(Mode3ConfigSelector);
            Mode3ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 2) + (10 * 2), 5);
            Mode3ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));
            Mode3ConfigSelector.Text = "Mode 3";
            Mode3ConfigSelector.Click += (sender, e) => { eventMode = EventMode.Mode3; };

            Mode4ConfigSelector = new Button();
            ModeConfigSelection.Controls.Add(Mode4ConfigSelector);
            Mode4ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 3) + (10 * 3), 5);
            Mode4ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));
            Mode4ConfigSelector.Text = "Mode 4";
            Mode4ConfigSelector.Click += (sender, e) => { eventMode = EventMode.Mode4; };

            Mode5ConfigSelector = new Button();
            ModeConfigSelection.Controls.Add(Mode5ConfigSelector);
            Mode5ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 4) + (10 * 4), 5);
            Mode5ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));
            Mode5ConfigSelector.Text = "Mode 5";
            Mode5ConfigSelector.Click += (sender, e) => { eventMode = EventMode.Mode5; };

            Mode6ConfigSelector = new Button();
            ModeConfigSelection.Controls.Add(Mode6ConfigSelector);
            Mode6ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 5) + (10 * 5), 5);
            Mode6ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));
            Mode6ConfigSelector.Text = "Mode 6";
            Mode6ConfigSelector.Click += (sender, e) => { eventMode = EventMode.Mode6; };

            Mode7ConfigSelector = new Button();
            ModeConfigSelection.Controls.Add(Mode7ConfigSelector);
            Mode7ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 6) + (10 * 6), 5);
            Mode7ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));
            Mode7ConfigSelector.Text = "Mode 7";
            Mode7ConfigSelector.Click += (sender, e) => { eventMode = EventMode.Mode7; };

            Mode8ConfigSelector = new Button();
            ModeConfigSelection.Controls.Add(Mode8ConfigSelector);
            Mode8ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 7) + (10 * 7), 5);
            Mode8ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));
            Mode8ConfigSelector.Text = "Mode 8";
            Mode8ConfigSelector.Click += (sender, e) => { eventMode = EventMode.Mode8; };

            GlobalConfigSelector = new Button();
            ModeConfigSelection.Controls.Add(GlobalConfigSelector);
            GlobalConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 8) + (10 * 8), 5);
            GlobalConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));
            GlobalConfigSelector.Text = "Global";
            GlobalConfigSelector.Click += (sender, e) => { eventMode = EventMode.Global; };

            ModeConfigControlPanel = new Panel();
            Main.Controls.Add(ModeConfigControlPanel);
            ModeConfigControlPanel.Location = new Point(0, (int)(Main.Height * 0.3));
            ModeConfigControlPanel.Size = new Size(Main.Width - 20, (int)(Main.Height * 0.7));
            ModeConfigControlPanel.BackColor = Color.Aquamarine;

            ModeConfigButtonTypeSelection = new Panel();
            ModeConfigControlPanel.Controls.Add(ModeConfigButtonTypeSelection);
            ModeConfigButtonTypeSelection.Location = new Point(10, 5);
            ModeConfigButtonTypeSelection.Size = new Size(ModeConfigControlPanel.Width - 20, (int)(ModeConfigControlPanel.Height * 0.2) - 10);
            ModeConfigButtonTypeSelection.BackColor = Color.Gray;

            TypeKeys = new Button();
            ModeConfigButtonTypeSelection.Controls.Add(TypeKeys);
            TypeKeys.Text = "Keys";
            TypeKeys.Location = new Point(5 + ((int)((ModeConfigSelection.Width - 70) / 5) * 0) + (10 * 0), 5);
            TypeKeys.Size = new Size((int)((ModeConfigSelection.Width - 70) / 6), (int)(ModeConfigButtonTypeSelection.Height - 10));
            TypeKeys.Click += (sender, e) => { eventControlMode = EventControlMode.Notes; };

            TypePads = new Button();
            ModeConfigButtonTypeSelection.Controls.Add(TypePads);
            TypePads.Text = "Pads";
            TypePads.Location = new Point(5 + ((int)((ModeConfigSelection.Width - 70) / 5) * 1) + (10 * 1), 5);
            TypePads.Size = new Size((int)((ModeConfigSelection.Width - 70) / 6), (int)(ModeConfigButtonTypeSelection.Height - 10));
            TypePads.Click += (sender, e) => { eventControlMode = EventControlMode.Pads; };

            TypeKnobFaders = new Button();
            ModeConfigButtonTypeSelection.Controls.Add(TypeKnobFaders);
            TypeKnobFaders.Text = "KnobFaders";
            TypeKnobFaders.Location = new Point(5 + ((int)((ModeConfigSelection.Width - 70) / 5) * 2) + (10 * 2), 5);
            TypeKnobFaders.Size = new Size((int)((ModeConfigSelection.Width - 70) / 6), (int)(ModeConfigButtonTypeSelection.Height - 10));
            TypeKnobFaders.Click += (sender, e) => { eventControlMode = EventControlMode.KnobFaders; };

            TypeSlideFaders = new Button();
            ModeConfigButtonTypeSelection.Controls.Add(TypeSlideFaders);
            TypeSlideFaders.Text = "SlideFaders";
            TypeSlideFaders.Location = new Point(5 + ((int)((ModeConfigSelection.Width - 70) / 5) * 3) + (10 * 3), 5);
            TypeSlideFaders.Size = new Size((int)((ModeConfigSelection.Width - 70) / 6), (int)(ModeConfigButtonTypeSelection.Height - 10));
            TypeSlideFaders.Click += (sender, e) => { eventControlMode = EventControlMode.SlideFaders; };

            TypeFaderButtons = new Button();
            ModeConfigButtonTypeSelection.Controls.Add(TypeFaderButtons);
            TypeFaderButtons.Text = "FaderButtons";
            TypeFaderButtons.Location = new Point(5 + ((int)((ModeConfigSelection.Width - 70) / 5) * 4) + (10 * 4), 5);
            TypeFaderButtons.Size = new Size((int)((ModeConfigSelection.Width - 70) / 6), (int)(ModeConfigButtonTypeSelection.Height - 10));
            TypeFaderButtons.Click += (sender, e) => { eventControlMode = EventControlMode.TopRowFaderButtons; };

            ModeConfigButtonList = new Panel();
            ModeConfigControlPanel.Controls.Add(ModeConfigButtonList);
            ModeConfigButtonList.Location = new Point(10, (int)(ModeConfigControlPanel.Height * 0.2) + 5);
            ModeConfigButtonList.Size = new Size(ModeConfigControlPanel.Width - 40, (int)(ModeConfigControlPanel.Height * 0.8) - 10);
            ModeConfigButtonList.AutoScroll = true;
            ModeConfigButtonList.HorizontalScroll.Visible = true;
            ModeConfigButtonList.HorizontalScroll.Enabled = true;
            ModeConfigButtonList.VerticalScroll.Visible = true;
            ModeConfigButtonList.VerticalScroll.Enabled = true;
        }

        public void ResizeUI()
        {
            FormPanel.Location = new Point(0, 0);
            FormPanel.Size = new Size(this.Width - 18, this.Height - 40);

            Main.Location = new Point(0, (int)(FormPanel.Height * 0.1));
            Main.Size = new Size(this.Width, (int)(FormPanel.Height * 0.9));

            InfoPanel.Location = new Point(0, 0);
            InfoPanel.Size = new Size(Main.Width, (int)(Main.Height * 0.2));

            settingsConfigurerButton.Location = new Point(5, 5);
            settingsConfigurerButton.Size = new Size(InfoPanel.Width / 6, InfoPanel.Height - 10);

            ModeConfigSelection.Location = new Point(0, (int)(Main.Height * 0.2));
            ModeConfigSelection.Size = new Size(Main.Width, (int)(Main.Height * 0.1));

            Mode1ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 0) + (10 * 0), 10);
            Mode1ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));

            Mode2ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 1) + (10 * 1), 10);
            Mode2ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));

            Mode3ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 2) + (10 * 2), 10);
            Mode3ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));

            Mode4ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 3) + (10 * 3), 10);
            Mode4ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));

            Mode5ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 4) + (10 * 4), 10);
            Mode5ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));

            Mode6ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 5) + (10 * 5), 10);
            Mode6ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));

            Mode7ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 6) + (10 * 6), 10);
            Mode7ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));

            Mode8ConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 7) + (10 * 7), 10);
            Mode8ConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));

            GlobalConfigSelector.Location = new Point(10 + ((int)((ModeConfigSelection.Width - 110) / 9) * 8) + (10 * 8), 10);
            GlobalConfigSelector.Size = new Size((int)((ModeConfigSelection.Width - 110) / 9), (int)(ModeConfigSelection.Height - 10));

            ModeConfigControlPanel.Location = new Point(0, (int)(Main.Height * 0.3));
            ModeConfigControlPanel.Size = new Size(Main.Width, (int)(Main.Height * 0.7));

            ModeConfigButtonTypeSelection.Location = new Point(10, 5);
            ModeConfigButtonTypeSelection.Size = new Size(ModeConfigControlPanel.Width - 20, (int)(ModeConfigControlPanel.Height * 0.2) - 10);

            TypeKeys.Location = new Point(5 + ((int)((ModeConfigSelection.Width - 80) / 5) * 0) + (10 * 0), 5);
            TypeKeys.Size = new Size((int)((ModeConfigSelection.Width - 80) / 6), (int)(ModeConfigButtonTypeSelection.Height - 10));

            TypePads.Location = new Point(5 + ((int)((ModeConfigSelection.Width - 80) / 5) * 1) + (10 * 1), 5);
            TypePads.Size = new Size((int)((ModeConfigSelection.Width - 80) / 6), (int)(ModeConfigButtonTypeSelection.Height - 10));

            TypeKnobFaders.Location = new Point(5 + ((int)((ModeConfigSelection.Width - 80) / 5) * 2) + (10 * 2), 5);
            TypeKnobFaders.Size = new Size((int)((ModeConfigSelection.Width - 80) / 6), (int)(ModeConfigButtonTypeSelection.Height - 10));

            TypeSlideFaders.Location = new Point(5 + ((int)((ModeConfigSelection.Width - 80) / 5) * 3) + (10 * 3), 5);
            TypeSlideFaders.Size = new Size((int)((ModeConfigSelection.Width - 80) / 6), (int)(ModeConfigButtonTypeSelection.Height - 10));

            TypeFaderButtons.Location = new Point(5 + ((int)((ModeConfigSelection.Width - 80) / 5) * 4) + (10 * 4), 5);
            TypeFaderButtons.Size = new Size((int)((ModeConfigSelection.Width - 80) / 6), (int)(ModeConfigButtonTypeSelection.Height - 10));

            ModeConfigButtonList.Location = new Point(10, (int)(ModeConfigControlPanel.Height * 0.2) + 5);
            ModeConfigButtonList.Size = new Size(ModeConfigControlPanel.Width, (int)(ModeConfigControlPanel.Height * 0.8) - 10);

            Update();
        }
    }
}
