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
    public partial class HY_SalesCID : Office2007Form
    {
        public HY_ProductionPlanning hyproduc;//实例化请购信息窗口实行跨窗口传值
        public HY_SalesCID()
        {
            InitializeComponent();
        }
        private void listViewXS_DoubleClick(object sender, EventArgs e)
        {
            string str_Number = this.listViewXS.SelectedItems[0].SubItems[1].Text;
            string str_FID = this.listViewXS.SelectedItems[0].SubItems[2].Text;
            hyproduc.p_NumberC(str_Number, str_FID);
            this.Close();
        }

        private void HY_SalesCID_Load_1(object sender, EventArgs e)
        {
            HY_BLL.HY_ProductionPlanningBLL hypro = new HY_BLL.HY_ProductionPlanningBLL();
            this.listViewXS.View = View.Details;
            this.listViewXS.FullRowSelect = true;
            string sql = "select o_ID,o_DID,o_FID,o_Person,o_RDate from HY_CustomerOrder order by o_ID desc";
            SqlDataReader sdr = hypro.f_ProductionPlanningslist(sql);
            while (sdr.Read())
            {
                ListViewItem lv = new ListViewItem(sdr[0].ToString());
                lv.SubItems.Add(sdr[1].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                lv.SubItems.Add(sdr[3].ToString());
                lv.SubItems.Add(sdr[4].ToString());
                this.listViewXS.Items.Add(lv);
            }
        }
    }
}
