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
        public void show()
        {
            Admin.Show();
        }
        public void create(Admin admin)
        {
            Admin.Create(admin);
        }
        public void showByid(int id)
        {
            Admin.ShowById(id);
        }
        public void delete(int id)
        {
            Admin.Delete(id);
        }
        public void upd(Admin admin)
        {
            Admin.Update(admin);
        }
    }
}
