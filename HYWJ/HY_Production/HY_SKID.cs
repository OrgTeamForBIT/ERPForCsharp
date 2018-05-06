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

namespace HYWJ.HY_Production
{
    public partial class HY_SKID : Office2007Form
    {
        public HY_SKID()
        {
            InitializeComponent();
        }
        public HY_BomDetails hybomdet;//实例化BOM明细窗口实行跨窗口传值
        private void HY_SKID_Load(object sender, EventArgs e)
        {
            string sql = "select b_ID,b_SKID,b_CID,b_ModClass from HY_BomInfo order by b_ID desc";
            requistionDate(sql);
        }
        private void requistionDate(string sql)
        {           
            HY_BLL.HY_BomlistBLL hybombll = new HY_BLL.HY_BomlistBLL();
            this.listView1.View = View.Details;
            this.listView1.FullRowSelect = true;
            SqlDataReader sdr = hybombll.f_Bomlist(sql);
            while (sdr.Read())
            {
                ListViewItem lv = new ListViewItem(sdr[0].ToString());
                lv.SubItems.Add(sdr[1].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                lv.SubItems.Add(sdr[3].ToString());
                this.listView1.Items.Add(lv);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string str_ID = this.listView1.SelectedItems[0].SubItems[1].Text;
            hybomdet.b_SKID(str_ID);
            this.Close();
        }

        private void key_TextChanged(object sender, EventArgs e)
        {
            string k = this.key.Text.Trim();
            string sql = "select b_ID,b_SKID,b_CID,b_ModClass from HY_BomInfo where b_SKID like '%" + k + "%' or b_CID like '%" + k + "%'";
            this.listView1.Items.Clear();//清空项    
            requistionDate(sql);
        }
    }
}
