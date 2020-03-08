namespace WinCommonSoftware.Views.HomeGroup.QQManageGroup.QQManageViews
{
    partial class QQGroupCard
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
            this.GroupNameTxt = new System.Windows.Forms.Label();
            this.GroupInfoTxt = new System.Windows.Forms.Label();
            this.CheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.GroupHeadImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupHeadImage)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupNameTxt
            // 
            this.GroupNameTxt.AutoSize = true;
            this.GroupNameTxt.Location = new System.Drawing.Point(55, 8);
            this.GroupNameTxt.Margin = new System.Windows.Forms.Padding(0);
            this.GroupNameTxt.Name = "GroupNameTxt";
            this.GroupNameTxt.Size = new System.Drawing.Size(29, 12);
            this.GroupNameTxt.TabIndex = 1;
            this.GroupNameTxt.Text = "群名";
            // 
            // GroupInfoTxt
            // 
            this.GroupInfoTxt.AutoSize = true;
            this.GroupInfoTxt.Location = new System.Drawing.Point(55, 30);
            this.GroupInfoTxt.Margin = new System.Windows.Forms.Padding(0);
            this.GroupInfoTxt.Name = "GroupInfoTxt";
            this.GroupInfoTxt.Size = new System.Drawing.Size(65, 12);
            this.GroupInfoTxt.TabIndex = 2;
            this.GroupInfoTxt.Text = "群基本信息";
            // 
            // CheckEdit
            // 
            this.CheckEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckEdit.Location = new System.Drawing.Point(162, 5);
            this.CheckEdit.Margin = new System.Windows.Forms.Padding(0);
            this.CheckEdit.Name = "CheckEdit";
            this.CheckEdit.Properties.Caption = "";
            this.CheckEdit.Size = new System.Drawing.Size(15, 19);
            this.CheckEdit.TabIndex = 3;
            // 
            // GroupHeadImage
            // 
            this.GroupHeadImage.Location = new System.Drawing.Point(15, 8);
            this.GroupHeadImage.Margin = new System.Windows.Forms.Padding(0);
            this.GroupHeadImage.Name = "GroupHeadImage";
            this.GroupHeadImage.Size = new System.Drawing.Size(34, 34);
            this.GroupHeadImage.TabIndex = 0;
            this.GroupHeadImage.TabStop = false;
            // 
            // QQGroupCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CheckEdit);
            this.Controls.Add(this.GroupInfoTxt);
            this.Controls.Add(this.GroupNameTxt);
            this.Controls.Add(this.GroupHeadImage);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "QQGroupCard";
            this.Size = new System.Drawing.Size(162, 44);
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupHeadImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GroupHeadImage;
        private System.Windows.Forms.Label GroupNameTxt;
        private System.Windows.Forms.Label GroupInfoTxt;
        private DevExpress.XtraEditors.CheckEdit CheckEdit;
    }
}
