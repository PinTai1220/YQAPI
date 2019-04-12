using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Commen;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class UserInfosDAL : IDALServices<UserInfos>
    {
        private readonly IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public  int Create(UserInfos t)
        {
            string sql = "insert into UserInfos values(@UserInfo_Name,@UserInfo_Sex,@ID_Num,@Phone_Num,@Address,@HeadImg)";
            return DapperHelper<object>.Execut(sql,t);
        }

        public  int Delete(int id)
        {
            string sql = "delete from UserInfos where id=@id";
            return DapperHelper<object>.Execut(sql,new {id});
        }

        public  List<UserInfos> Show()
        {
            string sql = "select * from UserInfos";
            return DapperHelper<UserInfos>.Query(sql,null);
        }

        public  UserInfos ShowById(int id)
        {
            string sql = "select * from UserInfos where id=@id";
            return DapperHelper<UserInfos>.Query(sql,new {id}).FirstOrDefault();
        }

        public  int Update(UserInfos t)
        {
            string sql = "update UserInfos set UserInfo_Name=@UserInfo_Name,UserInfo_Sex=@UserInfo_Sex,ID_Num=@ID_Num,Phone_Num=@Phone_Num,Address=@Address,HeadImg=@HeadImg";
            return DapperHelper<object>.Execut(sql,t);
        }
    }
}
