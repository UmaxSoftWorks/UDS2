using System.Collections.Generic;
using System.Text;
using Umax.Interfaces.Enums;

namespace Umax.Interfaces.Containers.Items
{
    public interface ITemplate: IItem
    {
        Encoding Encoding { get; }
        IEventedList<IFile> Items { get; }

        List<IFile> Select(FileType Type);
    }
}
