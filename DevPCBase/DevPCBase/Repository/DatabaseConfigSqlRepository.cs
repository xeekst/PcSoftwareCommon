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
    public class DatabaseConfigSqlRepository : SqliteRepository<DatabaseConfigSqlEntity, string>
    {
        public DatabaseConfigSqlRepository(string dbPath) : base(dbPath)
        {
            ColumnMapper.SetMapper<DatabaseConfigSqlEntity>();
        }
        public bool SaveSqlText(DatabaseConfigSqlEntity entity)
        {
            string sqlText = "INSERT INTO database_config_sql (id,database_config_id,name,sql_text,db_type,create_time,update_time) " +
                "VALUES(@Id,@DatabaseConfigId,@Name,@SqlText,@DbType,@CreateTime,@UpdateTime)";
            this.Insert(sqlText, entity);
            return true;
        }
        
        public IList<DatabaseConfigSqlEntity> GetAllSqlConfig(string databaseConfigId)
        {
            string sqlText = "SELECT id,database_config_id,name,sql_text,db_type,create_time,update_time FROM database_config_sql WHERE database_config_id = @DatabaseConfigId";
            var r = this.QueryMutiple(sqlText, new { DatabaseConfigId = databaseConfigId });
            return r;
        }

        public bool UpdateSqlText(string id,string sqlText,string name)
        {
            string sql = "UPDATE database_config_sql SET sql_text=@SqlText,name=@Name WHERE id=@Id";
            var param = new { Id = id, SqlText = sqlText, Name = name };
            this.Update(sql, param);
            return true;
        }
        public bool DeleteSqlText(string id)
        {
            string sql = "DELETE FROM database_config_sql WHERE id=@Id";
            var param = new { Id = id };
            this.Delete(sql, param);
            return true;
        }
    }
}
