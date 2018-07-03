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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DialogResult result = DialogResult.Cancel;//不对窗体2进行任何操作，result的默认值Cancel

        private void button1_Click(object sender, EventArgs e)//点击按钮1，result值为Ok
        {
            result = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)//点击按钮2，result值为Cancel
        {
            result = DialogResult.Cancel;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)//这是closing事件，注意只有关闭Frm2窗体才会给 this.DialogResult赋值啊
        {
            this.DialogResult = result;//把结果给窗口的DialogResult
        }
    }
}
