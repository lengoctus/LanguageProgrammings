using Session25_Security_EF.Models;
using System.Collections.Generic;

namespace Session25_Security_EF.ViewModels
{
    public class AccountViewModel
    {
        public Account account { get; set; }

        public List<Role> Roles { get; set; }
    }
}
