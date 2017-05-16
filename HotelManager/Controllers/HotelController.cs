using HotelManager.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelManager.Controllers
{
    public class HotelController : ApiController
    {
        // api/Hotel/GetNearbyHotels
        [HttpGet]
        [ActionName("GetNearbyHotels")]
        public ICollection<Hotel> GetNearbyHotels()
        {
            return DbHelper.GetTestData();
        }
    }
}