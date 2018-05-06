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
    public partial class HY_BomTORequisitions : Office2007Form
    {
        public HY_BomTORequisitions()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 自定义返回请购单号(跨窗口传值定义)
        /// </summary>
        /// <param name="DID">请购单号</param>
        public void f_BomID(string BID)
        {
            this.b_BID.Text = BID;
        }
        private void btnQG_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Production.HY_BomTORequisitionID hybomtoreq = new HY_BomTORequisitionID();
            hybomtoreq.hybomtor = this;
            hybomtoreq.ShowDialog();

        }

        private void HY_BomTORequisitions_Load(object sender, EventArgs e)
        {

        }

        private void btnTO_Click(object sender, EventArgs e)
        {
            string did = this.b_BID.Text.Trim();
            if (did == string.Empty)
            {
                MessageBoxEx.Show("请输入物料单号！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.b_BID.Focus();
                return;
            }
            did = did.Replace("B", "QG");
            HY_BLL.HY_BomDetailsBLL hybom = new HY_BomDetailsBLL();
            string sql = "select b_HDate from HY_BomInfo where b_SKID='" + did + "'";
            SqlDataReader sdr = hybom.f_SQLBom(sql);
            while (sdr.Read())
            {
                if (sdr[0].ToString() == string.Empty)
                {
                    MessageBoxEx.Show("此物料单还未审核,请部门经理审核后再抛单", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            HY_BLL.HY_RequisitionInfoBLL hyrepinfobll = new HY_RequisitionInfoBLL();
            string fsql = "select * from HY_RequisitionInfo where r_DID='" + did + "'";
            DataTable f = hyrepinfobll.ExecuteQuery(fsql);
            if (f.Rows.Count > 0)
            {
                MessageBox.Show("此请购单已抛转成采购单无需重复抛单！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.b_BID.Text = "";
            }
            else
            {
                string sql2 = "insert into HY_RequisitionInfo(r_DID,r_CID,r_NameID,r_Name,r_Person,r_Origin,r_Specifications,r_Amount,r_Hot,r_Notes,r_QDate,r_ModClass) select REPLACE(d_SKID,'B','QG'),d_CID,d_PID,d_PName,d_SPerson,d_Model,d_Specifications,d_Amount,d_Heat,d_Notes,'" + DateTime.Now + "',d_ModClass from HY_BomDetails WHERE d_SKID='" + this.b_BID.Text.Trim() + "'";
                int res = hyrepinfobll.com_ExecuteQuery(sql2);
                if (res > 0)
                {
                    MessageBox.Show("恭喜：请购单抛转采购单成功！", "提示", MessageBoxButtons.OK);
                }
            }
        }
    }
}
