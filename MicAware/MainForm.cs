using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Elgato;
using MicAware.Properties;
using Voicemeeter;
using VoiceMeeter;

namespace MicAware
{
    public partial class MainForm : Form
    {
        #region Constructor

        public MainForm()
        {
            InitializeComponent();
            voiceMeeterStatus = SystemStatus.VoiceMeeterStatus.Unknown;
        }

        #endregion

        #region Variables

        private static readonly string lightStripUri = Settings.Default.LightStripUri;
        private static readonly int lightStripPort = Settings.Default.LightStripPort;
        private static readonly LightApi lightApi = new(lightStripUri, lightStripPort);

        private static SystemStatus.VoiceMeeterStatus voiceMeeterStatus;
        private static SystemStatus.LightStripStatus lightStripStatus = SystemStatus.LightStripStatus.Unknown;
        private static SystemStatus.MicrophoneStatus microphoneStatus = SystemStatus.MicrophoneStatus.Unknown;
        private static bool pulseOn = true;

        #endregion

        #region Status Display

        private void DisplayVoiceMeeterStatus()
        {
            switch (voiceMeeterStatus)
            {
                case SystemStatus.VoiceMeeterStatus.LoggedIn:
                    VoiceMeeterStatusLabel.Text = "OK";
                    VoiceMeeterStatusLabel.ForeColor = Color.White;
                    VoiceMeeterLabel.ForeColor = Color.White;
                    VoiceMeeterPanel.BackColor = Color.Green;
                    break;
                case SystemStatus.VoiceMeeterStatus.Error:
                    VoiceMeeterStatusLabel.Text = "Error";
                    VoiceMeeterStatusLabel.ForeColor = Color.White;
                    VoiceMeeterLabel.ForeColor = Color.White;
                    VoiceMeeterPanel.BackColor = Color.Red;
                    break;
                case SystemStatus.VoiceMeeterStatus.Unknown:
                    VoiceMeeterStatusLabel.Text = string.Empty;
                    VoiceMeeterStatusLabel.ForeColor = Color.White;
                    VoiceMeeterLabel.ForeColor = Color.Black;
                    VoiceMeeterPanel.BackColor = Color.DodgerBlue;
                    break;
                default:
                    VoiceMeeterLabel.Text = string.Empty;
                    VoiceMeeterStatusLabel.ForeColor = Color.Black;
                    VoiceMeeterLabel.ForeColor = Color.Black;
                    VoiceMeeterPanel.BackColor = Color.White;
                    break;
            }
        }

        private void DisplayMicrophoneStatus()
        {
            switch (microphoneStatus)
            {
                case SystemStatus.MicrophoneStatus.On:
                    MicrophonePanel.BackColor = Color.Green;
                    MicrophoneLabel.ForeColor = Color.White;
                    MicrophoneStatusLabel.ForeColor = Color.White;
                    SetLightSignalMicOn();
                    MicrophoneStatusLabel.Text = "ON";
                    break;
                case SystemStatus.MicrophoneStatus.Off:
                    MicrophonePanel.BackColor = Color.Green;
                    MicrophoneLabel.ForeColor = Color.White;
                    MicrophoneStatusLabel.ForeColor = Color.White;
                    MicrophoneStatusLabel.Text = "OFF";
                    break;
                case SystemStatus.MicrophoneStatus.Error:
                    MicrophoneLabel.ForeColor = Color.White;
                    MicrophonePanel.BackColor = Color.Red;
                    MicrophoneStatusLabel.ForeColor = Color.White;
                    MicrophoneStatusLabel.Text = "OFF";
                    break;
                case SystemStatus.MicrophoneStatus.Unknown:
                    MicrophonePanel.BackColor = Color.DodgerBlue;
                    MicrophoneLabel.ForeColor = Color.Black;
                    MicrophoneStatusLabel.ForeColor = Color.Black;
                    MicrophoneStatusLabel.Text = "Wait";
                    SetLightSignalMicStatusUnknown();
                    break;
                default:
                    MicrophonePanel.BackColor = Color.DodgerBlue;
                    MicrophoneLabel.ForeColor = Color.Black;
                    MicrophoneStatusLabel.ForeColor = Color.Black;
                    MicrophoneStatusLabel.Text = "Wait";
                    SetLightSignalMicStatusUnknown();
                    break;
            }
        }

        private void DisplayLightStripStatus()
        {
            switch (lightStripStatus)
            {
                case SystemStatus.LightStripStatus.OK:
                    LightStripPanel.BackColor = Color.Green;
                    LightStripLabel.ForeColor = Color.White;
                    LightStripStatusLabel.ForeColor = Color.White;
                    LightStripStatusLabel.Text = "OK";
                    break;
                case SystemStatus.LightStripStatus.Error:
                    LightStripPanel.BackColor = Color.Red;
                    LightStripLabel.ForeColor = Color.White;
                    LightStripStatusLabel.ForeColor = Color.White;
                    LightStripStatusLabel.Text = "Error";
                    break;
                case SystemStatus.LightStripStatus.Unknown:
                    LightStripPanel.BackColor = Color.DodgerBlue;
                    LightStripLabel.ForeColor = Color.White;
                    LightStripStatusLabel.ForeColor = Color.White;
                    LightStripStatusLabel.Text = "Wait";
                    break;
            }
        }

        #endregion

        #region Light Signal Settings

        private void SetLightSignalMicOff()
        {
            var res = lightApi.SendLightStatusColor(true, 0, 100, 100);
            SetLightStripStatus(res);
        }

        private void SetLightSignalMicStatusUnknown()
        {
            var res = lightApi.SendLightStatusColor(true, 240, 100, 100);
            SetLightStripStatus(res);
        }

        private void SetLightSignalMicOn()
        {
            var res = lightApi.SendLightStatusColor(true, 107, 100, 100);
            SetLightStripStatus(res);
        }

        private void SetLightSignalOff()
        {
            var res = lightApi.SendLightStatusOnOff(false);
            SetLightStripStatus(res);
        }

        private void SetLightStripStatus(string statusJson)
        {
            if (statusJson == null)
                lightStripStatus = SystemStatus.LightStripStatus.Error;
            else
                lightStripStatus = SystemStatus.LightStripStatus.OK;
            DisplayLightStripStatus();
        }

        #endregion

        #region Control Events

        private void NotifyIconMain_DoubleClick(object sender, EventArgs e)
        {
            RestoreWindowFromMinimized();
        }

        private void MenuItemShow_Click(object sender, EventArgs e)
        {
            RestoreWindowFromMinimized();
        }

        private void RestoreWindowFromMinimized()
        {
            ShowInTaskbar = true;
            NotifyIconGreen.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Form Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            var resLogin = Remote.Login(RunVoicemeeterParam.VoicemeeterBanana, false);
            voiceMeeterStatus =
                resLogin ? SystemStatus.VoiceMeeterStatus.LoggedIn : SystemStatus.VoiceMeeterStatus.Error;

            DisplayVoiceMeeterStatus();
            DisplayMicrophoneStatus();

            if (voiceMeeterStatus == SystemStatus.VoiceMeeterStatus.LoggedIn) TimerHeartbeat.Enabled = true;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                NotifyIconGreen.Visible = true;
                TimerMinimize.Enabled = false;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SetLightSignalOff();
        }

        #endregion

        #region Timer

        private void TimerHeartbeat_Tick(object sender, EventArgs e)
        {
            var isDirty = Remote.IsParametersDirty();
            Debug.WriteLine($"isDirty: {isDirty}");

            // VoiceMeeter is connected
            if (isDirty == 1)
            {
                microphoneStatus = SystemStatus.MicrophoneStatus.Unknown;
                voiceMeeterStatus = SystemStatus.VoiceMeeterStatus.LoggedIn;

                var res = Remote.GetParameter("Strip[0].Mute");
                switch (res)
                {
                    case 0:
                        microphoneStatus = SystemStatus.MicrophoneStatus.On;
                        TimerBlink.Enabled = false;
                        break;
                    case 1:
                        microphoneStatus = SystemStatus.MicrophoneStatus.Off;
                        pulseOn = true;
                        TimerBlink.Enabled = true;
                        break;
                    default:
                        TimerBlink.Enabled = false;
                        microphoneStatus = SystemStatus.MicrophoneStatus.Unknown;
                        break;
                }
            }

            // VoiceMeeter is disconnected
            if (isDirty == -2)
            {
                microphoneStatus = SystemStatus.MicrophoneStatus.Unknown;
                voiceMeeterStatus = SystemStatus.VoiceMeeterStatus.Error;
                TimerBlink.Enabled = false;
            }

            DisplayVoiceMeeterStatus();
            DisplayMicrophoneStatus();
        }

        private void TimerBlink_Tick(object sender, EventArgs e)
        {
            if (pulseOn)
                SetLightSignalMicOff();
            else
                SetLightSignalOff();

            pulseOn = !pulseOn;
        }

        private void TimerMinimize_Tick(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
                WindowState = FormWindowState.Minimized;
            TimerMinimize.Enabled = false;
        }

        #endregion

    }
}