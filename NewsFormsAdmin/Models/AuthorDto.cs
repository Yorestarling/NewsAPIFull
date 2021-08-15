using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsFormsAdmin.Models
{
    public class AuthorDto
    {

        [Key] public int AuthorId { get; set; }
      
        [StringLength(60)]
        public string AuthorName { get; set; }
    }
}
