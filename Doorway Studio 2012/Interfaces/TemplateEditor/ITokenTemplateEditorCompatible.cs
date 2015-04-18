using Umax.Interfaces.Enums;

namespace Umax.Interfaces.TemplateEditor
{
    public interface ITokenTemplateEditorCompatible
    {
        string[] Token { get; }

        string Description(LanguageType Language);

        string Group { get; }
    }
}
