using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 根据窗体2的操作决定窗体1_的操作
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
            DialogResult result = frm2.ShowDialog();
            if (result ==DialogResult .OK )
            {
                textBox1.Text = "我更新文本框";
            }
            else
            {
                textBox1.Text = "不更新";
            }
        }
    }
}
