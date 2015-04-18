using System;
using System.Collections.Generic;
using Umax.Interfaces.Compatibility.Tokens;
using Umax.Interfaces.Enums;

namespace Umax.Interfaces.Text
{
    public interface ITextMaker : IClone, IDisposable, ITokensCompatible
    {
        string Name { get; }
        string Category { get; }
        string ControlName { get; }
        string GUIName { get; }

        ITextSettings Settings { get; }

        MakerStateType State { get; }

        /// <summary>
        /// Replaces all tokens in specified content
        /// </summary>
        /// <param name="Content"></param>
        /// <param name="Keywords"></param>
        /// <returns></returns>
        string Invoke(string Content, List<string> Keywords);

        void Initialize();

        void Load(string TextPath);
        void Save(string TextPath);
    }
}
