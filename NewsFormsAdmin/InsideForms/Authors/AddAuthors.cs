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
using System.Linq;
using System.Threading.Tasks;


namespace NewsFormsAdmin.InsideForms.Authors
{
    public partial class AddAuthors : Form
    {
        static readonly HttpClient httpClient = new HttpClient();
        public AddAuthors()
        {
            InitializeComponent();
            httpClient.BaseAddress = new Uri("https://localhost:44320/");
        }

        private void BtnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void addAuthors()
        {
            var author = new AuthorDto
            {
                AuthorName = TxtAuthors.Text,
            };

            string json = JsonConvert.SerializeObject(author);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = httpClient.PostAsync("/api/Authors", content).Result;

            if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Author Inserted!");

            }
            else
            {
                MessageBox.Show("¡Error!");
            }
        }
        private void BtnAuthors_Click(object sender, EventArgs e)
        {
            addAuthors();
            //addAuthor();
        }
    }
}
