using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using Commen;
using DAL;

namespace BLL
{
    public class OrdersBLL : IDataservices<Orders>
    {
        IDALServices<Orders> dal = new OrdersDAL();

        public   int Create(Orders t)
        {
            return dal.Create(t);
        }

        public   int Delete(int id)
        {
            return dal.Delete(id);
        }

        public  List<Orders> Show()
        {

            return dal.Show();
        }

        public  Orders ShowById(int id)
        {
            return dal.ShowById(id);
        }

        public  int Update(Orders t)
        {
            return dal.Update(t);
        }
    }
}
