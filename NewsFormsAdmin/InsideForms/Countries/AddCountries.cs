using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewsFormsAdmin.InsideForms.Countries
{
    public partial class AddCountries : Form
    {
        public AddCountries()
        {
            InitializeComponent();
        }

        private void BtnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
