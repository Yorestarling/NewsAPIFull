using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewsFormsAdmin.InsideForms.Articles
{
    public partial class CrudAricles : Form
    {
        public CrudAricles()
        {
            InitializeComponent();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            DetailsArticles details = new DetailsArticles();
            details.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnArticles_Click(object sender, EventArgs e)
        {
            AddArticles add = new AddArticles();
            add.ShowDialog();
        }
    }
}
