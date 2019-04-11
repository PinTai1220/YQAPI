using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Commen;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UsersDAL : IDataservices<Users, UsersDAL>
    {
        
        public override int Create(Users t)
        {
            
            string sql = string.Format("insert into Users values('{0}','{1}','{2}',{3},'{4}','{5}','{6}','{7}','{8}')",
                t.User_Name,t.User_PassWord,t.Name,t.Sex,t.Birthday,t.Email,t.HeadImg,t.Phone,t.Reg_Time);
            using (SqlConnection conn=new SqlConnection())
            {

            }
            return 0;
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
