using Umax.Plugins.Images.Modify.Border.Common;

namespace Umax.Plugins.Images.Modify.Border.Keyword
{
    public class ModifyBorderKeywordImageSettings : ModifyBorderImageSettings
    {
        public override string Name
        {
            get { return "ModifyBorderKeywordImageSettings"; }
        }

        public override object NewInstance()
        {
            return new ModifyBorderKeywordImageSettings();
        }

        public override void Dispose()
        {
            
        }
    }
}
