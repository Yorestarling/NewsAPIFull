using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APInewsREST.Data
{
    public class ArticlesDTO
    {
        [StringLength(60)]
        public string AuthorName { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Column("descriptions")]
        public string Descriptions { get; set; }
        [Column("ulr")]
        public string Ulr { get; set; }
        [Column("ulrToImage")]
        public string UlrToImage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PublishedAt { get; set; }
        public string Content { get; set; }
        public string SourcesName { get; set; }
        public string CategoryName { get; set; }
        public string CountriesName { get; set; }


    }
}
