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
    public class MoneyController : ApiController
    {
        public IDataservices<Money> Money { get; set; }
        public void show()
        {
            Money.Show();
        }
        public void create(Money money)
        {
            Money.Create(money);
        }
        public void showByid(int id)
        {
            Money.ShowById(id);
        }
        public void delete(int id)
        {
            Money.Delete(id);
        }
        public void upd(Money money)
        {
            Money.Update(money);
        }
    }
}
