using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerOperations.data;
using HotelReservation.Entities;


namespace CustomerDB.test
{
    [TestClass]
    public class customertest
    {
        [TestMethod]
        public void TestCostomerInsert()
        {
            CustomerDBImpl test = new CustomerDBImpl();
            Int64 result = test.InsertCustomer("Shahrukh1", "Khan1", "abc@gmail.com", "9877548789");
            Assert.AreNotEqual(result, 0);

        }

        [TestMethod]
        public void TestCostomerSelect()
        {
            CustomerDBImpl test = new CustomerDBImpl();
            Customer cust = test.SelectCustomer("Shreekesh");

            Assert.AreEqual(cust.FirstName, "Shreekesh");
        }



    }

}
