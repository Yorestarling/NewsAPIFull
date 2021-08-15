using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewsFormsAdmin.InsideForms.Categories
{
    public partial class CrudCategory : Form
    {
        public CrudCategory()
        {
            InitializeComponent();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoryList category = new CategoryList();
            category.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnArticles_Click(object sender, EventArgs e)
        {
            AddCategory add = new AddCategory();
            add.ShowDialog();
        }
    }
}
