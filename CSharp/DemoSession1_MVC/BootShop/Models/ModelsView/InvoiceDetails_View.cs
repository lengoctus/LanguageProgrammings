using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootShop.Models.ModelsView
{
    public class InvoiceDetails_View
    {
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}
