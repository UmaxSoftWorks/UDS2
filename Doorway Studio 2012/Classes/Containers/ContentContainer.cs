using System.Collections.Generic;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;

namespace Umax.Classes.Containers
{
    public class ContentContainer : IContentContainer
    {
        public List<IPage> Pages {get; set;}

        public List<ICategory> Categories { get; set; }

        public string[] Images { get; set; }

        public string[] Keywords { get; set; }

        public string Text { get; set; }

        public IContentContainerExtensions Extensions { get; set; }

        public string Path { get; set; }

        public int Index { get; set; }

        public ContentContainer()
        {
            this.Pages = new List<IPage>();
            this.Categories = new List<ICategory>();

            this.Images = new string[0];
            this.Keywords = new string[0];

            this.Text = string.Empty;

            this.Extensions = new ContentContainerExtensions();

            this.Index = 0;
            this.Path = string.Empty;
        }

        public void Dispose()
        {

        }
    }
}
