using DevExpress.XtraTab;
using DevPCBase.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevPCBase.ControlUtils
{
    public class AccordionControlUtil : SingletonObject<AccordionControlUtil>
    {
        public void CloseTabpageByTitle(string title, XtraTabControl xtraTabControl)
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)//遍历得到和关闭的选项卡一样的Text
            {
                if (page.Text == title)
                {
                    xtraTabControl.TabPages.Remove(page);
                    page.Dispose();
                    return;
                }
            }
        }

        public string AddNewPageIfNotExist(string title, XtraTabControl xtraTabControl)
        {
            if (IsExist(title, xtraTabControl))
            {
                return title;
            }
            XtraTabPage npage = new XtraTabPage();
            int length = xtraTabControl.TabPages.Count;
            npage.Text = title;
            npage.Name = $"xtraTabElement{length}";
            npage.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            xtraTabControl.TabPages.Add(npage);
            xtraTabControl.SelectedTabPage = npage;
            return npage.Text;
        }

        public void SelectPageByTitle(string title,XtraTabControl xtraTabControl)
        {
            xtraTabControl.TabPages.ToList().ForEach(e =>
            {
                if(e.Text == title)
                {
                    xtraTabControl.SelectedTabPage = e;
                }
            });
        }

        public void BindTabpageClick(DevExpress.XtraBars.Navigation.AccordionControlElementCollection elements, XtraTabControl xtraTabControl)
        {
            foreach (var ele in elements)
            {
                if (ele.GetType() == typeof(DevExpress.XtraBars.Navigation.AccordionControlElement))
                {
                    if (ele.Elements.Count > 0)
                    {
                        BindTabpageClick(ele.Elements, xtraTabControl);
                    }
                    else
                    {
                        if (ele.Style == DevExpress.XtraBars.Navigation.ElementStyle.Item || ele.Text.Trim() == "Home")
                        {
                            //添加点击后动态添加tabpage事件
                            ele.Click += (s, e) =>
                            {
                                AddNewPageIfNotExist(ele.Text.Trim(), xtraTabControl);
                                SelectPageByTitle(ele.Text.Trim(), xtraTabControl);
                            };
                            //添加点击后的第二个事件 tabpage上的tag字符串绑定的UserControl 反射实例化后绑定到tabpage上去
                            ele.Click += (s, e) =>
                            {
                                AccordionControl_Load_TabpageControl_Click(s, e, xtraTabControl);
                            };
                        }

                    }
                }

            }
        }
        private void AccordionControl_Load_TabpageControl_Click(object sender, EventArgs e, XtraTabControl xtraTabControl)
        {
            var accordionElement = sender as DevExpress.XtraBars.Navigation.AccordionControlElement;
            if (accordionElement == null)
                return;
            var tabpage = xtraTabControl.TabPages.ToList().Find(t => t.Text.Trim() == accordionElement.Text.Trim());
            if (accordionElement.Tag is string)
            {
                var tagArray = accordionElement.Tag.ToString().Split(',');
                string contronName = tagArray[0];
                string param = tagArray.Length > 1 ? tagArray[1] : null;
                var allTypes = Assembly.GetExecutingAssembly().DefinedTypes;
                var controlType = allTypes.ToList().Find(m => m.Name.Equals(contronName));
                if (controlType != null)
                {
                    var controlObj = param == null ? Activator.CreateInstance(controlType.AsType()) : Activator.CreateInstance(controlType.AsType(), param);
                    if (controlObj is Control)
                    {
                        var control = controlObj as Control;
                        tabpage.Controls.Add(control);
                        control.Dock = DockStyle.Fill;
                    }
                }
            }
        }
        private bool IsExist(string title, XtraTabControl xtraTabControl)
        {
            return xtraTabControl.TabPages.ToList().Exists(e => e.Text == title);
        }
        private int CheckTabCount(string title,XtraTabControl xtraTabControl)
        {
            int count = 0;
            foreach(XtraTabPage page in xtraTabControl.TabPages)
            {
                if(page.Text == title)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
