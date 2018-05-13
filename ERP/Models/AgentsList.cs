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
    
    public partial class AgentsList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AgentsList()
        {
            this.digtab = new HashSet<digtab>();
            this.PartMount = new HashSet<PartMount>();
        }
    
        public int AgentID { get; set; }
        public string AgentName { get; set; }
        public string address { get; set; }
        public Nullable<decimal> NationalID { get; set; }
        public int LandID { get; set; }
        public int SysID { get; set; }
        public int LevelID { get; set; }
        public string Neighborhood { get; set; }
        public string NeighborhoodNext { get; set; }
        public Nullable<int> Stage { get; set; }
        public Nullable<System.DateTime> AcceptedDate { get; set; }
        public Nullable<decimal> Spaces { get; set; }
        public Nullable<decimal> SpacesReal { get; set; }
        public Nullable<decimal> PriceMeter { get; set; }
        public Nullable<decimal> Deposit { get; set; }
        public Nullable<decimal> DepositPlus { get; set; }
        public Nullable<System.DateTime> TossDate { get; set; }
        public Nullable<int> FileNum { get; set; }
        public string Licenseid { get; set; }
        public Nullable<System.DateTime> LicenseDate { get; set; }
        public string Remark { get; set; }
        public Nullable<int> StatusFlag { get; set; }
        public Nullable<int> DigID { get; set; }
        public Nullable<int> DigSer { get; set; }
        public Nullable<System.DateTime> DigDate { get; set; }
        public string DigRemark { get; set; }
    
        public virtual LevelList LevelList { get; set; }
        public virtual Syslisto Syslisto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<digtab> digtab { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartMount> PartMount { get; set; }
    }
}