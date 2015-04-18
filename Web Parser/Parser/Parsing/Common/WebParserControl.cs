using System.Windows.Forms;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.WebParser;

namespace WebParser.Parser.Parsing.Common
{
    public abstract partial class WebParserControl : UserControl, IWebParserControl
    {
        public WebParserControl()
        {
            InitializeComponent();
        }

        public abstract string GUIName { get; }

        public LanguageType Language { get; set; }

        public abstract string ExecutorName { get; }

        public bool OK { get; set; }

        public TaskEditType EditType { get; set; }

        public ITask Task { get; set; }

        public abstract object NewInstance();

        public abstract void Collect();
    }
}
