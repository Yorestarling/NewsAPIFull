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

namespace NewsFormsAdmin.InsideForms.Sources
{
    public partial class AddSource : Form
    {
        static readonly HttpClient httpClient = new HttpClient();
        public AddSource()
        {
            InitializeComponent();
            httpClient.BaseAddress = new Uri("https://localhost:44320/");
        }

        private void BtnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSource_Click(object sender, EventArgs e)
        {
            addsource();
            txtSource.Clear();
        }


        private void addsource()
        {
            var Source = new SourcesDto
            {
                SourcesName = txtSource.Text,
            };

            string json = JsonConvert.SerializeObject(Source);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = httpClient.PostAsync("/api/Sources", content).Result;

            if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Source Inserted!");

            }
            else
            {
                MessageBox.Show("¡Error!");
            }
        }
        

    }
}
