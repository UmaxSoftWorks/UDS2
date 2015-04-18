using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Modify.Common;

namespace Umax.Plugins.Images.Modify.Keyword
{
    public class ModifyKeywordImageSettings : ModifyImageSettings
    {
        public ModifyKeywordImageSettings()
        {
            this.Font = new FontSettings();
        }

        public FontSettings Font { get; set; }

        public override string Name
        {
            get { return "ModifyKeywordImageSettings"; }
        }

        public override object NewInstance()
        {
            return new ModifyKeywordImageSettings();
        }

        public override void Dispose()
        {

        }
    }
}
