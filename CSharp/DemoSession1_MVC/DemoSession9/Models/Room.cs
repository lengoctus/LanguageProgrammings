using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession9.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public List<Booking> Bookings { get; set; }
    }
}
