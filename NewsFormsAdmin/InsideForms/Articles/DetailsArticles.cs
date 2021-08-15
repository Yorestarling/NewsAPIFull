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
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Linq;
using System.Net.Http;

namespace NewsFormsAdmin.InsideForms.Articles
{
    public partial class DetailsArticles : Form
    {

        static HttpClient httpClient = new HttpClient();
        List<ArticlesD> articles;
        public DetailsArticles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetailsArticles_Load(object sender, EventArgs e)
        {
            

            LoadGrid();
        }

        private async Task<string> GetHttp()
        {
            WebRequest request = WebRequest.Create("https://localhost:44320/api/Articles");
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private async Task<List<ArticlesD>> Articles()
        {
            string response = await GetHttp();

            articles = JsonConvert.DeserializeObject<List<ArticlesD>>(response);

            return articles;
        }


        private async void LoadGrid()
        {
            await Articles();

            var list = (from x in articles
                        where x.Title.ToLower().Contains(TxtSearch.Text.ToLower())
                        || x.AuthorName.ToLower().Contains(TxtSearch.Text.ToLower())
                        select new
                        {
                            Author = x.AuthorName,
                            Title = x.Title,
                            Description = x.Descriptions,
                            Content = x.Content,
                            Url = x.Ulr,
                            UrlToImage = x.UlrToImage,
                            Published = x.PublishedAt,
                            Category = x.CategoryName,
                            Country = x.CountriesName,
                            Source = x.SourcesName
                        }).ToList();

            dataGridView1.DataSource = list;

           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
