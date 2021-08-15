using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace NewsFormsAdmin.Models
{
    public class Category
    {
        public Category()
        {
            Articles = new HashSet<ArticleRequest>();
        }


        public int CategoryId { get; set; }

        [StringLength(30)]
        public string CategoryName { get; set; }

        //[InverseProperty(nameof(ArticlesD.Category))]
        public virtual ICollection<ArticleRequest> Articles { get; set; }
    }
}
