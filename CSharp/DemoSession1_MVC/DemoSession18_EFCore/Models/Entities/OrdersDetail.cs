using System;
using System.Collections.Generic;

namespace DemoSession18_EFCore.Models.Entities
{
    public partial class OrdersDetail
    {
        public int OrdersId { get; set; }
        public int ProductId { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }

        public virtual Orders Orders { get; set; }
        public virtual Product Product { get; set; }
    }
}
