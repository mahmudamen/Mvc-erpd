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
    
    public partial class JobCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobCategory()
        {
            this.HR_EmpReform = new HashSet<HR_EmpReform>();
        }
    
        public int JBC_PK { get; set; }
        public string JBC_Name { get; set; }
        public Nullable<int> Kdr_fk { get; set; }
        public string JBC_Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_EmpReform> HR_EmpReform { get; set; }
        public virtual JobKader JobKader { get; set; }
    }
}
