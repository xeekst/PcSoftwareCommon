using WinCommonSoftware.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCommonSoftware
{
    public class GlobalCache : SingletonObject<GlobalCache>
    {
        private MainForm _mainForm = null;
        public MainForm MainFormInstance
        {
            get
            {
                return this._mainForm;
            }
            set
            {
                this._mainForm = value;
            }
        }
    }
}
