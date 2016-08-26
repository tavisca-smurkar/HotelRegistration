using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace BookingDetailsOperation.Data
{
    public class BookingDetailsDBImpl
    {
        private const string DBName = "HotelDB";

        public Int64 InsertBookingDetails(Int64 Cust_Id, Int64 Hotel_Id)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultdatabase = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);

            DbCommand command = database.GetStoredProcCommand("spInsertBookingDetails");
            database.AddInParameter(command, "@Cust_Id", System.Data.DbType.Int64, Cust_Id);
            database.AddInParameter(command, "@Hotel_Id", System.Data.DbType.Int64, Hotel_Id);
                        
            Int64 bookingId = Convert.ToInt64(database.ExecuteScalar(command).ToString());
            return bookingId;

        }
    }
}
