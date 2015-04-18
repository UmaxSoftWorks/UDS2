using System.Collections.Generic;
using Umax.Plugins.Tasks.Enums;

namespace Umax.Plugins.Tasks.Classes
{
    public class Tag
    {
        public Tag()
        {
            this.Path = string.Empty;
            this.Encoding = EncodingType.ANSI;

            this.Items = new List<string>();
        }

        /// <summary>
        /// Gets or sets File Path
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets Encoding
        /// </summary>
        public EncodingType Encoding { get; set; }

        /// <summary>
        /// Gets or sets Tag items
        /// </summary>
        public List<string> Items { get; set; }
    }
}
