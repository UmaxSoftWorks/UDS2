using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Monitor.Classes;
using Umax.Resources;

namespace Monitor.Windows
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }
        public string Content { get; set; }

        private void Log_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.IconGreen;
            mainTextBox.Text = Content;
            mainTextBox.SelectionStart = mainTextBox.Text.Length;
        }
    }
}
