using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedmondTradeWork.ViewModels
{
    public class ContainerDetailsViewModel
    {
        public int ID { get; set; }
        public string ContainerNo { get; set; }
        public string Product { get; set; }
        public string Unit { get; set; }
        public int? Quantity { get; set; }
        public string BuyerCompany { get; set; }
        public DateTime? Date { get; set; }
        public string DeportunePort { get; set; }
        public string Nots { get; set; }
    }
}