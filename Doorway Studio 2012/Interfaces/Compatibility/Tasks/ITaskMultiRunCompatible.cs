using Umax.Interfaces.Enums;

namespace Umax.Interfaces.Compatibility.Tasks
{
    public interface ITaskMultiRunCompatible
    {
        int ScheduleStep { get; set; }
        TaskScheduleType Schedule { get; set; }
    }
}
