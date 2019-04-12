using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    public interface IDALServices<TEntity>
    {
        int Create(TEntity t);
        int Delete(int id);
        int Update(TEntity t);
        TEntity ShowById(int id);
        List<TEntity> Show();
    }
}
