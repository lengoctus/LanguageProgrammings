using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession25_Security_EF.Models.Dao
{
    public class Account_Dao
    {
        private readonly Db25Context _db;

        public Account_Dao()
        {
            _db = new Db25Context();
        }

        public Account Register(Account acc)
        {
            string mySalt = BCrypt.Net.BCrypt.GenerateSalt();
            acc.Password = BCrypt.Net.BCrypt.HashPassword(acc.Password, mySalt);

            _db.Account.Add(acc);
            _db.SaveChanges();
            return acc;
        }
    }
}
