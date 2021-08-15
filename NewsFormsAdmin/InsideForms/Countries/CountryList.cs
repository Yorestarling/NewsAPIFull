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

namespace NewsFormsAdmin.InsideForms.Countries
{
    public partial class CountryList : Form
    {
        static HttpClient httpClient = new HttpClient();
        List<CountryDto> Country;
        public CountryList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private async Task<string> GetHttp()
        {
            WebRequest request = WebRequest.Create("https://localhost:44320/api/Countries");
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private void CountryList_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private async Task<List<CountryDto>> Countries()
        {
            string response = await GetHttp();

            Country = JsonConvert.DeserializeObject<List<CountryDto>>(response);

            return Country;
        }

        private async void LoadGrid()
        {
            await Countries();

            var list = (from x in Country
                        where x.ContriesName.ToLower().Contains(textBox1.Text.ToLower()
                        )
                        select new
                        {
                            CountryId = x.CountriesId,
                            CaountryName = x.ContriesName,
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
