using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//注意这个和项目“委托实现窗体传值”是一样的
//只不过是“委托实现窗体传值”中给事假绑定函数时，是直接通过子窗口的构造函数（当然首先要先重写子窗口的构造函数）

//在这里我有尝试给事假绑定两个函数

namespace 委托实现窗体传值2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            ChildForm childFrm = new ChildForm();
            childFrm._del += Do1;
            childFrm._del += Do2;

            childFrm.Show();
        }

        public void Do1(string text)
        {
            txtMian1.Text = text + "1";
        }

        public void Do2(string text)
        {
            txtMian2.Text = text + "2";
        }

    }
}
