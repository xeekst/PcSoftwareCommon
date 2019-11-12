using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevPCBase.Properties;
using DevPCBase.Repository;
using DevPCBase.Repository.Entity;
using DevPCBase.Utils;
using DevPCBase.Utils.DatabaseUtil;

namespace DevPCBase.Views.HomeGroup.DataView
{
    public partial class DatabaseSettingControl : UserControl
    {
        private DatabaseConfigRepository configRepository = null;
        private DatabaseType dbType = DatabaseType.MSSQL;
        private DatabaseConfigEntity currentConfig = null;
        private IDatabaseCommonUtil databaseUtil = null;
        public DatabaseSettingControl()
        {
            InitializeComponent();
        }
        
        public DatabaseSettingControl(string typeText)
        {
            InitializeComponent();
            if(Enum.TryParse<DatabaseType>(typeText,out DatabaseType type))
            {
                switch (type)
                {
                    case DatabaseType.MSSQL:
                        this.dbType = DatabaseType.MSSQL;
                        this.InitMssql();
                        break;
                    case DatabaseType.MYSQL:
                        this.dbType = DatabaseType.MYSQL;
                        this.InitMysql();
                        break;
                    default:
                        break;
                }
            }
        }
        private void InitMysql()
        {
            MysqlRadio.Checked = true;
            MssqlRadio.Enabled = false;
            LogoPictureBox.Image = Resources.mysql_logo;
            this.databaseUtil = MysqlCommonUtil.Instance;
        }
        private void InitMssql()
        {
            MssqlRadio.Checked = true;
            MysqlRadio.Enabled = false;
            LogoPictureBox.Image = Resources.mssql_logo;
            this.databaseUtil = MssqlCommonUtil.Instance;
        }

        private void AddSettingBtn_Click(object sender, EventArgs e)
        {
            DatabaseConfigEntity configEntity = new DatabaseConfigEntity()
            {
                Id = Guid.NewGuid().ToString(),
                ConfigName = configNameTxt.Text,
                Host = serverHostTxt.Text,
                Port = portTxt.Text,
                UserName = userNameTxt.Text,
                Password = passwordTxt.Text,
                DbType = MssqlRadio.Checked ? "mssql" : "mysql",
                CreateTime = DateTime.Now,
                UpdateTime = DateTime.Now
            };

            this.configRepository.AddConfig(configEntity);
            this.FreshConfig();
        }

        private void DatabaseSettingControl_Load(object sender, EventArgs e)
        {
            this.InitListView();
            this.configRepository = new DatabaseConfigRepository("Data Source=dbconfig.db");
            this.FreshConfig();
        }

        private void FreshConfig()
        {
            this.currentConfig = null;
            var configs = this.configRepository.GetAllConfigs(this.dbType.ToString().ToLower());
            SelectDBListView.Items.Clear();
            for (int i = 0;i<configs.Count;i++)
            {
                var item = new ListViewItem();
                item.SubItems[0].Text = i.ToString();
                item.SubItems.Add(configs[i].ConfigName);
                item.SubItems.Add("loading...");
                item.Tag = configs[i];
                SelectDBListView.Items.Add(item);
            }
            SelectDBListView.Columns[1].Width = SelectDBListView.Width - (SelectDBListView.Columns[0].Width + SelectDBListView.Columns[2].Width + 5);
        }

        private void InitListView()
        {
            this.SelectDBListView.FullRowSelect = true;
            this.SelectDBListView.GridLines = true;
        }

        private void SelectDBListView_Resize(object sender, EventArgs e)
        {
            SelectDBListView.Columns[1].Width = SelectDBListView.Width - (SelectDBListView.Columns[0].Width + SelectDBListView.Columns[2].Width + 5);
        }

        private void SelectDBListView_Click(object sender, EventArgs e)
        {
            var selectItems = SelectDBListView.SelectedItems;
            if (selectItems.Count > 0)
            {
                var currentItem = selectItems[0];
                var entity = currentItem.Tag as DatabaseConfigEntity;
                this.currentConfig = entity;
                configNameTxt.Text = entity.ConfigName;
                serverHostTxt.Text = entity.Host;
                portTxt.Text = entity.Port;
                userNameTxt.Text = entity.UserName;
                passwordTxt.Text = entity.Password;
                switch (entity.DbType)
                {
                    case "mssql":
                        MssqlRadio.Checked = true;
                        break;
                    case "mysql":
                        MysqlRadio.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void TestConnectBtn_Click(object sender, EventArgs e)
        {
            try
            {

                var connectString = this.databaseUtil.GetConnectString(serverHostTxt.Text, portTxt.Text, userNameTxt.Text, passwordTxt.Text);

                if (this.databaseUtil.TestConnect(connectString, out string mssqlErrorText))
                {
                    MessageBox.Show("connected success!");
                }
                else
                {
                    MessageBox.Show("connected error:" + mssqlErrorText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            this.configRepository.DeleteConfig(this.currentConfig.Id);
            this.FreshConfig();
            MessageBox.Show("Delete Success!");
        }

        private void UpdateSettingBtn_Click(object sender, EventArgs e)
        {
            this.currentConfig.ConfigName = configNameTxt.Text;
            this.currentConfig.ConfigName = configNameTxt.Text;
            this.currentConfig.Host = serverHostTxt.Text;
            this.currentConfig.Port = portTxt.Text;
            this.currentConfig.UserName = userNameTxt.Text;
            this.currentConfig.Password = passwordTxt.Text;
            this.currentConfig.UpdateTime = DateTime.Now;
            this.configRepository.UpdateConfig(this.currentConfig);
            this.FreshConfig();
            MessageBox.Show("Update Success!");
        }
    }
}
