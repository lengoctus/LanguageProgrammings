using BootShop.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootShop.ViewComponents
{
    [ViewComponent(Name = "Product")]
    public class ProductViewComponent : ViewComponent
    {
        private readonly ConnectDbContext _db;

        public ProductViewComponent(ConnectDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var newProd =  _db.Product.AsNoTracking().Where(p => p.Status == true).OrderByDescending(p => p.Id).Take(2).ToList();
            return View("Index", newProd);
        }
    }
}
