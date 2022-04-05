using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession9.Models.ModelView
{
    public class Room_View
    {
        public static List<Booking> GetData()
        {
            var list = new Room()
            {
                Bookings = new List<Booking>
                {
                    new Booking{
                        ID = 01,
                        DayStart =DateTime.Parse("2019-12-02"),
                        DayEnd = DateTime.Parse("2019-12-01")
                    },
                    new Booking{
                        ID = 02,
                        DayStart =DateTime.Parse("2011-12-02"),
                        DayEnd = DateTime.Parse("2014-12-01")
                    },
                    new Booking{
                        ID = 03,
                        DayStart =DateTime.Parse("2019-11-02"),
                        DayEnd = DateTime.Parse("2019-1-01")
                    },
                    new Booking{
                        ID = 04,
                        DayStart =DateTime.Parse("2011-2-02"),
                        DayEnd = DateTime.Parse("2019-12-01")
                    },
                    new Booking{
                        ID = 05,
                        DayStart =DateTime.Parse("2015-12-02"),
                        DayEnd = DateTime.Parse("2013-12-01")
                    },
                    new Booking{
                        ID = 06,
                        DayStart =DateTime.Parse("2019-12-02"),
                        DayEnd = DateTime.Parse("2010-12-01")
                    }
                }
            };

            return list.Bookings;
        }


    }
}
