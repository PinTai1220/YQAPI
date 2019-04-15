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
        [HttpGet]
        public List<Money> Show()
        {
            return Money.Show();
        }
        [HttpPost]
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
        public void Update(Money money)
        {
            Money.Update(money);
        }
    }
}
