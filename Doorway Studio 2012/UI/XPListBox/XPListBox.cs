using System.Drawing;
using System.Windows.Forms;

namespace Umax.UI.XPListBox
{
    public class XPListBox : ListBox
    {
        public ImageList ImageList { get; set; }

        public XPListBox()
        {
            // Set owner draw mode
            this.DrawMode = DrawMode.OwnerDrawFixed;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            e.DrawBackground();
            e.DrawFocusRectangle();
            XPListBoxItem item;
            Rectangle bounds = e.Bounds;
            Size imageSize = this.ImageList.ImageSize;

            try
            {
                item = (XPListBoxItem)Items[e.Index];

                if (item.ImageIndex != -1)
                {
                    this.ImageList.Draw(e.Graphics, bounds.Left, bounds.Top, item.ImageIndex);
                    e.Graphics.DrawString(item.Text, e.Font, new SolidBrush(e.ForeColor), bounds.Left + imageSize.Width, bounds.Top);
                }
                else
                {
                    e.Graphics.DrawString(item.Text, e.Font, new SolidBrush(e.ForeColor), bounds.Left, bounds.Top);
                }
            }
            catch
            {
                if (e.Index != -1)
                {
                    e.Graphics.DrawString(Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), bounds.Left, bounds.Top);
                }
                else
                {
                    e.Graphics.DrawString(Text, e.Font, new SolidBrush(e.ForeColor), bounds.Left, bounds.Top);
                }
            }

            base.OnDrawItem(e);
        }
    }
}
