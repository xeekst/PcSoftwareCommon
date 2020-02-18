namespace WinCommonSoftware.Views.HomeGroup.DataView
{
    partial class DatabaseSettingControl
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SelectDBListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SSHGroup = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.UpdateSettingBtn = new DevExpress.XtraEditors.SimpleButton();
            this.AddSettingBtn = new DevExpress.XtraEditors.SimpleButton();
            this.DatabaseSettingGroup = new System.Windows.Forms.GroupBox();
            this.testConnectBtn = new DevExpress.XtraEditors.SimpleButton();
            this.configNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.MssqlRadio = new DevExpress.XtraEditors.CheckEdit();
            this.MysqlRadio = new DevExpress.XtraEditors.CheckEdit();
            this.passwordTxt = new DevExpress.XtraEditors.TextEdit();
            this.userNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.portTxt = new DevExpress.XtraEditors.TextEdit();
            this.serverHostTxt = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.DatabaseSettingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MssqlRadio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MysqlRadio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverHostTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SelectDBListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(763, 606);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 0;
            // 
            // SelectDBListView
            // 
            this.SelectDBListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.SelectDBListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectDBListView.Location = new System.Drawing.Point(0, 0);
            this.SelectDBListView.Name = "SelectDBListView";
            this.SelectDBListView.Size = new System.Drawing.Size(254, 606);
            this.SelectDBListView.TabIndex = 0;
            this.SelectDBListView.UseCompatibleStateImageBehavior = false;
            this.SelectDBListView.View = System.Windows.Forms.View.Details;
            this.SelectDBListView.Click += new System.EventHandler(this.SelectDBListView_Click);
            this.SelectDBListView.Resize += new System.EventHandler(this.SelectDBListView_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "配置名";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "状态";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 90;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SSHGroup);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DeleteBtn);
            this.splitContainer2.Panel2.Controls.Add(this.UpdateSettingBtn);
            this.splitContainer2.Panel2.Controls.Add(this.AddSettingBtn);
            this.splitContainer2.Panel2.Controls.Add(this.DatabaseSettingGroup);
            this.splitContainer2.Size = new System.Drawing.Size(505, 606);
            this.splitContainer2.SplitterDistance = 212;
            this.splitContainer2.TabIndex = 0;
            // 
            // SSHGroup
            // 
            this.SSHGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SSHGroup.Location = new System.Drawing.Point(0, 0);
            this.SSHGroup.Name = "SSHGroup";
            this.SSHGroup.Size = new System.Drawing.Size(505, 212);
            this.SSHGroup.TabIndex = 6;
            this.SSHGroup.TabStop = false;
            this.SSHGroup.Text = "SSH";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteBtn.Appearance.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Appearance.Options.UseBackColor = true;
            this.DeleteBtn.AppearanceHovered.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteBtn.AppearanceHovered.Options.UseBackColor = true;
            this.DeleteBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.DeleteBtn.Location = new System.Drawing.Point(33, 352);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "删除";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateSettingBtn
            // 
            this.UpdateSettingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateSettingBtn.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.UpdateSettingBtn.Appearance.Options.UseBackColor = true;
            this.UpdateSettingBtn.AppearanceHovered.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UpdateSettingBtn.AppearanceHovered.Options.UseBackColor = true;
            this.UpdateSettingBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.UpdateSettingBtn.Location = new System.Drawing.Point(269, 352);
            this.UpdateSettingBtn.Name = "UpdateSettingBtn";
            this.UpdateSettingBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateSettingBtn.TabIndex = 2;
            this.UpdateSettingBtn.Text = "更新配置";
            this.UpdateSettingBtn.Click += new System.EventHandler(this.UpdateSettingBtn_Click);
            // 
            // AddSettingBtn
            // 
            this.AddSettingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSettingBtn.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AddSettingBtn.Appearance.Options.UseBackColor = true;
            this.AddSettingBtn.AppearanceHovered.BackColor = System.Drawing.Color.LimeGreen;
            this.AddSettingBtn.AppearanceHovered.Options.UseBackColor = true;
            this.AddSettingBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.AddSettingBtn.Location = new System.Drawing.Point(370, 352);
            this.AddSettingBtn.Name = "AddSettingBtn";
            this.AddSettingBtn.Size = new System.Drawing.Size(75, 23);
            this.AddSettingBtn.TabIndex = 1;
            this.AddSettingBtn.Text = "新增";
            this.AddSettingBtn.Click += new System.EventHandler(this.AddSettingBtn_Click);
            // 
            // DatabaseSettingGroup
            // 
            this.DatabaseSettingGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseSettingGroup.Controls.Add(this.testConnectBtn);
            this.DatabaseSettingGroup.Controls.Add(this.configNameTxt);
            this.DatabaseSettingGroup.Controls.Add(this.label6);
            this.DatabaseSettingGroup.Controls.Add(this.LogoPictureBox);
            this.DatabaseSettingGroup.Controls.Add(this.MssqlRadio);
            this.DatabaseSettingGroup.Controls.Add(this.MysqlRadio);
            this.DatabaseSettingGroup.Controls.Add(this.passwordTxt);
            this.DatabaseSettingGroup.Controls.Add(this.userNameTxt);
            this.DatabaseSettingGroup.Controls.Add(this.portTxt);
            this.DatabaseSettingGroup.Controls.Add(this.serverHostTxt);
            this.DatabaseSettingGroup.Controls.Add(this.label5);
            this.DatabaseSettingGroup.Controls.Add(this.label4);
            this.DatabaseSettingGroup.Controls.Add(this.label3);
            this.DatabaseSettingGroup.Controls.Add(this.label2);
            this.DatabaseSettingGroup.Controls.Add(this.label1);
            this.DatabaseSettingGroup.Location = new System.Drawing.Point(0, 0);
            this.DatabaseSettingGroup.Name = "DatabaseSettingGroup";
            this.DatabaseSettingGroup.Size = new System.Drawing.Size(502, 346);
            this.DatabaseSettingGroup.TabIndex = 0;
            this.DatabaseSettingGroup.TabStop = false;
            this.DatabaseSettingGroup.Text = "DATABASE_SETTING";
            // 
            // testConnectBtn
            // 
            this.testConnectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testConnectBtn.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.testConnectBtn.Appearance.Options.UseBackColor = true;
            this.testConnectBtn.AppearanceHovered.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.testConnectBtn.AppearanceHovered.Options.UseBackColor = true;
            this.testConnectBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.testConnectBtn.Location = new System.Drawing.Point(370, 276);
            this.testConnectBtn.Name = "testConnectBtn";
            this.testConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.testConnectBtn.TabIndex = 13;
            this.testConnectBtn.Text = "测试连接";
            this.testConnectBtn.Click += new System.EventHandler(this.TestConnectBtn_Click);
            // 
            // configNameTxt
            // 
            this.configNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configNameTxt.Location = new System.Drawing.Point(114, 101);
            this.configNameTxt.Name = "configNameTxt";
            this.configNameTxt.Size = new System.Drawing.Size(331, 20);
            this.configNameTxt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "配置名：";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoPictureBox.Image = global::WinCommonSoftware.Properties.Resources.mssql_logo;
            this.LogoPictureBox.Location = new System.Drawing.Point(52, 20);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(393, 66);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 11;
            this.LogoPictureBox.TabStop = false;
            // 
            // MssqlRadio
            // 
            this.MssqlRadio.Location = new System.Drawing.Point(219, 278);
            this.MssqlRadio.Name = "MssqlRadio";
            this.MssqlRadio.Properties.Caption = "Mssql";
            this.MssqlRadio.Properties.RadioGroupIndex = 1;
            this.MssqlRadio.Size = new System.Drawing.Size(75, 19);
            this.MssqlRadio.TabIndex = 10;
            this.MssqlRadio.TabStop = false;
            // 
            // MysqlRadio
            // 
            this.MysqlRadio.Location = new System.Drawing.Point(114, 278);
            this.MysqlRadio.Name = "MysqlRadio";
            this.MysqlRadio.Properties.Caption = "Mysql";
            this.MysqlRadio.Properties.RadioGroupIndex = 1;
            this.MysqlRadio.Size = new System.Drawing.Size(75, 19);
            this.MysqlRadio.TabIndex = 9;
            this.MysqlRadio.TabStop = false;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTxt.Location = new System.Drawing.Point(114, 240);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(331, 20);
            this.passwordTxt.TabIndex = 8;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTxt.Location = new System.Drawing.Point(114, 204);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(331, 20);
            this.userNameTxt.TabIndex = 7;
            // 
            // portTxt
            // 
            this.portTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portTxt.Location = new System.Drawing.Point(114, 170);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(331, 20);
            this.portTxt.TabIndex = 6;
            // 
            // serverHostTxt
            // 
            this.serverHostTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverHostTxt.Location = new System.Drawing.Point(114, 139);
            this.serverHostTxt.Name = "serverHostTxt";
            this.serverHostTxt.Size = new System.Drawing.Size(331, 20);
            this.serverHostTxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "账户：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "地址：";
            // 
            // DatabaseSettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "DatabaseSettingControl";
            this.Size = new System.Drawing.Size(763, 606);
            this.Load += new System.EventHandler(this.DatabaseSettingControl_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.DatabaseSettingGroup.ResumeLayout(false);
            this.DatabaseSettingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MssqlRadio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MysqlRadio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverHostTxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox SSHGroup;
        private DevExpress.XtraEditors.SimpleButton UpdateSettingBtn;
        private DevExpress.XtraEditors.SimpleButton AddSettingBtn;
        private System.Windows.Forms.GroupBox DatabaseSettingGroup;
        private DevExpress.XtraEditors.SimpleButton DeleteBtn;
        private DevExpress.XtraEditors.CheckEdit MssqlRadio;
        private DevExpress.XtraEditors.CheckEdit MysqlRadio;
        private DevExpress.XtraEditors.TextEdit passwordTxt;
        private DevExpress.XtraEditors.TextEdit userNameTxt;
        private DevExpress.XtraEditors.TextEdit portTxt;
        private DevExpress.XtraEditors.TextEdit serverHostTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private DevExpress.XtraEditors.TextEdit configNameTxt;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton testConnectBtn;
        private System.Windows.Forms.ListView SelectDBListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
