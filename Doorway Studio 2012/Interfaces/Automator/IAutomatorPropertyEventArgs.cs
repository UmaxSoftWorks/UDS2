using System;
using System.ComponentModel;
using Umax.Interfaces.Automator.Enums;

namespace Umax.Interfaces.Automator
{
    public interface IAutomatorPropertyEventArgs
    {
        bool Handled { get; set; }

        AutomatorPropertyAttributeType Type { get; }

        ITypeDescriptorContext Context { get; }

        IServiceProvider Provider { get; }

        object Value { get; }
    }
}
