namespace WinCommonSoftware.Views.HomeGroup.DataView
{
    partial class SQLViewControl
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.PasswordTxt = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.Label();
            this.PortTxt = new System.Windows.Forms.Label();
            this.HostTxt = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelHost = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.SQLGroupBox = new System.Windows.Forms.GroupBox();
            this.SQLDeleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SQLEditBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SQLAddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.connectStatusText = new System.Windows.Forms.Label();
            this.DatabaseCheckedComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SQLTextListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExportBtn = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RunScriptBtn = new DevExpress.XtraEditors.SimpleButton();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerRight = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.SqlDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.SaveSqlBtn = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SqlEditNameTextbox = new System.Windows.Forms.TextBox();
            this.SqlTextBox = new System.Windows.Forms.TextBox();
            this.ErrorDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SQLGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseCheckedComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.hideContainerRight.SuspendLayout();
            this.SqlDockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.ErrorDockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ExportBtn);
            this.splitContainer1.Panel2.Controls.Add(this.gridControl);
            this.splitContainer1.Size = new System.Drawing.Size(743, 606);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.PasswordTxt);
            this.splitContainer2.Panel1.Controls.Add(this.UsernameTxt);
            this.splitContainer2.Panel1.Controls.Add(this.PortTxt);
            this.splitContainer2.Panel1.Controls.Add(this.HostTxt);
            this.splitContainer2.Panel1.Controls.Add(this.labelPassword);
            this.splitContainer2.Panel1.Controls.Add(this.labelUsername);
            this.splitContainer2.Panel1.Controls.Add(this.labelHost);
            this.splitContainer2.Panel1.Controls.Add(this.labelPort);
            this.splitContainer2.Panel1.Controls.Add(this.SQLGroupBox);
            this.splitContainer2.Panel1.Controls.Add(this.connectStatusText);
            this.splitContainer2.Panel1.Controls.Add(this.DatabaseCheckedComboBox);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.SQLTextListView);
            this.splitContainer2.Size = new System.Drawing.Size(743, 188);
            this.splitContainer2.SplitterDistance = 358;
            this.splitContainer2.TabIndex = 0;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTxt.AutoSize = true;
            this.PasswordTxt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordTxt.Location = new System.Drawing.Point(222, 104);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(23, 12);
            this.PasswordTxt.TabIndex = 15;
            this.PasswordTxt.Text = "...";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTxt.AutoSize = true;
            this.UsernameTxt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UsernameTxt.Location = new System.Drawing.Point(222, 79);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(23, 12);
            this.UsernameTxt.TabIndex = 14;
            this.UsernameTxt.Text = "...";
            // 
            // PortTxt
            // 
            this.PortTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortTxt.AutoSize = true;
            this.PortTxt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PortTxt.Location = new System.Drawing.Point(53, 104);
            this.PortTxt.Name = "PortTxt";
            this.PortTxt.Size = new System.Drawing.Size(23, 12);
            this.PortTxt.TabIndex = 13;
            this.PortTxt.Text = "...";
            // 
            // HostTxt
            // 
            this.HostTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HostTxt.AutoSize = true;
            this.HostTxt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HostTxt.Location = new System.Drawing.Point(53, 79);
            this.HostTxt.Name = "HostTxt";
            this.HostTxt.Size = new System.Drawing.Size(23, 12);
            this.HostTxt.TabIndex = 12;
            this.HostTxt.Text = "...";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPassword.Location = new System.Drawing.Point(169, 104);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(35, 12);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "密码:";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUsername.Location = new System.Drawing.Point(169, 79);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(47, 12);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "用户名:";
            // 
            // labelHost
            // 
            this.labelHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHost.AutoSize = true;
            this.labelHost.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelHost.Location = new System.Drawing.Point(12, 79);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(35, 12);
            this.labelHost.TabIndex = 9;
            this.labelHost.Text = "Host:";
            // 
            // labelPort
            // 
            this.labelPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPort.Location = new System.Drawing.Point(12, 104);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(35, 12);
            this.labelPort.TabIndex = 8;
            this.labelPort.Text = "Port:";
            // 
            // SQLGroupBox
            // 
            this.SQLGroupBox.Controls.Add(this.SQLDeleteBtn);
            this.SQLGroupBox.Controls.Add(this.SQLEditBtn);
            this.SQLGroupBox.Controls.Add(this.SQLAddBtn);
            this.SQLGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SQLGroupBox.Location = new System.Drawing.Point(0, 135);
            this.SQLGroupBox.Name = "SQLGroupBox";
            this.SQLGroupBox.Size = new System.Drawing.Size(358, 53);
            this.SQLGroupBox.TabIndex = 7;
            this.SQLGroupBox.TabStop = false;
            this.SQLGroupBox.Text = "SQL脚本";
            // 
            // SQLDeleteBtn
            // 
            this.SQLDeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SQLDeleteBtn.Appearance.BackColor = System.Drawing.Color.Gray;
            this.SQLDeleteBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.SQLDeleteBtn.Appearance.Options.UseBackColor = true;
            this.SQLDeleteBtn.Appearance.Options.UseForeColor = true;
            this.SQLDeleteBtn.AppearanceHovered.BackColor = System.Drawing.Color.Silver;
            this.SQLDeleteBtn.AppearanceHovered.Options.UseBackColor = true;
            this.SQLDeleteBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.SQLDeleteBtn.Location = new System.Drawing.Point(266, 20);
            this.SQLDeleteBtn.Name = "SQLDeleteBtn";
            this.SQLDeleteBtn.Size = new System.Drawing.Size(57, 23);
            this.SQLDeleteBtn.TabIndex = 7;
            this.SQLDeleteBtn.Text = "删除";
            this.SQLDeleteBtn.Click += new System.EventHandler(this.SQLDeleteBtn_Click);
            // 
            // SQLEditBtn
            // 
            this.SQLEditBtn.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.SQLEditBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.SQLEditBtn.Appearance.Options.UseBackColor = true;
            this.SQLEditBtn.Appearance.Options.UseForeColor = true;
            this.SQLEditBtn.AppearanceHovered.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SQLEditBtn.AppearanceHovered.Options.UseBackColor = true;
            this.SQLEditBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.SQLEditBtn.Location = new System.Drawing.Point(89, 20);
            this.SQLEditBtn.Name = "SQLEditBtn";
            this.SQLEditBtn.Size = new System.Drawing.Size(59, 23);
            this.SQLEditBtn.TabIndex = 5;
            this.SQLEditBtn.Text = "编辑";
            // 
            // SQLAddBtn
            // 
            this.SQLAddBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SQLAddBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.SQLAddBtn.Appearance.Options.UseBackColor = true;
            this.SQLAddBtn.Appearance.Options.UseForeColor = true;
            this.SQLAddBtn.AppearanceHovered.BackColor = System.Drawing.Color.SandyBrown;
            this.SQLAddBtn.AppearanceHovered.Options.UseBackColor = true;
            this.SQLAddBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.SQLAddBtn.Location = new System.Drawing.Point(14, 20);
            this.SQLAddBtn.Name = "SQLAddBtn";
            this.SQLAddBtn.Size = new System.Drawing.Size(57, 23);
            this.SQLAddBtn.TabIndex = 6;
            this.SQLAddBtn.Text = "新增";
            this.SQLAddBtn.Click += new System.EventHandler(this.SQLAddBtn_Click);
            // 
            // connectStatusText
            // 
            this.connectStatusText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectStatusText.AutoSize = true;
            this.connectStatusText.Location = new System.Drawing.Point(87, 54);
            this.connectStatusText.Name = "connectStatusText";
            this.connectStatusText.Size = new System.Drawing.Size(29, 12);
            this.connectStatusText.TabIndex = 4;
            this.connectStatusText.Text = "None";
            // 
            // DatabaseCheckedComboBox
            // 
            this.DatabaseCheckedComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseCheckedComboBox.Location = new System.Drawing.Point(89, 13);
            this.DatabaseCheckedComboBox.Name = "DatabaseCheckedComboBox";
            this.DatabaseCheckedComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DatabaseCheckedComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.DatabaseCheckedComboBox.Size = new System.Drawing.Size(256, 20);
            this.DatabaseCheckedComboBox.TabIndex = 1;
            this.DatabaseCheckedComboBox.SelectedIndexChanged += new System.EventHandler(this.DatabaseCheckedComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择配置:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "连接状态:";
            // 
            // SQLTextListView
            // 
            this.SQLTextListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.SQLTextListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SQLTextListView.FullRowSelect = true;
            this.SQLTextListView.Location = new System.Drawing.Point(0, 0);
            this.SQLTextListView.Name = "SQLTextListView";
            this.SQLTextListView.Size = new System.Drawing.Size(381, 188);
            this.SQLTextListView.TabIndex = 0;
            this.SQLTextListView.UseCompatibleStateImageBehavior = false;
            this.SQLTextListView.View = System.Windows.Forms.View.Details;
            this.SQLTextListView.SelectedIndexChanged += new System.EventHandler(this.SQLTextListView_SelectedIndexChanged);
            this.SQLTextListView.Resize += new System.EventHandler(this.SQLTextListView_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "配置名";
            // 
            // ExportBtn
            // 
            this.ExportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportBtn.Appearance.BackColor = System.Drawing.Color.ForestGreen;
            this.ExportBtn.Appearance.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExportBtn.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExportBtn.Appearance.Options.UseBackColor = true;
            this.ExportBtn.Appearance.Options.UseFont = true;
            this.ExportBtn.Appearance.Options.UseForeColor = true;
            this.ExportBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ExportBtn.AppearanceHovered.Options.UseBackColor = true;
            this.ExportBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ExportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportBtn.Location = new System.Drawing.Point(633, 385);
            this.ExportBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(75, 24);
            this.ExportBtn.TabIndex = 1;
            this.ExportBtn.Text = "导出";
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl.Location = new System.Drawing.Point(0, 2);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(743, 378);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // RunScriptBtn
            // 
            this.RunScriptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RunScriptBtn.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.RunScriptBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.RunScriptBtn.Appearance.Options.UseBackColor = true;
            this.RunScriptBtn.Appearance.Options.UseForeColor = true;
            this.RunScriptBtn.AppearanceHovered.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.RunScriptBtn.AppearanceHovered.Options.UseBackColor = true;
            this.RunScriptBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RunScriptBtn.Location = new System.Drawing.Point(131, 552);
            this.RunScriptBtn.Name = "RunScriptBtn";
            this.RunScriptBtn.Size = new System.Drawing.Size(57, 23);
            this.RunScriptBtn.TabIndex = 8;
            this.RunScriptBtn.Text = "Run";
            this.RunScriptBtn.Click += new System.EventHandler(this.RunScriptBtn_Click);
            // 
            // dockManager
            // 
            this.dockManager.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerRight});
            this.dockManager.Form = this;
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"});
            // 
            // hideContainerRight
            // 
            this.hideContainerRight.BackColor = System.Drawing.SystemColors.Control;
            this.hideContainerRight.Controls.Add(this.SqlDockPanel);
            this.hideContainerRight.Controls.Add(this.ErrorDockPanel);
            this.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideContainerRight.Location = new System.Drawing.Point(743, 0);
            this.hideContainerRight.Name = "hideContainerRight";
            this.hideContainerRight.Size = new System.Drawing.Size(20, 606);
            // 
            // SqlDockPanel
            // 
            this.SqlDockPanel.Controls.Add(this.dockPanel1_Container);
            this.SqlDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.SqlDockPanel.ID = new System.Guid("4a49afa6-f7bf-44e5-bc5b-00d5d5ae24ed");
            this.SqlDockPanel.Location = new System.Drawing.Point(0, 0);
            this.SqlDockPanel.Name = "SqlDockPanel";
            this.SqlDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.SqlDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.SqlDockPanel.SavedIndex = 0;
            this.SqlDockPanel.SavedSizeFactor = 1D;
            this.SqlDockPanel.Size = new System.Drawing.Size(200, 606);
            this.SqlDockPanel.Text = "SQLEdit";
            this.SqlDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.RunScriptBtn);
            this.dockPanel1_Container.Controls.Add(this.SaveSqlBtn);
            this.dockPanel1_Container.Controls.Add(this.label3);
            this.dockPanel1_Container.Controls.Add(this.SqlEditNameTextbox);
            this.dockPanel1_Container.Controls.Add(this.SqlTextBox);
            this.dockPanel1_Container.Location = new System.Drawing.Point(5, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(191, 579);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // SaveSqlBtn
            // 
            this.SaveSqlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveSqlBtn.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.SaveSqlBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.SaveSqlBtn.Appearance.Options.UseBackColor = true;
            this.SaveSqlBtn.Appearance.Options.UseForeColor = true;
            this.SaveSqlBtn.AppearanceHovered.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveSqlBtn.AppearanceHovered.Options.UseBackColor = true;
            this.SaveSqlBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.SaveSqlBtn.Location = new System.Drawing.Point(2, 552);
            this.SaveSqlBtn.Name = "SaveSqlBtn";
            this.SaveSqlBtn.Size = new System.Drawing.Size(59, 23);
            this.SaveSqlBtn.TabIndex = 6;
            this.SaveSqlBtn.Text = "保存";
            this.SaveSqlBtn.Click += new System.EventHandler(this.SaveSqlBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "SQL名称：";
            // 
            // SqlEditNameTextbox
            // 
            this.SqlEditNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SqlEditNameTextbox.Location = new System.Drawing.Point(2, 517);
            this.SqlEditNameTextbox.Name = "SqlEditNameTextbox";
            this.SqlEditNameTextbox.Size = new System.Drawing.Size(190, 21);
            this.SqlEditNameTextbox.TabIndex = 1;
            // 
            // SqlTextBox
            // 
            this.SqlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SqlTextBox.Location = new System.Drawing.Point(-2, 0);
            this.SqlTextBox.Multiline = true;
            this.SqlTextBox.Name = "SqlTextBox";
            this.SqlTextBox.Size = new System.Drawing.Size(194, 499);
            this.SqlTextBox.TabIndex = 0;
            // 
            // ErrorDockPanel
            // 
            this.ErrorDockPanel.Controls.Add(this.controlContainer1);
            this.ErrorDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.ErrorDockPanel.ID = new System.Guid("22029f08-181f-4360-b723-03251ae82a99");
            this.ErrorDockPanel.Location = new System.Drawing.Point(0, 0);
            this.ErrorDockPanel.Name = "ErrorDockPanel";
            this.ErrorDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.ErrorDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.ErrorDockPanel.SavedIndex = 0;
            this.ErrorDockPanel.SavedSizeFactor = 1D;
            this.ErrorDockPanel.Size = new System.Drawing.Size(200, 606);
            this.ErrorDockPanel.Text = "错误";
            this.ErrorDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // controlContainer1
            // 
            this.controlContainer1.Location = new System.Drawing.Point(5, 23);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(191, 579);
            this.controlContainer1.TabIndex = 0;
            // 
            // SQLViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.hideContainerRight);
            this.Name = "SQLViewControl";
            this.Size = new System.Drawing.Size(763, 606);
            this.Load += new System.EventHandler(this.SQLViewControl_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.SQLGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseCheckedComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.hideContainerRight.ResumeLayout(false);
            this.SqlDockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            this.ErrorDockPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.ComboBoxEdit DatabaseCheckedComboBox;
        private System.Windows.Forms.Label connectStatusText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton ExportBtn;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraEditors.SimpleButton SQLAddBtn;
        private DevExpress.XtraEditors.SimpleButton SQLEditBtn;
        private System.Windows.Forms.GroupBox SQLGroupBox;
        private DevExpress.XtraEditors.SimpleButton SQLDeleteBtn;
        private DevExpress.XtraEditors.SimpleButton RunScriptBtn;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label PasswordTxt;
        private System.Windows.Forms.Label UsernameTxt;
        private System.Windows.Forms.Label PortTxt;
        private System.Windows.Forms.Label HostTxt;
        private DevExpress.XtraBars.Docking.DockPanel SqlDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.SimpleButton SaveSqlBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SqlEditNameTextbox;
        private System.Windows.Forms.TextBox SqlTextBox;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerRight;
        private DevExpress.XtraBars.Docking.DockPanel ErrorDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private System.Windows.Forms.ListView SQLTextListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
