using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voicemeeter;
using VoiceMeeter;
using Elgato;

namespace MicFlasher.UI
{
    public partial class MainForm : Form
    {
        private static bool pulseOn = true;
        private static readonly LightApi lightApi = new LightApi("192.168.178.83", 9123);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Remote.Login(RunVoicemeeterParam.VoicemeeterBanana, false);
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Remote.Logout();
        }

        private void timerFlashPulse_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine(pulseOn
                ? lightApi.SendLightStatusColor(true, 0, 100, 100)
                : lightApi.SendLightStatusOnOff(false));
            pulseOn = !pulseOn;
        }

        private void lblMuteStatus_Click(object sender, EventArgs e)
        {

        }

        //private async void timerHeartbeat_Tick(object sender, EventArgs e)
        //{
        //    var isDirty = Remote.IsParametersDirty();
        //    if (isDirty == 1)
        //    {
        //        var res = Remote.GetParameter("Strip[0].Mute");

        //        var muteStatus = "unknown";

        //        switch (res)
        //        {
        //            case 0:
        //                muteStatus = "Mute OFF";
        //                await LightsGreenAsync();
        //                break;
        //            case 1:
        //                muteStatus = "Mute ON";
        //                break;
        //            default:
        //                muteStatus = "undefined";
        //                break;
        //        }


    }
}