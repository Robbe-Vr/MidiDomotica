using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MidiDomotica.Core.MidiConnection.DeviceConnection;

namespace MidiDomotica
{
    class MidiDomoticaContext : ApplicationContext
    {
        private MidiDomotica form;

        private NotifyIcon TrayIcon;
        private ContextMenuStrip TrayIconContextMenu;
        private ToolStripMenuItem FormToggleItem;
        private ToolStripMenuItem ReconnectItem;
        private ToolStripMenuItem CloseMenuItem;

        public MidiDomoticaContext()
        {
            form = new MidiDomotica();

            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            InitializeComponent();
            TrayIcon.Visible = true;

            form.onNotificationReady += ShowNotification;

            ShowNotification(this, new NotifyEventArgs()
            {
                Title = "MidiDomotica",
                MessageStringFormat = "MidiDomotica is all set up!",
            });
        }

        private void ShowNotification(object sender, NotifyEventArgs e)
        {
            TrayIcon.BalloonTipIcon = ToolTipIcon.Info;
            TrayIcon.BalloonTipText = e.Params != null ? String.Format(e.MessageStringFormat, e.Params) : e.MessageStringFormat;
            TrayIcon.BalloonTipTitle = e.Title ?? "MidiDomotica action performed!";

            TrayIcon.ShowBalloonTip(2000);
        }

        private void InitializeComponent()
        {
            TrayIcon = new NotifyIcon();
            TrayIcon.Text = "MidiDomotica";

            TrayIcon.Icon = Properties.Resources.TrayIcon;

            TrayIcon.DoubleClick += TrayIcon_DoubleClick;

            TrayIconContextMenu = new ContextMenuStrip();
            FormToggleItem = new ToolStripMenuItem();
            ReconnectItem = new ToolStripMenuItem();
            CloseMenuItem = new ToolStripMenuItem();
            TrayIconContextMenu.SuspendLayout();

            // 
            // TrayIconContextMenu
            // 
            this.TrayIconContextMenu.Items.AddRange(new ToolStripItem[] {
                this.FormToggleItem,
                this.ReconnectItem,
                this.CloseMenuItem,
            });
            this.TrayIconContextMenu.Name = "MidiDomotica";
            this.TrayIconContextMenu.Size = new Size(153, 70);

            //
            // FormMenuItem
            //
            this.FormToggleItem.Name = "FormToggle";
            this.FormToggleItem.Size = new Size(152, 152);
            this.FormToggleItem.Text = form.Visible ? "Hide" : "Show";
            this.FormToggleItem.Click += new EventHandler(this.FormToggleButton_Click);

            //
            // FormMenuItem
            //
            this.ReconnectItem.Name = "Reconnect";
            this.ReconnectItem.Size = new Size(152, 152);
            this.ReconnectItem.Text = "Connect";
            this.ReconnectItem.Click += new EventHandler(this.ReconnectButton_Click);

            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new Size(152, 22);
            this.CloseMenuItem.Text = "Close MidiDomotica";
            this.CloseMenuItem.Click += new EventHandler(this.CloseMenuItem_Click);

            TrayIconContextMenu.ResumeLayout(false);
            TrayIcon.ContextMenuStrip = TrayIconContextMenu;
        }

        private void FormToggleButton_Click(object sender, EventArgs e)
        {
            ToggleForm();
        }
        private void ToggleForm()
        {
            if (form != null && !form.IsDisposed && form.Visible)
            {
                form.ToggleForm(false);
                this.FormToggleItem.Text = "Show";
            }
            else
            {
                if (form == null || form.IsDisposed)
                {
                    form = null;
                    form = new MidiDomotica();
                    form.onNotificationReady += ShowNotification;
                }
                form.ToggleForm(true);
                this.FormToggleItem.Text = "Hide";
            }
        }

        private void ReconnectButton_Click(object sender, EventArgs e)
        {
            form.SearchMidiDevice();
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close MidiDomotica?",
                    "Close MidiDomotica?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            form.Close();
            form.Dispose();
            form = null;

            TrayIcon.Visible = false;
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            ToggleForm();
        }
    }
}
