using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession9.Models
{
    public class Booking
    {
        public int ID { get; set; }
        public DateTime DayStart { get; set; }
        public DateTime DayEnd { get; set; }
        public double Money { get; set; }
    }
}
