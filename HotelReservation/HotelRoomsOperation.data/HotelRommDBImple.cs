using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using HotelReservation.Entities;
namespace HotelRoomsOperation.data
{
    public class HotelRommDBImple
    {
        private const string DBName = "HotelDB";

        public Int64 InsertHotelRooms(Int64 Hotel_Id, string RoomType,Int64 Rates, Int64 AvailableRooms, Int64 TotalRooms)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultdatabase = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand command = database.GetStoredProcCommand("spInsertHotelRooms");
            database.AddInParameter(command, "@Hotel_Id", System.Data.DbType.Int64, Hotel_Id);
            database.AddInParameter(command, "@RoomType", System.Data.DbType.String, RoomType);
            database.AddInParameter(command, "@Rates", System.Data.DbType.UInt64, Rates);
            database.AddInParameter(command, "@AvailableRooms", System.Data.DbType.Int64, AvailableRooms);
            database.AddInParameter(command, "@TotalRooms", System.Data.DbType.Int64, TotalRooms);
            
            Int64 roomId = Convert.ToInt64(database.ExecuteScalar(command).ToString());
            return roomId;


        }

        public List<HotelRooms> SelectHotelRooms(Int64 Hotel_Id)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultdatabase = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand command = database.GetStoredProcCommand("spSelectHotelRooms");
            database.AddInParameter(command, "@Hotel_Id", System.Data.DbType.Int64, Hotel_Id);

            List<HotelRooms> hotelroom = HotelRoomsTranslate.ParseHotelRooms(database.ExecuteDataSet(command));
           
            return hotelroom;
        }


        public Int64 UpdateHotelRooms(Int64 Room_Id)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultdatabase = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand command = database.GetStoredProcCommand("spUpdateHotelRooms");

            database.AddInParameter(command, "@Room_Id", System.Data.DbType.Int64, Room_Id);
          
            Int64 updatedrow =  database.ExecuteNonQuery(command);
            return updatedrow;
        }

    }
}
