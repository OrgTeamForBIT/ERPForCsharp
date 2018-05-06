/*  
 * 作者: JOY 
 * 创建时间: 20010-02-27 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:  请购信息明细主窗体
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
    public partial class HY_RequisitionDetail : Office2007Form
    {
        public HY_RequisitionDetail()
        {
            InitializeComponent();
        }

        private void HY_RequisitionDetail_Load(object sender, EventArgs e)
        {
            string sql = "select r_State,r_DID,r_NameID,r_Name,r_Supplier,r_Origin,r_Specifications,r_Hot,r_Units,r_Amount,r_Person,r_Department,r_QDate,r_XDate,r_Notes from HY_RequisitionInfo order by r_ID desc";
            listViewDate(sql);
        }
        //自定义绑定listView数据
        private void listViewDate(string sql)
        {
            
            HY_BLL.HY_ProcurementBLL hyul = new HY_ProcurementBLL();
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;
            SqlDataReader sdr = hyul.f_RequisitionInfo(sql);
            while (sdr.Read())
            {
                ListViewItem lv = new ListViewItem();
                if (sdr[0].ToString() == "已确认")
                {
                    lv.ImageIndex = 0;
                }
                else
                {
                    lv.ImageIndex = 1;
                }
                lv.SubItems.Add(sdr[1].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                lv.SubItems.Add(sdr[3].ToString());
                lv.SubItems.Add(sdr[4].ToString());
                lv.SubItems.Add(sdr[5].ToString());
                lv.SubItems.Add(sdr[6].ToString());
                lv.SubItems.Add(sdr[7].ToString());
                lv.SubItems.Add(sdr[8].ToString());
                lv.SubItems.Add(sdr[9].ToString());
                lv.SubItems.Add(sdr[10].ToString());
                lv.SubItems.Add(sdr[11].ToString());
                lv.SubItems.Add(sdr[12].ToString());
                lv.SubItems.Add(sdr[13].ToString());
                lv.SubItems.Add(sdr[14].ToString());
                this.listView1.Items.Add(lv);
            }
        }

        private void btnSE_Click(object sender, EventArgs e)
        {
            string k = this.key.Text.Trim();
            int classid =int.Parse( this.comboBoxClass.SelectedIndex.ToString());
            switch (classid)
            {
                case 0:
                    string sql1 = "select r_State,r_DID,r_NameID,r_Name,r_Supplier,r_Origin,r_Specifications,r_Hot,r_Units,r_Amount,r_Person,r_Department,r_QDate,r_XDate,r_Notes from HY_RequisitionInfo where r_DID like '%" + k + "%' order by r_ID desc ";
                    this.listView1.Items.Clear();
                    listViewDate(sql1);
                    break;

                case 1:
                    string sql2 = "select r_State,r_DID,r_NameID,r_Name,r_Supplier,r_Origin,r_Specifications,r_Hot,r_Units,r_Amount,r_Person,r_Department,r_QDate,r_XDate,r_Notes from HY_RequisitionInfo where r_Name like '%" + k + "%' order by r_ID desc ";
                    this.listView1.Items.Clear();
                    listViewDate(sql2);
                    break;

                case 2:
                    string sql3 = "select r_State,r_DID,r_NameID,r_Name,r_Supplier,r_Origin,r_Specifications,r_Hot,r_Units,r_Amount,r_Person,r_Department,r_QDate,r_XDate,r_Notes from HY_RequisitionInfo where r_NameID like '%" + k + "%' order by r_ID desc ";
                    this.listView1.Items.Clear();
                    listViewDate(sql3);
                    break;

                case 3:
                    string sql4 = "select r_State,r_DID,r_NameID,r_Name,r_Supplier,r_Origin,r_Specifications,r_Hot,r_Units,r_Amount,r_Person,r_Department,r_QDate,r_XDate,r_Notes from HY_RequisitionInfo where r_Supplier  like '%" + k + "%' order by r_ID desc ";
                    this.listView1.Items.Clear();
                    listViewDate(sql4);
                    break;

                case 4:
                    string sql5 = "select r_State,r_DID,r_NameID,r_Name,r_Supplier,r_Origin,r_Specifications,r_Hot,r_Units,r_Amount,r_Person,r_Department,r_QDate,r_XDate,r_Notes from HY_RequisitionInfo where r_Department like '%" + k + "%' order by r_ID desc ";
                    this.listView1.Items.Clear();
                    listViewDate(sql5);
                    break;

                case 5:
                    string sql6 = "select r_State,r_DID,r_NameID,r_Name,r_Supplier,r_Origin,r_Specifications,r_Hot,r_Units,r_Amount,r_Person,r_Department,r_QDate,r_XDate,r_Notes from HY_RequisitionInfo where r_Person like '%" + k + "%' order by r_ID desc ";
                    this.listView1.Items.Clear();
                    listViewDate(sql6);
                    break;
            }
        }
    }
}
