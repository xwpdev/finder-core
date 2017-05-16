using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManager.Helpers
{
    public static class DbHelper
    {
        private static readonly HotelEngineDbEntities context;

        public static dynamic GetTestData()
        {
            var hotelList = new List<Hotel>();
            for (int i = 1; i < 12; i++)
            {
                hotelList.Add(new Hotel
                {
                    Id = i,
                    Address = "Address " + i,
                    ContactEmail = "Email " + i,
                    ContactNo = "Number " + i,
                    IsActive = true,
                    Lat = "123",
                    Long = "123",
                    Name = "Test " + i,
                    StarRating = 4,
                    Website = "www" + i
                });
            }
            return hotelList;
        }
    }
}