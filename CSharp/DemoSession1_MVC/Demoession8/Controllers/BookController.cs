using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demoession8.Controllers
{
    public class BookController : Controller
    {
        /// <summary>
        /// Xay dung form nhap thong tin cua 1 quyen sach va thuc hien kiem tra du lieu hop le theo yeu cau sau:

        ///1. id kieu chuoi khong duoc rong

        ///2. name kieu chuoi khong duoc rong

        ///3. isbn kieu chuoi theo quy tac

        ///4. rating kieu so thuc co gia tri nam trong khoang tu 1 den 5

        ///5. page kieu so nguyen co gia tri nam trong khoang tu 1 den 2000

        ///6. price kieu so thuc co gia tri nam trong khoang tu 1 den 500000

        ///7. url kieu chuoi co dinh dang la url

        ///8. description kieu chuoi khong duoc rong
        /// </summary> 
        public IActionResult Index()
        {
            return View();
        }
    }
}