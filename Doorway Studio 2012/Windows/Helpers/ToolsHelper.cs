using Umax.Windows.Tools.Automator.Pro;
using Umax.Windows.Tools.Automator.Regular;
using Umax.Windows.Tools.TemplateEditor;

namespace Umax.Windows.Helpers
{
    public static class ToolsHelper
    {
        public static void OpenTemplateEditor()
        {
            if (Core.Core.Instanse.Data.Count == 0) return;

            new TemplateEditor().Show();
        }

        public static void OpenAutomator()
        {
            if (Core.Core.Instanse.Data.Count == 0) return;

            new Automator().Show();
        }

        public static void OpenAutomatorPro()
        {
            if (Core.Core.Instanse.Data.Count == 0) return;

            new AutomatorPro().Show();
        }
    }
}
