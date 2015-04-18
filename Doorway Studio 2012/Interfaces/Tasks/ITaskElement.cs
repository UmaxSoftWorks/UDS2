using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace Umax.Interfaces.Tasks
{
    public interface ITaskElement : IClone
    {
        string Name { get; }
        string GUIName { get; }
        string Category { get; }
        string WindowName { get; }
        Image Image { get; }
    }
}
