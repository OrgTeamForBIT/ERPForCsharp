/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   采购信息主窗体
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
using HY_BLL;
using System.Data.SqlClient;
using HY_Model;

namespace HYWJ.HY_Invoicing
{
    public partial class HY_Purchasingdetails : Office2007Form
    {
        public HY_Purchasingdetails()
        {
            InitializeComponent();
        }

        private void HY_Purchasingdetails_Load(object sender, EventArgs e)
        {

            string sql = "select distinct c_DID,c_CID from HY_ProcurementInfo";
            requistionDate(sql);
        }
        //自定义绑定数据
        private void requistionDate(string sql)
        {
            
            HY_BLL.HY_ProcurementBLL hyul = new HY_ProcurementBLL();
            this.listView1.View = View.Details;
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;
            SqlDataReader sdr = hyul.f_RequisitionInfo(sql);
            while (sdr.Read())
            {
                ListViewItem lv = new ListViewItem(sdr[0].ToString());
                lv.SubItems.Add(sdr[1].ToString());
                this.listView1.Items.Add(lv);
            }
        }
        private string mainvalue;      //传给子窗体的值
        //跨窗体传值属性
        public string GetMainvalue
        {
            get { return mainvalue; }
            set { mainvalue = value; }
        }
        private void toolStripHY_Purchasing_Click(object sender, EventArgs e)
        {
            //string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
            HYWJ.HY_Report.HY_PurchasingdetailsReport hyrep = new HYWJ.HY_Report.HY_PurchasingdetailsReport();
            hyrep.Owner = this;
            hyrep.ShowDialog();//对话框模式窗口
            hyrep.Dispose();
        }

        private void btnMX_Click(object sender, EventArgs e)
        {
            //string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
            HYWJ.HY_Report.HY_PurchasingdetailsReport hyrep = new HYWJ.HY_Report.HY_PurchasingdetailsReport();
            hyrep.Owner = this;
            hyrep.ShowDialog();//对话框模式窗口
            hyrep.Dispose();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            
            GetMainvalue = this.listView1.SelectedItems[0].SubItems[0].Text;//窗口传值将变量赋值给方法
            string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
            this.groupPanel2.Text = str_DID + "采购单产品列表";
            this.dataGridViewCGMX.AutoGenerateColumns = false;// 关闭自动创建列
            HY_BLL.HY_RequisitionInfoBLL hyrepinfobll = new HY_RequisitionInfoBLL();
            string sql = "select * from HY_ProcurementInfo where c_DID='" + str_DID + "'";
            this.dataGridViewCGMX.DataSource = hyrepinfobll.ExecuteQuery(sql);
        }
        //输入框查询采购单
        private void key_TextChanged(object sender, EventArgs e)
        {
                string k = this.key.Text.Trim();
                string sql = "select distinct c_DID,c_CID from HY_ProcurementInfo where c_DID like '%" + k + "%'";
                this.listView1.Items.Clear();
                requistionDate(sql);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("请选择单号后在在操作", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
                HYWJ.HY_Report.HY_PurchasingdetailsReport hyrep = new HYWJ.HY_Report.HY_PurchasingdetailsReport();
                hyrep.Owner = this;
                hyrep.ShowDialog();//对话框模式窗口
                hyrep.Dispose();
            }

        }
        private void key_Enter(object sender, EventArgs e)
        {
            this.key.Text = "";
        }

        private void btnSO_Click(object sender, EventArgs e)
        {
            string sql = "select distinct c_DID,c_CID from HY_ProcurementInfo where c_DID='"+this.comDID.Text.Trim()+"'";
        }
    }
}
