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
    public class RolesDAL : IDALServices<Roles>
    {
        private readonly IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public   int Create(Roles t)
        {
            string sql = "insert into Roles values(@Role_Name)";
            return DapperHelper<object>.Execut(sql,t);
        }

        public   int Delete(int id)
        {
            string sql = "delete from Comments id=@id";
            return DapperHelper<object>.Execut(sql,new { id});
        }

        public   List<Roles> Show()
        {
            string sql = "select * from Comments";
            return DapperHelper<Roles>.Query(sql,null);
        }

        public   Roles ShowById(int id)
        {
            string sql = "select * from Comments where id=@id";
            return DapperHelper<Roles>.Query(sql,new { id}).FirstOrDefault();
        }

        public   int Update(Roles t)
        {
            string sql = "update Comments set Role_Name=@Role_Name";
            return DapperHelper<object>.Execut(sql,t);
        }
    }
}
