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
    public class BlogsBLL : IDataservices<Blogs, BlogsBLL>
    {
        IDataservices<Blogs, BlogsDAL> dal = BlogsDAL.GetInstance();
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
