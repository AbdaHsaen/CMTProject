//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMTLabs.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class LookupCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LookupCategory()
        {
            this.Lookups = new HashSet<Lookup>();
        }
    
        public int LookupCategoryId { get; set; }
        public string CategoryName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lookup> Lookups { get; set; }
    }
}
