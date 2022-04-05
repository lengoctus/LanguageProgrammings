using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession13_Ajax2.Models
{
    public class ProductModel
    {
        private List<Products> products;

        public ProductModel()
        {
            products = new List<Products> {
            new Products { Id = 1, Name = "sp01", Price = 2000, Category = "cate1"},
            new Products { Id = 2, Name = "sp02", Price = 3000, Category = "cate2"},
            new Products { Id = 3, Name = "ap03", Price = 4000, Category = "cate4"},
            new Products { Id = 4, Name = "ap04", Price = 5000, Category = "cate5"},
            new Products { Id = 5, Name = "dp05", Price = 6000, Category = "cate7"},
            new Products { Id = 6, Name = "dp06", Price = 7000, Category = "cate1"},
            new Products { Id = 7, Name = "hp07", Price = 8000, Category = "cate4"},
            new Products { Id = 8, Name = "hp08", Price = 9000, Category = "cate6"},
            new Products { Id = 9, Name = "sp09", Price = 10000, Category = "cate9"},
            new Products { Id = 10, Name = "sp010", Price = 12000, Category = "cate11"}
            };
        }

        public List<Products> FindAll()
        {
            return products;
        }

        public List<Products> FindProd(string keyword)
        {
            return products.Where(p => p.Name.ToLower().Contains(keyword.ToLower())).Select(p => new Products
            {
                Id = p.Id,
                Name = p.Name
            }).ToList();
        }

        public List<Products> SearchByCategory(string category)
        {
            return products.Where(p => p.Category.ToLower().Equals(category.ToLower())).ToList();
        }
    }
}
