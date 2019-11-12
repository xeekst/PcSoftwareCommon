using DevPCBase.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.Util.Repository.ColumnMapperCommon;
using X.Util.Repository.Sqlite;

namespace DevPCBase.Repository
{
    public class DatabaseConfigRepository : SqliteRepository<DatabaseConfigEntity, string>
    {
        public DatabaseConfigRepository(string dbPath) : base(dbPath)
        {
            ColumnMapper.SetMapper<DatabaseConfigEntity>();
        }

        public bool AddConfig(DatabaseConfigEntity entity)
        {
            string sql = "INSERT INTO database_config(id,config_name,host,port,user_name,password,db_type,create_time,update_time) VALUES(@Id,@ConfigName,@Host,@Port,@UserName,@Password,@DbType,@CreateTime,@UpdateTime)";
            return this.Insert(sql, entity);
        }
        public void UpdateConfig(DatabaseConfigEntity entity)
        {
            this.Update("UPDATE database_config SET " +
                "config_name=@ConfigName," +
                "host=@Host,"+
                "port=@Port," +
                "user_name=@UserName," +
                "password=@Password," +
                "db_type=@DbType," +
                "update_time=@UpdateTime WHERE id=@Id",entity);

        }
        public void DeleteConfig(string id)
        {
            string sqlText = "DELETE FROM database_config WHERE id = @Id";
            this.Delete(sqlText, new { Id = id });
        }
        public IList<DatabaseConfigEntity> GetAllConfigs(string type)
        {
            string sqlText = "SELECT * FROM database_config WHERE db_type = @DbType";
            var configs = this.QueryMutiple(sqlText,new { DbType=type });
            return configs;
        }
    }
}
