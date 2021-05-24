using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Card
{
    public partial class frmUserRecharge : Form
    {
        public frmUserRecharge()
        {
            InitializeComponent();
        }

        //主窗体
        private void gbTopup_Enter(object sender, EventArgs e)
        {
            this.Time.Start();
        }

        //时间
        private void Time_Tick(object sender, EventArgs e)
        {
            this.labelTime_3.Text = DateTime.Now.ToString();
            this.labelTime_3.Visible = false;
        }

        //读取数据库里面的内容
        private void btnQueryData_4_Click(object sender, EventArgs e)
        {
            //查询用户信息
            string sql = "select CardNumber, UserName, UserGender, UserAge from UserInfo where CardNumber='{0}'";
            sql = string.Format(sql, txtCardNumber_4.Text);
            DBHelp help = new DBHelp();
            DataTable dt = new DataTable();
            dt = help.QueryData(sql);

            //将数据库的值提到C#中
            int card = int.Parse(txtCardNumber_4.Text);

            //进行判断
            string sql_1 = "select CardNumber from UserInfo where CardNumber='{0}'";
            sql_1 = string.Format(sql_1, txtCardNumber_4.Text);
            SqlDataReader reader = help.GetData(sql_1);
            int reault = 0;
            if (reader.Read())
            {
                reault = Convert.ToInt32(reader["CardNumber"]);
            }
            reader.Close();
            if (reault != card)
            {
                MessageBox.Show("请输入正确的用户卡号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //对数据进行赋值
            txtUserName_4.Text = dt.Rows[0][1].ToString();
            cbGender_4.Text = dt.Rows[0][2].ToString();
            txtUserAge_4.Text = dt.Rows[0][3].ToString();
        }


        //一卡通充值
        private void btnTopupMoney_Click(object sender, EventArgs e)
        {
            //判断输入值
            string topup = txtTopup.Text;
            if (topup == "")
            {
                MessageBox.Show("信息不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        
            //连接数据库，添加(更新)信息
            string sql = "insert into Subway(Cost, Time, CardNumber) values({0}, '{1}', '{2}')";
            sql = string.Format(sql, txtTopup.Text, labelTime_3.Text, txtCardNumber_4.Text);
            string sql_1 = "update Top_up set TopupMoney+={0} where CardNumber = '{1}'";//
            sql_1 = string.Format(sql_1, txtTopup.Text, txtCardNumber_4.Text);//


            //判断是否充值成功
            DBHelp help = new DBHelp();
            bool Info = help.SelectData(sql);
            bool Info_1 = help.SelectData(sql_1);//
            //int result = help.UpData(sql);
            //int result_1 = help.UpData(sql_1);//
            //bool Info = result > 0 ? true : false;
            //bool Info_1 = result_1 > 0 ? true : false;//

            if (Info || Info_1)
            {
                MessageBox.Show("充值成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("充值失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        DataSet ds;
        int count = 0;//记录数据库有多少行
        //查询数据
        private void btnQueryData_5_Click(object sender, EventArgs e)
        {
            //判断输入卡号
            string card = this.txtCardNumber_5.Text;
            if (card == "")
            {
                MessageBox.Show("请输入需要查询的卡号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //将数据库的值提到C#中
            int card_1 = int.Parse(txtCardNumber_5.Text);

            //进行判断
            string sql_1 = "select CardNumber from UserInfo where CardNumber='{0}'";
            sql_1 = string.Format(sql_1, txtCardNumber_5.Text);
            DBHelp help = new DBHelp();
            SqlDataReader reader = help.GetData(sql_1);
            int reault = 0;
            if (reader.Read())
            {
                reault = Convert.ToInt32(reader["CardNumber"]);
                reader.Close();
            }
            if (reault != card_1)
            {
                MessageBox.Show("请输入正确的用户卡号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //连接数据库，查询并填充数据
            Data();
            //连接表
            DataTable dt = ds.Tables[0];
            this.dataGridView2.DataSource = dt;//调用数据库表到这个DataGridView控件中
        }

        private void Data()
        {
            //查询表中的内容
            DBHelp help = new DBHelp();
            string sql = "select u.CardNumber, u.UserName, s.Cost, s.Entrance, s.Exitof, s.Time from UserInfo u join Subway s on u.CardNumber = s.CardNumber where u.CardNumber = '{0}' order by s.Time";
            sql = string.Format(sql, txtCardNumber_5.Text);
            ds = help.SetData(sql);
            count = ds.Tables[0].Rows.Count;//记录数据库有多少行

            //输出账户余额
            string sql_1 = "select TopupMoney from Top_up where CardNumber = '{0}'";
            sql_1 = string.Format(sql_1, txtCardNumber_5.Text);
            SqlDataReader reader = help.GetData(sql_1);
            if(reader.Read())
            {
                labmoney.Text = reader["TopupMoney"].ToString();//
            }
            reader.Close();

            if (ds == null || ds.Tables[0].Rows.Count == 0)//ds.Tables[0].Rows.Count：表集的第一个表的所有行数（也就是总数）
            {
                MessageBox.Show("查询失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ////如果用户查询信息“成功”,则跳出查询的信息
                //MessageBox.Show("查询成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
