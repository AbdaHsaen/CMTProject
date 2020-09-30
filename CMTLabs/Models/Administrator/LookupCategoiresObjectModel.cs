using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMTLabs.Models.Administrator
{
    public class LookupCategoiresObjectModel
    {
        public int LookupCategoryId { get; set; }

        [DisplayName("Lookup Category Name")]
        [Required]
        public string CategoryName { get; set; }
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }

        public ICollection<LookupObjectModel> Lookups { get; set; }
    }
}