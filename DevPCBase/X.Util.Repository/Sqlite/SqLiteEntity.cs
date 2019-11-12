using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.Util.Repository.ColumnMapperCommon;

namespace X.Util.Repository.Sqlite
{
    public class SqliteEntity<TKey> : IEntity<TKey>
    {
        [Column(Name = "id")]
        public TKey Id { get; set; }
    }
}
