using System;
using Umax.Interfaces.Enums;

namespace Umax.Interfaces.Containers.Items
{
    public interface IFile : ICloneable
    {
        FileType Type { get; }
        string Path { get; }
        string Content { get; }

        /// <summary>
        /// Keywords for Custom pages, etc
        /// </summary>
        string[] Items { get; }

        void Delete();
    }
}
