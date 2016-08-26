using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entities;
using System.Data;
namespace HotelOperation.data
{
    public static class HotelTranslate
    {
        public static List<Hotel> ParseHotel(DataSet hoteldataset)
        {
            if (hoteldataset == null) return null;

            if (hoteldataset.Tables.Count > 0 && hoteldataset.Tables[0].Rows.Count > 0)
            {
                List<Hotel> hotelList = new List<Hotel>();
                foreach (DataRow row in hoteldataset.Tables[0].Rows)
                {
                    Hotel hotel = new Hotel();
                    hotel.Hotel_Id = Convert.ToInt32(row["Hotel_Id"]);
                    hotel.HotelName = row["HotelName"].ToString();
                    hotel.HotelEmailId = row["HotelEmailID"].ToString();
                    hotel.PhoneNumber = row["HotelPhoneNumber"].ToString();
                    hotel.City = row["City"].ToString();

                    hotelList.Add(hotel);
                }
                return hotelList;
                              
            }
            return null;
        }
    }
}
