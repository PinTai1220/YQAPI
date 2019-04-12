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
    public class RolesController : ApiController
    {
        public IDataservices<Roles> Roles { get; set; }
        public void show()
        {
            Roles.Show();
        }
        public void create(Roles roles)
        {
            Roles.Create(roles);
        }
        public void showByid(int id)
        {
            Roles.ShowById(id);
        }
        public void delete(int id)
        {
            Roles.Delete(id);
        }
        public void upd(Roles roles)
        {
            Roles.Update(roles);
        }
    }
}
