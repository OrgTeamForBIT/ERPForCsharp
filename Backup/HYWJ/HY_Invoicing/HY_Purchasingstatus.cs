/*  
 * 作者: JOY 
 * 创建时间: 2010-03-01 10:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   采购状况明细信息主窗体
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
    public partial class HY_Purchasingstatus : Office2007Form
    {
        private string sql = "select c_DID,max(c_CID),max(c_Supplier),max(c_State) from HY_ProcurementInfo GROUP BY c_DID";
        private HY_BLL.HY_RequisitionInfoBLL hyrepinfobll;
        public HY_Purchasingstatus()
        {
            InitializeComponent();
            hyrepinfobll = new HY_RequisitionInfoBLL();
        }

        private void HY_Purchasingstatus_Load(object sender, EventArgs e)
        {          
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
                lv.SubItems.Add(sdr[2].ToString());
                lv.SubItems.Add(sdr[3].ToString());
                if (sdr[3].ToString() ==string.Empty)
                {
                    lv.ImageIndex = 0;
                }
                if (sdr[3].ToString()== "1")
                {
                    lv.ImageIndex = 1;
                }
                if (sdr[3].ToString() == "2")
                {
                    lv.ImageIndex = 2;
                }
                if (sdr[3].ToString() == "3")
                {
                    lv.ImageIndex = 3;
                }
                this.listView1.Items.Add(lv);
            }
        }
        private string mainvalue;      //传给子窗体的值
        private string supplier;      //传给子窗体的值供应商
        private string modelID;     //厂内编号（模号）

        //模号
        public string ModelID
        {
            get { return modelID; }
            set { modelID = value; }
        }
        //供应商
        public string HYSupplier
        {
            get { return supplier; }
            set { supplier = value; }
        }
        //跨窗体传值属性
        public string GetMainvalue
        {
            get { return mainvalue; }
            set { mainvalue = value; }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            HYSupplier = this.listView1.SelectedItems[0].SubItems[2].Text;//窗口传值将变量赋值给方法
            GetMainvalue = this.listView1.SelectedItems[0].SubItems[0].Text;//窗口传值将变量赋值给方法
            ModelID = this.listView1.SelectedItems[0].SubItems[1].Text;//窗口传值将变量赋值给方法
            string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
            this.groupPanel2.Text = str_DID + "采购单产品列表";
            this.dataGridViewCGMX.AutoGenerateColumns = false;// 关闭自动创建列
            string sql = "select * from HY_ProcurementInfo where c_DID='" + str_DID + "'";
            this.dataGridViewCGMX.DataSource = hyrepinfobll.ExecuteQuery(sql);

            string sql1 = "select distinct c_Supplier from HY_ProcurementInfo where c_DID='" + str_DID + "'";
            this.Supplier.DataSource = hyrepinfobll.ExecuteQuery(sql1);
            this.Supplier.DisplayMember = "c_Supplier";
        }

        private void key_TextChanged(object sender, EventArgs e)
        {
            string k = this.key.Text.Trim();
            string sql = "select c_DID,max(c_CID),max(c_Supplier),max(c_State) from HY_ProcurementInfo GROUP BY c_DID,c_CID HAVING c_DID like '%" + k + "%' or c_CID like '%" + k + "%'";
            this.listView1.Items.Clear();
            requistionDate(sql);
        }

        private void btnCG_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("请选择采购单后在操作", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.key.Text="";
        }
        //筛选记录
        private void btnSX_Click(object sender, EventArgs e)
        {
            if (this.Supplier.Text != string.Empty)
            {
                HYSupplier = this.Supplier.Text;
                GetMainvalue = this.listView1.SelectedItems[0].SubItems[0].Text;//窗口传值将变量赋值给方法
                string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
                string sup = this.Supplier.Text;
                this.groupPanel2.Text = str_DID + "采购单产品列表";
                this.dataGridViewCGMX.AutoGenerateColumns = false;// 关闭自动创建列
                HY_BLL.HY_RequisitionInfoBLL hyrepinfobll = new HY_RequisitionInfoBLL();
                string sql = "select * from HY_ProcurementInfo where c_DID='" + str_DID + "' and c_Supplier='" + sup + "'";
                this.dataGridViewCGMX.DataSource = hyrepinfobll.ExecuteQuery(sql);
            }
            
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("请选择采购单后在操作", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.paneStat.Visible = true;
                this.groupPanel1.Enabled = false;
                this.did.Text = this.listView1.SelectedItems[0].SubItems[0].Text;
                this.Statr.Text = this.listView1.SelectedItems[0].SubItems[3].Text;
                if (this.Statr.Text == string.Empty)
                {
                    this.btnCGZ.Enabled = true;
                    this.btnBHZ.Enabled = false;
                    this.btnYDH.Enabled = false;
                }
                if (this.Statr.Text =="1")
                {
                    this.btnCGZ.Enabled = false;
                    this.btnYDH.Enabled = false;
                    this.btnBHZ.Enabled = true;
                    this.cgok.Text = "采购物料正在处理中";
                }
                if (this.Statr.Text == "2")
                {            
                    this.btnCGZ.Enabled = false;
                    this.btnBHZ.Enabled = false;
                    this.btnYDH.Enabled = true;
                    this.cgok.Text = "采购物料正在备货中";
                }
                if (this.Statr.Text == "3")
                {
                    this.btnCGZ.Enabled = false;
                    this.btnBHZ.Enabled = false;
                    this.btnYDH.Enabled = false;
                    this.cgok.Text = "采购单已完成产品已到货";
                }


            }
            
        }
        //隐藏采购单状态
        private void reflectionImage1_Click(object sender, EventArgs e)
        {
            this.paneStat.Visible = false;
            this.groupPanel1.Enabled = true;
        }
        //采购中状态
        private void btnCGZ_Click(object sender, EventArgs e)
        {
            string sqlcgz = "Update HY_ProcurementInfo set  c_State=1 where c_DID='"+this.did.Text+"'";
            int res=hyrepinfobll.com_ExecuteQuery(sqlcgz);
            if (res > 0)
            {
                MessageBoxEx.Show("采购状态确认成功", "错误提示", MessageBoxButtons.OK);
                this.paneStat.Visible = false;
                this.Close();
            }

        }
        //备货中状态
        private void btnBHZ_Click(object sender, EventArgs e)
        {
            string sqlbhz = "Update HY_ProcurementInfo set  c_State=2 where c_DID='" + this.did.Text + "'";
            int res = hyrepinfobll.com_ExecuteQuery(sqlbhz);
            if (res > 0)
            {
                MessageBoxEx.Show("备货状态确认成功", "错误提示", MessageBoxButtons.OK);
                this.paneStat.Visible = false;
                this.Close();
            }
        }
        //已到货状态
        private void btnYDH_Click(object sender, EventArgs e)
        {
            string sqlydh = "Update HY_ProcurementInfo set  c_State=3 where c_DID='" + this.did.Text + "'";
            int res = hyrepinfobll.com_ExecuteQuery(sqlydh);
            if (res > 0)
            {
                MessageBoxEx.Show("已到货状态确认成功", "错误提示", MessageBoxButtons.OK);
                this.paneStat.Visible = false;
                this.Close();
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("请选择采购单后在操作", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
                HYWJ.HY_Report.HY_PurchasingdetailsDH hyrepdh = new HYWJ.HY_Report.HY_PurchasingdetailsDH();
                hyrepdh.Owner = this;
                hyrepdh.ShowDialog();//对话框模式窗口
                hyrepdh.Dispose();
            }
        }
    }
}
