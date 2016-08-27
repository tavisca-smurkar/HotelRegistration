﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelRoomsOperation.data;
using HotelReservation.Entities;
using System.Collections.Generic;

namespace HotelRoomsDB.test
{
    [TestClass]
    public class hotelroomtest
    {
        HotelRommDBImple test = new HotelRommDBImple();
        [TestMethod]
        public void TestInsertHotelRooms()
        {

            Int64 result = test.InsertHotelRooms(5, "AC",700, 15, 20);
            Assert.AreNotEqual(result, 0);
        }


        [TestMethod]
        public void TestHotelRoomsSelect()
        {
            List<HotelRooms> hotelRooms = test.SelectHotelRooms(5);

            Assert.AreEqual(hotelRooms[0].Hotel_Id, 5);
        }

        [TestMethod]
        public void TestHotelRoomsUpdate()
        {

            Int64 result = test.UpdateHotelRooms(5);

            Assert.AreNotEqual(result, 0);
        }
    }
}
