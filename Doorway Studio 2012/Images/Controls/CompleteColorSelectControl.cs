using System;
using System.Windows.Forms;
using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Controls
{
    public partial class CompleteColorSelectControl : UserControl
    {
        public CompleteColorSelectControl()
        {
            InitializeComponent();
        }

        public ColorSettings Settings
        {
            get
            {
                ColorSettings settings = new ColorSettings();

                switch (colorComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            settings.Color = ColorType.Random;
                            break;
                        }

                    case 1:
                        {
                            settings.Color = ColorType.Selected;
                            break;
                        }

                    case 2:
                        {
                            settings.Color = ColorType.Range;
                            break;
                        }
                }

                settings.SelectedColor = colorSelect.SelectedColor;

                settings.SelectedColorRangeRMin = (int)colorRangeRMinNumericUpDown.Value;
                settings.SelectedColorRangeRMax = (int)colorRangeRMaxNumericUpDown.Value;

                settings.SelectedColorRangeGMin = (int)colorRangeGMinNumericUpDown.Value;
                settings.SelectedColorRangeGMax = (int)colorRangeGMaxNumericUpDown.Value;

                settings.SelectedColorRangeBMin = (int)colorRangeBMinNumericUpDown.Value;
                settings.SelectedColorRangeBMax = (int)colorRangeBMaxNumericUpDown.Value;

                return settings;
            }

            set
            {
                switch (value.Color)
                {
                    case ColorType.Random:
                        {
                            colorComboBox.SelectedIndex = 0;
                            break;
                        }

                    case ColorType.Selected:
                        {
                            colorComboBox.SelectedIndex = 1;
                            break;
                        }

                    case ColorType.Range:
                        {
                            colorComboBox.SelectedIndex = 2;
                            break;
                        }
                }

                colorSelect.SelectedColor = value.SelectedColor;

                colorRangeRMinNumericUpDown.Value = value.SelectedColorRangeRMin;
                colorRangeRMaxNumericUpDown.Value = value.SelectedColorRangeRMax;

                colorRangeGMinNumericUpDown.Value = value.SelectedColorRangeGMin;
                colorRangeGMaxNumericUpDown.Value = value.SelectedColorRangeGMax;

                colorRangeBMinNumericUpDown.Value = value.SelectedColorRangeBMin;
                colorRangeBMaxNumericUpDown.Value = value.SelectedColorRangeBMax;
            }
        }

        private void colorComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (colorComboBox.SelectedIndex)
            {
                // Random
                case 0:
                    {
                        colorSelect.Enabled = false;
                        colorRangeRMinNumericUpDown.Enabled = false;
                        colorRangeRMaxNumericUpDown.Enabled = false;
                        colorRangeGMinNumericUpDown.Enabled = false;
                        colorRangeGMaxNumericUpDown.Enabled = false;
                        colorRangeBMinNumericUpDown.Enabled = false;
                        colorRangeBMaxNumericUpDown.Enabled = false;
                        break;
                    }

                // Selected
                case 1:
                    {
                        colorSelect.Enabled = true;
                        colorRangeRMinNumericUpDown.Enabled = false;
                        colorRangeRMaxNumericUpDown.Enabled = false;
                        colorRangeGMinNumericUpDown.Enabled = false;
                        colorRangeGMaxNumericUpDown.Enabled = false;
                        colorRangeBMinNumericUpDown.Enabled = false;
                        colorRangeBMaxNumericUpDown.Enabled = false;
                        break;
                    }

                // Range
                case 2:
                    {
                        colorSelect.Enabled = false;
                        colorRangeRMinNumericUpDown.Enabled = true;
                        colorRangeRMaxNumericUpDown.Enabled = true;
                        colorRangeGMinNumericUpDown.Enabled = true;
                        colorRangeGMaxNumericUpDown.Enabled = true;
                        colorRangeBMinNumericUpDown.Enabled = true;
                        colorRangeBMaxNumericUpDown.Enabled = true;
                        break;
                    }
            }
        }
    }
}
