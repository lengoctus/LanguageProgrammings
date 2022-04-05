using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession3.Models
{
    public class ProductsModel
    {
        public List<Products> findAll()
        {
            return new List<Products>()
            {
                new Products{ Id=1, Name="Banh Chung", Price=2000, Image = "73013116_409207736409579_438760905337995264_n.jpg"},

                new Products{ Id=2, Name="Banh Bap", Price=2000, Image = "73013116_409207736409579_438760905337995264_n.jpg"},
                new Products{ Id=3, Name="Banh Nep", Price=3000, Image = "73472799_409207666409586_7032551485938335744_n.jpg"},
                new Products{ Id=4, Name="Banh Mut", Price=4000, Image = "73341324_147410913306862_6242422445735673856_n.jpg"},
                new Products{ Id=5, Name="Banh Gai", Price=5000, Image = "Annotation 2019-10-29 174207.png"},
            };
        }
    }
}
