//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class YearsList
    {
        public int id { get; set; }
        public string YearName { get; set; }
        public Nullable<System.DateTime> BeginYear { get; set; }
        public Nullable<System.DateTime> EndYear { get; set; }
        public bool IsActive { get; set; }
    }
}
