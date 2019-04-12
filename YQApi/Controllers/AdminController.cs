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
    public class AdminController : ApiController
    {
        public IDataservices<Admin> Admin { get; set; }
        [HttpGet]
        public void show()
        public void Show()
        {
            Admin.Show();
        }
        [HttpPost]
        public void create(Admin admin)
        public void Create(Admin admin)
        {
            Admin.Create(admin);
        }
        public void ShowById(int Id)
        {
            Admin.ShowById(Id);
        }
        public void Delete(int Id)
        {
            Admin.Delete(Id);
        }
        public void Update(Admin admin)
        {
            Admin.Update(admin);
        }
    }
}
