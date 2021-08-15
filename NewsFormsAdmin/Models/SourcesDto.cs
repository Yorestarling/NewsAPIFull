using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsFormsAdmin.Models
{
    public class SourcesDto
    {
        public int SourcesId { get; set; }

        [StringLength(30)]
        public string SourcesName { get; set; }
    }
}
