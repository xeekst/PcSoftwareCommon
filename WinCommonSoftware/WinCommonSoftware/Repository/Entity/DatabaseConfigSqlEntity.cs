using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.Util.Repository.ColumnMapperCommon;
using X.Util.Repository.Sqlite;

namespace WinCommonSoftware.Repository.Entity
{
    public class DatabaseConfigSqlEntity : SqliteEntity<string>
    {
        [Column(Name ="name")]
        public string Name { get; set; }
        [Column(Name = "database_config_id")]
        public string DatabaseConfigId { get; set; }
        [Column(Name = "db_type")]
        public string DbType { get; set; }
        [Column(Name = "sql_text")]
        public string SqlText { get; set; }
        [Column(Name = "create_time")]
        public DateTime CreateTime { get; set; }
        [Column(Name = "update_time")]
        public DateTime UpdateTime { get; set; }

    }
}
