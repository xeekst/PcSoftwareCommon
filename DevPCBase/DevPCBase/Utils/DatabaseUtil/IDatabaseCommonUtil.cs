using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPCBase.Utils.DatabaseUtil
{
    interface IDatabaseCommonUtil
    {
        string GetConnectString(string host, string port, string userName, string password);
        bool TestConnect(string connectString, out string errorText);
        DataTable QuerySync(string connectString, string sqlText, out string errorText);
    }
}
