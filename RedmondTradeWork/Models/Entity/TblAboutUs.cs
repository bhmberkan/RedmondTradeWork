//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedmondTradeWork.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblAboutUs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblAboutUs()
        {
            this.TblMainPage = new HashSet<TblMainPage>();
        }
    
        public int AboutUsID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string Photo2 { get; set; }
        public string SubHeadingTitle { get; set; }
        public string SubHeading { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblMainPage> TblMainPage { get; set; }
    }
}
