using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NewsFormsAdmin.Models
{
    public class ArticleRequest
    {
        [Key]
        public int ArticleId { get; set; }
        public int AuthorId { get; set; }
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
        public int SourcesId { get; set; }
        public int CategoryId { get; set; }
        public int CountriesId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty("Articles")]
        public virtual Author Author { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Articles")]
        public virtual Category Category { get; set; }
        [ForeignKey(nameof(CountriesId))]
        [InverseProperty(nameof(Country.Articles))]
        public virtual Country Countries { get; set; }
        [ForeignKey(nameof(SourcesId))]
        [InverseProperty(nameof(Source.Articles))]
        public virtual Source Sources { get; set; }
    }
}
