using NewsFormsAdmin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Linq;

namespace NewsFormsAdmin.InsideForms.Categories
{
    
    public partial class CategoryList : Form
    {
        static HttpClient httpClient = new HttpClient();

        List<Category_DTO> Category;
        public CategoryList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private  void CategoryList_Load(object sender, EventArgs e)
        {
            
            LoadGrid();
        }

        private async Task<string> GetHttp()
        {
            WebRequest request = WebRequest.Create("https://localhost:44320/api/Categories");
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();

        }


        private async Task<List<Category_DTO>> Categories()
        {
            string response = await GetHttp();

            Category = JsonConvert.DeserializeObject<List<Category_DTO>>(response);

            return Category;
        }

        private async void LoadGrid()
        {
            await Categories();

            var list = (from x in Category
                        where x.CategoryName.ToLower().Contains(textBox1.Text.ToLower()
                        )
                        select new
                        {
                            Categoryid = x.CategoryId,
                            CategoryName = x.CategoryName,
                        }).ToList();

            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
