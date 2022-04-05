using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootShop.Models.ModelsView
{
    public class Product_View
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Created { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
