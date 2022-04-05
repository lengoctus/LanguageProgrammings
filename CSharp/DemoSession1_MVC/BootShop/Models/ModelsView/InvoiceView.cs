using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootShop.Models.ModelsView
{
    public class InvoiceView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; }
        public string Payment { get; set; }
        public int AccountId { get; set; }
    }
}
