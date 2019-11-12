using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevPCBase.Utils;
using DevPCBase.Repository;
using DevPCBase.Repository.Entity;
using DevPCBase.ControlUtils;
using DevPCBase.Utils.DatabaseUtil;
using System.IO;

namespace DevPCBase.Views.HomeGroup.DataView
{
    public partial class SQLViewControl : UserControl
    {
        private DatabaseConfigRepository configRepository = null;
        private DatabaseConfigSqlRepository configSqlRepository = null;
        private DatabaseType dbType = DatabaseType.MSSQL;
        private Dictionary<string, DatabaseConfigEntity> configDic = new Dictionary<string, DatabaseConfigEntity>();
        private IDatabaseCommonUtil databaseUtil = null;
        private string currentSqlTextConfigId = string.Empty;

        public SQLViewControl()
        {
            InitializeComponent();
            
        }
        public SQLViewControl(string typeText)
        {
            InitializeComponent();
            if (Enum.TryParse<DatabaseType>(typeText, out DatabaseType type))
            {
                switch (type)
                {
                    case DatabaseType.MSSQL:
                        this.dbType = DatabaseType.MSSQL;
                        this.databaseUtil = MssqlCommonUtil.Instance;
                        break;
                    case DatabaseType.MYSQL:
                        this.dbType = DatabaseType.MYSQL;
                        this.databaseUtil = MysqlCommonUtil.Instance;
                        break;
                    default:
                        break;
                }
            }
        }

        private void SQLViewControl_Load(object sender, EventArgs e)
        {
            this.configRepository = new DatabaseConfigRepository("Data Source=dbconfig.db");
            this.configSqlRepository = new DatabaseConfigSqlRepository("Data Source=dbconfig.db");
            this.SQLTextListView.Columns[1].Width = this.SQLTextListView.Width - this.SQLTextListView.Columns[0].Width - 10;
            var configs = this.configRepository.GetAllConfigs(this.dbType.ToString().ToLower());
            for (int i = 0; i < configs.Count; i++)
            {
                DatabaseCheckedComboBox.Properties.Items.Add(configs[i].ConfigName);
                configDic[configs[i].ConfigName] = configs[i];
            }
        }
        
        private void DatabaseCheckedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var config = this.GetCurrentConfig();
            HostTxt.Text = config.Host;
            PortTxt.Text = config.Port;
            UsernameTxt.Text = config.UserName;
            PasswordTxt.Text = config.Password;
            new Task(() =>
            {
                var connectString = this.databaseUtil.GetConnectString(config.Host, config.Port, config.UserName, config.Password);
                string status = this.databaseUtil.TestConnect(connectString, out string errorText) ? "连接成功" : "连接失败";
                CommonControlUtil.Instance.InvokeControlFuncInThread(this.connectStatusText, (t) =>
                {
                    this.connectStatusText.Text = t;
                }, status);
                CommonControlUtil.Instance.InvokeControlFuncInThread(this.SQLTextListView, (t) =>
                {
                    this.GetConfigSqlTexts();
                }, null);
            }).Start();
           

        }

        private void SQLAddBtn_Click(object sender, EventArgs e)
        {
            GlobalCache.Instance.MainFormInstance.Width = GlobalCache.Instance.MainFormInstance.Width < 1100 ? GlobalCache.Instance.MainFormInstance.Width + 200 : GlobalCache.Instance.MainFormInstance.Width;
            SqlDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            this.InitEditTextbox();
        }

        #region private methods
        private void InitEditTextbox()
        {
            this.currentSqlTextConfigId = string.Empty;
            this.SqlEditNameTextbox.Text = string.Empty;
            this.SqlTextBox.Text = string.Empty;
        }
        private DatabaseConfigEntity GetCurrentConfig()
        {
            var key = this.DatabaseCheckedComboBox.Properties.Items[this.DatabaseCheckedComboBox.SelectedIndex].ToString();
            var currentConfig = this.configDic[key];
            return currentConfig;
        }
        
        #endregion
        private void RunScriptBtn_Click(object sender, EventArgs e)
        {
            string sqlText = SqlTextBox.Text;
            var config = this.GetCurrentConfig();
            var connectString = this.databaseUtil.GetConnectString(config.Host, config.Port, config.UserName, config.Password);
            var resultDt = this.databaseUtil.QuerySync(connectString, sqlText,out string errorText);
            gridControl.DataSource = resultDt;

            gridView.PopulateColumns();
        }
        private void GetConfigSqlTexts()
        {
            string configId = this.GetCurrentConfig().Id;
            var sqlTextConfigs = this.configSqlRepository.GetAllSqlConfig(configId);
            this.SQLTextListView.Items.Clear();
            for(int i =0;i<sqlTextConfigs.Count;i++)
            {
                var item = new ListViewItem();
                item.SubItems[0].Text = i.ToString();
                item.SubItems.Add(sqlTextConfigs[i].Name);
                item.SubItems.Add("loading...");
                item.Tag = sqlTextConfigs[i];
                this.SQLTextListView.Items.Add(item);
            }
        }
        private void SaveSqlBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.currentSqlTextConfigId))
            {
                DatabaseConfigSqlEntity entity = new DatabaseConfigSqlEntity()
                {
                    Id = Guid.NewGuid().ToString(),
                    DatabaseConfigId = this.GetCurrentConfig().Id,
                    DbType = this.dbType.ToString().ToLower(),
                    Name = SqlEditNameTextbox.Text,
                    SqlText = SqlTextBox.Text,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now
                };
                this.configSqlRepository.SaveSqlText( entity);
            }
            else
            {
                this.configSqlRepository.UpdateSqlText(this.currentSqlTextConfigId,this.SqlTextBox.Text,this.SqlEditNameTextbox.Text);
            }
            this.GetConfigSqlTexts();
            MessageBox.Show("保存成功！");
        }

        private void SQLTextListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalCache.Instance.MainFormInstance.Width = GlobalCache.Instance.MainFormInstance.Width < 1100 ? GlobalCache.Instance.MainFormInstance.Width + 200 : GlobalCache.Instance.MainFormInstance.Width;
            SqlDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            var selectItems = this.SQLTextListView.SelectedItems;
            if (selectItems.Count > 0)
            {
                var selectItem = selectItems[0];
                DatabaseConfigSqlEntity configSqlEntity = selectItem.Tag as DatabaseConfigSqlEntity;
                this.SqlTextBox.Text = configSqlEntity.SqlText;
                this.SqlEditNameTextbox.Text = configSqlEntity.Name;
                this.currentSqlTextConfigId = configSqlEntity.Id;
            }
        }

        private void SQLTextListView_Resize(object sender, EventArgs e)
        {
            this.SQLTextListView.Columns[1].Width = this.SQLTextListView.Width - this.SQLTextListView.Columns[0].Width - 10;
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = this.gridControl.DataSource as DataTable;
            if (dt == null) return;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文本文件(*.csv)|*.csv|所有文件|*.*";//设置文件类型
            saveFileDialog.FileName = "export_data";//设置默认文件名
            saveFileDialog.DefaultExt = "csv";//设置默认格式（可以不设）
            saveFileDialog.AddExtension = true;
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.GetEncoding("utf-8")))
                {
                    string columns = string.Empty;
                    sw.WriteLine(columns);
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        columns = columns + dt.Columns[i].ToString() + ",";
                    }
                    columns.TrimEnd(',');
                    for (int r = 0; r < dt.Rows.Count; r++)
                    {
                        string rowText = string.Join(",", dt.Rows[r].ItemArray);
                        sw.WriteLine(rowText);
                    }
                    sw.Flush();
                }
                MessageBox.Show("导出成功!");
            }
        }

        private void SQLDeleteBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.currentSqlTextConfigId))
            {
                if(MessageBox.Show("是否删除？","确认框", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (this.configSqlRepository.DeleteSqlText(this.currentSqlTextConfigId))
                    {
                        MessageBox.Show("删除成功！");
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                    this.GetConfigSqlTexts();
                }
            }
        }
    }
}
