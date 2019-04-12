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
        public void Show()
        {
            Money.Show();
        }
        public void Create(Money money)
        {
            Money.Create(money);
        }
        public void ShowById(int Id)
        {
            Money.ShowById(Id);
        }
        public void Delete(int Id)
        {
            Money.Delete(Id);
        }
        public void Upd(Money money)
        {
            Money.Update(money);
        }
    }
}
