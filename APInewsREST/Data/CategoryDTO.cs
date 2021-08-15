using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APInewsREST.Data
{
    public class CategoryDTO
    {

        public int CategoryId { get; set; }

        [StringLength(30)]
        public string CategoryName { get; set; }

    }
}
