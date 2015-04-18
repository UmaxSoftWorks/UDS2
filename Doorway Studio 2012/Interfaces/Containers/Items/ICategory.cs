using System.Collections.Generic;

namespace Umax.Interfaces.Containers.Items
{
    public interface ICategory : IItem
    {
        string URL { get; }

        string Keyword { get; }

        List<ICategory> Categories { get; set; }
    }
}
