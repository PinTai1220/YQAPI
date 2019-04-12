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
        public void show()
        {
            Orders.Show();
        }
        public void create(Orders orders)
        {
            Orders.Create(orders);
        }
        public void showByid(int id)
        {
            Orders.ShowById(id);
        }
        public void delete(int id)
        {
            Orders.Delete(id);
        }
        public void upd(Orders orders)
        {
            Orders.Update(orders);
        }
    }
}
