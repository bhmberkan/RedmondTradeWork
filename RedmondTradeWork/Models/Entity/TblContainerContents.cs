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
    
    public partial class TblContainerContents
    {
        public int ID { get; set; }
        public string Product { get; set; }
        public string Unit { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string BuyerCompany { get; set; }
        public string Nots { get; set; }
        public Nullable<int> Container { get; set; }
    
        public virtual TblContainer TblContainer { get; set; }
    }
}
