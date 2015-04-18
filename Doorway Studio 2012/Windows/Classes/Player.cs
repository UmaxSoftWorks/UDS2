using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Umax.Windows.Classes
{
    public class Player
    {
        [DllImport("winmm.dll")]
        protected static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        private static Player instanse;
        public static Player Instanse
        {
            get { return instanse ?? (instanse = new Player()); }
        }

        private Player()
        {
        }

        protected bool Open(string File)
        {
            if (!System.IO.File.Exists(File))
            {
                return false;
            }
            mciSendString("open \"" + File + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            return true;
        }

        public bool Playing { get; protected set; }


        public void Play(string FileName, int Length, bool Loop)
        {
            // Open
            if (this.Open(FileName))
            {
                // Play
                string command = "play MediaFile from 0 to " + (Length * 1000).ToString();
                if (Loop)
                {
                    command += " REPEAT";
                }

                mciSendString(command, null, 0, IntPtr.Zero);
            }
        }

        public void Stop()
        {
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
        }
    }

}
