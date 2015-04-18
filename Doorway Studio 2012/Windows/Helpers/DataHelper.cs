using System.Windows.Forms;
using Core.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Tasks;
using Umax.Windows.Enums;
using Umax.Windows.Windows.Data;
using Umax.Windows.Windows.Log;

namespace Umax.Windows.Helpers
{
    public static class DataHelper
    {
        public static void EditTask(IWin32Window Parent, ITask Task)
        {
            for (int i = 0; i < Core.Core.Instanse.Tasks.Windows.Count; i++)
            {
                if (Core.Core.Instanse.Tasks.Windows[i].ExecutorName != Task.Executor.Name) continue;

                using (Form window = Core.Core.Instanse.Tasks.Windows[i].NewInstance() as Form)
                {
                    if (!(window is ITaskWindow)) return;

                    (window as ITaskWindow).Task = Task;
                    (window as ITaskWindow).EditType = TaskEditType.Edit;

                    // Invoke
                    window.Show();
                }

                return;
            }
        }

        public static void CreateWorkSpace()
        {
            new ItemAction
                {
                    Action = DataActionType.Create,
                    Element = DataElementType.WorkSpaces
                }.Show();
        }

        public static void CopyWorkSpace(IWin32Window Parent, IWorkSpace WorkSpace)
        {
            new ItemAction
                {
                    Action = DataActionType.Copy,
                    Element = DataElementType.WorkSpaces,
                    WorkSpace = WorkSpace
                }.Show(Parent);
        }

        public static void CopyTask(IWin32Window Parent, IWorkSpace WorkSpace, ITask Task)
        {
            if (!Task.IsCopyable())
            {
                return;
            }

            new ItemAction
                {
                    Action = DataActionType.Copy,
                    Element = DataElementType.Tasks,
                    WorkSpace = WorkSpace,
                    Item = Task
                }.Show(Parent);
        }

        public static void CreateTask()
        {
            if (Core.Core.Instanse.Data.Count == 0) return;

            new TaskCreate().Show();
        }

        public static void ShowLog()
        {
            if (RunTime.Instance.LogWindow == null)
            {
                RunTime.Instance.LogWindow = new Log();
            }

            if (RunTime.Instance.LogWindow.IsDisposed)
            {
                RunTime.Instance.LogWindow = new Log();
            }

            RunTime.Instance.LogWindow.Show();
        }

        public static void EditTasks()
        {
            if (Core.Core.Instanse.Data.Count == 0) return;

            new ItemEdit
                {
                    Action = DataElementType.Tasks
                }.Show();
        }

        public static void EditKeywords()
        {
            if (Core.Core.Instanse.Data.Count == 0) return;

            new ItemEdit
                {
                    Action = DataElementType.Keywords
                }.Show();
        }

        public static void EditText()
        {
            if (Core.Core.Instanse.Data.Count == 0) return;

            new ItemEdit
                {
                    Action = DataElementType.Text
                }.Show();
        }

        public static void EditImages()
        {
            if (Core.Core.Instanse.Data.Count == 0) return;

            new ItemEdit
                {
                    Action = DataElementType.Images
                }.Show();
        }

        public static void EditTemplates()
        {
            if (Core.Core.Instanse.Data.Count == 0) return;

            new ItemEdit
                {
                    Action = DataElementType.Templates
                }.Show();
        }

        public static void EditPresets()
        {
            if (Core.Core.Instanse.Data.Count == 0) return;

            new ItemEdit
                {
                    Action = DataElementType.Presets
                }.Show();
        }

        public static void EditWorkSpaces()
        {
            if (Core.Core.Instanse.Data.Count == 0) return;

            new ItemEdit
                {
                    Action = DataElementType.WorkSpaces
                }.Show();
        }

        public static void EditOptions()
        {
            new Windows.Common.Options().Show();
        }
    }
}
