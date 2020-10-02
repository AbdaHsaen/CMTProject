using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.Common.POCOs
{
    public class LookupDTO
    {
        public int LookupId { get; set; }
        public int LookupCategoryId { get; set; }
        public string LookupName { get; set; }
        public string LookupCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int? ParantId { get; set; }

    }
}
