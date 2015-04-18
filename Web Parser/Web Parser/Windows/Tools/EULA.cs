using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebParser.Windows
{
    public partial class EULA : Form
    {
        public EULA()
        {
            InitializeComponent();
        }

        public bool Accepted { get; protected set; }
    }
}
