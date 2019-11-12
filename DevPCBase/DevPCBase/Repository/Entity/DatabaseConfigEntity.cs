using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.Util.Repository.ColumnMapperCommon;
using X.Util.Repository.Sqlite;

namespace DevPCBase.Repository.Entity
{
    public class DatabaseConfigEntity : SqliteEntity<string>
    {
        [Column(Name = "config_name")]
        public string ConfigName { get; set; }
        [Column(Name = "host")]
        public string Host { get; set; }
        [Column(Name = "port")]
        public string Port { get; set; }
        [Column(Name = "user_name")]
        public string UserName { get; set; }
        [Column(Name = "password")]
        public string Password { get; set; }
        [Column(Name = "db_type")]
        public string DbType { get; set; }
        [Column(Name = "create_time")]
        public DateTime CreateTime { get; set; }
        [Column(Name = "update_time")]
        public DateTime UpdateTime { get; set; }
    }
}
