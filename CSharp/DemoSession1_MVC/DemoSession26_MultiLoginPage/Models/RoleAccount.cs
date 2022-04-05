using System;
using System.Collections.Generic;

namespace DemoSession26_MultiLoginPage.Models
{
    public partial class RoleAccount
    {
        public int RoleId { get; set; }
        public int AccountId { get; set; }
        public bool? Enabled { get; set; }

        public virtual Account Account { get; set; }
        public virtual Role Role { get; set; }
    }
}
