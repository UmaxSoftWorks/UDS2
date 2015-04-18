using System.Collections.Generic;

namespace Umax.Plugins.Tasks.Classes
{
    public class HTMLLink
    {
        public HTMLLink()
        {
            this.URL = string.Empty;
            this.Keywords = new List<string>();
        }

        public string URL { get; set; }
        public List<string> Keywords { get; set; }
    }
}
