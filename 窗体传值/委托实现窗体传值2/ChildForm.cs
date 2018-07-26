using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 委托实现窗体传值2
{
    ///我们就不自己定义委托了
    ///其实一般开发中一般都是使用c#自带的俩个委托
    ///Action和Func
    ///Action委托是没有返回值的委托
    ///Func是有返回值的委托
    

    public partial class ChildForm : Form
    {
        public Action<string> _del;

        public ChildForm()
        {
            InitializeComponent();
        }

        private void btnChild_Click(object sender, EventArgs e)
        {
            _del(txtChild.Text);
        }


    }
}
