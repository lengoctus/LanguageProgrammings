using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootShop.ViewComponents
{
    [ViewComponent(Name = "CartLeft")]
    public class CartLeftViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {


            return View("Index");
        }
    }
}
