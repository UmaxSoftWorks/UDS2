using Umax.Interfaces.Tokens;

namespace Umax.Windows.Tools.TemplateEditor.Classes
{
    public class TokenInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public IToken Token { get; set; }

        public TokenInfo()
        {
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.Category = string.Empty;
        }
    }
}
