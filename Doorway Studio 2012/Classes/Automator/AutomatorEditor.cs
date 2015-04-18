using System;
using System.ComponentModel;
using System.Drawing.Design;
using Umax.Interfaces.Automator.Events;

namespace Umax.Classes.Automator
{
    public class AutomatorEditor : UITypeEditor
    {
        public static event AutomatorPropertyEventHandler SimplePropertyChanging;

        public static event AutomatorClassEventHandler ComplexPropertyChanging;

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            /*List<Attribute> attributes = context.Instance.GetType().GetProperty(context.PropertyDescriptor.Name).GetCustomAttributes(typeof(AutomatorPropertyEditorAttribute), true).Cast<Attribute>().ToList();

            if (SimplePropertyChanging != null)
            {

            }*/

            return base.EditValue(context, provider, value);
        }
    }
}
