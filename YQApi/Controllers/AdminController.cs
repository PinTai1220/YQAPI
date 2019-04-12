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
        public void Show()
        {
            Admin.Show();
        }
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
        public void Upd(Admin admin)
        {
            Admin.Update(admin);
        }
    }
}
