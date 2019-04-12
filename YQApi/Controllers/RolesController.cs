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
        public void Show()
        {
            Roles.Show();
        }
        public void Create(Roles roles)
        {
            Roles.Create(roles);
        }
        public void ShowById(int Id)
        {
            Roles.ShowById(Id);
        }
        public void Delete(int Id)
        {
            Roles.Delete(Id);
        }
        public void Upd(Roles roles)
        {
            Roles.Update(roles);
        }
    }
}
