using System.IO;
using Umax.Plugins.Tasks.Enums;

namespace Umax.Plugins.Tasks.Classes
{
    public class FileTokenExecutor : FileToken
    {
        protected string[] Items;

        public FileTokenExecutor()
        {
            this.Items = new string[0];
        }

        public FileTokenExecutor(FileToken Token)
        {
            this.Token = Token.Token;
            this.Path = Token.Path;

            this.Encoding = Token.Encoding;
            this.Type = Token.Type;
        }

        public void Initialize()
        {
            this.Items = File.ReadAllLines(this.Path, (this.Encoding == EncodingType.ANSI) ? System.Text.Encoding.Default : System.Text.Encoding.UTF8);
        }

        public string Invoke(int SiteIndex, string Content)
        {
            return Content;
        }
    }
}
