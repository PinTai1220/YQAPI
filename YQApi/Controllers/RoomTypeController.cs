using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Commen;
using Model;

namespace YQApi.Controllers
{
    public class RoomTypeController : ApiController
    {
        public IDataservices<RoomType> RoomType { get; set; }
        public void show()
        {
            RoomType.Show();
        }
        public void create(RoomType roomType)
        {
            RoomType.Create(roomType);
        }
        public void showByid(int id)
        {
            RoomType.ShowById(id);
        }
        public void delete(int id)
        {
            RoomType.Delete(id);
        }
        public void upd(RoomType roomType)
        {
            RoomType.Update(roomType);
        }
    }
}
