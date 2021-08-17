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

namespace NewsFormsAdmin.InsideForms.Countries
{
    public partial class AddCountries : Form
    {
        static readonly HttpClient httpClient = new HttpClient();
        public AddCountries()
        {
            InitializeComponent();
            httpClient.BaseAddress = new Uri("https://localhost:44320/");
        }

        private void BtnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addcountries()
        {
            var author = new CountryDto
            {
                ContriesName = txtCountry.Text,
            };

            string json = JsonConvert.SerializeObject(author);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = httpClient.PostAsync("/api/Countries", content).Result;

            if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Country Inserted!");

            }
            else
            {
                MessageBox.Show("¡Error!");
            }
        }

        private void BtnCountry_Click(object sender, EventArgs e)
        {
            addcountries();
            txtCountry.Clear();
        }
    }
}
