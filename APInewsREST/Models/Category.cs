using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace APInewsREST.Models
{
    public partial class Category
    {
        public Category()
        {
            Articles = new HashSet<Article>();
        }

        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(30)]
        public string CategoryName { get; set; }

        [InverseProperty(nameof(Article.Category))]
        public virtual ICollection<Article> Articles { get; set; }
    }
}
