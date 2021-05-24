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
    public partial class frmUserInfo : Form
    {
        public frmUserInfo()
        {
            InitializeComponent();
        }

        //主窗体
        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            this.Time.Start();
        }

        //时间
        private void Time_Tick(object sender, EventArgs e)
        {
            this.labelTime_1.Text = DateTime.Now.ToString();
            this.labelTime_1.Visible = false;
        }

        //添加用户信息
        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            //用户输入
            string card = this.txtCardNumber_1.Text;
            string name = this.txtUserName_1.Text;
            string gender = this.cbUserGender_1.Text;
            string age = this.txtUserAge_1.Text;
            string initial = this.txtInitial_1.Text;
            //string time = this.labelTime_1.Text;

            //判断输入值
            if (card == "" || name == "" || gender == "" || age == "" || initial == "")
            {
                MessageBox.Show("信息不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //连接数据库，添加用户基本信息
            string sql = "insert into UserInfo(CardNumber, UserName, UserGender, UserAge) values ('{0}', '{1}', '{2}', {3})";
            sql = string.Format(sql, txtCardNumber_1.Text, txtUserName_1.Text, cbUserGender_1.Text, txtUserAge_1.Text);
            string sql_1 = "insert into Subway(Cost, Time, CardNumber) values({0}, '{1}', '{2}')";
            sql_1 = string.Format(sql_1, txtInitial_1.Text, labelTime_1.Text, txtCardNumber_1.Text);
            string sql_2 = "insert into Top_up(TopupMoney, TopupTime, CardNumber) values({0}, '{1}', '{2}')";//
            sql_2 = string.Format(sql_2, txtInitial_1.Text, labelTime_1.Text, txtCardNumber_1.Text);//

            //判断是否添加成功
            DBHelp help = new DBHelp();
            bool Info = help.SelectData(sql);
            bool Info_1 = help.SelectData(sql_1);
            bool Info_2 = help.SelectData(sql_2);//
            //int result = help.UpData(sql);
            //int result_1 = help.UpData(sql_1);
            //int result_2 = help.UpData(sql_2);
            //bool Info = result > 0 ? true : false;
            //bool Info_1 = result_1 > 0 ? true : false;
            //bool Info_2 = result_2 > 0 ? true : false;

            if (Info || Info_1 || Info_2)
            {
                MessageBox.Show("用户信息保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("用户信息保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        DataSet ds;
        int count = 0;//记录数据库有多少行
        //查询用户信息
        private void btnQueryData_1_Click(object sender, EventArgs e)
        {
            //提示用户输入姓名
            string name = this.txtUserName_2.Text;
            if (name == "")
            {
                MessageBox.Show("请输入需要查询的用户姓名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //连接数据库，查询数据
            Data();
            //连接表
            DataTable dt = ds.Tables[0];
            this.dataGridView1.DataSource = dt;//调用数据库表到这个DataGridView控件中
        }

        private void Data()
        {
            DBHelp help = new DBHelp();
            string sql = "select u.CardNumber, u.UserName, u.UserGender, u.UserAge, t.TopupMoney, t.TopupTime from UserInfo u join Top_up t on u.CardNumber = t.CardNumber where u.UserName='{0}'";
            sql = string.Format(sql, txtUserName_2.Text);

            ds = help.SetData(sql);
            count = ds.Tables[0].Rows.Count;//记录数据库有多少行

            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("数据库不存在该用户的基本信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName_2.Text = "";
                return;
            }
            else
            {
                ////如果用户查询信息“成功”,则跳出查询的信息
                //MessageBox.Show("用户信息查询成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //删除用户信息
        private void tsDelecte_Click(object sender, EventArgs e)
        {
            string sql = "delete from UserInfo where UserName='{0}'";//与数据库表进行“级联”
            sql = string.Format(sql, txtUserName_2.Text);

            //判断用户是否删除成功
            DBHelp help = new DBHelp();
            bool Info = help.SelectData(sql);
            //int result = help.UpData(sql);
            //bool Info = result > 0 ? true : false;

            if (Info)
            {
                MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
