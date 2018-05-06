using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HY_BLL;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using HY_Model;


namespace HYWJ.HY_Production
{
    public partial class HY_Person : Office2007Form
    {
        public HY_Bomlist hybom;//实例化请购信息窗口实行跨窗口传值
        public HY_Person()
        {
            InitializeComponent();
        }

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
        //查询用户
        private void key_TextChanged(object sender, EventArgs e)
        {
            string k = this.key.Text.Trim();
            string sql = "select h_ID,h_UserName,h_yUserPwd,h_Permissions,h_Status,h_Department from HY_user where h_UserName like '%" + k + "%'";
            this.listView1.Items.Clear();//清空项
            requistionDate(sql);
        }
        //跨窗体传值
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string str_name = this.listView1.SelectedItems[0].SubItems[1].Text;
            string str_dep = this.listView1.SelectedItems[0].SubItems[2].Text;
            hybom.q_Person(str_name, str_dep);
            this.Close();
        }
        //清空文本框
        private void key_Enter(object sender, EventArgs e)
        {
            this.key.Text = "";
        }
    }
}
