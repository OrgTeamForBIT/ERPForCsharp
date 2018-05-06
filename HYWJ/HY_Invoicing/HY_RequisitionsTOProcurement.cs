/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:  请购单抛采购单
 */
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

namespace HYWJ.HY_Invoicing
{
    public partial class HY_RequisitionsTOProcurement : Office2007Form
    {
        public HY_RequisitionsTOProcurement()
        {
            InitializeComponent();
        }

        private void HY_RequisitionsTOProcurement_Load(object sender, EventArgs e)
        {
            
        }
    
        private void btnQG_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Invoicing.HY_RequisitionNO hyreqtion = new HY_RequisitionNO();
            hyreqtion.hyreqtiontoproc = this;
            hyreqtion.ShowDialog();
        }
        /// <summary>
        /// 自定义返回请购单号(跨窗口传值定义)
        /// </summary>
        /// <param name="DID">请购单号</param>
        public void q_Requisitions(string DID)
        {
            this.q_DID.Text = DID;
        }

        private void btnTO_Click(object sender, EventArgs e)
        {   
            string did = this.q_DID.Text.Trim();
            if (did == string.Empty)
            {
                MessageBoxEx.Show("请输入请购单号后在执行抛单！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.q_DID.Focus();
                return;
            }
            HY_BLL.HY_RequisitionInfoBLL hyrepinfobll = new HY_RequisitionInfoBLL();
            did = did.Replace("QG", "CG");
            string fsq0 = "select r_DID,r_Supplier,r_State from HY_RequisitionInfo where r_DID='" + this.q_DID.Text.Trim() + "'";
            string fsql = "select c_DID from HY_ProcurementInfo where c_DID='" + did + "'";
            DataTable fh = hyrepinfobll.ExecuteQuery(fsq0);
            DataTable f = hyrepinfobll.ExecuteQuery(fsql);
            if (fh.Rows.Count > 0)
            {
                if (fh.Rows[0][1].ToString() == string.Empty)
                {
                    MessageBoxEx.Show("此请购单供应商等信息没有添加,请添加后抛单！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.q_DID.Text = "";
                    return;
                }
                if (fh.Rows[0][2].ToString() == "确认中")
                {
                    MessageBoxEx.Show("此请购单等待确认中，确认后方可操作！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.q_DID.Text = "";
                    return;
                }
            }
            if (f.Rows.Count > 0)
            {
                MessageBoxEx.Show("此请购单已抛转成采购单无需重复抛单！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.q_DID.Text = "";
            }
            else
            {
                string sql = "insert into HY_ProcurementInfo(c_DID,c_CID,c_Department,c_Person,c_Name,c_NameID,c_Supplier,c_Origin,c_QDate,c_XDate,c_Specifications,c_Units,c_Uses,c_Notes,c_Hot,c_Amount,c_ModClass) select REPLACE(r_DID,'QG','CG'),r_CID,r_Department,r_Person,r_Name,r_NameID,r_Supplier,r_Origin,r_QDate,r_XDate,r_Specifications,r_Units,r_Uses,r_Notes,r_Hot,r_Amount,r_ModClass from HY_RequisitionInfo WHERE r_DID='" + this.q_DID.Text.Trim() + "'";
                int res = hyrepinfobll.com_ExecuteQuery(sql);
                if (res > 0)
                {
                    MessageBoxEx.Show("恭喜：请购单抛转采购单成功！", "提示", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

    }
}