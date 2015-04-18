using System.Collections.Generic;
using Umax.Interfaces.Containers;

namespace Umax.Classes.Containers
{
    public class ContentContainerExtensions : IContentContainerExtensions
    {
        public Dictionary<string, string> Strings { get; set; }

        public Dictionary<string, List<string>> Lists { get; set; }

        public Dictionary<string, Dictionary<string, string>> Dictionaries { get; set; }

        public ContentContainerExtensions()
        {
            this.Strings = new Dictionary<string, string>();
            this.Lists = new Dictionary<string, List<string>>();
            this.Dictionaries = new Dictionary<string, Dictionary<string, string>>();
        }
    }
}
