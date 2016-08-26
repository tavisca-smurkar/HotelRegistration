using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Entities
{
    public class HotelRooms
    {
        public Int64 Room_Id { get; set; }
        public Int64 Hotel_Id { get; set; }
        public string RoomType { get; set; }
        public Int64 Rates { get; set; }
        public Int64 AvailableRooms { get; set; }
        public Int64 TotalRooms { get; set; }

    }
}
