/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:  请购单号信息主窗体
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using HY_DbSqlHelp;
using HY_BLL;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HYWJ.HY_Invoicing
{
    public partial class HY_RequisitionNO : Office2007Form
    {
        public HY_RequisitionNO()
        {
            InitializeComponent();
        }

        public HY_RequisitionsTOProcurement hyreqtiontoproc;//实例化请购信息窗口实行跨窗口传值
        private void HY_RequisitionNO_Load(object sender, EventArgs e)
        {
            this.key.Text = "输入单号查询请购单.....";
            string sql = "select distinct r_DID,r_State,r_CID from HY_RequisitionInfo";
            requistionDate(sql);
        }
        //自定义绑定数据
        private void requistionDate(string sql)
        {
            HY_BLL.HY_RequisitionInfoBLL hyul = new HY_RequisitionInfoBLL();
            this.listView1.View = View.Details;
            this.listView1.FullRowSelect = true;
            SqlDataReader sdr = hyul.f_RequisitionInfo(sql);
            while (sdr.Read())
            {
                ListViewItem lv = new ListViewItem(sdr[0].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                if (sdr[1].ToString() == "已确认")
                {
                    lv.ImageIndex = 0;
                }
                else
                {
                    lv.ImageIndex = 1;
                }
                
                this.listView1.Items.Add(lv);
            }
        }

        private void key_TextChanged(object sender, EventArgs e)
        {
            string k = this.key.Text.Trim();
            string sql = "select distinct r_DID,r_State,r_CID from HY_RequisitionInfo where r_DID like '%" + k + "%' or r_CID like '%" + k + "%'";
            this.listView1.Items.Clear();//清空项
            requistionDate(sql);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
            hyreqtiontoproc.q_Requisitions(str_DID);
            this.Close();
        }

        private void key_Enter(object sender, EventArgs e)
        {
            this.key.Text = "";
        }
    }
}
