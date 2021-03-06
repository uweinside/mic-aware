
namespace MicAware
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.VoiceMeeterLabel = new System.Windows.Forms.Label();
            this.VoiceMeeterPanel = new System.Windows.Forms.Panel();
            this.VoiceMeeterStatusLabel = new System.Windows.Forms.Label();
            this.MicrophonePanel = new System.Windows.Forms.Panel();
            this.MicrophoneLabel = new System.Windows.Forms.Label();
            this.MicrophoneStatusLabel = new System.Windows.Forms.Label();
            this.LightStripPanel = new System.Windows.Forms.Panel();
            this.LightStripLabel = new System.Windows.Forms.Label();
            this.LightStripStatusLabel = new System.Windows.Forms.Label();
            this.TimerHeartbeat = new System.Windows.Forms.Timer(this.components);
            this.TimerBlink = new System.Windows.Forms.Timer(this.components);
            this.NotifyIconGreen = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuStripTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerMinimize = new System.Windows.Forms.Timer(this.components);
            this.NotifyIconRed = new System.Windows.Forms.NotifyIcon(this.components);
            this.VoiceMeeterPanel.SuspendLayout();
            this.MicrophonePanel.SuspendLayout();
            this.LightStripPanel.SuspendLayout();
            this.MenuStripTrayIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // VoiceMeeterLabel
            // 
            this.VoiceMeeterLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoiceMeeterLabel.ForeColor = System.Drawing.Color.White;
            this.VoiceMeeterLabel.Location = new System.Drawing.Point(4, 15);
            this.VoiceMeeterLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.VoiceMeeterLabel.Name = "VoiceMeeterLabel";
            this.VoiceMeeterLabel.Size = new System.Drawing.Size(92, 20);
            this.VoiceMeeterLabel.TabIndex = 3;
            this.VoiceMeeterLabel.Text = "VoiceMeeter";
            this.VoiceMeeterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VoiceMeeterPanel
            // 
            this.VoiceMeeterPanel.BackColor = System.Drawing.Color.DarkGray;
            this.VoiceMeeterPanel.Controls.Add(this.VoiceMeeterStatusLabel);
            this.VoiceMeeterPanel.Controls.Add(this.VoiceMeeterLabel);
            this.VoiceMeeterPanel.Location = new System.Drawing.Point(0, 0);
            this.VoiceMeeterPanel.Name = "VoiceMeeterPanel";
            this.VoiceMeeterPanel.Size = new System.Drawing.Size(100, 100);
            this.VoiceMeeterPanel.TabIndex = 4;
            // 
            // VoiceMeeterStatusLabel
            // 
            this.VoiceMeeterStatusLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoiceMeeterStatusLabel.ForeColor = System.Drawing.Color.White;
            this.VoiceMeeterStatusLabel.Location = new System.Drawing.Point(4, 35);
            this.VoiceMeeterStatusLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.VoiceMeeterStatusLabel.Name = "VoiceMeeterStatusLabel";
            this.VoiceMeeterStatusLabel.Size = new System.Drawing.Size(96, 41);
            this.VoiceMeeterStatusLabel.TabIndex = 4;
            this.VoiceMeeterStatusLabel.Text = "OK";
            this.VoiceMeeterStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MicrophonePanel
            // 
            this.MicrophonePanel.BackColor = System.Drawing.Color.DarkGray;
            this.MicrophonePanel.Controls.Add(this.MicrophoneLabel);
            this.MicrophonePanel.Controls.Add(this.MicrophoneStatusLabel);
            this.MicrophonePanel.Location = new System.Drawing.Point(102, 0);
            this.MicrophonePanel.Name = "MicrophonePanel";
            this.MicrophonePanel.Size = new System.Drawing.Size(100, 100);
            this.MicrophonePanel.TabIndex = 5;
            // 
            // MicrophoneLabel
            // 
            this.MicrophoneLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MicrophoneLabel.ForeColor = System.Drawing.Color.White;
            this.MicrophoneLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MicrophoneLabel.Location = new System.Drawing.Point(5, 15);
            this.MicrophoneLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.MicrophoneLabel.Name = "MicrophoneLabel";
            this.MicrophoneLabel.Size = new System.Drawing.Size(89, 20);
            this.MicrophoneLabel.TabIndex = 4;
            this.MicrophoneLabel.Text = "Microphone";
            this.MicrophoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MicrophoneStatusLabel
            // 
            this.MicrophoneStatusLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MicrophoneStatusLabel.ForeColor = System.Drawing.Color.White;
            this.MicrophoneStatusLabel.Location = new System.Drawing.Point(0, 35);
            this.MicrophoneStatusLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.MicrophoneStatusLabel.Name = "MicrophoneStatusLabel";
            this.MicrophoneStatusLabel.Size = new System.Drawing.Size(100, 41);
            this.MicrophoneStatusLabel.TabIndex = 3;
            this.MicrophoneStatusLabel.Text = "ON";
            this.MicrophoneStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LightStripPanel
            // 
            this.LightStripPanel.BackColor = System.Drawing.Color.DarkGray;
            this.LightStripPanel.Controls.Add(this.LightStripLabel);
            this.LightStripPanel.Controls.Add(this.LightStripStatusLabel);
            this.LightStripPanel.Location = new System.Drawing.Point(204, 0);
            this.LightStripPanel.Name = "LightStripPanel";
            this.LightStripPanel.Size = new System.Drawing.Size(100, 100);
            this.LightStripPanel.TabIndex = 6;
            // 
            // LightStripLabel
            // 
            this.LightStripLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LightStripLabel.ForeColor = System.Drawing.Color.White;
            this.LightStripLabel.Location = new System.Drawing.Point(0, 15);
            this.LightStripLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LightStripLabel.Name = "LightStripLabel";
            this.LightStripLabel.Size = new System.Drawing.Size(100, 20);
            this.LightStripLabel.TabIndex = 5;
            this.LightStripLabel.Text = "LightStrip";
            this.LightStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LightStripStatusLabel
            // 
            this.LightStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LightStripStatusLabel.ForeColor = System.Drawing.Color.White;
            this.LightStripStatusLabel.Location = new System.Drawing.Point(0, 35);
            this.LightStripStatusLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LightStripStatusLabel.Name = "LightStripStatusLabel";
            this.LightStripStatusLabel.Size = new System.Drawing.Size(100, 41);
            this.LightStripStatusLabel.TabIndex = 3;
            this.LightStripStatusLabel.Text = "OK";
            this.LightStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimerHeartbeat
            // 
            this.TimerHeartbeat.Interval = 250;
            this.TimerHeartbeat.Tick += new System.EventHandler(this.TimerHeartbeat_Tick);
            // 
            // TimerBlink
            // 
            this.TimerBlink.Interval = 1000;
            this.TimerBlink.Tick += new System.EventHandler(this.TimerBlink_Tick);
            // 
            // NotifyIconGreen
            // 
            this.NotifyIconGreen.BalloonTipText = "MicAware";
            this.NotifyIconGreen.BalloonTipTitle = "MicAware";
            this.NotifyIconGreen.ContextMenuStrip = this.MenuStripTrayIcon;
            this.NotifyIconGreen.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIconGreen.Icon")));
            this.NotifyIconGreen.Text = "MicAware";
            this.NotifyIconGreen.DoubleClick += new System.EventHandler(this.NotifyIconMain_DoubleClick);
            // 
            // MenuStripTrayIcon
            // 
            this.MenuStripTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemShow,
            this.MenuItemExit});
            this.MenuStripTrayIcon.Name = "MenuStripTrayIcon";
            this.MenuStripTrayIcon.Size = new System.Drawing.Size(104, 48);
            // 
            // MenuItemShow
            // 
            this.MenuItemShow.Name = "MenuItemShow";
            this.MenuItemShow.Size = new System.Drawing.Size(103, 22);
            this.MenuItemShow.Text = "&Show";
            this.MenuItemShow.Click += new System.EventHandler(this.MenuItemShow_Click);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(103, 22);
            this.MenuItemExit.Text = "&Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // TimerMinimize
            // 
            this.TimerMinimize.Enabled = true;
            this.TimerMinimize.Interval = 10000;
            this.TimerMinimize.Tick += new System.EventHandler(this.TimerMinimize_Tick);
            // 
            // NotifyIconRed
            // 
            this.NotifyIconRed.BalloonTipText = "MicAware";
            this.NotifyIconRed.BalloonTipTitle = "MicAware";
            this.NotifyIconRed.ContextMenuStrip = this.MenuStripTrayIcon;
            this.NotifyIconRed.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIconRed.Icon")));
            this.NotifyIconRed.Text = "MicAware";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 99);
            this.Controls.Add(this.LightStripPanel);
            this.Controls.Add(this.MicrophonePanel);
            this.Controls.Add(this.VoiceMeeterPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MicAware 1.0";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.VoiceMeeterPanel.ResumeLayout(false);
            this.MicrophonePanel.ResumeLayout(false);
            this.LightStripPanel.ResumeLayout(false);
            this.MenuStripTrayIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label VoiceMeeterLabel;
        private System.Windows.Forms.Panel VoiceMeeterPanel;
        private System.Windows.Forms.Panel MicrophonePanel;
        private System.Windows.Forms.Label MicrophoneLabel;
        private System.Windows.Forms.Panel LightStripPanel;
        private System.Windows.Forms.Label LightStripLabel;
        private System.Windows.Forms.Label VoiceMeeterStatusLabel;
        private System.Windows.Forms.Label MicrophoneStatusLabel;
        private System.Windows.Forms.Label LightStripStatusLabel;
        private System.Windows.Forms.Timer TimerHeartbeat;
        private System.Windows.Forms.Timer TimerBlink;
        private System.Windows.Forms.NotifyIcon NotifyIconGreen;
        private System.Windows.Forms.Timer TimerMinimize;
        private System.Windows.Forms.ContextMenuStrip MenuStripTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.NotifyIcon NotifyIconRed;
        private System.Windows.Forms.ToolStripMenuItem MenuItemShow;
    }
}