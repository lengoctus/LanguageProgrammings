using System;
using System.Collections.Generic;

namespace Review_Buoi1.Models.Entities
{
    public partial class InvoiceDetails
    {
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
