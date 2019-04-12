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
    public class RoomsController : ApiController
    {
        public IDataservices<Rooms> Rooms { get; set; }
        public void show()
        {
            Rooms.Show();
        }
        public void create(Rooms rooms)
        {
            Rooms.Create(rooms);
        }
        public void showByid(int id)
        {
            Rooms.ShowById(id);
        }
        public void delete(int id)
        {
            Rooms.Delete(id);
        }
        public void upd(Rooms rooms)
        {
            Rooms.Update(rooms);
        }
    }
}
