using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPCBase.Utils.DatabaseUtil
{
    public class MssqlCommonUtil : SingletonObject<MssqlCommonUtil>, IDatabaseCommonUtil
    {
        public string GetConnectString(string host,string port,string userName,string password)
        {
            string serverText = string.IsNullOrEmpty(port) ? $"{host}" : $"{host},{port}";
            string connectString = string.Format("Data Source={0};User Id={1};Password={2};Connection Timeout=5", serverText, userName, password);
            return connectString;
        }

        public DataTable QuerySync(string connectString, string sqlText, out string errorText)
        {
            errorText = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlText, conn))
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

        public bool TestConnect(string connectString,out string errorText)
        {
            errorText = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                }
                return true;
            }
            catch(Exception e)
            {
                errorText = e.ToString();
                return false;
            }
        }
    }
}
