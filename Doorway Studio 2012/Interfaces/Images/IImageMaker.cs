using System;
using System.Collections.Generic;
using Umax.Interfaces.Compatibility.Tokens;
using Umax.Interfaces.Enums;

namespace Umax.Interfaces.Images
{
    public interface IImageMaker : IClone, IDisposable, ITokensCompatible
    {
        string Name { get; }
        string Category { get; }
        string ControlName { get; }
        string GUIName { get; }

        MakerStateType State { get; }

        IImageSettings Settings { get; }

        /// <summary>
        /// Replaces all image tokens in Content.
        /// </summary>
        /// <param name="Path">Directory path</param>
        /// <param name="Content">Content to replace tokens in</param>
        /// <param name="Items">List of items</param>
        /// <returns>Returns content with all replaced tokens</returns>
        string Invoke(string Path, string Content, List<string> Items);

        void Load(string ImagePath);
        void Save(string ImagePath);

        void Initialize();
    }
}
