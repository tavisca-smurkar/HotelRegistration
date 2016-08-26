using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using HotelReservation.Entities;

namespace HotelOperation.data
{
    public class HotelDBImpl
    {
        private const string DBName = "HotelDB";

        public Int64 InsertHotel(string HotelName, string HotelEmailID, string HotelPhoneNumber, string City)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultdatabase = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand command = database.GetStoredProcCommand("spInsertHotel");
            database.AddInParameter(command, "@HotelName", System.Data.DbType.String, HotelName);
            database.AddInParameter(command, "@HotelEmailId", System.Data.DbType.String, HotelEmailID);
            database.AddInParameter(command, "@PhoneNumber", System.Data.DbType.String, HotelPhoneNumber);
            database.AddInParameter(command, "@City", System.Data.DbType.String, City);

            Int64 hotelId = Convert.ToInt64(database.ExecuteScalar(command).ToString());
            return hotelId;
            
        }

        public  List<Hotel> SelectHotel(string City)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultdatabase = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand command = database.GetStoredProcCommand("spSelectHotel");
            database.AddInParameter(command, "@City", System.Data.DbType.String, City);

            List<Hotel> hotels= HotelTranslate.ParseHotel(database.ExecuteDataSet(command));
           
            return hotels;
        }
    }
}
