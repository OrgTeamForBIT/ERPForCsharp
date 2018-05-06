/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   供应商信息列表查询
 */  
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using HY_DbSqlHelp;
using HY_BLL;
using System.Data.SqlClient;

namespace HYWJ.HY_Invoicing
{
    public partial class HY_SupplierList : Office2007Form
    {
        public HY_SupplierList()
        {
            InitializeComponent();
        }

        private void HY_SupplierList_Load(object sender, EventArgs e)
        {

            HY_BLL.HY_SupplierBLL hysuplist = new HY_SupplierBLL();
            this.listView1.View = View.Details;
            this.listView1.FullRowSelect = true;
            string sql = "select s_gyName,s_jName,s_Area,s_Name,s_Tel,s_cpName from HY_Supplier";
            SqlDataReader sdr = hysuplist.f_SupplierLiset(sql);
            while (sdr.Read())
            {
                ListViewItem lv = new ListViewItem(sdr[0].ToString());
                lv.SubItems.Add(sdr[1].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                lv.SubItems.Add(sdr[3].ToString());
                lv.SubItems.Add(sdr[4].ToString());
                lv.SubItems.Add(sdr[5].ToString());
                lv.ImageIndex = 1;
                this.listView1.Items.Add(lv);
            }
        }
        //检索信息
        private void supSelect_Click(object sender, EventArgs e)
        {
            if (this.sType.SelectedIndex == -1)
            {
                MessageBox.Show("请选择检索条件","提示信息");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
     
    }
}
