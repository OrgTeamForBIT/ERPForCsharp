using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HYWJ.HY_Business
{
    public partial class HY_Customer : Office2007Form
    {
        private HY_BLL.HY_CustomerInfoBLL hypro;
        public HY_CustomerOrder hycustomer;// 跨窗体
        public HY_Customer()
        {
            InitializeComponent();
            hypro = new HY_BLL.HY_CustomerInfoBLL();
        }

        private void HY_Customer_Load(object sender, EventArgs e)
        {
            string sql = "select * from HY_CustomerInfo order by c_ID desc";
            requistionDate(sql);
        }
         //自定义绑定数据
        private void requistionDate(string sql)
        {
            this.listViewCS.View = View.Details;
            this.listViewCS.FullRowSelect = true;
            SqlDataReader sdr = hypro.f_CustomerInfolist(sql);
            while (sdr.Read())
            {
                ListViewItem lv = new ListViewItem(sdr[0].ToString());
                lv.SubItems.Add(sdr[1].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                this.listViewCS.Items.Add(lv);
            }
        }

        private void key_TextChanged(object sender, EventArgs e)
        {
            string k = this.key.Text.Trim();
            this.listViewCS.Items.Clear();//清空项
            string sql = "select * from HY_CustomerInfo where c_Name like '%" + k + "%' or c_FID like '%"+k+"%'";
            requistionDate(sql);
        }

        private void listViewCS_DoubleClick(object sender, EventArgs e)
        {
            string str_name = this.listViewCS.SelectedItems[0].SubItems[1].Text;
            string str_id = this.listViewCS.SelectedItems[0].SubItems[2].Text;
            hycustomer.f_Name(str_name, str_id);
            this.Close();
        }
    }
}
