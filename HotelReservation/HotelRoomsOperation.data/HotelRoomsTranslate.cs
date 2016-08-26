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
        public static HotelRooms ParseHotelRooms(DataSet HotelRoomsdataset)
        {
            if (HotelRoomsdataset == null) return null;

            if (HotelRoomsdataset.Tables.Count > 0 && HotelRoomsdataset.Tables[0].Rows.Count > 0)
            {
                DataRow row = HotelRoomsdataset.Tables[0].Rows[0];
                HotelRooms hotelrooms = new HotelRooms();
                hotelrooms.Room_Id = Convert.ToInt64(row["Room_Id"]);
                hotelrooms.Hotel_Id = Convert.ToInt64(row["Hotel_Id"]);
                hotelrooms.RoomType = row["RoomType"].ToString();
                hotelrooms.AvailableRooms = Convert.ToInt64(row["AvailableRooms"]);
                hotelrooms.TotalRooms = Convert.ToInt64(row["TotalRooms"]);
                return hotelrooms;
            }


            return null;
        }
    }
}
