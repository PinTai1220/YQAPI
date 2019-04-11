using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Commen;

namespace DAL
{
    public class BlogsDAL : IDataservices<Blogs, BlogsDAL>
    {
        public override int Create(Blogs t)
        {
            throw new NotImplementedException();
        }

        public override int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Blogs> Show()
        {
            throw new NotImplementedException();
        }

        public override Blogs ShowById(int id)
        {
            throw new NotImplementedException();
        }

        public override int Update(Blogs t)
        {
            throw new NotImplementedException();
        }
    }
}
