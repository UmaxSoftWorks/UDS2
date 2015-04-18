using System.Collections.Generic;
using System.Text;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;

namespace Core.Classes.Containers.Items
{
    public class Page : IPage
    {
        #region Information
        public string URL { get; set; }
        public List<string> Keywords { get; set; }
        public FileType Type { get; set; }
        public Encoding Encoding { get; set; }
        public string Content { get; set; }
        public ICategory Category { get; set; }
        public int ContinueNumber { get; set; }
        public int ContinueNumberStart { get; set; }
        public int ContinueNumberEnd { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Tag { get; set; }

        #endregion

        public void Save()
        {
            
        }

        public void Dispose()
        {
            
        }
    }
}
