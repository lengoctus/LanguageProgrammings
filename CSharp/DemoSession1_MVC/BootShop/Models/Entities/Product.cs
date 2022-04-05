using System;
using System.Collections.Generic;

namespace BootShop.Models.Entities
{
    public partial class Product
    {
        public Product()
        {
            InvoiceDetails = new HashSet<InvoiceDetails>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Created { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string Photo { get; set; }
        public string Details { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<InvoiceDetails> InvoiceDetails { get; set; }
    }
}
