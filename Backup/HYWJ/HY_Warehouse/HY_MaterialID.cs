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
using HY_BLL;

namespace HYWJ.HY_Warehouse
{
    public partial class HY_MaterialID : Office2007Form
    {
        public HYWJ.HY_Warehouse.HY_Requisitioned hyreq;//实例化物料领用信息窗口实行跨窗口传值
        private HY_BLL.HY_ProductionPlanningBLL hypro;
        public HY_MaterialID()
        {
            InitializeComponent();
            hypro = new HY_BLL.HY_ProductionPlanningBLL();
        }

        private void HY_MaterialID_Load(object sender, EventArgs e)
        {
            string sql = "select s_ID,s_PID,s_Pname,s_Specifications,s_Price,s_Class,s_Warehouse,s_CID from HY_Storage order by s_ID desc";
            selectlistViewDate(sql);
        }
        // 自定义绑定listView
        private void selectlistViewDate(string sql)
        {
            this.toolStripClass.SelectedIndex = 0;
            this.listViewXS.View = View.Details;
            this.listViewXS.GridLines=true;// 显示网格线
            this.listViewXS.FullRowSelect = true;         
            SqlDataReader sdr = hypro.f_ProductionPlanningslist(sql);
            while (sdr.Read())
            {
                ListViewItem lv = new ListViewItem(sdr[1].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                lv.SubItems.Add(sdr[3].ToString());
                lv.SubItems.Add(sdr[4].ToString());
                lv.SubItems.Add(sdr[5].ToString());
                lv.SubItems.Add(sdr[6].ToString());
                lv.SubItems.Add(sdr[7].ToString());
                this.listViewXS.Items.Add(lv);
            }
        }

        private void toolStripKey_TextChanged(object sender, EventArgs e)
        {
            string id = this.toolStripKey.Text.Trim();
            int cl =int.Parse( this.toolStripClass.SelectedIndex.ToString());
            switch (cl)
            { 
                case 0:
                  string sql1 = "select s_ID,s_PID,s_Pname,s_Specifications,s_Price,s_Class,s_Warehouse,s_CID from HY_Storage where s_Pname like '%" + id + "%' order by s_ID desc";
                  this.listViewXS.Items.Clear();
                  selectlistViewDate(sql1);
               break;

                case 1:
               string sql2 = "select s_ID,s_PID,s_Pname,s_Specifications,s_Price,s_Class,s_Warehouse,s_CID from HY_Storage where s_PID like '%" + id + "%' order by s_ID desc";
                  this.listViewXS.Items.Clear();
                  selectlistViewDate(sql2);
               break;
            
            }
            
        }

        private void listViewXS_DoubleClick(object sender, EventArgs e)
        {
            string str_pid = this.listViewXS.SelectedItems[0].SubItems[0].Text;
            string str_name = this.listViewXS.SelectedItems[0].SubItems[1].Text;
            string str_Specifications = this.listViewXS.SelectedItems[0].SubItems[2].Text;
            string str_Price = this.listViewXS.SelectedItems[0].SubItems[3].Text;
            string str_Class = this.listViewXS.SelectedItems[0].SubItems[4].Text;
            string str_Warehouse = this.listViewXS.SelectedItems[0].SubItems[5].Text;
            string str_CID = this.listViewXS.SelectedItems[0].SubItems[6].Text;
            hyreq.r_PName(str_pid, str_CID, str_name, str_Specifications, str_Price, str_Class, str_Warehouse);
            this.Close();
        }
    }
}
