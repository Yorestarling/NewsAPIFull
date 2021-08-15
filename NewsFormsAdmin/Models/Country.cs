using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewsFormsAdmin.Models
{
    public partial class Country
    {
        public Country()
        {
            Articles = new HashSet<ArticlesD>();
        }


        public int CountriesId { get; set; }

        [StringLength(70)]
        public string ContriesName { get; set; }

        //[InverseProperty(nameof(ArticlesD.Countries))]
        public virtual ICollection<ArticlesD> Articles { get; set; }
    }
}
