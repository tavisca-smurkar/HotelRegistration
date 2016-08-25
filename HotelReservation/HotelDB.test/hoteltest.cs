using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelOperation.data;
using HotelReservation.Entities;
namespace HotelDB.test
{
    [TestClass]
    public class hoteltest
    {
        HotelDBImpl test = new HotelDBImpl();
        [TestMethod]
        public void TestCostomerInsert()
        {

            Int64 result = test.InsertHotel("The Lalit", "thelalit@gmail.com", "9876543210", "Mumbai");
            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void TestCostomerSelect()
        {            
           Hotel hotel = test.SelectHotel("The Lalit");
           Assert.AreEqual(hotel.HotelName, "The Lalit");
        }

    }
}
