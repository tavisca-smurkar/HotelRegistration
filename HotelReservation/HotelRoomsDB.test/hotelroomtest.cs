using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelRoomsOperation.data;
using HotelReservation.Entities;

namespace HotelRoomsDB.test
{
    [TestClass]
    public class hotelroomtest
    {
        HotelRommDBImple test = new HotelRommDBImple();
        [TestMethod]
        public void TestInsertHotelRooms()
        {

            Int64 result = test.InsertHotelRooms(5, "AC", 15, 20);
            Assert.AreNotEqual(result, 0);
        }


        [TestMethod]
        public void TestHotelRoomsSelect()
        {

            HotelRooms hotelRooms = test.SelectHotelRooms(5);

            Assert.AreEqual(hotelRooms.Hotel_Id, 5);
        }

        [TestMethod]
        public void TestHotelRoomsUpdate()
        {

            Int64 result = test.UpdateHotelRooms(5,"AC");

            Assert.AreNotEqual(result, 0);
        }
    }
}
