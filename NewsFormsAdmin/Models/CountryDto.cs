using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsFormsAdmin.Models
{
   public class CountryDto
    {
        public int CountriesId { get; set; }

        [StringLength(70)]
        public string ContriesName { get; set; }
    }
}
