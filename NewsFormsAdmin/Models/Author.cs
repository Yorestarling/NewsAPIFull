using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


#nullable disable

namespace NewsFormsAdmin.Models
{
    public partial class Author
    {
        public Author()
        {
            Articles = new HashSet<ArticlesD>();
        }

        [Key]        public int AuthorId { get; set; }
        public int UsersId { get; set; }

        [StringLength(60)]
        public string AuthorName { get; set; }


        public virtual ICollection<ArticlesD> Articles { get; set; }
    }
}
