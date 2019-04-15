using Commen;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace YQApi.Controllers
{
    public class OrdersController : ApiController
    {
        public IDataservices<Orders> Orders { get; set; }
        [HttpGet]
        public List<Orders> Show()
        {
           return Orders.Show();
        }
        [HttpPost]
        public void Create(Orders orders)
        {
            Orders.Create(orders);
        }
        public void ShowByid(int Id)
        {
            Orders.ShowById(Id);
        }
        public void Delete(int Id)
        {
            Orders.Delete(Id);
        }
        public void Update(Orders orders)
        {
            Orders.Update(orders);
        }
    }
}
