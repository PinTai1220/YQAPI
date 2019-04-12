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
        public void show()
        {
            UserInfos.Show();
        }
        public void create(UserInfos userInfos)
        {
            UserInfos.Create(userInfos);
        }
        public void showByid(int id)
        {
            UserInfos.ShowById(id);
        }
        public void delete(int id)
        {
            UserInfos.Delete(id);
        }
        public void upd(UserInfos userInfos)
        {
            UserInfos.Update(userInfos);
        }
    }
}
