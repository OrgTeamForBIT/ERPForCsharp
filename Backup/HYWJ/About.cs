using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HYWJ
{
    public partial class About : Office2007Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelX6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.51aspx.com");
        }
    }
}
