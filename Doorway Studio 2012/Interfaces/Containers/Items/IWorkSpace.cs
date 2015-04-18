using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;

namespace Umax.Interfaces.Containers.Items
{
    public interface IWorkSpace : IItem
    {
        IEventedList<ITask> Tasks { get; }
        IEventedList<IImage> Images { get; }
        IEventedList<IKeyWord> Keywords { get; }
        IEventedList<IText> Text { get; }
        IEventedList<IPreset> Presets { get; }
        IEventedList<ITemplate> Templates { get; }

        ITask SelectTask(int Value, ItemSelectType Type);
        IImage SelectImage(int Value, ItemSelectType Type);
        IKeyWord SelectKeyword(int Value, ItemSelectType Type);
        IText SelectText(int Value, ItemSelectType Type);
        IPreset SelectPreset(int Value, ItemSelectType Type);
        ITemplate SelectTemplate(int Value, ItemSelectType Type);

        event SimpleEventHandler Changed;
    }
}
