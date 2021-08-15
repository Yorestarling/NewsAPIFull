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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        void addArticles()
        {
            string url = "https://localhost:44320/api/Articles";

            ArticleRequest article = new ArticleRequest();

            article.AuthorId = CbAuthor.SelectedIndex;
            article.Title = TxtTitle.Text;
            article.Descriptions = TxtDescriptions.Text;
            article.Ulr = TxtUrl.Text;
            article.CountriesId = CbCountry.SelectedIndex;
            article.CategoryId = CbCategory.SelectedIndex;
            article.SourcesId = CbSources.SelectedIndex;
            article.UlrToImage = TxtUrlToImage.Text;
            article.Content = TxtContent.Text;
            article.PublishedAt = DateTime.Now;

            string resultado = Send<ArticleRequest>(url, article, "POST");
        }

        public string Send<T>(string url, T objectRequest, string method = "POST")
        {
            string result = "";

            try
            {

               // JavaScriptSerializer js = new JavaScriptSerializer();

                //serializamos el objeto
                string json = JsonConvert.SerializeObject(objectRequest);

                //peticion
                WebRequest request = WebRequest.Create(url);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 10000; //esto es opcional

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

            }
            catch (Exception e)
            {
                result = e.Message;

            }

            return result;
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
