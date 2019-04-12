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
    public class RoomsBLL:IDataservices<Rooms>
    {
        IDALServices<Rooms> dal = new RoomsDAL();
        public  int Create(Rooms t)
        {
            return dal.Create(t);
        }

        public  int Delete(int id)
        {
            return dal.Delete(id);
        }

        public  List<Rooms> Show()
        {
            return dal.Show();
        }

        public  Rooms ShowById(int id)
        {
            return dal.ShowById(id);
        }

        public  int Update(Rooms t)
        {
            return dal.Update(t);
        }
    }
}
