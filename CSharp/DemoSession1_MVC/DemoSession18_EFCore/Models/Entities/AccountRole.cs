using System;
using System.Collections.Generic;

namespace DemoSession18_EFCore.Models.Entities
{
    public partial class AccountRole
    {
        public int RoleId { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Role Role { get; set; }
    }
}
