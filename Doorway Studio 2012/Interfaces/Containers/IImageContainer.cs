using Umax.Interfaces.Images;

namespace Umax.Interfaces.Containers
{
    public interface IImageContainer
    {
        IEventedList<IImageSettings> Settings { get; }
        IEventedList<IImageMaker> Makers { get; }
        IEventedList<IImageControl> Controls { get; }
    }
}
