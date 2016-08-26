using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookingDetailsOperation.Data;

namespace BookignDB.test
{
    [TestClass]
    public class bookingtest
    {
        [TestMethod]
        public void TestBookingDetailsInsert()
        {
            BookingDetailsDBImpl test = new BookingDetailsDBImpl();
            Int64 result = test.InsertBookingDetails(1, 2);
            Assert.AreNotEqual(result, 0);
        }
    }
}
