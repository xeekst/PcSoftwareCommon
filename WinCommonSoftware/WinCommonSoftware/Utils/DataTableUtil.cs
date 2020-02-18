using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCommonSoftware.Utils
{
    public class DataTableUtil : SingletonObject<DataTableUtil>
    {
        public DataTable ListDict2DataTable<TValue>(IList<Dictionary<string, TValue>> keyValuesList)
        {
            var dt = new DataTable();
            if(keyValuesList.Count <= 0)
            {
                return dt;
            }
            this.InitColumnNames(dt, keyValuesList[0]);
            foreach(Dictionary<string, TValue> keyValuePairs in keyValuesList)
            {
                DataRow row = dt.NewRow();
                foreach (KeyValuePair<string, TValue> keyValue in keyValuePairs)
                {
                    row[keyValue.Key] = keyValue.Value;
                }
                dt.Rows.Add(row);
            }
            return dt;
        }
        private void InitColumnNames<TValue>(DataTable targetDt, Dictionary<string, TValue> keyValues)
        {
            foreach (string key in keyValues.Keys)
            {
                targetDt.Columns.Add(key, keyValues[key].GetType());
            }
        }
    }
}
