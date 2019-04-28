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
    public class RoomsDAL : IDALServices<Rooms>
    {
        private readonly IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public   int Create(Rooms t)
        {
            string sql = "insert into Rooms values(@RoomType_Id,@Room_Num,@Room_State)";
            return DapperHelper<object>.Execut(sql,t);
        }

        public   int Delete(int id)
        {
            string sql = "delete from Rooms where id=@id";
            return DapperHelper<object>.Execut(sql,new { id});
        }

        public   List<Rooms> Show()
        {
            string sql = "select * from rooms a join RoomType b on a.RoomType_Id=b.RoomType_Id";
            return DapperHelper<Rooms>.Query(sql,null);
        }

        public   Rooms ShowById(int id)
        {
            string sql = "select * from Rooms where id=@id";
            return DapperHelper<Rooms>.Query(sql,new { id}).FirstOrDefault();
        }

        public   int Update(Rooms t)
        {
            string sql = "update Rooms set RoomType_Id=@RoomType_Id,Room_Num=@Room_Num,Room_State=@Room_State";
            return DapperHelper<object>.Execut(sql,t);
        }
    }
}
