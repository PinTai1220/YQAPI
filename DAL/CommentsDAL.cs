using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Commen;

namespace DAL
{
    public class CommentsDAL : IDataservices<Comments, CommentsDAL>
    {
        public override int Create(Comments t)
        {
            throw new NotImplementedException();
        }

        public override int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Comments> Show()
        {
            throw new NotImplementedException();
        }

        public override Comments ShowById(int id)
        {
            throw new NotImplementedException();
        }

        public override int Update(Comments t)
        {
            throw new NotImplementedException();
        }
    }
}
