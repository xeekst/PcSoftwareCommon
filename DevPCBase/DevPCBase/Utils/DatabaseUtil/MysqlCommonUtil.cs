using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPCBase.Utils.DatabaseUtil
{
    public class MysqlCommonUtil : SingletonObject<MysqlCommonUtil> , IDatabaseCommonUtil
    {
        public string GetConnectString(string host, string port, string userName, string password)
        {
            string serverText = string.IsNullOrEmpty(port) ? $"{host}" : $"{host},{port}";
            string connectString = string.Format("server={0};port={1};uid={2};pwd={3};charset=utf8;connection timeout=5", host, string.IsNullOrEmpty(port) ? "3306" : port,userName, password);
            return connectString;
        }
        public bool TestConnect(string connectString, out string errorText)
        {
            errorText = string.Empty;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectString))
                {
                    conn.Open();
                }
                return true;
            }
            catch (Exception e)
            {
                errorText = e.ToString();
                return false;
            }
        }

        public DataTable QuerySync(string connectString,string sqlText,out string errorText)
        {
            errorText = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectString))
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlText, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
            catch (Exception e)
            {
                errorText = e.ToString();
                return dt;
            }
        }
    }
}
