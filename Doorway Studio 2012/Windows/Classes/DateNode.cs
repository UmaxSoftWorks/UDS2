using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Umax.Windows.Classes
{
    public class DateNode
    {
        public DateNode()
        {
            this.Nodes = new List<TreeNode>();
        }

        public DateNode(DateTime Date)
            : this()
        {
            this.Date = Date;
        }

        public DateTime Date { get; set; }

        public List<TreeNode> Nodes { get; set; }
    }
}
