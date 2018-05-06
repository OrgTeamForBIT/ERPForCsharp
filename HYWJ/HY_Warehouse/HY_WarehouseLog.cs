using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using HY_BLL;

namespace HYWJ.HY_Warehouse
{
    public partial class HY_WarehouseLog : Form
    {
        private HY_BLL.HY_ProductionPlanningBLL hypro;
        public HY_WarehouseLog()
        {
            InitializeComponent();
            hypro = new HY_BLL.HY_ProductionPlanningBLL();
        }

        private void HY_WarehouseLog_Load(object sender, EventArgs e)
        {
            string sql = "select s_DID,s_PID,s_Pname,s_Specifications,s_Price,s_Class,s_Warehouse,s_Amount,s_XDate,s_DDate,s_Notes,s_Person,s_State,s_CID from HY_StorageLog order by s_ID desc";
            selectlistViewDate(sql);
        }
        // 自定义绑定listView
        private void selectlistViewDate(string sql)
        {
            //this.toolStripClass.SelectedIndex = 0;
            this.listViewXS.View = View.Details;
            this.listViewXS.GridLines = true;// 显示网格线
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
                lv.SubItems.Add(sdr[8].ToString());
                lv.SubItems.Add(sdr[9].ToString());
                lv.SubItems.Add(sdr[10].ToString());
                lv.SubItems.Add(sdr[11].ToString());
                lv.SubItems.Add(sdr[12].ToString());
                this.listViewXS.Items.Add(lv);
               
            }
        }
    }
}
