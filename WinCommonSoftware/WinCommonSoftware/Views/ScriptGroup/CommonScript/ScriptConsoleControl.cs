using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using WinCommonSoftware.Utils;
using WinCommonSoftware.Views.BaseViews;

namespace WinCommonSoftware.Views.ScriptGroup.CommonScript
{
    public partial class ScriptConsoleControl : UserControl
    {
        private SimpleRichTextboxControl _simpleRictTextboxControl = null;
        private int pid = default(int);
        public ScriptConsoleControl()
        {
            InitializeComponent();
            InitialzeOtherComponent();
            InitDispose();
        }
        private void InitialzeOtherComponent()
        {
            _simpleRictTextboxControl = new SimpleRichTextboxControl();
            _simpleRictTextboxControl.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(_simpleRictTextboxControl);
        }
        private void selectExeBtn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择exe文件";
            fileDialog.Filter = "exe文件(*.exe)|*.exe";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                selectExeBtn.Text = file;
            }
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            string runningCmd = string.IsNullOrEmpty(this.runningtimeTxt.Text) ? "" : this.runningtimeTxt.Text + " ";
            string cmd = runningCmd + this.selectExeBtn.Text + " " + this.scriptArgsTxt.Text;

            ProcessManagerUtil.Instance.StartProcessWithoutWindow(cmd, (s, args) =>
            {
                if (this._simpleRictTextboxControl.InvokeRequired)
                {
                    Action<string> actionDelegate = (text) =>
                    {
                        if (text != null)
                        {
                            this._simpleRictTextboxControl.Info(text);
                        }
                    };
                    this._simpleRictTextboxControl.BeginInvoke(actionDelegate, args.Data);
                }
            }, 
            (s, args) =>
            {
                if (this._simpleRictTextboxControl.InvokeRequired)
                {
                    Action<string> actionDelegate = (text) =>
                    {
                        if (text != null)
                        {
                            this._simpleRictTextboxControl.Error(text);
                        }
                    };
                    this._simpleRictTextboxControl.BeginInvoke(actionDelegate, args.Data);
                }
            },
            (pid) =>
            {
                 this.pid = pid;
            });
        }

        public void InitDispose()
        {
            this.Disposed += (s, e) =>
            {
                if (this.pid != default(int))
                {
                    var p = Process.GetProcessById(this.pid);
                    p.Kill();
                    p.Close();
                }
            };
        }
    }
}
