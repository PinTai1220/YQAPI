﻿using System;
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
        [HttpGet]
        public List<Rooms> Show()
        {
            return Rooms.Show();
        }
        public void Create(Rooms rooms)
        {
            Rooms.Create(rooms);
        }
        public void ShowById(int Id)
        {
            Rooms.ShowById(Id);
        }
        public void Delete(int Id)
        {
            Rooms.Delete(Id);
        }
        public void Update(Rooms rooms)
        {
            Rooms.Update(rooms);
        }
    }
}
