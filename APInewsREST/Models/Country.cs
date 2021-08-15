using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace APInewsREST.Models
{
    public partial class Country
    {
        public Country()
        {
            Articles = new HashSet<Article>();
        }

        [Key]
        public int CountriesId { get; set; }
        [Required]
        [StringLength(70)]
        public string ContriesName { get; set; }

        [InverseProperty(nameof(Article.Countries))]
        public virtual ICollection<Article> Articles { get; set; }
    }
}
