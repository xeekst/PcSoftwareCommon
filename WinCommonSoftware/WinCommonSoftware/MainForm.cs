using DevExpress.XtraBars;
using DevExpress.XtraTab;
using WinCommonSoftware.ControlUtils;
using WinCommonSoftware.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WinCommonSoftware.Views.HomeGroup.QQManageGroup;

namespace WinCommonSoftware
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs EArg = (DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs)e;
            AccordionControlUtil.Instance.CloseTabpageByTitle(EArg.Page.Text, xtraTabControl);
        }
        private void InitXtraTab()
        {
            accordionControl.ActiveGroup = accordionBottomHome;
            AccordionControlUtil.Instance.BindTabpageClick(accordionControl.Elements, xtraTabControl);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AccordionControlUtil.Instance.DisableAccordControl(Config.Instance.NotEnAbleAccordControl.Split(','),this.accordionControl.Elements);
            InitXtraTab();
            GlobalCache.Instance.MainFormInstance = this;
            this.SetHomeTabpage();
        }
        public void AddQQManageAccordionItem(string name,string text,string tag)
        {
            text = AccordionControlUtil.Instance.GetThisGroupItemName(this.accordionHome_QQManageGroup.Elements, text, text);
            var ele = new DevExpress.XtraBars.Navigation.AccordionControlElement()
            {
                Name = name,
                Text = text,
                Tag = tag,
                Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            };
            this.accordionHome_QQManageGroup.Elements.Add(ele);
            AccordionControlUtil.Instance.BindAccordionItemTabpageClick(ele, xtraTabControl);
        }
        private void SetHomeTabpage()
        {
            var qqManageControl = new QQManagerOverviewControl();
            this.xtraTableHome.Controls.Add(qqManageControl);
            qqManageControl.Dock = DockStyle.Fill;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.xtraTabControl.TabPages.ToList().ForEach(t =>
            {
                try
                {
                    t.Dispose();
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"exe:{ex}");
                }
                
            });
        }
    }
}
