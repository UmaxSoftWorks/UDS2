using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Compatibility.Tokens;
using Umax.Interfaces.TemplateEditor;
using Umax.Interfaces.Tokens;
using Umax.UI.XPRichTextBox;

namespace Umax.Windows.Tools.TemplateEditor.UI
{
    class IntellisenseRichTextBox: XPRichTextBox
    {
        private ListBox PopUp;
        public string PopUpFilter { get; protected set; }

        public IntellisenseRichTextBox()
        {
            this.oldText = string.Empty;

            this.Initialize();
            this.InitializeEvents();
        }

        private void Initialize()
        {
            this.PopUpFilter = string.Empty;

            this.PopUp = new ListBox();
            this.PopUp.Size = new Size(250, 200);
            this.PopUp.Visible = false;

            this.Controls.Add(this.PopUp);
        }

        private void InitializeEvents()
        {
            this.Click += this.IntellisenseRichTextBoxClick;
            this.DoubleClick += this.IntellisenseRichTextBoxDoubleClick;

            this.PopUp.KeyDown += this.PopUpKeyDown;
            this.PopUp.VisibleChanged += this.PopUpVisibleChanged;
            this.PopUp.DoubleClick += this.PopUpDoubleClick;
        }

        void PopUpDoubleClick(object sender, EventArgs e)
        {
            if (this.PopUp.SelectedIndex != -1)
            {
                this.PopUp.Hide();
            }
        }

        void PopUpVisibleChanged(object sender, EventArgs e)
        {
            if (!this.PopUp.Visible && this.PopUp.SelectedIndex != -1)
            {
                int index = this.SelectionStart;
                string item = this.PopUp.Items[this.PopUp.SelectedIndex].ToString();

                if (this.RemoveFilterString)
                {
                    this.Text = this.Text.Substring(0, index - this.PopUpFilter.Length) + item + this.Text.Substring(index);
                }
                else
                {
                    this.Text = this.Text.Insert(index, item);
                }

                this.SelectionStart = index + item.Length;
            }
        }

        void PopUpKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                return;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab)
            {
                e.Handled = true;
                this.Focus();

                string key = e.KeyCode.ToString();
                SendKeys.Send("{" + (key == "Back" ? "BS" : key) + "}");
                return;
            }

            if (e.KeyCode == Keys.Return && (this.PopUp.SelectedIndex != -1 || this.PopUp.Items.Count == 1))
            {
                if (this.PopUp.Items.Count == 1)
                {
                    this.PopUp.SelectedIndex = 0;
                }

                this.Focus();
                this.PopUp.Visible = false;
                return;
            }

            this.Focus();

            this.OnKeyDown(e);
            this.OnKeyPress(new KeyPressEventArgs((char) e.KeyValue));

            this.AppendText(KeyboardHelper.CodeToString(e.KeyValue));
        }

        void IntellisenseRichTextBoxDoubleClick(object sender, EventArgs e)
        {
            this.Focus();
            this.HidePopUp();
        }

        void IntellisenseRichTextBoxClick(object sender, EventArgs e)
        {
            this.HidePopUp();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (e.KeyChar == '[')
            {
                this.ShowPopUp();
                this.PopUpFilter = ((char)e.KeyChar).ToString();
                return;
            }
            
            if (e.KeyChar == ']')
            {
                this.HidePopUp();
                return;
            }

            if (this.PopUpVisible && !char.IsControl(e.KeyChar))
            {
                this.PopUpFilter += e.KeyChar.ToString();
                this.FilterPopUp(this.PopUpFilter);
            }
        }


        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (this.PopUpVisible)
            {
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                {
                    e.Handled = true;
                    this.PopUp.Focus();
                    return;
                }

                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    this.HidePopUp();
                }

                if (e.KeyCode == Keys.Back)
                {
                    if (this.SelectionLength == 0)
                    {
                        this.PopUpFilter = this.PopUpFilter.Length != 0 ? this.PopUpFilter.Substring(0, this.PopUpFilter.Length - 1) : string.Empty;
                        this.FilterPopUp(this.PopUpFilter);
                    }
                    else
                    {
                        this.HidePopUp();
                    }
                }

                if (e.KeyCode == Keys.Return)
                {
                    if (this.PopUp.SelectedIndex != -1 || this.PopUp.Items.Count == 1)
                    {
                        if (this.PopUp.Items.Count == 1)
                        {
                            this.PopUp.SelectedIndex = 0;

                            e.Handled = true;
                        }

                        this.HidePopUp();
                        return;
                    }

                    this.HidePopUp();
                }

                if (this.PopUpFilter == string.Empty)
                {
                    this.HidePopUp();
                }
            }
        }

        public bool PopUpVisible { get { return this.PopUp.Visible; } }

        public void ShowPopUp()
        {
            this.ShowPopUp(string.Empty);
        }

        private bool RemoveFilterString { get; set; }
        public void ShowPopUp(string Filter)
        {
            if (this.PopUpVisible)
            {
                return;
            }

            Point location = this.GetPositionFromCharIndex(this.SelectionStart);
            this.PopUp.Location = new Point(location.X, location.Y + (int)(this.Font.Size * (this.ZoomFactor + 1)));

            if (string.IsNullOrEmpty(Filter))
            {
                this.RemoveFilterString = true;
                this.InitializePopUp();
            }
            else
            {
                this.RemoveFilterString = false;
                this.FilterPopUp(Filter);
                if (this.PopUp.Items.Count == 1)
                {
                    this.PopUp.SelectedIndex = 0;
                    this.PopUpVisibleChanged(this, EventArgs.Empty);
                    return;
                }
            }

            this.PopUp.BringToFront();
            this.PopUp.Show();
            this.PopUp.Update();
            this.PopUp.Focus();
        }

        public void HidePopUp()
        {
            if (this.PopUpVisible)
            {
                this.PopUp.Visible = false;
            }

            Application.DoEvents();
            this.PopUpFilter = string.Empty;
        }

        private List<IToken> tokens;
        public List<IToken> Tokens
        {
            get { return this.tokens; }
            set
            {
                this.tokens = value;

                if (this.tokens == null)
                {
                    return;
                }

                this.TokensRegex = new Dictionary<IToken, Regex[]>(this.tokens.Count);

                for (int i = 0; i < this.tokens.Count; i++)
                {
                    Regex[] regex = null;
                    if (this.Tokens[i] is ITokensRegexCompatible)
                    {
                        regex = new Regex[(this.Tokens[i] as ITokensRegexCompatible).RegexTokens.Length];
                        for (int k = 0; k < regex.Length; k++)
                        {
                            regex[k] = new Regex((this.Tokens[i] as ITokensRegexCompatible).RegexTokens[k], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        }
                    }
                    else
                    {
                        regex = new Regex[this.Tokens[i].Tokens.Length];
                        for (int k = 0; k < regex.Length; k++)
                        {
                            regex[k] = new Regex(this.Tokens[i].Tokens[k], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        }
                    }

                    this.TokensRegex.Add(this.tokens[i], regex);
                }
            }
        }

        private Dictionary<IToken, Regex[]> TokensRegex { get; set; }

        private void InitializePopUp()
        {
            this.FilterPopUp(string.Empty);
        }

        private void FilterPopUp(string Filter)
        {
            this.PopUp.Items.Clear();

            List<string> items = new List<string>();

            for (int i = 0; i < this.Tokens.Count; i++)
            {
                if (this.Tokens[i] is ITokenTemplateEditorCompatible)
                {
                    items.AddRange((this.Tokens[i] as ITokenTemplateEditorCompatible).Token);
                }
                else
                {
                    items.AddRange(this.Tokens[i].Tokens);
                }
            }

            // Filter
            if (Filter != string.Empty)
            {
                List<string> filter = new List<string>();
                for (int i = 0; i < items.Count; i++)
                {
                    if (!items[i].Contains(StringContainsType.All, true, Filter.Split(new char[]{' ', ':'},  StringSplitOptions.RemoveEmptyEntries)))
                    {
                        filter.Add(items[i]);
                    }
                }

                if (items.Count != filter.Count)
                {
                    for (int i = 0; i < filter.Count; i++)
                    {
                        items.Remove(filter[i]);
                    }
                }
            }

            items.Sort();

            this.PopUp.Items.AddRange(items.ToArray());
        }

        protected override void OnTextChanged(EventArgs e)
        {
            float zoom = this.ZoomFactor;

            // Lock painting
            this.LockUpdate();
            this.SuspendLineNumberPainting();

            int index = this.SelectionStart;

            // Process text changed
            base.OnTextChanged(e);

            // Process token painting
            this.Process();

            this.SelectionStart = index;

            // Resume painting
            this.ResumeLineNumberPainting();
            this.UnLockUpdate();

            this.ZoomFactor = zoom;
        }

        private bool Processing { get; set; }
        private void Process()
        {
            if (this.Processing)
            {
                return;
            }

            this.Processing = true;

            // Created with an estimate of how big the stringbuilder has to be...
            StringBuilder sb = new StringBuilder((int) (this.Text.Length*1.5 + 150));

            // Adding RTF header
            sb.Append(@"{\rtf1\ansi\ansicpg1251\deff0\deflang1049{\fonttbl{");

            // Font table creation
            this.AddFontToRTF(sb, this.Font, 0);
            sb.Append("}\n");

            // ColorTable
            sb.Append(@"{\colortbl ;");

            Dictionary<Color, int> colors = new Dictionary<Color, int>();

            int counter = 1;

            foreach (Color color in this.Tokens.Select(Token => Token.Color).Where(Item => Item != Color.Black).Distinct())
            {
                if (!colors.ContainsKey(color))
                {
                    colors.Add(color, counter);
                    counter++;
                }
            }

            foreach (KeyValuePair<Color, int> color in colors)
            {
                this.AddColorToRTF(sb, color.Key);
            }

            // Parsing text
            sb.Append("}\n").Append(@"\viewkind4\uc1\pard\sa200\sl276\slmult1\lang9");
            sb.Append(this.RTFDefaultSettings(colors));

            // Replacing "\" to "\\" for RTF...
            string text = Text.Replace("\\", "\\\\").Replace("{", "\\{").Replace("}", "\\}").Replace("\r", string.Empty);

            if (this.Text.EndsWith("\n"))
            {
                text = text.TrimEnd('\n') + this.RTFParagraph;
            }

            text = text.Replace("\n", this.RTFLine);

            foreach (KeyValuePair<IToken, Regex[]> token in this.TokensRegex)
            {
                // For each match from the regex, highlight the word.
                for (int i = 0; i < token.Value.Length; i++)
                {
                    int location = 0;
                    foreach (Match match in token.Value[i].Matches(text))
                    {
                        location = text.IndexOf(match.Value, location);
                        string value = text.Substring(location, match.Length);

                        if (token.Key.Bold)
                        {
                            value = this.RTFBoldOn + value + this.RTFBoldOff + this.RTFEndTag;
                        }

                        value = this.RTFColor(token.Key.Color, colors) + value + this.RTFDefaultSettings(colors);

                        text = text.Substring(0, location) + value + text.Substring(location + match.Value.Length);
                        location += value.Length;
                    }
                }
            }

            sb.Append(text);

            this.Rtf = sb.Append("}").ToString();
            this.Processing = false;
        }

        #region Rtf building helper functions

        /// <summary>
        /// Set color and font to default control settings.
        /// </summary>
        /// <param name="sb">the string builder building the RTF</param>
        /// <param name="colors">colors dictionary</param>
        private string RTFDefaultSettings(Dictionary<Color, int> colors)
        {
            return this.RTFColor(this.ForeColor, colors) + this.RTFFont() + this.RTFFontSize((int) this.Font.Size) + this.RTFEndTag;
        }

        private string RTFColor(Color color, Dictionary<Color, int> colors)
        {
            if (color.A == Color.Black.A && color.R == Color.Black.R && color.G == Color.Black.G && color.B == Color.Black.B)
            {
                return @"\cf0";
            }

            return @"\cf" + colors[color].ToString();
        }

        private string RTFBackColor(Color color, Dictionary<Color, int> colors)
        {
            if (color.A == Color.Black.A && color.R == Color.Black.R && color.G == Color.Black.G && color.B == Color.Black.B)
            {
                return @"\cb0";
            }

            return @"\cb" + colors[color].ToString();
        }

        /// <summary>
        /// Sets the font to the specified font.
        /// </summary>
        private string RTFFont()
        {
            // This method should accept font and fonts dictionary, to specify correct font, but now method optimized for only one font
            return @"\f0";
        }

        private string RTFBoldOn { get { return @"\b"; } }

        private string RTFBoldOff { get { return @"\b0"; } }

        private string RTFFontSize(int Size)
        {
            return @"\fs" + (Size * 2).ToString();
        }

        private string RTFLine { get { return "\\line "; } }

        private string RTFParagraph { get { return "\\par\n"; } }

        private string RTFEndTag { get { return " "; } }

        /// <summary>
        /// Adds a font to the RTF's font table
        /// </summary>
        /// <param name="sb">The RTF's string builder</param>
        /// <param name="font">the Font to add</param>
        /// <param name="counter">a counter, containing the amount of fonts in the table</param>
        private void AddFontToRTF(StringBuilder sb, Font font, int counter)
        {
            sb.Append(@"\f").Append(counter).Append(@"\fswiss\fcharset1 ").Append(font.Name).Append(";}");
        }

        /// <summary>
        /// Adds a color to the RTF's color table
        /// </summary>
        /// <param name="sb">The RTF's string builder</param>
        /// <param name="color">the color to add</param>
        private void AddColorToRTF(StringBuilder sb, Color color)
        {
            sb.Append(@"\red").Append(color.R).Append(@"\green").Append(color.G).Append(@"\blue")
                .Append(color.B).Append(";");
        }

        #endregion

        private string oldText;
        public void Revert()
        {
            if (string.IsNullOrEmpty(this.oldText))
            {
                return;
            }

            int index = this.SelectionStart;
            this.Text = this.oldText;
            this.SelectionStart = index;
        }

        public void IncreaseIndent()
        {
            int index = this.SelectionStart;
            int length = this.SelectionLength;

            int startIndex = (this.Text.Length == this.SelectionStart)
                                 ? this.Text.LastIndexOf('\n')
                                 : this.Text.LastIndexOf('\n', index != 0 ? index - 1 : index);

            if (startIndex < 0)
            {
                startIndex = 0;
            }

            string increase = "  ";
            bool lineSkipped = false;

            string[] lines = this.Text.Substring(startIndex, (index - startIndex) + length).Split(new char[] { '\n' }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                if (i == 0 && startIndex != 0)
                {
                    lineSkipped = true;
                    continue;
                }

                lines[i] = increase + lines[i].Trim('\r');
            }

            string text = lines.ToList().AsString("\n").TrimEnd(new char[] { '\n' });
            this.Text = this.Text.Substring(0, startIndex) + text + this.Text.Substring(index + length);

            this.SelectionStart = index + length + (lines.Length * increase.Length) + (lineSkipped ? -increase.Length : 0);
        }

        public void DecreaseIndent()
        {
            int index = this.SelectionStart;
            int length = this.SelectionLength;

            int startIndex = (this.Text.Length == this.SelectionStart)
                                 ? this.Text.LastIndexOf('\n')
                                 : this.Text.LastIndexOf('\n', index != 0 ? index - 1 : index);

            if (startIndex < 0)
            {
                startIndex = 0;
            }

            string increase = "  ";

            string[] lines = this.Text.Substring(startIndex, (index - startIndex) + length).Split(new char[] { '\n' }, StringSplitOptions.None);

            int removed = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Replace("\t", increase);
                if (line.StartsWith(increase))
                {
                    lines[i] = line.Substring(increase.Length);
                    removed += 2;
                }
            }

            string text = lines.ToList().AsString("\n")/*.TrimEnd(new char[] { '\n' })*/;
            this.Text = this.Text.Substring(0, startIndex) + text + this.Text.Substring(index + length);

            this.SelectionStart = index + length - removed;
        }
    }
}
