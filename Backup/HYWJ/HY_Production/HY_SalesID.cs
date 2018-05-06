/*  
 * 作者: JOY 
 * 创建时间: 2009-12-23 10:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明: 客户订单号信息窗体
 */
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
    public partial class HY_SalesID : Office2007Form
    {
        private HY_BLL.HY_ProductionPlanningBLL hypro;
        public HY_SalesID()
        {
            InitializeComponent();
            hypro = new HY_BLL.HY_ProductionPlanningBLL();
        }
        public HY_ProductionPlanning hyproduc;//实例化请购信息窗口实行跨窗口传值
        private void HY_SalesID_Load(object sender, EventArgs e)
        {
            string sql = "select * from HY_ProductionPlanning order by p_ID desc";
            requistionDate(sql);
        }
        private void requistionDate(string sql)
        {
            this.listViewXS.View = View.Details;
            this.listViewXS.FullRowSelect = true;
            SqlDataReader sdr = hypro.f_ProductionPlanningslist(sql);
            while (sdr.Read())
            {
                ListViewItem lv = new ListViewItem(sdr[0].ToString());
                lv.SubItems.Add(sdr[1].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                this.listViewXS.Items.Add(lv);
            }
        }
        private void listViewXS_DoubleClick(object sender, EventArgs e)
        {
            string str_Number = this.listViewXS.SelectedItems[0].SubItems[1].Text;
            hyproduc.p_Number(str_Number);
            this.Close();
        }

        private void key_TextChanged(object sender, EventArgs e)
        {
            string k = this.key.Text.Trim();
            string sql = "select * from HY_ProductionPlanning where p_DID like '%"+k+"%'";
            this.listViewXS.Items.Clear();//清空项
            requistionDate(sql);
        }

        private void key_Enter(object sender, EventArgs e)
        {
            this.key.Text = "";
        }
    }
}
