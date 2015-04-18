using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Umax.Windows.Tools.Automator.Editors
{
    class FilesLocationEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                // set file filter info here
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.FileName;
                }
            }
            return value;
        }
    }
}
