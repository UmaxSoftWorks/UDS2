using System.Collections.Generic;

namespace Umax.UI.XPListBox
{
    public class XPListBoxGroup : XPListBoxItem
    {
        public List<XPListBoxItem> Items { get; set; }

        public XPListBoxGroup() : this(string.Empty) { }

        public XPListBoxGroup(string Text) : this(Text, -1) { }

        public XPListBoxGroup(string Text, int Index)
        {
            this.Text = Text;
            this.ImageIndex = Index;

            this.Items = new List<XPListBoxItem>();
        }

        public override string ToString()
        {
            return this.Text;
        }

        public override bool Visible
        {
            get
            {
                if (this.Items == null)
                {
                    this.Items = new List<XPListBoxItem>();
                }

                for (int i = 0; i < this.Items.Count; i++)
                {
                    if (this.Items[i].Visible)
                    {
                        return true;
                    }
                }

                return false;
            }

            set
            {
                if (this.Items == null)
                {
                    this.Items = new List<XPListBoxItem>();
                }

                for (int i = 0; i < this.Items.Count; i++)
                {
                    this.Items[i].Visible = value;
                }
            }
        }
    }
}
