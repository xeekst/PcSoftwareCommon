using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.Util.Repository.ColumnMapperCommon;

namespace X.Util.Repository.Mysql
{
    public class MysqlEntity<TKey> : IEntity<TKey>
    {
        [Column(Name = "id")]
        public TKey Id { get; set; }
    }
}
