using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entities;
using System.Data;
namespace CustomerOperations.data
{
    public static class CustomerTranslate
    {
        public static Customer ParseCustomer(DataSet customerdataset)
        {
            if (customerdataset == null) return null;

            if (customerdataset.Tables.Count > 0 && customerdataset.Tables[0].Rows.Count > 0)
                {
                    DataRow row = customerdataset.Tables[0].Rows[0];
                    Customer customer = new Customer();
                    customer.Id = Convert.ToInt32(row["Cust_Id"]);
                    customer.FirstName = row["FirstName"].ToString();
                    customer.LastName = row["LastName"].ToString();
                    customer.EmailId = row["EmailId"].ToString();
                    customer.PhoneNumber = row["PhoneNumber"].ToString();
                    return customer;
                }
            
            
            return null;
        }

    }
}
