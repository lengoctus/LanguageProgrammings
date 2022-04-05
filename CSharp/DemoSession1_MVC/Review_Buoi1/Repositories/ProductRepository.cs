using Review_Buoi1.Models.EFCore;
using Review_Buoi1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Review_Buoi1.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ConnectDbContext dbContext) : base(dbContext)
        {
            
        }

        public List<Product> Search(string key)
        {
            return GetAll().Where(p => p.Name.Contains(key.Trim())).ToList();
        }
    }
}
