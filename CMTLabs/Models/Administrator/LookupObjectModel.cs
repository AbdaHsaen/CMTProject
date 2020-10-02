using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMTLabs.Models.Administrator
{
    public class LookupObjectModel
    {
        public int LookupId { get; set; }
        public int LookupCategoryId { get; set; }
        [DisplayName("Lookup Name")]
        [Required]
        public string LookupName { get; set; }
        [DisplayName("Lookup Code")]
        [Required]
        public string LookupCode { get; set; }
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Lookup Parant")]
        public int? ParantId { get; set; }
    }
}