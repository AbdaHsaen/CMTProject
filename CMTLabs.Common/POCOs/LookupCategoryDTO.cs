using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.Common.POCOs
{
   public class LookupCategoryDTO
    {
        public int LookupCategoryId { get; set; }
        public string CategoryName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifedDate { get; set; }
    }
}
