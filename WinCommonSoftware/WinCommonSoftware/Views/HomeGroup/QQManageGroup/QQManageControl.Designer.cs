namespace WinCommonSoftware.Views.HomeGroup.QQManageGroup
{
    partial class QQManageControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.sendGroupMsgBtn = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPane = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationQQFriends = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationQQGroups = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane)).BeginInit();
            this.navigationPane.SuspendLayout();
            this.navigationQQGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.Default;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(800, 602);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(800, 602);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "基础管理";
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(763, 574);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "通讯录";
            this.tabNavigationPage2.Controls.Add(this.panelControl1);
            this.tabNavigationPage2.Controls.Add(this.navigationPane);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(800, 574);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.sendGroupMsgBtn);
            this.panelControl1.Location = new System.Drawing.Point(0, 534);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 38);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(183, 8);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(90, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "自动同意加群";
            // 
            // sendGroupMsgBtn
            // 
            this.sendGroupMsgBtn.Location = new System.Drawing.Point(89, 8);
            this.sendGroupMsgBtn.Name = "sendGroupMsgBtn";
            this.sendGroupMsgBtn.Size = new System.Drawing.Size(75, 23);
            this.sendGroupMsgBtn.TabIndex = 0;
            this.sendGroupMsgBtn.Text = "发送消息";
            // 
            // navigationPane
            // 
            this.navigationPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationPane.Controls.Add(this.navigationQQFriends);
            this.navigationPane.Controls.Add(this.navigationQQGroups);
            this.navigationPane.Location = new System.Drawing.Point(0, 0);
            this.navigationPane.Name = "navigationPane";
            this.navigationPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationQQGroups,
            this.navigationQQFriends});
            this.navigationPane.RegularSize = new System.Drawing.Size(800, 536);
            this.navigationPane.SelectedPage = this.navigationQQGroups;
            this.navigationPane.Size = new System.Drawing.Size(800, 536);
            this.navigationPane.TabIndex = 0;
            this.navigationPane.Text = "navigationPane";
            // 
            // navigationQQFriends
            // 
            this.navigationQQFriends.Caption = "     好友     ";
            this.navigationQQFriends.Name = "navigationQQFriends";
            this.navigationQQFriends.Size = new System.Drawing.Size(729, 476);
            // 
            // navigationQQGroups
            // 
            this.navigationQQGroups.Caption = "     群聊     ";
            this.navigationQQGroups.Controls.Add(this.panel1);
            this.navigationQQGroups.Name = "navigationQQGroups";
            this.navigationQQGroups.Size = new System.Drawing.Size(702, 476);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 476);
            this.panel1.TabIndex = 0;
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "tabNavigationPage3";
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(763, 574);
            // 
            // QQManageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Name = "QQManageControl";
            this.Size = new System.Drawing.Size(800, 602);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane)).EndInit();
            this.navigationPane.ResumeLayout(false);
            this.navigationQQGroups.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationQQFriends;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton sendGroupMsgBtn;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationQQGroups;
        private System.Windows.Forms.Panel panel1;
    }
}
