using System;
using Umax.Interfaces.Enums;
using Umax.Plugins.Tasks.Enums;

namespace Umax.Plugins.Tasks.Classes
{
    [Serializable]
    public class FileToken
    {
        /// <summary>
        /// Gets or sets Token Name
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets File Path
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets Encoding
        /// </summary>
        public EncodingType Encoding { get; set; }

        /// <summary>
        /// Gets or sets Token type
        /// </summary>
        public FileTokenType Type { get; set; }

        public FileToken()
        {
            this.Token = string.Empty;
            this.Path = string.Empty;

            this.Encoding = EncodingType.ANSI;
            this.Type = FileTokenType.ReadRandomLine;
        }
    }
}
