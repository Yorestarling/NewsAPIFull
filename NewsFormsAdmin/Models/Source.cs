using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewsFormsAdmin.Models
{
    public partial class Source
    {
        public Source()
        {
            Articles = new HashSet<ArticlesD>();
        }


        public int SourcesId { get; set; }

        [StringLength(30)]
        public string SourcesName { get; set; }

        //[InverseProperty(nameof(ArticlesD.Sources))]
        public virtual ICollection<ArticlesD> Articles { get; set; }
    }
}
