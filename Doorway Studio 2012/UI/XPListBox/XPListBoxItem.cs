namespace Umax.UI.XPListBox
{
    public class XPListBoxItem
    {
        public string Text { get; set; }

        public int ImageIndex { get; set; }

        public virtual bool Visible { get; set; }

        public XPListBoxItem() : this(string.Empty) { }
        
        public XPListBoxItem(string Text) : this(Text, -1) { }

        public XPListBoxItem(string Text, int Index)
        {
            this.Text = Text;
            this.ImageIndex = Index;
            this.Visible = true;
        }

        public object Tag { get; set; }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
