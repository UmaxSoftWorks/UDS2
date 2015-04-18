using System.Windows.Forms;

namespace Umax.Classes.Helpers
{
    public static class ControlHelper
    {
        public static bool CanUpdate(this Control Control, bool CheckParents)
        {
            bool result = true;

            if (CheckParents && Control.Parent != null)
            {
                result = Control.Parent.CanUpdate(true);
            }

            return result && Control.CanUpdate();
        }

        public static bool CanUpdate(this Control Control)
        {
            return (!Control.Disposing && !Control.IsDisposed) && Control.Visible;
        }
    }
}
