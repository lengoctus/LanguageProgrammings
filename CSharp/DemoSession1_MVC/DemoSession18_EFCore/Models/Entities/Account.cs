using System;
using System.Collections.Generic;

namespace DemoSession18_EFCore.Models.Entities
{
    public partial class Account
    {
        public Account()
        {
            AccountRole = new HashSet<AccountRole>();
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string Photo { get; set; }
        public bool? Status { get; set; }
        public DateTime? Expire { get; set; }

        public virtual ICollection<AccountRole> AccountRole { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
