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
    
    public partial class DurList
    {
        public int ID { get; set; }
        public Nullable<int> ProFK { get; set; }
        public Nullable<System.DateTime> DurDateFirst { get; set; }
        public Nullable<System.DateTime> DurDateSec { get; set; }
        public Nullable<System.DateTime> DurDateThird { get; set; }
        public Nullable<System.DateTime> FinalDate { get; set; }
        public string Remark { get; set; }
    
        public virtual ProList ProList { get; set; }
    }
}
