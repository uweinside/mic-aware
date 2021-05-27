using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicAware
{
    public static class SystemStatus
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
