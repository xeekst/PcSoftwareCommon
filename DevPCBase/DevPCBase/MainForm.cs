using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevPCBase.ControlUtils;
using DevPCBase.Views;
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

namespace DevPCBase
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
            InitXtraTab();
            GlobalCache.Instance.MainFormInstance = this;
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
