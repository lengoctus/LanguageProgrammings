﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession24_Security.Models
{
    public class Account
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string[] Role { get; set; }
    }
}
