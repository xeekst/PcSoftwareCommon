using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X.Util.Repository
{
    interface IRepository<TEntity, TKey> where TEntity : IEntity<TKey>
    {
        TEntity Query(string sqlText, object param = null);
        IList<TEntity> QueryMutiple(string sqlText, object param = null);
        bool Insert(string sqlText, object param = null);
        //bool InsertMutiple(string sqlText, object param);
        bool Delete(string sqlText, object param = null);
        //bool DeleteMutiple(string sqlText, object param);
        void Update(string sqlText, object param = null);

        void Execute(string sqlText, object param = null);
    }
}
