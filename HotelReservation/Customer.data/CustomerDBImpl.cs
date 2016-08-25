using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace Customer.data
{
    public class CustomerDBImpl
    {
        private const string DBName = "HotelDB";

        public void InsertCustomer(string firstname, string lastname, string emailid, string phonenumber)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultdatabase = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand commmand = database.GetStoredProcCommand("spInsertCustomer");
            database.AddInParameter(commmand, "FirstName", System.Data.DbType.String, firstname);
            database.AddInParameter(commmand, "LastName", System.Data.DbType.String, lastname);
            database.AddInParameter(commmand, "EmailId", System.Data.DbType.String, emailid);
            database.AddInParameter(commmand, "PhoneNumber", System.Data.DbType.String, phonenumber);
            database.ExecuteScalar(commmand);
        }
    }
}
