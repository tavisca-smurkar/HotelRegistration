using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entities;
using System.Data;
namespace HotelRoomsOperation.data
{
    public static class HotelRoomsTranslate
    {
        public static List<HotelRooms> ParseHotelRooms(DataSet HotelRoomsdataset)
        {
            if (HotelRoomsdataset == null) return null;

            if (HotelRoomsdataset.Tables.Count > 0 && HotelRoomsdataset.Tables[0].Rows.Count > 0)
            {
                List<HotelRooms> hotelrooms = new List<HotelRooms>();
                foreach (DataRow row in HotelRoomsdataset.Tables[0].Rows)
                {
                    HotelRooms hotelroom = new HotelRooms();
                    hotelroom.Room_Id = Convert.ToInt64(row["Room_Id"]);
                    hotelroom.Hotel_Id = Convert.ToInt64(row["Hotel_Id"]);
                    hotelroom.RoomType = row["RoomType"].ToString();
                    hotelroom.Rates = Convert.ToInt64(row["Rates"]);
                    hotelroom.AvailableRooms = Convert.ToInt64(row["AvailableRooms"]);
                    hotelroom.TotalRooms = Convert.ToInt64(row["TotalRooms"]);
                    hotelrooms.Add(hotelroom);
                }
                          
                return hotelrooms;
            }
            
            return null;
        }
    }
}
