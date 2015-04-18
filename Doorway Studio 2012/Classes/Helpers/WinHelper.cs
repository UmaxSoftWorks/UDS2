using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Umax.Classes.Helpers
{
    public static class WinHelper
    {
        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, int Msg, int wParam, string lParam);

        [DllImport("User32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wparam, int lparam);

        public static void SendMessage(Keys Key, string WindowName)
        {
            int WM_KEYDOWN = 256;
            int hwnd = FindWindow(null, WindowName);

            if (hwnd != 0)
            {
                SendMessage(hwnd, WM_KEYDOWN, (int)Key, String.Empty);
            }
        }

        public static string ReadRegistryKey(string Path, string Name)
        {
            try
            {
                return Registry.CurrentUser.OpenSubKey(Path, true).GetValue(Name, String.Empty).ToString();
            }
            catch (Exception)
            {
                return String.Empty;
            }
        }

        [DllImport("user32.dll")]
        public static extern bool LockWindowUpdate(IntPtr hWndLock);

        public static void LockUpdate(this Control Control)
        {
            LockWindowUpdate(Control.Handle);
        }

        public static void UnLockUpdate(this Control Control)
        {
            LockWindowUpdate(IntPtr.Zero);
        }

        public static void SetReDraw(this Control Control, bool Value)
        {
            SendMessage(Control.Handle, 0x000B, Value ? 1 : 0, 0);
        }

        public static void WriteRegistryKey(string Path, string Name, string Value)
        {
            try
            {
                // Create new registry folder
                RegistryKey key = Registry.CurrentUser.OpenSubKey(Path, true) ?? Registry.CurrentUser.CreateSubKey(Path);
                key.SetValue(Name, Value);
            }
            catch (Exception) { }
        }

        public static void RemoveRegistryKey(string Path, string Name)
        {
            try
            {
                Registry.CurrentUser.OpenSubKey(Path, true).DeleteValue(Name, false);
            }
            catch (Exception) { }
        }

        [DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, uint Msg);

        private const uint SW_RESTORE = 0x09;

        public static void Restore(this Form form)
        {
            ShowWindow(form.Handle, SW_RESTORE);
        }

        public static DialogResult MessageBox(string Text, string Title, MessageBoxButtons Buttons, MessageBoxIcon Icon)
        {
            return System.Windows.Forms.MessageBox.Show(Text, Title, Buttons, Icon);
        }
    }
}
