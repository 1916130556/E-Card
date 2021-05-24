using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace E_Card
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //连接数据库
            bool NamePwd = LoginData(txtAccount_1.Text, txtPwd_1.Text);

            if (txtAccount_1.Text == "" || txtPwd_1.Text == "")
            {
                MessageBox.Show("账号或密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (NamePwd)
            {
                //如果登录成功，则跳出主界面
                frmMain main = new frmMain();
                main.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("登录失败！", "登录", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //连接数据库
        public bool LoginData(string Account, string Pwd)
        {
            string sql = "select * from Login where Account='{0}' and Pwd='{1}'";
            sql = string.Format(sql, Account, Pwd);
            DBHelp help = new DBHelp();
            SqlDataReader reader = help.GetData(sql);
            if (reader.Read())
            {
                reader.Close();
                help.Close();
                return true;
            }
            else
            {
                reader.Close();
                help.Close();
                return false;
            }
        }

        //注册账号
        private void labRegister_Click(object sender, EventArgs e)
        {
            frmRegister ster = new frmRegister();
            ster.Show();
            Hide();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
