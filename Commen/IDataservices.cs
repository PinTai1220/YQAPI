using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    /// <summary>
    /// 抽象类
    /// </summary>
    /// <typeparam name="TEntity">数据实例</typeparam>
    /// <typeparam name="CEntity">该继承类</typeparam>
    public interface  IDataservices<TEntity>
        where TEntity : class, new()
    {
          int Create(TEntity t);
          int Delete(int id);
          int Update(TEntity t);
          TEntity ShowById(int id);
          List<TEntity> Show();
    }
}
