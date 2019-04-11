using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace dapper1
{
    public class DapperHelper<T>
    {
        private IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlDiagnosticsDb"].ConnectionString);
        public int Execute(string SqlStr,object Obj)
        {
           return conn.Execute(SqlStr, Obj);
        }
        public IEnumerable<T> Query(string SqlStr,object Obj)
        {
            return conn.Query<T>(SqlStr, Obj);
        }
    }
}
