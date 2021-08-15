using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewsFormsAdmin.InsideForms.Categories
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void BtnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
