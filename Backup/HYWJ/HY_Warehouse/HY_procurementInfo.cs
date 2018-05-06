/*  
 * 作者: JOY 
 * 创建时间: 2009-12-30 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明: 采购信息入库主窗体
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
using System.Data.SqlClient;
using HY_BLL;
using HY_Model;

namespace HYWJ.HY_Warehouse
{
    public partial class HY_procurementInfo : Office2007Form
    {
        private HY_BLL.HY_StorageBLL hystorbll = null;
        public HY_Storage hystor;//实例化请购信息窗口实行跨窗口传值
        public HY_procurementInfo()
        {
            InitializeComponent();
            hystorbll = new HY_StorageBLL();
        }

        private void HY_procurementInfo_Load(object sender, EventArgs e)
        {
            string sql = "select c_DID,c_CID,c_Name,c_Supplier,c_Origin,c_Specifications,c_Units,c_Amount,c_State from HY_ProcurementInfo order by c_ID desc";
            requistionDate(sql);
            this.HY_Class.SelectedIndex = 0;
        }

        ////绑定产品类别
        //private void c_Class()
        //{
        //    string sql = "select c_ID,c_DID from HY_ProcurementInfo order by c_ID desc";
        //    this.s_DID.DataSource = hystorbll.ExecuteQuerySelect(sql);
        //    this.s_DID.DisplayMember = "c_DID";
        //    this.s_DID.ValueMember = "c_ID";
        //}
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
                lv.SubItems.Add(sdr[4].ToString());
                lv.SubItems.Add(sdr[5].ToString());
                lv.SubItems.Add(sdr[6].ToString());
                lv.SubItems.Add(sdr[7].ToString());
                lv.SubItems.Add(sdr[8].ToString());
                if (sdr[8].ToString() == string.Empty)
                {
                    lv.ImageIndex = 0;
                }
                if (sdr[8].ToString() == "1")
                {
                    lv.ImageIndex = 1;
                }
                if (sdr[8].ToString() == "2")
                {
                    lv.ImageIndex = 2;
                }
                if (sdr[8].ToString() == "3")
                {
                    lv.ImageIndex = 3;
                }
                this.listView1.Items.Add(lv);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string st =this.listView1.SelectedItems[0].SubItems[8].Text.ToString();
            if (st != "3")
            {
                MessageBoxEx.Show("此物料还未到货不能添加!","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            else
            {
                string c_CID = this.listView1.SelectedItems[0].SubItems[1].Text;
                string c_Name = this.listView1.SelectedItems[0].SubItems[2].Text;
                string c_Supplier = this.listView1.SelectedItems[0].SubItems[3].Text;
                string c_Origin = this.listView1.SelectedItems[0].SubItems[4].Text;
                string c_Specifications = this.listView1.SelectedItems[0].SubItems[5].Text;
                string c_Units = this.listView1.SelectedItems[0].SubItems[6].Text;
                string c_Amount = this.listView1.SelectedItems[0].SubItems[7].Text;
                hystor.f_Procinfo(c_CID, c_Name, c_Supplier, c_Origin, c_Specifications, c_Units, c_Amount);
                this.Close();
            }
        }
        //查询采购单
        private void btnSerch_Click(object sender, EventArgs e)
        {
            string c_did=this.HY_Class.Text.Trim();
            string key=this.Key.Text.Trim();
            if (key == string.Empty)
            {
                string sql1 = "select c_DID,c_CID,c_Name,c_Supplier,c_Origin,c_Specifications,c_Units,c_Amount,c_State from HY_ProcurementInfo where c_DID='" + c_did + "'";
                this.listView1.Items.Clear();
                requistionDate(sql1);
            }
            else if (this.HY_Class.SelectedIndex == 0)
            {
                string sql1 = "select c_DID,c_CID,c_Name,c_Supplier,c_Origin,c_Specifications,c_Units,c_Amount,c_State from HY_ProcurementInfo where c_CID like '%" + key + "%'";
                this.listView1.Items.Clear();
                requistionDate(sql1);
            }
            else if(this.HY_Class.SelectedIndex==1)
            {
                string sql1 = "select c_DID,c_CID,c_Name,c_Supplier,c_Origin,c_Specifications,c_Units,c_Amount,c_State from HY_ProcurementInfo where c_DID like '%" + key + "%'";
                this.listView1.Items.Clear();
                requistionDate(sql1);
            }
            else if (this.HY_Class.SelectedIndex == 2)
            {
                string sql1 = "select c_DID,c_CID,c_Name,c_Supplier,c_Origin,c_Specifications,c_Amount,c_State from HY_ProcurementInfo where c_Name like '%" + key + "%'";
                this.listView1.Items.Clear();
                requistionDate(sql1);
            }

        }

        private void btnCLOS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
