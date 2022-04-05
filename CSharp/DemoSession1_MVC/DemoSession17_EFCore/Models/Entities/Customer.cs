using System;
using System.Collections.Generic;

namespace DemoSession17_EFCore.Models.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Invoice = new HashSet<Invoice>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public DateTime? Birthday { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}
