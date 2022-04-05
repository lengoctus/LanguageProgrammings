using Review_Buoi1.Models.EFCore;
using Review_Buoi1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Review_Buoi1.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public List<Product> Search(string key);
    }
}
