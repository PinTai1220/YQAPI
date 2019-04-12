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
    public class RoomTypeDAL : IDALServices<RoomType>
    {
        private readonly IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public   int Create(RoomType t)
        {
            string sql = "insert into RoomType values(@RoomType_Name,@RoomType_Price)";
            return DapperHelper<object>.Execut(sql,t);
        }

        public   int Delete(int id)
        {
            string sql = "delete from RoomType where id=@id";
            return DapperHelper<object>.Execut(sql,new {id });
        }

        public   List<RoomType> Show()
        {
            string sql = "select * from RoomType";
            return DapperHelper<RoomType>.Query(sql,null);
        }

        public   RoomType ShowById(int id)
        {
            string sql = "select * from RoomType where id=@id";
            return DapperHelper<RoomType>.Query(sql,new { id}).FirstOrDefault();
        }

        public   int Update(RoomType t)
        {
            string sql = "update RoomType set RoomType_Name=@RoomType_Name,RoomType_Price=@RoomType_Price";
            return DapperHelper<object>.Execut(sql,t);
        }
    }
}
