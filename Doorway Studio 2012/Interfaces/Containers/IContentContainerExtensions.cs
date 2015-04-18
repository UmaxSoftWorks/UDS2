using System.Collections.Generic;

namespace Umax.Interfaces.Containers
{
    public interface IContentContainerExtensions
    {
        Dictionary<string, string> Strings { get; set; }

        Dictionary<string, List<string>> Lists { get; set; }

        Dictionary<string, Dictionary<string, string>> Dictionaries { get; set; }
    }
}
