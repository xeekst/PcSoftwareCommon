using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.Util.Repository.ColumnMapperCommon;
using X.Util.Repository.Sqlite;

namespace X.Util.Repository.Test
{
    public class UserEntity : SqliteEntity<string>
    {
        [Column(Name = "user_name")]
        public string UserName { get; set; }
        [Column(Name = "balance")]
        public int Balance { get; set; }
    }
}
