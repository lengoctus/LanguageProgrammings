using System;
using System.Collections.Generic;

namespace DemoSession16_EF6.Models.Entities
{
    public partial class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? Gender { get; set; }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
