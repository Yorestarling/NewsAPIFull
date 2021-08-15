using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace APInewsREST.Models
{
    [Table("UsersLog")]
    public partial class UsersLog
    {
        public UsersLog()
        {
            Authors = new HashSet<Author>();
        }

        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(250)]
        public string DisplayName { get; set; }
        [Required]
        [StringLength(40)]
        public string Username { get; set; }
        [Required]
        [StringLength(400)]
        public string Passwords { get; set; }

        [InverseProperty(nameof(Author.Users))]
        public virtual ICollection<Author> Authors { get; set; }
    }
}
