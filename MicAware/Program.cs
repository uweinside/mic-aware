using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voicemeeter;

namespace MicAware
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

            Application.Run(new MainForm());

            var resLogout = VoiceMeeter.Remote.Logout();
            if (!resLogout)
                MessageBox.Show("VoiceMeeter log out failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}
