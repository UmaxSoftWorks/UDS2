using System;
using Umax.Classes.Enums;
using Umax.Interfaces.Automator.Enums;
using Umax.Interfaces.Enums;

namespace Umax.Classes.Automator
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class AutomatorPropertyEditorAttribute: Attribute
    {
        public AutomatorPropertyEditorAttribute()
        {
            this.Type = AutomatorPropertyAttributeType.None;
        }

        public AutomatorPropertyEditorAttribute(AutomatorPropertyAttributeType Type)
        {
            this.Type = Type;
        }

        public AutomatorPropertyAttributeType Type { get; set; }
    }
}
