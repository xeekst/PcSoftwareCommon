using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCommonSoftware.Views.BaseViews
{
    public partial class SimpleRichTextboxControl : UserControl
    {
        public SimpleRichTextboxControl()
        {
            InitializeComponent();
        }
        //todo:info->green error->red warning:橙色 等等
        private enum MessageType
        {
            DEBUG = 0,
            INFO = 1,
            WARNING = 2,
            ERROR = 3,
        }
        public void Error(params string[] msgs)
        {
            AppendTextMessageType(msgs, Color.Red, MessageType.ERROR);
        }
        public void Info(params string[] msgs)
        {
            AppendTextMessageType(msgs, Color.Green, MessageType.INFO);
        }
        public void Warning(params string[] msgs)
        {
            AppendTextMessageType(msgs, Color.Orange, MessageType.WARNING);
        }
        public void Debug(params string[] msgs)
        {
            AppendTextMessageType(msgs, Color.AliceBlue, MessageType.WARNING);
        }
        private void AppendTextMessageType(string[] msgs,Color color,MessageType messageType)
        {
            richTextBox.SelectionStart = richTextBox.Text.Length;
            richTextBox.SelectionLength = 0;
            richTextBox.SelectionColor = color;
            richTextBox.AppendText(GetTypeMsg(messageType));
            richTextBox.SelectionColor = richTextBox.ForeColor;
            richTextBox.AppendText(GetMessageText(msgs));
        }
        private string GetTypeMsg( MessageType messageType)
        {
            string msg = $"[{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}] [{messageType.ToString()}] :";
            return msg;
        }
        private string GetMessageText(string[] msgs)
        {
            string msg = string.Empty;
            for (int i = 0; i < msgs.Length; i++)
            {
                msg = msg + " " + msgs[i];
            }
            msg += "\n";
            return msg;
        }
    }
}
