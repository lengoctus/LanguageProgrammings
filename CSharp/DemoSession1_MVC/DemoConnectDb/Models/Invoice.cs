using System;
using System.Collections.Generic;

namespace DemoConnectDb.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceDetails = new HashSet<InvoiceDetails>();
        }

        public int IdInv { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? IdCus { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual Customer IdCusNavigation { get; set; }
        public virtual ICollection<InvoiceDetails> InvoiceDetails { get; set; }
    }
}
