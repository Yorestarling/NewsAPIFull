using NewsFormsAdmin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsFormsAdmin.InsideForms.Authors
{
    public partial class AuthorsList : Form
    {
        static HttpClient httpClient = new HttpClient();
        List<AuthorDto> Author;

        private int authorsid;
        public AuthorsList()
        {
            InitializeComponent();
        }
        private async Task<string> GetHttp()
        {
            WebRequest request = WebRequest.Create("https://localhost:44320/api/Authors");
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private async Task<List<AuthorDto>> Authors()
        {
            string response = await GetHttp();

            Author = JsonConvert.DeserializeObject<List<AuthorDto>>(response);

            return Author;
        }

        private async void LoadGrid()
        {
            await Authors();

            var list = (from x in Author
                        where x.AuthorName.ToLower().Contains(textBox1.Text.ToLower()
                        )
                        select new
                        {
                            AuthorId = x.AuthorId,
                            Author = x.AuthorName,
                        }).ToList();

            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;

        }

        private void AuthorsList_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure to delete this author?");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //authorsid = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            
        }
    }
}
