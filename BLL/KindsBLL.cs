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
    public class KindsBLL:IDataservices<Kinds,KindsBLL>
    {
        IDataservices<Kinds, KindsDAL> dal = KindsDAL.GetInstance();

        public override int Create(Kinds t)
        {
            throw new NotImplementedException();
        }

        public override int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Kinds> Show()
        {
            throw new NotImplementedException();
        }

        public override Kinds ShowById(int id)
        {
            throw new NotImplementedException();
        }

        public override int Update(Kinds t)
        {
            throw new NotImplementedException();
        }
    }
}
