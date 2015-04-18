using Umax.Interfaces.Containers;

namespace Umax.Interfaces.Compatibility.Tasks
{
    public interface ITaskDataCompatible
    {
        IDataContainer Data { get; set; }
    }
}
