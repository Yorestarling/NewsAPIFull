using NewsFormsAdmin.InsideForms.Articles;
using NewsFormsAdmin.InsideForms.Authors;
using NewsFormsAdmin.InsideForms.Categories;
using NewsFormsAdmin.InsideForms.Countries;
using NewsFormsAdmin.InsideForms.Sources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewsFormsAdmin
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnArticles_Click(object sender, EventArgs e)
        {
            CrudAricles aricles = new CrudAricles();
            aricles.ShowDialog();
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            Authors details = new Authors();
            details.ShowDialog();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CrudCategory details = new CrudCategory();
            details.ShowDialog();
        }

        private void btnCountries_Click(object sender, EventArgs e)
        {
            CrudContry details = new CrudContry();
            details.ShowDialog();
        }

        private void btnSources_Click(object sender, EventArgs e)
        {
            CrudSource source = new CrudSource();
            source.ShowDialog();
        }
    }
}
