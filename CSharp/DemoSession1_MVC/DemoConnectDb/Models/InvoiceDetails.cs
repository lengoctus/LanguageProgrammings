using System;
using System.Collections.Generic;

namespace DemoConnectDb.Models
{
    public partial class InvoiceDetails
    {
        public int IdInv { get; set; }
        public int IdProd { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Promotion { get; set; }
        public decimal? PriceSale { get; set; }

        public virtual Invoice IdInvNavigation { get; set; }
        public virtual Product IdProdNavigation { get; set; }
    }
}
