using System;
using System.Drawing;
using System.Windows.Forms;
using Umax.Classes.Helpers;
using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Controls
{
    public partial class FontSelectControl : UserControl
    {
        public FontSelectControl()
        {
            InitializeComponent();

            FontFamily[] fontList = FontHelper.Fonts;
            for (int i = 0; i < fontList.Length; i++)
            {
                if (fontList[i].IsStyleAvailable(FontStyle.Bold) &&
                   fontList[i].IsStyleAvailable(FontStyle.Italic) &&
                   fontList[i].IsStyleAvailable(FontStyle.Underline) &&
                   fontList[i].IsStyleAvailable(FontStyle.Strikeout))
                {
                    fontComboBox.Items.Add(fontList[i].Name);
                }
            }
        }

        public FontSettings Settings
        {
            get
            {
                FontSettings settings = new FontSettings();

                // Font
                switch (fontTypeComboBox.SelectedIndex)
                {
                    // Random
                    case 0:
                        {
                            settings.Font = FontType.Random;
                            break;
                        }

                    // Selected
                    case 1:
                        {
                            settings.Font = FontType.Selected;
                            break;
                        }
                }

                for (int i = 0; i < fontComboBox.Items.Count; i++)
                {
                    if (fontComboBox.Items[i].ToString() == settings.FontName)
                    {
                        fontComboBox.SelectedIndex = i;
                        break;
                    }
                }

                settings.FontSize = int.Parse(fontSizeComboBox.Text);

                settings.FontStyle = FontStyle.Regular;

                if (fontBoldCheckBox.Checked)
                {
                    settings.FontStyle = FontStyle.Bold;
                }

                if (fontItalicCheckBox.Checked)
                {
                    settings.FontStyle |= FontStyle.Italic;
                }

                if (fontStrikeoutCheckBox.Checked)
                {
                    settings.FontStyle |= FontStyle.Strikeout;
                }

                if (fontUnderlineCheckBox.Checked)
                {
                    settings.FontStyle |= FontStyle.Underline;
                }

                settings.FontColorSettings = fontCompleteColorSelectControl.Settings;

                return settings;
            }
            set
            {
                switch (value.Font)
                {
                    case FontType.Random:
                        {
                            fontTypeComboBox.SelectedIndex = 0;
                            break;
                        }

                    case FontType.Selected:
                        {
                            fontTypeComboBox.SelectedIndex = 1;
                            break;
                        }
                }

                for (int i = 0; i < fontComboBox.Items.Count; i++)
                {
                    if (fontComboBox.Items[i].ToString() == value.FontName)
                    {
                        fontComboBox.SelectedIndex = i;
                        break;
                    }
                }

                fontSizeComboBox.Text = value.FontSize.ToString();

                if (value.FontStyle == FontStyle.Bold)
                {
                    fontBoldCheckBox.Checked = true;
                }

                if (value.FontStyle == FontStyle.Italic)
                {
                    fontItalicCheckBox.Checked = true;
                }

                if (value.FontStyle == FontStyle.Strikeout)
                {
                    fontStrikeoutCheckBox.Checked = true;
                }

                if (value.FontStyle == FontStyle.Underline)
                {
                    fontUnderlineCheckBox.Checked = true;
                }

                fontCompleteColorSelectControl.Settings = value.FontColorSettings;
            }
        }
        private void fontTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (fontTypeComboBox.SelectedIndex)
            {
                // Random
                case 0:
                    {
                        fontComboBox.Enabled = false;
                        break;
                    }

                // Selected
                case 1:
                    {
                        fontComboBox.Enabled = true;
                        break;
                    }
            }
        }
    }
}
