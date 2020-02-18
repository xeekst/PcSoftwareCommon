using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.Util.Repository.ColumnMapperCommon;

namespace X.Util.Repository.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ColumnMapper.SetMapper<UserEntity>();
            UserRepository userRepository = new UserRepository("Data Source=E:/testuser.db");
            userRepository.CreateUserTable();
            userRepository.InsertInto();
            var r = userRepository.QueryUserInfo();
            Console.ReadKey();

        }
    }
}
