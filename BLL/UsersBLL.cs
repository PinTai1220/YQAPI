﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using Commen;

namespace BLL
{
    public class UsersBLL : IDataservices<Users, UsersBLL>
    {
        IDataservices<Users, UsersDAL> dal = UsersDAL.GetInstance();
        public override int Create(Users t)
        {
            throw new NotImplementedException();
        }

        public override int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Users> Show()
        {
            throw new NotImplementedException();
        }

        public override Users ShowById(int id)
        {
            throw new NotImplementedException();
        }

        public override int Update(Users t)
        {
            throw new NotImplementedException();
        }
    }
}
