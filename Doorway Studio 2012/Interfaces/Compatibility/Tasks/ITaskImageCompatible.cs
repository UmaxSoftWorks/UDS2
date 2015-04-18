using Umax.Interfaces.Containers;

namespace Umax.Interfaces.Compatibility.Tasks
{
    public interface ITaskImageCompatible
    {
        IImageContainer Images { get; set; }
    }
}
