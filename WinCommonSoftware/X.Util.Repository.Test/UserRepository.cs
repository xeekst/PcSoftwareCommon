using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.Util.Repository.Sqlite;

namespace X.Util.Repository.Test
{
    public class UserRepository : SqliteRepository<UserEntity,string>
    {
        public UserRepository(string databaseNamePath) : base(databaseNamePath)
        {

        }
        public void CreateUserTable()
        {
            string sqlText = $"CREATE TABLE user( id varchar(40) Primary Key,user_name varchar(200),balance int )";
            this.Execute(sqlText);
        }

        public void InsertInto()
        {
            string sqlText = $"insert into user values('u1101','name2',13)";
            this.Insert(sqlText);
        }
        public IList<UserEntity> QueryUserInfo()
        {
            var r = this.QueryMutiple("select * from user");
            return r;
        }

    }
}
