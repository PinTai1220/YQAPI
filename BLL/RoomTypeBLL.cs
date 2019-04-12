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
    public class RoomTypeBLL : IDataservices<RoomType>
    {
        IDALServices<RoomType> dal = new RoomTypeDAL();
        public int Create(RoomType t)
        {
            return dal.Create(t);
        }

        public int Delete(int id)
        {
            return dal.Delete(id);
        }

        public List<RoomType> Show()
        {
            return dal.Show();
        }

        public RoomType ShowById(int id)
        {
            return dal.ShowById(id);
        }

        public int Update(RoomType t)
        {
            return dal.Update(t);
        }
    }
}
