using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 委托实现窗体传值
{
    ///注意这是从Frm2传值到Frm1 ，与使用Tag属性是不一样的额，使用Tag属性相当于是从Frm1传值到Frm2
    ///你这样去思考，在Frm1中你希望对Frm2中的一个值进行某种操作，那么你就通过修改的Frm2的构造函数来把Frm1中的那个针对Frm2中值的操作，传递过来

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(ShowMsg);
            frm2.Show();
        }

        public void ShowMsg(string str)
        {
            txtFrm1.Text = str;
        }
    }
}
