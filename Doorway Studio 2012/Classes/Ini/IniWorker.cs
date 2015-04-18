using System.Runtime.InteropServices;
using System.Text;

namespace Umax.Classes.Ini
{
    public class IniWorker
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
            string key,string def, StringBuilder retVal, int size, string filePath);

        public string FilePath
        {
            get;
            protected set;
        }

        public IniWorker(string Path)
        {
            this.FilePath = Path;
        }

        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.FilePath);
        }

        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, string.Empty, temp, 255, this.FilePath);
            return temp.ToString();
        }

        public string IniReadValue(string Section, string Key, string DefaultValue)
        {
            StringBuilder temp = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, string.Empty, temp, 255, this.FilePath);
            return string.IsNullOrEmpty(temp.ToString()) ? DefaultValue : temp.ToString();
        }

        public static void IniWriteValue(string Section, string Key, string Value, string FilePath)
        {
            WritePrivateProfileString(Section, Key, Value, FilePath);
        }

        public static string IniReadValue(string Section, string Key, string FilePath, string DefaultValue)
        {
            StringBuilder temp = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, string.Empty, temp, 255, FilePath);
            return string.IsNullOrEmpty(temp.ToString()) ? DefaultValue : temp.ToString();
        }

    }
}
