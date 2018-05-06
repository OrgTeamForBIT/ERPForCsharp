using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using HY_BLL;

namespace HYWJ.HY_Invoicing
{
    public partial class HY_RequisitionsID : Office2007Form
    {
        public HY_Requisitions hyreq;//实例化窗体
        public HY_RequisitionsID()
        {
            InitializeComponent();
        }

        private void HY_RequisitionsID_Load(object sender, EventArgs e)
        {
            string sql = "select r_DID,max(r_ID),max(r_QDate),max(r_Person) from HY_RequisitionInfo group by r_DID";
            listViewDate(sql);
        }
        //自定义绑定listView数据
        private void listViewDate(string sql)
        {          
            HY_BLL.HY_ProcurementBLL hyul = new HY_ProcurementBLL();
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;
            SqlDataReader sdr = hyul.f_RequisitionInfo(sql);
            while (sdr.Read())
            {
                ListViewItem lv = new ListViewItem(sdr[1].ToString());
                lv.SubItems.Add(sdr[0].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                lv.SubItems.Add(sdr[3].ToString());
                this.listView1.Items.Add(lv);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string str_did = this.listView1.SelectedItems[0].SubItems[1].Text;
            hyreq.q_Qid(str_did);
            this.Close();
        }
    }
}
