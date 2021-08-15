using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace NewsFormsAdmin.Models
{
    public class ArticlesD
    {
        //public int ArticleId { get; set; }
        public string AuthorName { get; set; }

        public string Title { get; set; }

        public string Descriptions { get; set; }

        public string Ulr { get; set; }

        public string UlrToImage { get; set; }

        public DateTime? PublishedAt { get; set; }
        public string Content { get; set; }
        public string SourcesName { get; set; }
        public string CategoryName { get; set; }
        public string CountriesName { get; set; }

        //public int SourcesId { get; set; }
        //public int CategoryId { get; set; }
        //public int CountriesId { get; set; }

        internal object GetArticlesD()
        {
            throw new NotImplementedException();
        }

        //[ForeignKey(nameof(AuthorId))]

        //public virtual Author Author { get; set; }
        //[ForeignKey(nameof(CategoryId))]

        //public virtual Category Category { get; set; }
        //[ForeignKey(nameof(CountriesId))]
        //[InverseProperty(nameof(Country.Articles))]
        //public virtual Country Countries { get; set; }

        //[ForeignKey(nameof(SourcesId))]
        //[InverseProperty(nameof(Source.Articles))]
        //public virtual Source Sources { get; set; }
    }
}
