using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMTLabs.Models.Administrator
{
    public class LookupObjectModel
    {
        public int LookupId { get; set; }
        public int LookupCategoryId { get; set; }
        public string LookupName { get; set; }
        public string LookupCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}