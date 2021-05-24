using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Card
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //主窗体
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //退出
            Application.Exit();
        }

        //退出系统
        private void toolStripExit_Click(object sender, EventArgs e)
        {
            //弹出自定义对话框
            DialogResult result = MessageBox.Show("确定退出系统吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//DialogResult：消息框返回值
            //判断用户选择的按钮
            if (result == DialogResult.Yes)
            {
                //如果用户选择“Yes”，则执行窗体关闭事件
                Application.Exit();
            }
            else
            {
                //如果用户选择“No”，则取消窗体关闭事件
                e.Equals(CancelButton);
            }
        }
        private void labExit_Click(object sender, EventArgs e)
        {
            //弹出自定义对话框
            DialogResult result = MessageBox.Show("确定退出系统吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //判断用户选择的按钮
            if (result == DialogResult.Yes)
            {
                //如果用户选择“Yes”，则执行窗体关闭事件
                Application.Exit();
            }
            else
            {
                //如果用户选择“No”，则取消窗体关闭事件
                e.Equals(CancelButton);
            }
        }


        //实例化窗体
        frmUserInfo info = new frmUserInfo();
        frmUserConsumption consumption = new frmUserConsumption();
        frmUserRecharge recharge = new frmUserRecharge();

        //用户基本信息管理
        private void pbUserInfo_Click(object sender, EventArgs e)
        {
            info.Show();
            info.MdiParent = this;
            consumption.Hide();
            recharge.Hide();
        }

        //模拟地铁刷卡消费
        private void pbUserConsumption_Click(object sender, EventArgs e)
        {
            info.Hide();
            consumption.Show();
            consumption.MdiParent = this;
            recharge.Hide();
        }

        //充值及消费记录查询
        private void pbUserRecharge_Click(object sender, EventArgs e)
        {
            info.Hide();
            consumption.Hide();
            recharge.Show();
            recharge.MdiParent = this;
        }
    }
}
