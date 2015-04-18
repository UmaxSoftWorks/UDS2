using System.Collections.Generic;

namespace Umax.Interfaces.Containers.Items
{
    public interface IImage: IItem
    {
        List<IFile> Items { get; }
    }
}
