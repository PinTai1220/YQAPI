using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commen;
using DAL;
using Model;

namespace BLL
{
    public class RolesBLL : IDataservices<Roles>
    {
        IDALServices<Roles> dal = new RolesDAL();
        public int Create(Roles t)
        {
            return dal.Create(t);
        }

        public int Delete(int id)
        {
            return dal.Delete(id);
        }

        public List<Roles> Show()
        {
            return dal.Show();
        }

        public Roles ShowById(int id)
        {
            return dal.ShowById(id);
        }

        public int Update(Roles t)
        {
            return dal.Update(t);
        }
    }
}
