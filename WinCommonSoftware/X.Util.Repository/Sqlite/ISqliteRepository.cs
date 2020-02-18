using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X.Util.Repository.Sqlite
{
    internal interface ISqliteRepository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : SqliteEntity<TKey>
    {
    }
}
