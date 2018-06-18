using LittleFish.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LittleFilsh.Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            txtkeyValue.Text = Md5Helper.MD5(CommonHelper.CreateNo(), 16).ToLower();
            txtPwdValue.Text = Md5Helper.MD5(DESEncrypt.Encrypt(Md5Helper.MD5(txtPwd.Text, 32).ToLower(), txtkeyValue.Text).ToLower(), 32).ToLower();
        }
    }
}
