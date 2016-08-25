using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;
using HotelReservation.Entities;

namespace CustomerOperations.data
{
    public class CustomerDBImpl
    {
        private const string DBName = "HotelDB";

        public void InsertCustomer(string firstname, string lastname, string emailid, string phonenumber)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultdatabase = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand command = database.GetStoredProcCommand("spInsertCustomer");
            database.AddInParameter(command, "FirstName", System.Data.DbType.String, firstname);
            database.AddInParameter(command, "LastName", System.Data.DbType.String, lastname);
            database.AddInParameter(command, "EmailId", System.Data.DbType.String, emailid);
            database.AddInParameter(command, "PhoneNumber", System.Data.DbType.String, phonenumber);
            database.ExecuteScalar(command);
        }


        public Customer SelectCustomer(string firstname)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultdatabase = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand command = database.GetStoredProcCommand("spSelectCustomer");
            database.AddInParameter(command, "FirstName", System.Data.DbType.String, firstname);

            Customer customer = CustomerTranslate.ParseCustomer(database.ExecuteDataSet(command));
            return customer;
        }
    }
}
