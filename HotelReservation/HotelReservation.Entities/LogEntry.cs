using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Entities
{
    public class LogEntry
    {
        public Int64 CustomerID { get; set; }
        public string message { get; set; }
        public DateTime logdate_time { get; set; }
    }
}
