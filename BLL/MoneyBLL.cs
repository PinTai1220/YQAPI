using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using Commen;

namespace BLL
{
    public class MoneyBLL : IDataservices<Money>
    {
        IDALServices<Money> dal = new MoneyDAL();
        public int Create(Money t)
        {
            return dal.Create(t);
        }

        public int Delete(int id)
        {
            return dal.Delete(id);
        }

        public List<Money> Show()
        {
            return dal.Show();
        }

        public Money ShowById(int id)
        {
            return dal.ShowById(id);
        }

        public int Update(Money t)
        {
            return dal.Update(t);
        }
    }
}
