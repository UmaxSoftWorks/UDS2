using System;
using System.ComponentModel;
using Umax.Interfaces.Automator;
using Umax.Interfaces.Automator.Enums;
using Umax.Interfaces.Enums;

namespace Umax.Classes.Automator
{
    public class AutomatorPropertyEventArgs : IAutomatorPropertyEventArgs
    {
        public AutomatorPropertyEventArgs(AutomatorPropertyAttributeType Type, ITypeDescriptorContext Context, IServiceProvider Provider, object Value)
        {
            this.Handled = false;
            this.Type = Type;

            this.Context = Context;
            this.Provider = Provider;
            this.Value = Value;
        }

        public bool Handled { get; set; }

        public AutomatorPropertyAttributeType Type { get; protected set; }

        public ITypeDescriptorContext Context { get; protected set; }

        public IServiceProvider Provider { get; protected set; }

        public object Value { get; protected set; }
    }
}
