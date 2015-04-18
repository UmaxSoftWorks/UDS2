using System.Windows.Forms;
using Umax.Classes.Automator;
using Umax.Interfaces.Automator;

namespace Umax.Windows.Tools.Automator.UI
{
    class AutomatorPropertyGrid : PropertyGrid
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            // Initialize events
            this.InitializeEvents();
        }

        protected override void Dispose(bool disposing)
        {
            // Deinitialize events
            this.DeInitializeEvents();

            base.Dispose(disposing);
        }

        protected void InitializeEvents()
        {
            AutomatorEditor.ComplexPropertyChanging += this.ComplexPropertyChanging;
            AutomatorEditor.SimplePropertyChanging += this.SimplePropertyChanging;
        }

        protected void DeInitializeEvents()
        {
            AutomatorEditor.ComplexPropertyChanging -= this.ComplexPropertyChanging;
            AutomatorEditor.SimplePropertyChanging -= this.SimplePropertyChanging;
        }

        void SimplePropertyChanging(IAutomatorPropertyEventArgs args)
        {

        }

        void ComplexPropertyChanging(IAutomatorClassEventArgs args)
        {

        }
    }
}
