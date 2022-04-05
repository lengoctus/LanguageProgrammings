using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DemoSession18_EFCore.Models.Entities;
using DemoSession18_EFCore.Models.ModelView;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoSession18_EFCore.Controllers
{
    public class OrderController : Controller
    {
        private readonly MyDemoDbContext _db;
        private readonly IMapper _map;

        public OrderController(MyDemoDbContext db, IMapper map)
        {
            _db = db;
            _map = map;
        }

        //public OrderController(MyDemoDbContext db)
        //{
        //    _db = db;
        //}

        public IActionResult Index()
        {
            var listOrder = _db.Orders.ToList();
            //var list = _map.Map<OrderView>(listOrder);

            return View(listOrder);
        }

        public ActionResult<OrderView> Add()
        {
            var employees = _db.Employee.Select(l => new
            {
                Id = l.Id,
                FullName = l.FullName
            }).ToList();


            var account = _db.Account.Select(p => new
            {
                Id = p.Id,
                UserName = p.Username
            }).ToList();


            var orderModel = new OrderView
            {
                Orders = new Orders(),
                Employees = new SelectList(employees, "Id", "FullName"),
                Accounts = new SelectList(account, "Id", "UserName")
            };

            return View(orderModel);
        }

        [HttpPost]
        public ActionResult<OrderView> Add(OrderView order_view)
        {
            order_view.Orders.CreationDate = DateTime.Now;
            _db.Orders.Add(order_view.Orders);

            return RedirectToAction("Add");
        }
    }
}