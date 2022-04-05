using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Demoession8.Models
{
    public class Account
    {
        [Required]
        public string UserName { get; set; }

        [MinLength(6)]
        [Required]
        [RegularExpression(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})", ErrorMessage = "Password is Invalid")]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string Website { get; set; }

        [Required]
        [Range(18, maximum: 100)]
        public int Age { get; set; }
    }
}
