using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;

namespace Umax.Interfaces.Compatibility.Images
{
    public interface IImageDataCompatible
    {
        IEventedList<IImage> ImageData { get; set; }
    }
}
