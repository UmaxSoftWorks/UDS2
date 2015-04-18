using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;

namespace Umax.Interfaces.Tasks
{
    public interface ITaskWindow : IClone
    {
        string Name { get; }
        string GUIName { get; }
        LanguageType Language { get; set; }

        string ExecutorName { get; }

        bool OK { get; set; }

        TaskEditType EditType { get; set; }

        /// <summary>
        /// Task should be used for editing purposes only
        /// </summary>
        ITask Task { get; set; }
    }
}
