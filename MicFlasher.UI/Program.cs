using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voicemeeter;

namespace MicFlasher.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>


        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StatusInfo.VoiceMeeterStatus voiceMeeterStatus = StatusInfo.VoiceMeeterStatus.Unknown;
            var resLogin = VoiceMeeter.Remote.Login(RunVoicemeeterParam.VoicemeeterBanana, false);
            voiceMeeterStatus =
                resLogin ? (StatusInfo.VoiceMeeterStatus)StatusInfo.VoiceMeeterStatus.LoggedIn : StatusInfo.VoiceMeeterStatus.Error;

            Application.Run(new MainForm(voiceMeeterStatus));

            var resLogout = VoiceMeeter.Remote.Logout();
            if (!resLogout)
                MessageBox.Show("VoiceMeeter log out failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

    public static class StatusInfo
    {
        public enum VoiceMeeterStatus
        {
            LoggedIn,
            Error,
            Unknown
        }

        public enum MicrophoneStatus
        {
            On,
            Off,
            Error,
            Unknown
        }

        public enum LightStripStatus
        {
            OK,
            Error,
            Unknown
        }


    }
}
