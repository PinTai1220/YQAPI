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
        public void Show()
        {
            RoomType.Show();
        }
        public void Create(RoomType roomType)
        {
            RoomType.Create(roomType);
        }
        public void ShowByid(int Id)
        {
            RoomType.ShowById(Id);
        }
        public void Delete(int Id)
        {
            RoomType.Delete(Id);
        }
        public void Upd(RoomType roomType)
        {
            RoomType.Update(roomType);
        }
    }
}
