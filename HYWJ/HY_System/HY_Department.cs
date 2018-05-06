/*  
 * 作者: JOY 
 * 创建时间: 2009-10-20 09:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   基础数据设置
 */  
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HY_DbSqlHelp;

namespace HYWJ.HY_System
{
    public partial class HY_Department : Form
    {
        public HY_Department()
        {
            InitializeComponent();
        }

        private void dnCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //添加部门名称
        private void dnADD_Click(object sender, EventArgs e)
        {
            string dName = this.d_Name.Text.Trim();
            if (dName == string.Empty)
            {
                MessageBox.Show("部门名称不能为空!");
                this.d_Name.Focus();

            }
            string sql="insert into HY_Department(d_Name) values('"+dName+"')";
            HY_DbSqlHelp.DBsqlHelp hy_help = new DBsqlHelp();
            int res=hy_help.insertEx(sql);
            if (res > 0)
            {
               MessageBox.Show("添加成功!");
               lbHYList();
            }
        }

        private void HY_Department_Load(object sender, EventArgs e)
        {

            lbHYList();
           
        }

        private void lbHYList()
        {
            string sql = "select d_Name from HY_Department";
            HY_DbSqlHelp.DBsqlHelp hy_help = new DBsqlHelp();
            this.lbHY.DataSource = hy_help.ExecuteQuery(sql);
            this.lbHY.DisplayMember = "d_Name";
        }
    }
}
