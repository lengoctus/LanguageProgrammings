using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession24_Security.Models
{
    public class AccountModels
    {
        private List<Account> account { get; set; }

        public AccountModels()
        {
            account = new List<Account>
            {
                new Account {
                    UserName = "Ngoc Tu",
                    Password = "1234",
                    Role = new string[]{"SuperAdmin", "Admin", "Employee"}
                },
                new Account {
                    UserName = "Ngoc Tran",
                    Password = "1234",
                    Role = new string[]{"Admin", "Employee"}
                },
                new Account {
                    UserName = "Ngoc Sang",
                    Password = "1234",
                    Role = new string[]{"Employee"}
                },
            };
        }

        public Account Find(string username)
        {
            var acc = account.SingleOrDefault(p => p.UserName == username);
            return acc;
        }

        public Account Login(string username, string password)
        {
            var acc = account.SingleOrDefault(p => p.UserName == username && p.Password == password);
            return acc;
        }
    }
}
