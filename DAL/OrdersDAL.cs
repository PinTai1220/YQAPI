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
    public class OrdersDAL : IDALServices<Orders>
    {
        private readonly IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public  int Create(Orders t)
        {
            string sql = "insert into Orders values(@Order_Time,@Content,@Blog_Time,@User_Id,@Money_Received,@Money_Favorable,@Money_Should,@Type_Of_Payment,@CheckIn_Time,@Leave_Time,@Room_State)";
            return DapperHelper<object>.Execut(sql,t);
        }

        public  int Delete(int id)
        {
            string sql = "delete from Orders where id=@id";
            return DapperHelper<object>.Execut(sql,new { id});
        }

        public  List<Orders> Show()
        {
            string sql = "select a.*,b.UserInfo_Name,b.Phone_Num,c.Room_Num from Orders a join UserInfos b on a.User_Id=b.UserInfo_Id  join Rooms c on a.Room_State=c.Room_Id";
            return DapperHelper<Orders>.Query(sql,null);
        }

        public  Orders ShowById(int id)
        {
            string sql = "select * from Orders where id=@id";
            return DapperHelper<Orders>.Query(sql,new { id}).FirstOrDefault();
        }

        public  int Update(Orders t)
        {
            string sql = "update Orders set Room_State=@Room_State where Order_Id=@Order_Id";
            return DapperHelper<object>.Execut(sql,t);
        }
    }
}
