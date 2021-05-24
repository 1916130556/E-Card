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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        //注册账号
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtAccount_2.Text == "" || txtPwd_2.Text == "" || txtPwd_3.Text == "")
            {
                MessageBox.Show("账号或密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(txtPwd_2.Text != txtPwd_3.Text)
            {
                MessageBox.Show("密码与确认密码不符！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //将数据库的值提到C#中
            int account = int.Parse(txtAccount_2.Text);

            //进行判断
            string sql = "select Account from Login where Account='{0}'";
            sql = string.Format(sql, txtAccount_2.Text);
            DBHelp help = new DBHelp();
            SqlDataReader reader = help.GetData(sql);
            int reault = 0;
            if (reader.Read())
            {
                reault = Convert.ToInt32(reader["Account"]);
            }
            if (reault == account)
            {
                MessageBox.Show("数据库已有相同账号，请重新想一个！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            reader.Close();

            //插入数据库语句
            string sql_1 = "insert into Login(Account, Pwd) values('{0}', '{1}')";
            sql_1 = string.Format(sql_1, txtAccount_2.Text, txtPwd_2.Text);


            bool Info = help.SelectData(sql_1);
            //int result = help.UpData(sql);
            //bool Info = result > 0 ? true : false;

            //判断是否注册成功
            if (Info)
            {
                frmLogin login = new frmLogin();
                login.Show();
                Hide();
                MessageBox.Show("注册成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("注册失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //返回
        private void btnrReturn_1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            Hide();
        }
    }
}
