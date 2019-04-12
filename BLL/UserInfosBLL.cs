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
    public class UserInfosBLL : IDataservices<UserInfos>
    {
        IDALServices<UserInfos> dal = new UserInfosDAL();

        public  int Create(UserInfos t)
        {
            return dal.Create(t);
        }

        public  int Delete(int id)
        {
            return dal.Delete(id);
        }

        public  List<UserInfos> Show()
        {
            return dal.Show();
        }

        public  UserInfos ShowById(int id)
        {
            return dal.ShowById(id);
        }

        public  int Update(UserInfos t)
        {
            return dal.Update(t);
        }
    }
}
