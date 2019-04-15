﻿using System;
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
        public void Update(UserInfos userInfos)
        {
            UserInfos.Update(userInfos);
        }
    }
}
