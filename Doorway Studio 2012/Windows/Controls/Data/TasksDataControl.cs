using System.Windows.Forms;
using Umax.Windows.Interfaces;

namespace Umax.Windows.Controls.Data
{
    public partial class TasksDataControl : UserControl, IEventedControl
    {
        public TasksDataControl()
        {
            InitializeComponent();
        }

        public void InitializeEvents()
        {
        }

        public void DeInitializeEvents()
        {
            tasksGridDataControl.DeInitializeEvents();
            tasksTreeDataControl.DeInitializeEvents();
        }

        public void UpdateControl()
        {

        }
    }
}
