using WinCommonSoftware.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCommonSoftware.ControlUtils
{
    public class CommonControlUtil : SingletonObject<CommonControlUtil>
    {
        public void InvokeControlFuncInThread(Control control,Action<string> func, string value = null)
        {
            if (control.InvokeRequired)
            {
                Action<string> actionDelegate = (text) =>
                {
                    func(text);
                };
                control.BeginInvoke(actionDelegate, value);
            }
        }
    }
}
