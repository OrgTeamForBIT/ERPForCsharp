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

namespace HYWJ.HY_Invoicing
{
    public partial class HY_SupplierListSO : Office2007Form
    {
        public HY_SupplierListSO()
        {
            InitializeComponent();
        }

        public HY_Requisitions hyreq;//实例化请购信息窗口实行跨窗口传值
        private void HY_SupplierListSO_Load(object sender, EventArgs e)
        {
            string sql = "select s_gyName,s_jName,s_Area,s_Name,s_Tel,s_cpName from HY_Supplier";
            requistionDate(sql);
        }
        private void requistionDate(string sql)
        {
            HY_BLL.HY_SupplierBLL hysuplist = new HY_SupplierBLL();
            this.listView1.View = View.Details;
            this.listView1.FullRowSelect = true; 
            SqlDataReader sdr = hysuplist.f_SupplierLiset(sql);
            while (sdr.Read())
            {
                ListViewItem lv = new ListViewItem(sdr[0].ToString());
                lv.SubItems.Add(sdr[1].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                this.listView1.Items.Add(lv);
            }
        }
        private void key_TextChanged(object sender, EventArgs e)
        {
            string k = this.key.Text.Trim();
            string sql = "select s_gyName,s_jName,s_Area,s_Name,s_Tel,s_cpName from HY_Supplier where s_gyName like '%" + k + "%' or s_jName like '%" + k + "%'";
            this.listView1.Items.Clear();
            requistionDate(sql);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string str_name = this.listView1.SelectedItems[0].SubItems[0].Text;
            hyreq.q_Supplier(str_name);
            this.Close();
        }
        private void key_Enter(object sender, EventArgs e)
        {
            this.key.Text = "";
        }
    }
}
