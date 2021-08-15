using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewsFormsAdmin.InsideForms.Authors
{
    public partial class AddAuthors : Form
    {
        public AddAuthors()
        {
            InitializeComponent();
        }

        private void BtnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
