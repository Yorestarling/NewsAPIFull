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

namespace NewsFormsAdmin.InsideForms.Sources
{
    public partial class SourceList : Form
    {
        static HttpClient httpClient = new HttpClient();
        List<SourcesDto> Sources;
        public SourceList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SourceList_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private async Task<string> GetHttp()
        {
            WebRequest request = WebRequest.Create("https://localhost:44320/api/Sources");
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private async Task<List<SourcesDto>> Source()
        {
            string response = await GetHttp();

            Sources = JsonConvert.DeserializeObject<List<SourcesDto>>(response);

            return Sources;
        }

        private async void LoadGrid()
        {
            await Source();

            var list = (from x in Sources
                        where x.SourcesName.ToLower().Contains(textBox1.Text.ToLower()
                        )
                        select new
                        {
                            SourceId = x.SourcesId,
                            SourceName = x.SourcesName,
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
