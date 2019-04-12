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
    public class MoneyDAL : IDALServices<Money>
    {
        private readonly IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public   int Create(Money t)
        {
            string sql = "insert into Money values(@Money_Num,@Recharge_Time,@User_Id)";
            return DapperHelper<object>.Execut(sql,t);
        }
         
        public   int Delete(int id)
        {
            string sql = "delete from Money where id=@id";
            return DapperHelper<object>.Execut(sql,new { id});
        }

        public   List<Money> Show()
        {
            string sql = "select * from Money";
            return DapperHelper<Money>.Query(sql,null);
        }

        public   Money ShowById(int id)
        {
            string sql = "select * from Money where id=@id";
            return DapperHelper<Money>.Query(sql,new { id}).FirstOrDefault();
        }

        public   int Update(Money t)
        {
            string sql = "update Money set Money_Num=@Money_Num,Recharge_Time=@Recharge_Time,User_Id=@User_Id";
            return DapperHelper<object>.Execut(sql,t);
        }
    }
}
