using System.Collections.Generic;
using System.Text;
using Umax.Interfaces.Enums;

namespace Umax.Interfaces.Containers.Items
{
    public interface IPage : IItem
    {
        string URL { get; }
        List<string> Keywords { get; }

        FileType Type { get; }
        Encoding Encoding { get; }
        string Content { get; set; }

        string Tag { get; set; }

        /// <summary>
        /// Gets or sets category
        /// </summary>
        ICategory Category { get; }


        void Save();

        #region Continues
        int ContinueNumber { get; }//number of page for map and continuous pages, start with 1
        int ContinueNumberStart { get; }//start index of items
        int ContinueNumberEnd { get; }//end index of items
        #endregion
    }
}
