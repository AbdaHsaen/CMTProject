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
    
    public partial class Service
    {
        public int ServiceId { get; set; }
        public int TypeOfServiceLookupId { get; set; }
        public int WorkOrderId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Lookup Lookup { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}