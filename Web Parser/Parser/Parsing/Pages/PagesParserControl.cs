using WebParser.Parser.Parsing.Common;

namespace WebParser.Parser.Parsing.Pages
{
    public partial class PagesParserControl : WebParserControl
    {
        public PagesParserControl()
        {
            InitializeComponent();
        }

        public override string GUIName
        {
            get { return "PagesParserControl"; }
        }

        public override string ExecutorName
        {
            get { return "PagesParserExecutor"; }
        }

        public override object NewInstance()
        {
            return new PagesParserControl();
        }

        public override void Collect()
        {
            this.Task.Executor = new PagesParserExecutor();
        }
    }
}
