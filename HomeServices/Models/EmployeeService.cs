//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeServices.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeService
    {
        public int EmployeeId { get; set; }
        public int ServiceId { get; set; }
        public Nullable<decimal> AdditionalRate { get; set; }
        public Nullable<int> Rating { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Service Service { get; set; }
    }
}
