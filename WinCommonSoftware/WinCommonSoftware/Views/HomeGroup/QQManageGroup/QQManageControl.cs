using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinCommonSoftware.Views.HomeGroup.QQManageGroup.QQManageViews;

namespace WinCommonSoftware.Views.HomeGroup.QQManageGroup
{
    public partial class QQManageControl : UserControl
    {
        public QQManageControl()
        {
            InitializeComponent();
            var card1 = new QQGroupCard();
            var p = new Padding { Left = 10 };
            
            var card2 = new QQGroupCard();
            
            var card3 = new QQGroupCard();
            
            var w = this.panel1.Width / 3;
            //card1.Margin = p;
            //card1.Margin = p;
            //card1.Margin = p;
            //card1.Size = new Size() { Width = 165, Height = 42 };
            //card3.Size = new Size() { Width = 165, Height = 42 };
            //card2.Size = new Size() { Width = 165, Height = 42 };
            card1.Location = new Point() { X = 5, Y = 7 };
            card2.Location = new Point() { X = 172, Y = 7 };
            card3.Location = new Point() { X = 339, Y = 7 };
            this.panel1.Controls.Add(card1);
            this.panel1.Controls.Add(card2);
            this.panel1.Controls.Add(card3);
        }

        private void AddGroupCard()
        {
            
            //this.QQGroupListView.Items.Add(card);
            
        }
    }
}
