/*  
 * 作者: JOY 
 * 创建时间: 2009-12-27 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   库存明细信息主窗体
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using HY_BLL;
using HY_Model;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HYWJ.HY_Warehouse
{
    public partial class HY_StockDetails : Office2007Form
    {
        private HY_BLL.HY_StorageBLL hyul;
        public HY_StockDetails()
        {
            InitializeComponent();
            hyul = new HY_StorageBLL();
        }

        private void HY_StockDetails_Load(object sender, EventArgs e)
        {
            this.groupBox4.Enabled = false;
            string sql = "select * from HY_Storage order by s_ID desc";
            requistionDate(sql);
            listViewDate();
        }
        //自定义绑定ListView数据
        private void listViewDate()
        {
            this.listView1.View = View.Details;
            this.listView1.FullRowSelect = true;
            string sql = "select s_PID,sum(s_Amount) as s_KCAmount,s_Pname from HY_Storage group by s_PID,s_Pname having sum(s_Amount)<40";
            SqlDataReader sdr = hyul.f_HY_Storagelist(sql);
            while (sdr.Read())
            {
                
                ListViewItem lv = new ListViewItem(sdr[0].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                lv.SubItems.Add(sdr[1].ToString());
                this.listView1.Items.Add(lv);
            }
        }
        //自定义绑定数据
        private void requistionDate(string sql)
        {
            this.dataGridViewCK.AutoGenerateColumns = false;// 关闭自动创建列
            HY_BLL.HY_StorageBLL hystorfobll = new HY_StorageBLL();
            this.dataGridViewCK.DataSource = hystorfobll.ExecuteQuerySelect(sql);
        }
        //自定义查询绑定数据
        private void requistionSelectDate(string sql)
        {
            this.dataGridViewCK.AutoGenerateColumns = false;// 关闭自动创建列
            HY_BLL.HY_StorageBLL hystorfobll = new HY_StorageBLL();
            this.dataGridViewCK.DataSource = hystorfobll.ExecuteQuerySelect(sql);
        }

        /// <summary>
        /// 自定义绑定入库单
        /// </summary>
        private void f_CID()
        {
            string C = "CK";
            HYWJ.HY_System.HY_NO hyNO = new HYWJ.HY_System.HY_NO();
            this.s_DID.Text = hyNO.JhGoodsID(C);
        }

        private void btnCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //验证输入是否是数字
        public bool IsNumber(string str_number)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str_number, @"^[0-9]*$");
        }

        private void butSelect_Click(object sender, EventArgs e)
        {
            int selectCalssID =int.Parse( this.selectCalss.SelectedIndex.ToString());
            string k=this.key.Text.Trim();
            if (k != string.Empty)
            {
                switch (selectCalssID)
                {
                    case 0:
                        string sql0 = "select * from HY_Storage where s_DID='" + k + "' order by s_ID desc";
                        requistionSelectDate(sql0);
                    break;
                    case 1:
                        string sql1 = "select * from HY_Storage where s_PID='" + k + "' order by s_ID desc";
                        requistionSelectDate(sql1);
                    break;
                }
            }
            else
            {
                MessageBox.Show("请输入查询关键字！", "操作提示", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.key.Focus();
            }          
        }

        private void key_TextChanged(object sender, EventArgs e)
        {
            string id = this.key.Text.Trim();
            int cl = int.Parse(this.selectCalss.SelectedIndex.ToString());
            switch (cl)
            {
                case 0:
                    string sql1 = "select * from HY_Storage where s_Pname like '%" + id + "%' order by s_ID desc";
                    requistionDate(sql1);
                    break;

                case 1:
                    string sql2 = "select * from HY_Storage where s_PID like '%" + id + "%' order by s_ID desc";
                    requistionDate(sql2);
                    break;
                
                case 2:
                    string sql3 = "select * from HY_Storage where s_DID like '%" + id + "%' order by s_ID desc";
                    requistionDate(sql3);
                    break;
            }
        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Report.HY_StorageDB hystordb = new HYWJ.HY_Report.HY_StorageDB();
            hystordb.ShowDialog();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string str_ID = this.listView1.SelectedItems[0].SubItems[0].Text;
            string sql = "select top 1 s_DID,s_CID,s_Person,s_Class,s_Warehouse,s_PID,s_Pname,s_Specifications,s_Amount,s_Price,s_Notes from HY_Storage where s_PID='" + str_ID + "'";
            SqlDataReader sdr = hyul.f_HY_Storagelist(sql);
            while (sdr.Read())
            {
                this.groupBox4.Enabled = true;
                this.s_DID.Text = sdr[0].ToString();
                this.s_CID.Text = sdr[1].ToString();
                this.s_Person.Text = sdr[2].ToString();
                this.s_Class.Text = sdr[3].ToString();
                this.s_Warehouse.Text = sdr[4].ToString();
                this.s_PID.Text = sdr[5].ToString();
                this.s_Pname.Text = sdr[6].ToString();
                this.s_Specifications.Text = sdr[7].ToString();
                this.s_Notes.Text = sdr[10].ToString();
            }
        }
        //追加补货信息
        private void btnADDOK_Click(object sender, EventArgs e)
        {
            if (this.s_Specifications.Text.Trim() == string.Empty)
            {
                MessageBoxEx.Show("产品规格不能为空,请正确填写", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.s_Specifications.Focus();
                return;
            }
            if (this.s_Price.Text.Trim() == string.Empty)
            {
                MessageBoxEx.Show("产品单价不能为空,请正确填写", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.s_Price.Focus();
                return;
            }
            if (!IsNumber(this.s_Price.Text.Trim()))
            {
                MessageBoxEx.Show("产品单价只能为数字,请正确填写", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.s_Price.Focus();
                return;
            }
            if (this.s_Amount.Text.Trim() == string.Empty)
            {
                MessageBoxEx.Show("产品数量不能为空,请正确填写", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.s_Amount.Focus();
                return;
            }
            if (!IsNumber(this.s_Amount.Text.Trim()))
            {
                MessageBoxEx.Show("产品数量只能为数字,请正确填写", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.s_Amount.Focus();
                return;
            }
            HY_Model.HY_Storage hystormodel = new HY_Model.HY_Storage();
            hystormodel.S_DID = this.s_DID.Text;
            hystormodel.S_CID = this.s_CID.Text;
            hystormodel.S_Person = this.s_Person.Text;
            hystormodel.S_Class = this.s_Class.Text;
            hystormodel.S_Warehouse = this.s_Warehouse.Text;
            hystormodel.S_XDate = Convert.ToDateTime(this.s_XDate.Value);
            hystormodel.S_DDate = Convert.ToDateTime(this.s_DDate.Value);
            hystormodel.S_PID = this.s_PID.Text;
            hystormodel.S_Pname = this.s_Pname.Text.Trim();
            hystormodel.S_Specifications = this.s_Specifications.Text.Trim();
            hystormodel.S_Amount = int.Parse(this.s_Amount.Text.Trim());
            hystormodel.S_Price = int.Parse(this.s_Price.Text.Trim());
            hystormodel.S_Notes = this.s_Notes.Text.Trim();

            string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
            HY_BLL.HY_StorageBLL hystorbll = new HY_StorageBLL();
            string sql = "update HY_Storage set s_Amount=s_Amount+'" + hystormodel.S_Amount + "',s_Price='" + hystormodel.S_Price + "' where s_PID='" + str_DID + "'";
            int res = hystorbll.com_HY_HY_Storagelslist(sql);
            if (res > 0)
            {
                //写入log库存表
                string sqllog = "insert into HY_StorageLog(s_DID,s_CID,s_Person,s_Class,s_Warehouse,s_XDate,s_DDate,s_PID,s_Pname,s_Specifications,s_Amount,s_Price,s_Notes,s_State) values('" + hystormodel.S_DID + "','" + hystormodel.S_CID + "','" + hystormodel.S_Person + "','" + hystormodel.S_Class + "','" + hystormodel.S_Warehouse + "','" + hystormodel.S_XDate + "','" + hystormodel.S_DDate + "','" + hystormodel.S_PID + "','" + hystormodel.S_Pname + "','" + hystormodel.S_Specifications + "','" + hystormodel.S_Amount + "','" + hystormodel.S_Price + "','" + hystormodel.S_Notes + "','添加补货')";
                hystorbll.com_HY_HY_Storagelslist(sqllog);

                MessageBoxEx.Show("预警产品追加成功,确认后继续追加！", "操作提示", MessageBoxButtons.OK);
                string sql4 = "select * from HY_Storage order by s_ID desc";
                requistionDate(sql4);
            }
        }
    }
}
