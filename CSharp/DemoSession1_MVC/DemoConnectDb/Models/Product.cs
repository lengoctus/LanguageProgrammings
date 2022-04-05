using System;
using System.Collections.Generic;

namespace DemoConnectDb.Models
{
    public partial class Product
    {
        public Product()
        {
            InvoiceDetails = new HashSet<InvoiceDetails>();
        }

        public int IdProd { get; set; }
        public string NameProd { get; set; }
        public string Unit { get; set; }
        public decimal? Price { get; set; }
        public decimal? Quantity { get; set; }
        public int? IdCate { get; set; }

        public virtual Category IdCateNavigation { get; set; }
        public virtual ICollection<InvoiceDetails> InvoiceDetails { get; set; }
    }
}
