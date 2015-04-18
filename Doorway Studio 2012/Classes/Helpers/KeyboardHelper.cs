using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Umax.Classes.Helpers
{
    public class KeyboardHelper
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        private static extern int ToUnicodeEx(
            uint wVirtKey,
            uint wScanCode,
            Keys[] lpKeyState,
            StringBuilder pwszBuff,
            int cchBuff,
            uint wFlags,
            IntPtr dwhkl);

        [DllImport("user32.dll", ExactSpelling = true)]
        internal static extern IntPtr GetKeyboardLayout(uint threadId);

        [DllImport("user32.dll", ExactSpelling = true)]
        internal static extern bool GetKeyboardState(Keys[] keyStates);

        [DllImport("user32.dll", ExactSpelling = true)]
        internal static extern uint GetWindowThreadProcessId(IntPtr hwindow, out uint processId);

        // http://stackoverflow.com/questions/370754/convert-a-keycode-to-the-relevant-display-character
        public static string CodeToString(int scanCode)
        {
            uint procId;
            uint thread = GetWindowThreadProcessId(Process.GetCurrentProcess().MainWindowHandle, out procId);
            IntPtr hkl = GetKeyboardLayout(thread);

            if (hkl == IntPtr.Zero)
            {
                return string.Empty;
            }

            Keys[] keyStates = new Keys[256];
            if (!GetKeyboardState(keyStates))
                return string.Empty;

            StringBuilder sb = new StringBuilder(10);
            int rc = ToUnicodeEx((uint)scanCode, (uint)scanCode, keyStates, sb, sb.Capacity, 0, hkl);
            return sb.ToString();
        }
    }
}
