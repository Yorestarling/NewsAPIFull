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

namespace NewsFormsAdmin.InsideForms.Authors
{
    public partial class AddAuthors : Form
    {
        static HttpClient httpClient = new HttpClient();
        public AddAuthors()
        {
            InitializeComponent();
            httpClient.BaseAddress = new Uri("https://localhost:44320/");
        }

        private void BtnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addAuthor()
        {
            var authors = new Author
            {
                AuthorName = textBox1.Text,
            };

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Name Required");
            }       
            else
            {
                string json = JsonConvert.SerializeObject(authors);

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = httpClient.PostAsync("/api​/Authors", content).Result;

                if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Author Inserted");
                }
                else
                {
                    MessageBox.Show("¡Error inserting an article!");
                }
            }

        }

        private void BtnAuthors_Click(object sender, EventArgs e)
        {
            addAuthor();
        }
    }
}
