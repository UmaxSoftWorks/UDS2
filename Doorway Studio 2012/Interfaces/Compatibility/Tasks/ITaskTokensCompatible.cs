using Umax.Interfaces.Containers;

namespace Umax.Interfaces.Compatibility.Tasks
{
    public interface ITaskTokensCompatible
    {
        ITokenContainer Tokens { get; set; }
    }
}
