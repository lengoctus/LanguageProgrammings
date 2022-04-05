using System;
using System.Collections.Generic;

namespace DemoConnectDb.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Invoice = new HashSet<Invoice>();
        }

        public int IdCus { get; set; }
        public string NameCus { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}
