using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsFormsAdmin.Models
{
    public class Category_DTO
    {
        public int CategoryId { get; set; }

        [StringLength(30)]
        public string CategoryName { get; set; }
    }
}
