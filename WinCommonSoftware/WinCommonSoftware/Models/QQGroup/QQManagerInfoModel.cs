using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCommonSoftware.Models.QQGroup
{
    public class QQManagerInfoModel
    {
        public string QQNumber { get; set; }
        public string QQNickName { get; set; }

        public int QQOnlineStatus { get; set; }
        public int  MessageCount { get; set; }
        public string HostAddress { get; set; }

        public string ConfigPath { get; set; }
    }
}
