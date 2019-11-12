using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X.Util.Repository.Mysql
{
    internal interface IMysqlRepository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : MysqlEntity<TKey>
    {
    }
}
