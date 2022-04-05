using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession2.Models
{
    public class Invoices
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string Payment { get; set; }
        public Customers Customer { get; set; }

        public List<Products> Products { get; set; }
    }
}
