using Commen;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.IO;
using System.Web;

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
        [HttpPost]
        public void Update(UserInfos orders)
        {
            //Orders ordersResult = JsonConvert.DeserializeObject<Orders>(orders);

            //Stream stream = HttpContext.Current.Request.InputStream;
            //StreamReader streamReader = new StreamReader(stream);
            //JsonReader reader = new JsonTextReader(streamReader);
            //Orders result = JsonConvert.DeserializeObject<Orders>(reader);


            //return Orders.Update();
        }
    }
}
