using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Commen;
using Model;

namespace BLL
{
    public class AdminBLL : IDataservices<Admin>
    {
        IDALServices<Admin> dal = new AdminDAL();
        public int Create(Admin t)
        {
            return dal.Create(t);
        }

        public int Delete(int id)
        {
            return dal.Delete(id);
        }

        public List<Admin> Show()
        {
            return dal.Show();
        }

        public Admin ShowById(int id)
        {
            return dal.ShowById(id);
        }

        public int Update(Admin t)
        {
            return dal.Update(t);
        }
    }
}
