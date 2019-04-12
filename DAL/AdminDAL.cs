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
    public class AdminDAL : IDALServices<Admin>
    {
        private readonly IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public int Create(Admin t)
        {
            string sql = "insert into Admin values(@Admin_Name,@Admin_Pwd,@Role_Id)";
            return DapperHelper<object>.Execut(sql,t);
        }

        public int Delete(int id)
        {
            string sql = "delete from Admin where id=@id";
            return DapperHelper<object>.Execut(sql,new { id});
        }

        public List<Admin> Show()
        {
            string sql = "select * from Admin";
            return DapperHelper<Admin>.Query(sql, null);
        }

        public Admin ShowById(int id)
        {
            string sql = "select * from Admin where id=@id";
            return DapperHelper<Admin>.Query(sql,new { id}).FirstOrDefault();
        }

        public int Update(Admin t)
        {
            string sql = "update Admin set Admin_Name=@Admin_Name,Admin_Pwd=@Admin_Pwd,Role_Id=@Role_Id";
            return DapperHelper<object>.Execut(sql,t);
        }
    }
}
