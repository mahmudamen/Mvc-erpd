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
    
    public partial class vEmpHis
    {
        public int ID { get; set; }
        public int EmpID { get; set; }
        public string FullName { get; set; }
        public string Dept { get; set; }
        public string Jop { get; set; }
        public string Action { get; set; }
        public Nullable<int> Deptto { get; set; }
        public Nullable<int> Jopto { get; set; }
        public Nullable<decimal> Osal { get; set; }
        public Nullable<decimal> Nsal { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> Deptfrm { get; set; }
        public Nullable<int> Jopfrm { get; set; }
        public string NatID { get; set; }
    }
}
