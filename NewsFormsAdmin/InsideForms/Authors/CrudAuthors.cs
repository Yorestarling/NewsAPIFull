using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewsFormsAdmin.InsideForms.Authors
{
    public partial class Authors : Form
    {
        public Authors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            AuthorsList details = new AuthorsList();
            details.ShowDialog();
        }

        private void BtnAuthors_Click(object sender, EventArgs e)
        {
            AddAuthors add = new AddAuthors();
            add.ShowDialog();
        }
    }
}
