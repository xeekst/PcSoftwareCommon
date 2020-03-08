using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinCommonSoftware.Models.QQGroup;
using WinCommonSoftware.Utils;

namespace WinCommonSoftware.Views.HomeGroup.QQManageGroup
{
    public partial class QQManagerOverviewControl : UserControl
    {
        private List<QQManagerInfoModel> qqInfoList= new List<QQManagerInfoModel>();
        public QQManagerOverviewControl()
        {
            InitializeComponent();
        }

        private void StartQQBtn_Click(object sender, EventArgs e)
        {
            string coolqPath = @"C:\Users\xeekseven\Downloads\CQA-tuling\酷Q Air\CQA.exe";
            ProcessManagerUtil.Instance.StartProcessWithoutWindow(coolqPath, (s, args) => { }, (s, args) => { }, (pid) => { });
            this.QueryQQMessage();
        }

        private void QueryQQMessage()
        {
            var qqInfo = new QQManagerInfoModel()
            {
                QQNickName = "擦干",
                QQNumber = "12321411"
            };
            this.DynamicAddAccordionGroupItem(qqInfo);
        }
        private void DynamicAddAccordionGroupItem(QQManagerInfoModel model)
        {
            string name = model.QQNumber + Guid.NewGuid();
            string titleText = $"{model.QQNumber}({model.QQNickName})";
            GlobalCache.Instance.MainFormInstance.AddQQManageAccordionItem(name, titleText, "QQManageControl");
        }
    }
}
