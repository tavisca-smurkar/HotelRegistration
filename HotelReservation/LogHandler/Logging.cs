using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entities;
using System.IO;

namespace LogHandler
{
    public class LogStorer
    {
        public void search_logger(LogEntry new_log)
        {
            File.AppendAllText(@"D:\" + "log.txt", new_log.message + new_log.logdate_time +"\n");
        }


        public void search_hotel(Int64 c_id, Int64 hotel_id)
        {
            LogEntry new_log_hotel = new LogEntry();
            new_log_hotel.CustomerID = c_id;
            new_log_hotel.message = " Customer with customer id " + c_id + " has searched for hotel with hotel id " + hotel_id + " on ";
            new_log_hotel.logdate_time = DateTime.Now;
            search_logger(new_log_hotel);

        }

        public void search_room(Int64 c_id, Int64 room_id)
        {
            LogEntry new_log_hotel = new LogEntry();
            new_log_hotel.CustomerID = c_id;
            new_log_hotel.message = " Custeomer with customer id " + c_id + " has searched for room with room id " + room_id + " on ";
            new_log_hotel.logdate_time = DateTime.Now;
            search_logger(new_log_hotel);
        }


    }
}
