/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   用户信息主窗体
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using HY_DbSqlHelp;
using HY_BLL;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HYWJ.HY_Warehouse
{
    public partial class HY_Person : Office2007Form
    {
        public HY_Person()
        {
            InitializeComponent();
        }
        public HY_Storage hystor;//实例化请购信息窗口实行跨窗口传值

        private void HY_Person_Load(object sender, EventArgs e)
        {
            string sql = "select h_ID,h_UserName,h_yUserPwd,h_Permissions,h_Status,h_Department from HY_user";
            requistionDate(sql);
        }
        //自定义绑定数据
        private void requistionDate(string sql)
        {
            HY_BLL.HY_UserListBLL hyul = new HY_UserListBLL();
            this.listView1.View = View.Details;
            this.listView1.FullRowSelect = true;
            SqlDataReader sdr = hyul.f_hyUserLiset(sql);
            while (sdr.Read())
            {
                ListViewItem lv = new ListViewItem(sdr[0].ToString());
                lv.SubItems.Add(sdr[1].ToString());
                lv.SubItems.Add(sdr[5].ToString());
                this.listView1.Items.Add(lv);
            }

        }
        private void key_TextChanged(object sender, EventArgs e)
        {
            string k = this.key.Text.Trim();
            string sql = "select h_ID,h_UserName,h_yUserPwd,h_Permissions,h_Status,h_Department from HY_user where h_UserName like '" + k + "%'";
            this.listView1.Items.Clear();//清空项
            requistionDate(sql);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string str_name = this.listView1.SelectedItems[0].SubItems[1].Text;
            hystor.f_Person(str_name);
            this.Close();
        }
    }
}
