/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明: 库存明细账主窗体
 */ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HY_BLL;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HYWJ.HY_Warehouse
{
    public partial class HY_StockAccount : Office2007Form
    {
        private HY_BLL.HY_StorageBLL hystorfobll;
        public HY_StockAccount()
        {
            InitializeComponent();
            hystorfobll = new HY_StorageBLL();
        }

        private void HY_StockAccount_Load(object sender, EventArgs e)
        {
            this.comboBoxClass.SelectedIndex = 0;
            string sql = "select s_ID,s_DID,s_CID,s_Supplier,s_Person,s_Class,s_Warehouse,s_XDate,s_DDate,s_PID,s_Pname,s_Origin,s_Specifications,s_Units,s_Amount,s_Price,s_Notes,s_WFDateHot,s_DWDateHot,s_WFHotSup,s_WFDate,s_DWDate,s_WFSup,s_WFDateBM,s_DWDateBM,s_WFSupBM,(s_Amount*s_Price) AS HJ from HY_Storage";
            requistionDate(sql);
            string sql0 = "select sum(s_Amount*s_Price) as PR,sum(s_Amount) as AM from HY_Storage";
            f_account(sql0);
        }
        //自定义绑定数据
        private void requistionDate(string sql)
        {
            this.dataGridViewCK.AutoGenerateColumns = false;// 关闭自动创建列      
            this.dataGridViewCK.DataSource = hystorfobll.ExecuteQuerySelect(sql);
        }
        //汇总库存数量金额
        private void f_account(string sql)
        {
            SqlDataReader sdr = hystorfobll.f_HY_Storagelist(sql);
            while (sdr.Read())
            {
                //this.label3.Text = string.Format("{0:N}",float.Parse(sdr["PR"].ToString()));
                this.label4.Text = sdr["AM"].ToString();
            }
        }

        private void 生成库存明细账ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //数据查询
        private void key_TextChanged(object sender, EventArgs e)
        {
            string id = this.key.Text.Trim();
            int cl = int.Parse(this.comboBoxClass.SelectedIndex.ToString());

            switch (cl)
            {
                case 0:
                    string sql1 = "select s_ID,s_DID,s_CID,s_Person,s_Class,s_Warehouse,s_XDate,s_DDate,s_PID,s_Pname,s_Specifications,s_Amount,s_Price,s_Notes from HY_Storage where s_DID like '%" + id + "%' order by s_ID desc";
                    requistionDate(sql1);
                    break;

                case 1:
                    string sql2 = "select s_ID,s_DID,s_CID,s_Person,s_Class,s_Warehouse,s_XDate,s_DDate,s_PID,s_Pname,s_Specifications,s_Amount,s_Price,s_Notes from HY_Storage where s_PID like '%" + id + "%' order by s_ID desc";
                    requistionDate(sql2);
                    break;

                case 2:
                    string sql3 = "select s_ID,s_DID,s_CID,s_Person,s_Class,s_Warehouse,s_XDate,s_DDate,s_PID,s_Pname,s_Specifications,s_Amount,s_Price,s_Notes from HY_Storage where s_Pname like '%" + id + "%' order by s_ID desc";
                    requistionDate(sql3);
                    break;

            }
        }

        private void btnMX_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Report.HY_StorageAccountDB hystrac = new HYWJ.HY_Report.HY_StorageAccountDB();
            hystrac.Show();
        }
    }
}
