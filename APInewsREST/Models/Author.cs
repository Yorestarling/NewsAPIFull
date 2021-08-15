using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace APInewsREST.Models
{
    public partial class Author
    {
        public Author()
        {
            Articles = new HashSet<Article>();
        }

        [Key]
        public int AuthorId { get; set; }
        public int UsersId { get; set; }
        [Required]
        [StringLength(60)]
        public string AuthorName { get; set; }

        [ForeignKey(nameof(UsersId))]
        [InverseProperty(nameof(UsersLog.Authors))]
        public virtual UsersLog Users { get; set; }
        [InverseProperty(nameof(Article.Author))]
        public virtual ICollection<Article> Articles { get; set; }
    }
}
