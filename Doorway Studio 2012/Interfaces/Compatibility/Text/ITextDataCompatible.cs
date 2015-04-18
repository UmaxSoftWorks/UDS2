using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;

namespace Umax.Interfaces.Compatibility.Text
{
    public interface ITextDataCompatible
    {
        IEventedList<IText> TextData { get; set; }
    }
}
