/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   维护请购信息主窗体
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HY_BLL;
using System.Data.SqlClient;
using HY_Model;

namespace HYWJ.HY_Invoicing
{
    public partial class HY_RequisitionsWH : Form
    {
        public HY_BLL.HY_RequisitionInfoBLL hyrepinfobll;
        public HY_RequisitionsWH()
        {
            InitializeComponent();
            hyrepinfobll = new HY_RequisitionInfoBLL();
        }

        private void HY_RequisitionsWH_Load(object sender, EventArgs e)
        {
            //requistionDate();
            listViewDate();
        }
        ////自定义绑定数据
        //private void requistionDate()
        //{
        //    this.dataGridViewQG.AutoGenerateColumns = false;// 关闭自动创建列

        //    string sql = "select * from HY_RequisitionInfo order by r_ID desc";
        //    this.dataGridViewQG.DataSource = hyrepinfobll.ExecuteQuery(sql);
        //}
        //自定义绑定listView数据
        private void listViewDate()
        {
            string sql = "select distinct r_DID from HY_RequisitionInfo";
            HY_BLL.HY_ProcurementBLL hyul = new HY_ProcurementBLL();
            this.listView1.View = View.Details;
            this.listView1.FullRowSelect = true;
            SqlDataReader sdr = hyul.f_RequisitionInfo(sql);
            while (sdr.Read())
            {
                ListViewItem lv = new ListViewItem(sdr[0].ToString());
                //lv.SubItems.Add(sdr[1].ToString());
                this.listView1.Items.Add(lv);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
            this.dataGridViewQG.AutoGenerateColumns = false;// 关闭自动创建列
            string sql = "select * from HY_RequisitionInfo where r_DID='" + str_DID + "'";
            this.dataGridViewQG.DataSource = hyrepinfobll.ExecuteQuery(sql);
        }
    }
}
