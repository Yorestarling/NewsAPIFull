using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewsFormsAdmin.InsideForms.Sources
{
    public partial class CrudSource : Form
    {
        public CrudSource()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            SourceList source = new SourceList();
            source.ShowDialog();
        }

        private void BtnArticles_Click(object sender, EventArgs e)
        {
            AddSource add = new AddSource();
            add.ShowDialog();
        }
    }
}
