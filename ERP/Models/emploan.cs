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
    
    public partial class emploan
    {
        public int ID { get; set; }
        public Nullable<int> EmpId { get; set; }
        public Nullable<int> LoanID { get; set; }
        public Nullable<System.DateTime> GetDate { get; set; }
        public Nullable<decimal> PartVal { get; set; }
        public Nullable<int> Months { get; set; }
    
        public virtual HR_EmpReform HR_EmpReform { get; set; }
        public virtual LoanList LoanList { get; set; }
    }
}
