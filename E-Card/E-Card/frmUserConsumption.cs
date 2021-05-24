using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Card
{
    public partial class frmUserConsumption : Form
    {
        public frmUserConsumption()
        {
            InitializeComponent();
        }

        //填写用户信息
        private void btnQueryData_3_Click(object sender, EventArgs e)
        {
            //查询用户信息
            string sql = "select UserName, UserGender, UserAge from UserInfo where CardNumber='{0}'";
            sql = string.Format(sql, txtCardNumber_3.Text);
            DBHelp help = new DBHelp();
            DataTable dt = new DataTable();
            dt = help.QueryData(sql);

            //将数据库的值提到C#中
            int card = int.Parse(txtCardNumber_3.Text);

            //进行判断
            string sql_1 = "select CardNumber from UserInfo where CardNumber='{0}'";
            sql_1 = string.Format(sql_1, txtCardNumber_3.Text);
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
            txtUserName_3.Text = dt.Rows[0][0].ToString();
            cbGender_3.Text = dt.Rows[0][1].ToString();
            txtUserAge_3.Text = dt.Rows[0][2].ToString();
        }


        //进站口
        private void cbInto_SelectedIndexChanged(object sender, EventArgs e)//SelectedIndexChanged：更改所选的索引
        {
            //进出口站的编号(索引)
            int i = cbInto.SelectedIndex;//SelectedIndex：获取或设置指定当前选定项的索引；返回结果：当前选定的从0开始的索引，如果未选定任何项，则返回值为负(-1)
            int j = cbOut.SelectedIndex;

            //清除出口站的内容
            this.cbOut.Items.Clear();

            //根据出站口的选择来判断
            switch (i)
            {
                case 0:
                    cbOut.Items.Add("杨家湾站");
                    cbOut.Items.Add("街道站口");
                    cbOut.Items.Add("长春观战");
                    cbOut.Items.Add("螃蟹岬战");
                    cbOut.Items.Add("江汉路站");
                    cbOut.Items.Add("武汉广场站");
                    cbOut.Items.Add("新华露体育馆站");
                    cbOut.Items.Add("汉口火车站");
                    break;
                case 1:
                    cbOut.Items.Add("街道站口");
                    cbOut.Items.Add("长春观战");
                    cbOut.Items.Add("螃蟹岬战");
                    cbOut.Items.Add("江汉路站");
                    cbOut.Items.Add("武汉广场站");
                    cbOut.Items.Add("新华露体育馆站");
                    cbOut.Items.Add("汉口火车站");
                    break;
                case 2:
                    cbOut.Items.Add("长春观战");
                    cbOut.Items.Add("螃蟹岬战");
                    cbOut.Items.Add("江汉路站");
                    cbOut.Items.Add("武汉广场站");
                    cbOut.Items.Add("新华露体育馆站");
                    cbOut.Items.Add("汉口火车站");
                    break;
                case 3:
                    cbOut.Items.Add("螃蟹岬战");
                    cbOut.Items.Add("江汉路站");
                    cbOut.Items.Add("武汉广场站");
                    cbOut.Items.Add("新华露体育馆站");
                    cbOut.Items.Add("汉口火车站");
                    break;
                case 4:
                    cbOut.Items.Add("江汉路站");
                    cbOut.Items.Add("武汉广场站");
                    cbOut.Items.Add("新华露体育馆站");
                    cbOut.Items.Add("汉口火车站");
                    break;
                case 5:
                    cbOut.Items.Add("武汉广场站");
                    cbOut.Items.Add("新华露体育馆站");
                    cbOut.Items.Add("汉口火车站");
                    break;
                case 6:
                    cbOut.Items.Add("新华露体育馆站");
                    cbOut.Items.Add("汉口火车站");
                    break;
                case 7:
                    cbOut.Items.Add("汉口火车站");
                    break;
                default:
                    MessageBox.Show("输入有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }


        //出站口
        private void cbOut_SelectionChangeCommitted(object sender, EventArgs e)//SelectionChangeCommitted：更改已提交的选择
        {
            //通过进出站口，进行金额计算
            int i = cbInto.SelectedIndex;
            int j = cbOut.SelectedIndex;

            //计算金额
            switch (i)
            {
                case 0:
                    int sumMoney = (j + 1 - i) * 2;
                    txtCost_1.Text = sumMoney.ToString();
                    break;
                case 1:
                    sumMoney = (j + 2 - i) * 2;
                    txtCost_1.Text = sumMoney.ToString();
                    break;
                case 2:
                    sumMoney = (j + 3 - i) * 2;
                    txtCost_1.Text = sumMoney.ToString();
                    break;
                case 3:
                    sumMoney = (j + 4 - i) * 2;
                    txtCost_1.Text = sumMoney.ToString();
                    break;
                case 4:
                    sumMoney = (j + 5 - i) * 2;
                    txtCost_1.Text = sumMoney.ToString();
                    break;
                case 5:
                    sumMoney = (j + 6 - i) * 2;
                    txtCost_1.Text = sumMoney.ToString();
                    break;
                case 6:
                    sumMoney = (j + 7 - i) * 2;
                    txtCost_1.Text = sumMoney.ToString();
                    break;
                case 7:
                    sumMoney = (j + 8 - i) * 2;
                    txtCost_1.Text = sumMoney.ToString();
                    break;
                case 8:
                    sumMoney = (j + 9 - i) * 2;
                    txtCost_1.Text = sumMoney.ToString();
                    break;
                default:
                    break;
            }
        }


        //生成消费记录
        private void btnConsumption_Click(object sender, EventArgs e)
        {
            //将数据库的值提到C#中
            int cost = int.Parse(txtCost_1.Text);

            //插入数据
            string sql = "insert into Subway(Entrance, Exitof, Cost, Time, CardNumber) values ('{0}', '{1}', {2}, '{3}', '{4}')";
            sql = string.Format(sql, cbInto.Text, cbOut.Text, 0-cost, labelTime_2.Text, txtCardNumber_3.Text);

            DBHelp help = new DBHelp();
            bool Info = help.SelectData(sql);
            //int result = help.UpData(sql);
            //bool Info = result > 0 ? true : false;

            if (Info)
            {
                //对Top_upMoney：查询，更新，赋值
                string sql_2 = "select t.TopupMoney+s.Cost Money from Top_up t join Subway s on t.CardNumber = s.CardNumber where t.CardNumber = '{0}'";
                sql_2 = string.Format(sql_2, txtCardNumber_3.Text);
                SqlDataReader reader = help.GetData(sql_2);
                int read_1 = 0;
                while (reader.Read())
                {
                    read_1 = Convert.ToInt32(reader["Money"]);
                }
                reader.Close();
                string sql_3 = "update Top_up set TopupMoney='{0}' where CardNumber = '{1}'";
                sql_3 = string.Format(sql_3, read_1, txtCardNumber_3.Text);
                help.UpData(sql_3);

                MessageBox.Show("已经生成消费记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("生成消费记录失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //清空数据
        private void btnEmpty_Click(object sender, EventArgs e)
        {
            this.txtCardNumber_3.Clear();
            this.txtUserName_3.Clear();
            this.cbGender_3.SelectedIndex = -1;
            this.txtUserAge_3.Clear();
            this.cbInto.Text = "";
            this.cbOut.Text = "";
            this.txtCost_1.Clear();
        }

        //主窗体
        private void frmUserConsumption_Load(object sender, EventArgs e)
        {
            this.Time.Start();
        }

        //时间
        private void Time_Tick(object sender, EventArgs e)
        {
            this.labelTime_2.Text = DateTime.Now.ToString();
            this.labelTime_2.Visible = false;
        }

    }
}
