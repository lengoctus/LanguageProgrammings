using DemoSession18_EFCore.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession18_EFCore.Models.ModelView
{
    public class OrderView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime  CreationDate { get; set; }
        public string Payment { get; set; }
        public bool  Status { get; set; }
        public int  AccountId { get; set; }
        public int  EmployeeId { get; set; }

        public Orders Orders { get; set; }
        public SelectList Accounts { get; set; }
        public SelectList Employees { get; set; }

    }
}
