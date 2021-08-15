using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace APInewsREST.Models
{
    public partial class Source
    {
        public Source()
        {
            Articles = new HashSet<Article>();
        }

        [Key]
        public int SourcesId { get; set; }
        [Required]
        [StringLength(30)]
        public string SourcesName { get; set; }

        [InverseProperty(nameof(Article.Sources))]
        public virtual ICollection<Article> Articles { get; set; }
    }
}
