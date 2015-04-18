using System;
using System.Collections.Generic;
using Umax.Interfaces.Containers.Items;

namespace Umax.Interfaces.Containers
{
    public interface IContentContainer : IDisposable
    {
        List<IPage> Pages { get; }
        List<ICategory> Categories { get; }

        string[] Images { get; }
        string[] Keywords { get; }
        string Text { get; }

        /// <summary>
        /// Gets or sets path, where site will be saved
        /// </summary>
        string Path { get; set; }

        IContentContainerExtensions Extensions { get; }
    }
}
