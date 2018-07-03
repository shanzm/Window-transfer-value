using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winform_Tag属性
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Tag = 1234;
            //窗体属性Tag属性进行传值，当一个窗口Form1新建一个窗口Form2，
            //在新建这个Form2的时候，直接给这个Form2的tag属性进行赋值
            //然后在Form2中直接就可以通过this.Tag来获取这个值，从而实现窗口传值
            frm2.Show();
        }

    
    }
}
