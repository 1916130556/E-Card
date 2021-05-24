using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace E_Card
{
    class DBHelp
    {
        //string connString = @"server=307学生-0046\SQLEXPRESS; initial catalog=eeeeee; Integrated Security=true";
        string connString = @"server=LAPTOP-RSHOJC20; initial catalog=eeeeee; Integrated Security=true";
        SqlConnection conn;

        //打开数据库
        public void Open()
        {
            if (conn == null)
            {
                conn = new SqlConnection(connString);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            //如果连接中断，则重启连接
            if (conn.State == ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
        }

        //关闭数据库
        public void Close()
        {
            if (conn == null)
            {
                return;
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        //非断开式连接
        public SqlDataReader GetData(string sql)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader read = cmd.ExecuteReader();
            return read;
        }

        //断开式连接
        public DataSet SetData(string sql)
        {
            Open();   
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(ds);
            Close();
            return ds;
        }

        //表格式
        public DataTable QueryData(string sql)
        {
            Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(ds);
            Close();
            return ds.Tables[0];
        }

        //返回受影响的行数，增删改查
        public int UpData(string sql)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int retult = cmd.ExecuteNonQuery();
            return retult;
        }

        //返回受影响的行数，增删改查，判断
        public bool SelectData(string sqlStr)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            int result = cmd.ExecuteNonQuery();
            Close();
            return result > 0;
        }
    }
}
