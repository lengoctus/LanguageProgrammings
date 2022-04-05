using System;
using System.Collections.Generic;

namespace DemoSession18_EFCore.Models.Entities
{
    public partial class Product
    {
        public Product()
        {
            OrdersDetail = new HashSet<OrdersDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        public bool? Status { get; set; }
        public bool? Specials { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string Photo { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrdersDetail> OrdersDetail { get; set; }
    }
}
