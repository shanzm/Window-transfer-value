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
    public delegate void DelTest(string str);

    public partial class Form2 : Form
    {
        public DelTest _del;

        public Form2(DelTest ShowMsg)
        {
            InitializeComponent();
            this._del = ShowMsg;
        }



        private void btnFrm2_Click(object sender, EventArgs e)
        {
            _del(txtFrm2.Text);
        }

    }
}
