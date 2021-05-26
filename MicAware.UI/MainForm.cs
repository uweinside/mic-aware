using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Elgato;
using MicAware.UI.Properties;
using VoiceMeeter;

namespace MicAware.UI
{
    public partial class MainForm : Form
    {
        private static bool _pulseOn = true;
        private static int _retryCount = 0;
        private static readonly string LightStripUri = Settings.Default.LightStripUri;
        public static readonly int LightStripPort = Settings.Default.LightStripPort;
        private static readonly LightApi LightApi = new(LightStripUri, LightStripPort);
        private static StatusInfo.VoiceMeeterStatus _voiceMeeterStatus;
        private static StatusInfo.LightStripStatus _lightStripStatus = StatusInfo.LightStripStatus.Unknown;
        private static StatusInfo.MicrophoneStatus _microphoneStatus = StatusInfo.MicrophoneStatus.Unknown;

        public MainForm(StatusInfo.VoiceMeeterStatus voiceMeeterStatus)
        {
            InitializeComponent();
            _voiceMeeterStatus = voiceMeeterStatus;
            DisplayVoiceMeeterStatus();
            DisplayMicrophoneStatus();
            if (_voiceMeeterStatus == StatusInfo.VoiceMeeterStatus.LoggedIn) TimerHeartbeat.Enabled = true;
        }

        private void timerFlashPulse_Tick(object sender, EventArgs e)
        {
            if (_pulseOn)
                SendLightsRed();
            else
                SendLightsOff();

            _pulseOn = !_pulseOn;
        }

        private void DisplayVoiceMeeterStatus()
        {
            switch (_voiceMeeterStatus)
            {
                case StatusInfo.VoiceMeeterStatus.LoggedIn:
                    VoiceMeeterStatusLabel.Text = "OK";
                    VoiceMeeterStatusLabel.ForeColor = Color.White;
                    VoiceMeeterLabel.ForeColor = Color.White;
                    VoiceMeeterPanel.BackColor = Color.Green;
                    break;
                case StatusInfo.VoiceMeeterStatus.Error:
                    VoiceMeeterStatusLabel.Text = "Error";
                    VoiceMeeterStatusLabel.ForeColor = Color.White;
                    VoiceMeeterLabel.ForeColor = Color.White;
                    VoiceMeeterPanel.BackColor = Color.Red;
                    break;
                case StatusInfo.VoiceMeeterStatus.Unknown:
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
            switch (_microphoneStatus)
            {
                case StatusInfo.MicrophoneStatus.On:
                    MicrophonePanel.BackColor = Color.Green;
                    MicrophoneLabel.ForeColor = Color.White;
                    MicrophoneStatusLabel.ForeColor = Color.White;
                    SendLightsGreen();
                    MicrophoneStatusLabel.Text = "ON";
                    break;
                case StatusInfo.MicrophoneStatus.Off:
                    MicrophonePanel.BackColor = Color.Green;
                    MicrophoneLabel.ForeColor = Color.White;
                    MicrophoneStatusLabel.ForeColor = Color.White;
                    MicrophoneStatusLabel.Text = "OFF";
                    break;
                case StatusInfo.MicrophoneStatus.Error:
                    MicrophoneLabel.ForeColor = Color.White;
                    MicrophonePanel.BackColor = Color.Red;
                    MicrophoneStatusLabel.ForeColor = Color.White;
                    MicrophoneStatusLabel.Text = "OFF";
                    break;
                case StatusInfo.MicrophoneStatus.Unknown:
                    MicrophonePanel.BackColor = Color.DodgerBlue;
                    MicrophoneLabel.ForeColor = Color.Black;
                    MicrophoneStatusLabel.ForeColor = Color.Black;
                    MicrophoneStatusLabel.Text = "Wait";
                    SendLightsBlue();
                    break;
                default:
                    MicrophonePanel.BackColor = Color.DodgerBlue;
                    MicrophoneLabel.ForeColor = Color.Black;
                    MicrophoneStatusLabel.ForeColor = Color.Black;
                    MicrophoneStatusLabel.Text = "Wait";
                    SendLightsBlue();
                    break;
            }
        }

        private void DisplayLightStripStatus()
        {
            switch (_lightStripStatus)
            {
                case StatusInfo.LightStripStatus.OK:
                    LightStripPanel.BackColor = Color.Green;
                    LightStripLabel.ForeColor = Color.White;
                    LightStripStatusLabel.ForeColor = Color.White;
                    LightStripStatusLabel.Text = "OK";
                    break;
                case StatusInfo.LightStripStatus.Error:
                    LightStripPanel.BackColor = Color.Red;
                    LightStripLabel.ForeColor = Color.White;
                    LightStripStatusLabel.ForeColor = Color.White;
                    LightStripStatusLabel.Text = "Error";
                    break;
                case StatusInfo.LightStripStatus.Unknown:
                    LightStripPanel.BackColor = Color.DodgerBlue;
                    LightStripLabel.ForeColor = Color.White;
                    LightStripStatusLabel.ForeColor = Color.White;
                    LightStripStatusLabel.Text = "Wait";
                    break;
            }
        }

        private void SendLightsRed()
        {
            var res = LightApi.SendLightStatusColor(true, 0, 100, 100);
            SetLightStripStatus(res);
        }

        private void SendLightsBlue()
        {
            var res = LightApi.SendLightStatusColor(true, 240, 100, 100);
            SetLightStripStatus(res);
        }

        private void SendLightsGreen()
        {
            var res = LightApi.SendLightStatusColor(true, 107, 100, 100);
            SetLightStripStatus(res);
        }

        private void SendLightsOff()
        {
            var res = LightApi.SendLightStatusOnOff(false);
            SetLightStripStatus(res);
        }

        private void SendLightsOn()
        {
            var res = LightApi.SendLightStatusOnOff(true);
            SetLightStripStatus(res);
        }

        private void SetLightStripStatus(string statusJson)
        {
            if (statusJson == null)
                _lightStripStatus = StatusInfo.LightStripStatus.Error;
            else
            {
                _lightStripStatus = StatusInfo.LightStripStatus.OK;
            }
            DisplayLightStripStatus();
        }

        private void TimerHeartbeat_Tick(object sender, EventArgs e)
        {
            var isDirty = Remote.IsParametersDirty();
            Debug.WriteLine($"isDirty: {isDirty}");

            // VoiceMeeter is connected
            if (isDirty == 1)
            {
                _microphoneStatus = StatusInfo.MicrophoneStatus.Unknown;
                _voiceMeeterStatus = StatusInfo.VoiceMeeterStatus.LoggedIn;

                var res = Remote.GetParameter("Strip[0].Mute");
                switch (res)
                {
                    case 0:
                        _microphoneStatus = StatusInfo.MicrophoneStatus.On;
                        TimerBlink.Enabled = false;
                        break;
                    case 1:
                        _microphoneStatus = StatusInfo.MicrophoneStatus.Off;
                        _pulseOn = true;
                        TimerBlink.Enabled = true;
                        break;
                    default:
                        TimerBlink.Enabled = false;
                        _microphoneStatus = StatusInfo.MicrophoneStatus.Unknown;
                        break;
                }
            }

            // VoiceMeeter is disconnected
            if (isDirty == -2)
            {
                _microphoneStatus = StatusInfo.MicrophoneStatus.Unknown;
                _voiceMeeterStatus = StatusInfo.VoiceMeeterStatus.Error;
                TimerBlink.Enabled = false;
            }

            DisplayVoiceMeeterStatus();
            DisplayMicrophoneStatus();
        }

        private void TimerBlink_Tick(object sender, EventArgs e)
        {
            if (_pulseOn)
                SendLightsRed();
            else
                SendLightsOff();
            
            _pulseOn = !_pulseOn;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SendLightsOff();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // no comment
        }
    }
}