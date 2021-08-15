using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewsFormsAdmin.InsideForms.Countries
{
    public partial class CrudContry : Form
    {
        public CrudContry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CountryList countryList = new CountryList();
            countryList.ShowDialog();
        }
    }
}
