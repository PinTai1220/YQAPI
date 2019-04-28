using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using Commen;

namespace YQApi.Controllers
{
    public class UserInfosController : ApiController
    {
        public IDataservices<UserInfos> UserInfos { get; set; }
        public IDataservices<Orders> Orders { get; set; }
        [HttpGet]
        public List<UserInfos> Show()
        {
            return UserInfos.Show();
        }
        [HttpPost]
        public void Create(UserInfos userInfos)
        {
            UserInfos.Create(userInfos);
        }
        public void ShowById(int Id)
        {
            UserInfos.ShowById(Id);
        }
        public void Delete(int Id)
        {
            UserInfos.Delete(Id);
        }
        [HttpPost]
        public int Update(UserInfos userInfos)
        {
            int res= UserInfos.Update(userInfos);
            Orders ord = new Orders()
            {
                Order_Id = userInfos.orderid,
                Room_State = userInfos.state
            };
            int res1 = Orders.Update(ord);
            if (res == res1 && res == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
               
        }
    }
}
