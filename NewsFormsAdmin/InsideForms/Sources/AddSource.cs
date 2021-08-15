using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewsFormsAdmin.InsideForms.Sources
{
    public partial class AddSource : Form
    {
        public AddSource()
        {
            InitializeComponent();
        }

        private void BtnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
