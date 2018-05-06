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
using DevComponents.DotNetBar;
using HY_Model;

namespace HYWJ.HY_Invoicing
{
    public partial class HY_Purchaseorder : Office2007Form
    {
        public HY_BLL.HY_ProcurementBLL hyprocmentbll;
        private HYWJ.HY_System.OperateAndValidate valid;//实例化数据验证类
        public static int intFalg = 0;//控件方法状态
        private string sql = "select distinct c_DID,c_State,c_CID from HY_ProcurementInfo";
        //构造函数
        public HY_Purchaseorder()
        {
            InitializeComponent();
            hyprocmentbll = new HY_ProcurementBLL();
            valid = new HYWJ.HY_System.OperateAndValidate();
        }

        private void HY_Purchaseorder_Load(object sender, EventArgs e)
        {
            this.groupA.Enabled = false;
            this.groupB.Enabled = false;
            this.toolStripCEL.Enabled = false;
            this.toolStripDEL.Enabled = false;
            this.toolStripUPD.Enabled = false;
            this.toolStripSave.Enabled = false;
            //requistionDate();
            listViewDate(sql);
        }
        //自定义绑定数据
        private void requistionDate()
        {
            this.dataGridViewQG.AutoGenerateColumns = false;// 关闭自动创建列
            string sql = "select * from HY_RequisitionInfo order by r_ID desc";
            this.dataGridViewQG.DataSource = hyprocmentbll.ExecuteQuery(sql);
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
                ListViewItem lv = new ListViewItem(sdr[0].ToString());
                lv.SubItems.Add(sdr[1].ToString());
                lv.ImageIndex = 0;
                lv.SubItems.Add(sdr[2].ToString());
                this.listView1.Items.Add(lv);
            }
        }

        private void toolStripADD_Click(object sender, EventArgs e)
        {
            this.groupA.Enabled = true;
            this.groupB.Enabled = true;
            this.groupPaneA.Enabled = false;
            this.groupPaneB.Enabled = false;
            this.groupPaneC.Enabled = false;
            this.toolStripADD.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = true;
            string P = "CG";
            HYWJ.HY_System.HY_NO hyNO = new HYWJ.HY_System.HY_NO();
            this.r_ID.Text = hyNO.JhGoodsID(P);
            q_PID();
            intFalg = 1;
        }
        /// <summary>
        /// 返回品号
        /// </summary>
        public void q_PID()
        {
            string q = "P";
            HYWJ.HY_System.HY_NO hyNO = new HYWJ.HY_System.HY_NO();
            this.r_NameID.Text = hyNO.JhGoodsID(q);
        }
        /// <summary>
        /// 自定义返回请购单(跨窗口传值定义)
        /// </summary>
        /// <param name="Did">请购单号</param>
        public void q_Qid(string Did)
        {
            this.r_ID.Text = Did;
        }
        /// <summary>
        /// 自定义返回请购人(跨窗口传值定义)
        /// </summary>
        /// <param name="Name">用户</param>
        /// <param name="Dep">所属部门</param>
        public void q_Person(string Name, string Dep)
        {
            this.r_Person.Text = Name;
            this.r_Department.Text = Dep;
        }
        /// <summary>
        /// 自定义返回供应商(跨窗口传值定义)
        /// </summary>
        /// <param name="supName">供应商名称</param>
        public void q_Supplier(string supName)
        {
            this.r_Supplier.Text = supName;
        }
        private void toolStripUPD_Click(object sender, EventArgs e)
        {
            this.toolStripUPD.Enabled = false;
            this.toolStripDEL.Enabled = false;
            this.toolStripADD.Enabled = false;
            this.groupA.Enabled = true;
            this.groupB.Enabled = true;
            this.groupPaneA.Enabled = false;
            this.groupPaneB.Enabled = false;
            this.groupPaneC.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = true;
            intFalg = 2;
        }

        private void toolStripCEL_Click(object sender, EventArgs e)
        {
            this.r_ID.Text = "";
            this.r_NameID.Text = "";
            this.r_Department.Text = "";
            this.r_Person.Text = "";
            this.r_Name.Text = "";
            this.r_Supplier.Text = "";
            this.r_Origin.Text = "";
            this.r_Specifications.Text = "";
            this.r_Units.Text = "";
            this.r_Amount.Text = "";
            this.r_Uses.Text = "";
            this.r_Notes.Text = "";
            this.r_Hot.Text = "";
            this.groupA.Enabled = false;
            this.groupB.Enabled = false;
            this.groupPaneA.Enabled = true;
            this.groupPaneB.Enabled = true;
            this.groupPaneC.Enabled = true;
            this.toolStripADD.Enabled = true;
            this.toolStripCEL.Enabled = false;
            this.toolStripSave.Enabled = false;
            this.toolStripDEL.Enabled = false;
            this.toolStripUPD.Enabled = false;
            this.toolStripSave.Enabled = false;
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (!valid.validateNull(this.r_Person.Text.Trim()))
            {
                MessageBoxEx.Show("请购人不能为空", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.r_Person.Focus();
                return;
            }
            if (!valid.validateNull(this.r_Name.Text.Trim()))
            {
                MessageBoxEx.Show("品名不能为空", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.r_Name.Focus();
                return;
            }
            if (!valid.validateNull(this.r_Supplier.Text))
            {
                MessageBoxEx.Show("供应商不能为空", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.r_Supplier.Focus();
                return;
            }
            if (!valid.validateNull(this.r_Origin.Text.Trim()))
            {
                MessageBoxEx.Show("产品型号不能为空", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.r_Origin.Focus();
                return;
            }
            if (!valid.validateNull(this.r_XDate.Text.Trim()))
            {
                MessageBoxEx.Show("需要日期不能为空", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.r_XDate.Focus();
                return;
            }
            if (!valid.validateNull(this.r_Specifications.Text.Trim()))
            {
                MessageBoxEx.Show("产品规格不能为空", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.r_Specifications.Focus();
                return;
            }
            if (!valid.validateNull(this.r_Units.Text))
            {
                MessageBoxEx.Show("产品单位不能为空", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.r_Units.Focus();
                return;
            }
            if (!valid.validateNull(this.r_Amount.Text.Trim()))
            {
                MessageBoxEx.Show("产品数量不能为空", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.r_Amount.Focus();
                return;
            }
            else if (!valid.validateNum(this.r_Amount.Text.Trim()))
            {
                MessageBoxEx.Show("产品数量只能输入数字类型！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.r_Amount.Focus();
                return;
            }

            HY_Model.HY_Purchaseorder hypurorde = new HY_Model.HY_Purchaseorder();
            hypurorde.C_DID = this.r_ID.Text;
            hypurorde.C_CID = this.r_CID.Text.Trim();
            hypurorde.C_NameID = this.r_NameID.Text;
            hypurorde.C_Department = this.r_Department.Text;
            hypurorde.C_Person = this.r_Person.Text;
            hypurorde.C_Name = this.r_Name.Text.Trim();
            hypurorde.C_Supplier = this.r_Supplier.Text.Trim();
            hypurorde.C_Origin = this.r_Origin.Text.Trim();
            hypurorde.C_QDate = this.r_QDate.Value.Date;
            hypurorde.C_XDate = this.r_XDate.Value.Date;
            hypurorde.C_Specifications = this.r_Specifications.Text.Trim();
            hypurorde.C_Units = this.r_Units.Text.Trim();
            hypurorde.C_Amount = int.Parse(this.r_Amount.Text);
            hypurorde.C_Uses = this.r_Uses.Text.Trim();
            hypurorde.C_Notes = this.r_Notes.Text.Trim();
            hypurorde.C_Hot = this.r_Hot.Text.Trim();
            //添加动作
            if (intFalg == 1)
            {
                int res = hyprocmentbll.com_HY_Procurement(hypurorde);
                if (res > 0)
                {
                    MessageBoxEx.Show("采购信息添加成功！ 确定后可继续添加", "操作提示", MessageBoxButtons.OK);
                    this.r_NameID.Text = "";
                    this.r_Name.Text = "";
                    this.r_Supplier.Text = "";
                    this.r_Origin.Text = "";
                    this.r_Specifications.Text = "";
                    this.r_Units.Text = "";
                    this.r_Amount.Text = "";
                    this.r_Uses.Text = "";
                    this.r_Notes.Text = "";
                    this.r_Hot.Text = "";
                    q_PID();//更新品号
                    this.listView1.Items.Clear();
                    listViewDate(sql);
                }
            }

            //修改动作
            if (intFalg == 2)
            {
                string sql = "update HY_ProcurementInfo set c_DID='" + hypurorde.C_DID + "',c_Department='" + hypurorde.C_Department + "',c_Person='" + hypurorde.C_Person + "',c_Name='" + hypurorde.C_Name + "',c_Supplier='" + hypurorde.C_Supplier + "',c_Origin='" + hypurorde.C_Origin + "',c_QDate='" + hypurorde.C_QDate + "',c_XDate='" + hypurorde.C_XDate + "',c_Specifications='" + hypurorde.C_Specifications + "',c_Units='" + hypurorde.C_Units + "',c_Amount='" + hypurorde.C_Amount + "',c_Uses='" + hypurorde.C_Uses + "',c_Hot='" + hypurorde.C_Hot + "' where c_NameID='" + this.r_NameID.Text + "'";
                int res = hyprocmentbll.com_ExecuteQuery(sql);
                if (res > 0)
                {
                    MessageBoxEx.Show("请购信息更新修改成功！ 确定后可继续操作", "操作提示", MessageBoxButtons.OK);
                    this.r_ID.Text = "";
                    this.r_NameID.Text = "";
                    this.r_Department.Text = "";
                    this.r_Person.Text = "";
                    this.r_Name.Text = "";
                    this.r_Supplier.Text = "";
                    this.r_Origin.Text = "";
                    this.r_Specifications.Text = "";
                    this.r_Units.Text = "";
                    this.r_Amount.Text = "";
                    this.r_Uses.Text = "";
                    this.r_Notes.Text = "";
                    this.r_Hot.Text = "";
                    this.groupA.Enabled = false;
                    this.groupB.Enabled = false;
                    this.groupPaneA.Enabled = true;
                    this.groupPaneB.Enabled = true;
                    this.groupPaneC.Enabled = true;
                    this.toolStripADD.Enabled = true;
                    this.toolStripCEL.Enabled = false;
                    this.toolStripSave.Enabled = false;
                    this.toolStripDEL.Enabled = false;
                    this.toolStripUPD.Enabled = false;
                    this.toolStripSave.Enabled = false;
                    this.listView1.Items.Clear();
                    string sqlupdate = "select distinct c_DID,c_State,c_CID from HY_ProcurementInfo";
                    listViewDate(sqlupdate);
                }
            }
        }

        //删除整张采购单信息
        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("请选择采购单后在确认删除", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBoxEx.Show("确认后此采购单将被从数据库删除", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
                    string sqldel = "delete from HY_ProcurementInfo where c_DID='" + str_DID + "'";
                    int res = hyprocmentbll.com_ExecuteQuery(sqldel);
                    if (res > 0)
                    {
                        this.listView1.Items.Clear();
                        listViewDate(sql);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
            this.dataGridViewQG.AutoGenerateColumns = false;// 关闭自动创建列
            string sql = "select * from HY_ProcurementInfo where c_DID='" + str_DID + "'";
            this.dataGridViewQG.DataSource = hyprocmentbll.ExecuteQuery(sql);

            string sqlcont = "select count(*) as con from HY_ProcurementInfo where c_DID='" + str_DID + "'";
            SqlDataReader sdrcont = hyprocmentbll.f_RequisitionInfo(sqlcont);
            while (sdrcont.Read())
            {
                this.Statistics.Text = sdrcont[0].ToString();
            }
        }

        private void dataGridViewQG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripADD.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripDEL.Enabled = true;
            this.toolStripUPD.Enabled = true;
            string pid = this.dataGridViewQG[0, this.dataGridViewQG.CurrentCell.RowIndex].Value.ToString();
            string sql = "select c_ID,c_DID,c_NameID,c_Department,c_Person,c_Name,c_Supplier,c_Origin,c_QDate,c_XDate,c_Specifications,c_Units,c_Amount,c_Uses,c_Hot,c_Notes,c_CID from HY_ProcurementInfo where c_NameID='" + pid + "'";
            DataTable dt = hyprocmentbll.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                this.r_NameID.Text = dt.Rows[0][2].ToString();
                this.r_ID.Text = dt.Rows[0][1].ToString();
                this.r_Person.Text = dt.Rows[0][4].ToString();
                this.r_Department.Text = dt.Rows[0][3].ToString();
                this.r_Name.Text = dt.Rows[0][5].ToString();
                this.r_Supplier.Text = dt.Rows[0][6].ToString();
                this.r_Origin.Text = dt.Rows[0][7].ToString();
                this.r_QDate.Value = Convert.ToDateTime(dt.Rows[0][8].ToString());
                //this.r_XDate.Value = Convert.ToDateTime(dt.Rows[0][9].ToString());
                this.r_Specifications.Text = dt.Rows[0][10].ToString();
                this.r_Units.Text = dt.Rows[0][11].ToString();
                this.r_Amount.Text = dt.Rows[0][12].ToString();
                this.r_Uses.Text = dt.Rows[0][13].ToString();
                this.r_Hot.Text = dt.Rows[0][14].ToString();
                this.r_Notes.Text = dt.Rows[0][15].ToString();
                this.r_CID.Text = dt.Rows[0][16].ToString();
            }
        }

        private void toolStripDEL_Click(object sender, EventArgs e)
        {
            this.toolStripADD.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = true;
            if (MessageBoxEx.Show("确定删除本条记录后不可恢复！", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from HY_ProcurementInfo where c_NameID='" + this.r_NameID.Text + "'";
                int res = hyprocmentbll.com_ExecuteQuery(sql);
                if (res > 0)
                {
                    requistionDate();
                }
                else
                {
                    MessageBoxEx.Show("删除数据时出现错误,请检查操作或联系管理员", "删除提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            return;
        }

        private void key_TextChanged(object sender, EventArgs e)
        {
            string k = this.key.Text.Trim();
            string sqlselect = "select distinct c_DID,c_State,c_CID from HY_ProcurementInfo where c_DID like '%" + k + "%' or c_CID like '%" + k + "%'";
            this.listView1.Items.Clear();//清空项
            listViewDate(sqlselect);
        }

        private void toolStripOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //获取采购单号
        private void btnCG_Click(object sender, EventArgs e)
        {

        }
    }
}
