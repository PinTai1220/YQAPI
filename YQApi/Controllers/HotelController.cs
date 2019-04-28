using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using BLL;
using Model;
using Commen;
using YQApi.Models;

namespace YQApi.Controllers
{
    public class HotelController : ApiController
    {
        [HttpGet]
        public List<dynamic> GetSwiper()
        {
            List<dynamic> strs = new List<dynamic>()
            {
                new
                {
                    image = "http://localhost:54830/Image/timg.jpg"
                },
                new
                {
                    image = "http://localhost:54830/Image/timg2.jpg"
                },
                new
                {
                    image = "http://localhost:54830/Image/timg3.jpg"
                }
            };
            return strs;
        }
        [HttpGet]
        public List<Rooms> GetHotel()
        {
            RoomsBLL bll = new RoomsBLL();
            bll.Show();
            return bll.Show();
        }
    }
}
