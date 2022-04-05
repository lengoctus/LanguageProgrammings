using System;
using System.Collections.Generic;

namespace DemoSession25_Security_EF.Models
{
    public partial class RoleDetails
    {
        public int RoleId { get; set; }
        public int AccountId { get; set; }
        public int? Enabled { get; set; }

        public virtual Account Account { get; set; }
        public virtual Role Role { get; set; }
    }
}
