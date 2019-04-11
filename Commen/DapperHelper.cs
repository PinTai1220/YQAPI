using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Dapper;

namespace Commen
{
    public class DapperHelper<T> where T :new()
    {
        private readonly IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="SqlStr">sql</param>
        /// <param name="Obj">映射到sql中的对象</param>
        /// <returns>受影响行数</returns>
        public int Execut(string SqlStr,object Obj)
        {
            return conn.Execute(SqlStr, Obj);
        }
        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="SqlStr">sql</param>
        /// <param name="Obj">映射到sql中的对象集合</param>
        /// <returns>受影响行数</returns>
        public int Execut(string SqlStr, List<object> Obj)
        {
            return conn.Execute(SqlStr, Obj);
        }
        /// <summary>
        /// 获取List集合
        /// </summary>
        /// <param name="SqlStr">sql</param>
        /// <param name="Obj">映射到sql中的对象</param>
        /// <returns></returns>
        public List<T> Query(string SqlStr, object Obj)
        {
            IEnumerable<T> ie= conn.Query<T>(SqlStr, Obj);
            return ie as List<T>;
        }
        public List<dynamic> QueryObj(string SqlStr, object Obj)
        {
            var ie = conn.QueryMultiple(SqlStr, Obj);
            if (!ie.IsConsumed)
            {
               return ie.Read(buffered: false).ToList();
            }
            return null;
        }
    }
}
