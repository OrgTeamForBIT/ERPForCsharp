using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using HY_BLL;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HYWJ.HY_Production
{
    public partial class HY_BomTORequisitionID : Office2007Form
    {
        public HYWJ.HY_Production.HY_BomTORequisitions hybomtor;//实例化窗体
        public HY_BomTORequisitionID()
        {
            InitializeComponent();
        }

        private void HY_BomTORequisitionID_Load(object sender, EventArgs e)
        {
            string sql = "select b_SKID,b_Audit from HY_BomInfo order by b_ID desc";
            requistionDate(sql);
        }
        private void  requistionDate(string sql)
        {
            HY_BLL.HY_BomDetailsBLL hyul = new HY_BomDetailsBLL();
            this.listView1.View = View.Details;
            this.listView1.FullRowSelect = true;
            SqlDataReader sdr = hyul.f_SQLBom(sql);
            while (sdr.Read())
            {
                string st = sdr[1].ToString();
                ListViewItem lv = new ListViewItem(sdr[0].ToString());
                if (st != string.Empty)
                {
                    lv.SubItems.Add("已审核");
                }
                else
                {
                    lv.SubItems.Add("未审核");
                }
                this.listView1.Items.Add(lv);
            }
        }
        private void key_TextChanged(object sender, EventArgs e)
        {
            string k = this.key.Text.Trim();
            string sql = "select b_SKID from HY_BomInfo where b_SKID like '%" + k + "%'";
            this.listView1.Items.Clear();//清空项
            requistionDate(sql);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
            string st = this.listView1.SelectedItems[0].SubItems[1].Text;
            if (st == "未审核")
            {
                MessageBoxEx.Show("此单还未经部门经理审核不能转单", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                hybomtor.f_BomID(str_DID);
                this.Close();
            }
        }
    }
}
