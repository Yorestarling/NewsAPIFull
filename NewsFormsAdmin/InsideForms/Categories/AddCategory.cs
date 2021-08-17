using NewsFormsAdmin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace NewsFormsAdmin.InsideForms.Categories
{
    public partial class AddCategory : Form
    {
        static HttpClient httpClient = new HttpClient();
        public AddCategory()
        {
            InitializeComponent();
          
            httpClient.BaseAddress = new Uri("https://localhost:44320/");
        }

        private void BtnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {

        }
        private void addcategory()
        {
            var category = new Category_DTO
            {
                CategoryName = txtCategoryName.Text,
            };

            string json = JsonConvert.SerializeObject(category);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = httpClient.PostAsync("/api/Categories", content).Result;

            if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Category Inserted!");

            }
            else
            {
                MessageBox.Show("¡Error!");
            }
        }

        private void Btncategory_Click(object sender, EventArgs e)
        {
            addcategory();
            txtCategoryName.Clear();
        }
    }
}
