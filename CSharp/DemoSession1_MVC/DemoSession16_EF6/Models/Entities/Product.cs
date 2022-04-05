using System;
using System.Collections.Generic;

namespace DemoSession16_EF6.Models.Entities
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public bool? Status { get; set; }
        public string Description { get; set; }
    }
}
