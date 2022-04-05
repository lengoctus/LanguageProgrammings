using DemoSession6.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession6.ViewModels
{
    public class Accounts_ViewModels
    {
        public Accounts Account{get;set;}
        public SelectList Roles { get; set; }
    }

}
