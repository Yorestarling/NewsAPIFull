//using Nancy.Json;
using NewsFormsAdmin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Dapper;
using System.Net.Http;
using System.Threading.Tasks;

namespace NewsFormsAdmin.InsideForms.Articles
{
    public partial class AddArticles : Form
    {

        static HttpClient httpClient = new HttpClient();
        public AddArticles()
        {
            InitializeComponent();

            httpClient.BaseAddress = new Uri("https://localhost:44320/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void addArticles()
        {
            var articles = new ArticleRequest
            {
            
                Title = TxtTitle.Text,
                AuthorId = CbAuthor.SelectedIndex,
                Descriptions = TxtDescriptions.Text,
                Content = TxtContent.Text,
                Ulr = TxtUrl.Text,
                UlrToImage = TxtUrlToImage.Text,
                PublishedAt = DateTime.Now,
                SourcesId = CbSources.SelectedIndex,
                CategoryId = CbCategory.SelectedIndex,
                CountriesId = CbCountry.SelectedIndex,

            };

            if (TxtTitle.Text.Length == 0)
            {
                MessageBox.Show("Title Required");
            }
            else if (TxtDescriptions.Text.Length == 0)
            {
                MessageBox.Show("Descriptions Required");
            }
            else
            {
                string json = JsonConvert.SerializeObject(articles);

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = httpClient.PostAsync("/api/Articles", content).Result;

                if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Article Inserted");
                }
                else
                {
                    MessageBox.Show("¡Error inserting an article!");
                }
            }


            


        }

        

        void clear()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }
            CbSources.SelectedIndex = 0;
            CbCountry.SelectedIndex = 0;
            CbCategory.SelectedIndex = 0;
            CbAuthor.SelectedIndex = 0;   
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           addArticles();
           clear();
        }

       

        private async Task<string> GetHttp()
        {
            WebRequest request = WebRequest.Create("https://localhost:44320/api/Articles");
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async Task<string> GetHttp2()
        {
            WebRequest request = WebRequest.Create("https://localhost:44320/api/Authors");
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async Task<string> GetHttp3()
        {
            WebRequest request = WebRequest.Create("https://localhost:44320/api/Categories");
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async Task<string> GetHttp4()
        {
            WebRequest request = WebRequest.Create("https://localhost:44320/api/Countries");
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async Task<string> GetHttp5()
        {
            WebRequest request = WebRequest.Create("https://localhost:44320/api/Sources");
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void AddArticles_Load(object sender, EventArgs e)
        {
            authors();
            category();
            sources();
            country();
        }

        private async void authors()
        {
            string res = await GetHttp2();
            List<Author> List
                = JsonConvert.DeserializeObject<List<Author>>(res);

            var objauthor = new Author { AuthorId = 0, AuthorName = "SELECCIONAR" };
            List.Insert(0, objauthor);

            CbAuthor.DataSource = List;
            CbAuthor.DisplayMember = "AuthorName";
            CbAuthor.ValueMember = "AuthorId";

        }

        private async void category()
        {
            string res2 = await GetHttp3();
            List<Category> List2
                = JsonConvert.DeserializeObject<List<Category>>(res2);

            var objcate = new Category { CategoryId = 0, CategoryName = "SELECCIONAR" };
            List2.Insert(0, objcate);
            CbCategory.DataSource = List2;
            CbCategory.DisplayMember = "CategoryName";
            CbCategory.ValueMember = "CategoryId";
        }

        private async void sources()
        {
            string res3 = await GetHttp5();
            List<Source> List3
                = JsonConvert.DeserializeObject<List<Source>>(res3);

            var objsou = new Source { SourcesId = 0, SourcesName = "SELECCIONAR" };
            List3.Insert(0, objsou);
            CbSources.DataSource = List3;
            CbSources.DisplayMember = "SourcesName";
            CbSources.ValueMember = "SourcesId";
        }

        private async void country()
        {
            string res4 = await GetHttp4();
            List<Country> List4
                = JsonConvert.DeserializeObject<List<Country>>(res4);

            var objcou = new Country { CountriesId = 0, ContriesName = "SELECCIONAR" };
            List4.Insert(0, objcou);

            CbCountry.DataSource = List4;
            CbCountry.DisplayMember = "ContriesName";
            CbCountry.ValueMember = "CountriesId";
        }



    }
}
