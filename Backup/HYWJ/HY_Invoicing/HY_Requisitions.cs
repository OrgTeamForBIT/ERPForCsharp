/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   请购信息主窗体
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
using DevComponents.DotNetBar;
using HY_Model;

namespace HYWJ.HY_Invoicing
{
    public partial class HY_Requisitions : Office2007Form
    {
        public HY_BLL.HY_RequisitionInfoBLL hyrepinfobll;
        private HYWJ.HY_System.OperateAndValidate valid;//实例化数据验证类
        public static int intFalg = 0;//控件方法状态
        private string sql = "select distinct r_DID,r_State,r_CID from HY_RequisitionInfo";
        //构造函数
        public HY_Requisitions()
        {
            InitializeComponent();
            hyrepinfobll = new HY_RequisitionInfoBLL();
            valid = new HYWJ.HY_System.OperateAndValidate();
        }

        private void HY_Requisitions_Load(object sender, EventArgs e)
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
            this.dataGridViewQG.DataSource = hyrepinfobll.ExecuteQuery(sql);
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
                if (sdr[1].ToString() == "已确认")
                {
                    lv.ImageIndex = 0;
                }
                else
                {
                    lv.ImageIndex = 1;
                }
                lv.SubItems.Add(sdr[2].ToString());
                this.listView1.Items.Add(lv);
            }
        }
        private void toolStripOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //新增请购信息
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
            string P = "QG";
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
        ////自定义绑定请购部门
        //private void hy_Department()
        //{
        //    HY_BLL.HY_DepartmentBLL hydep = new HY_DepartmentBLL();
        //    string sql = "select * from HY_Department";
        //    this.r_Department.DataSource = hydep.ExecuteQuery(sql);
        //    this.r_Department.DisplayMember = "d_Name";
        //}
        //保存请购单
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

            HY_Model.HY_RequisitionInfo hyrepinfo = new HY_RequisitionInfo();
            hyrepinfo.R_DID = this.r_ID.Text;
            hyrepinfo.R_CID = this.r_CID.Text.Trim();
            hyrepinfo.R_NameID = this.r_NameID.Text;
            hyrepinfo.R_Department = this.r_Department.Text;
            hyrepinfo.R_Person = this.r_Person.Text;
            hyrepinfo.R_Name = this.r_Name.Text.Trim();
            hyrepinfo.R_Supplier = this.r_Supplier.Text.Trim();
            hyrepinfo.R_Origin = this.r_Origin.Text.Trim();
            hyrepinfo.R_QDate = this.r_QDate.Value.Date;
            hyrepinfo.R_XDate = this.r_XDate.Value.Date;
            hyrepinfo.R_Specifications = this.r_Specifications.Text.Trim();
            hyrepinfo.R_Units = this.r_Units.Text.Trim();
            hyrepinfo.R_Amount = int.Parse(this.r_Amount.Text);
            hyrepinfo.R_Uses = this.r_Uses.Text.Trim();
            hyrepinfo.R_Notes = this.r_Notes.Text.Trim();
            hyrepinfo.R_Hot = this.r_Hot.Text.Trim();


            //添加动作
            if (intFalg == 1)
            {
                int res = hyrepinfobll.com_RequisitionInfo(hyrepinfo);
                if (res > 0)
                {
                    MessageBoxEx.Show("请购信息添加成功！ 确定后可继续添加", "操作提示", MessageBoxButtons.OK);
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
                string sql = "update HY_RequisitionInfo set r_DID='" + hyrepinfo.R_DID + "',r_Department='" + hyrepinfo.R_Department + "',r_Person='" + hyrepinfo.R_Person + "',r_Name='" + hyrepinfo.R_Name + "',r_Supplier='" + hyrepinfo.R_Supplier + "',r_Origin='" + hyrepinfo.R_Origin + "',r_QDate='" + hyrepinfo.R_QDate + "',r_XDate='" + hyrepinfo.R_XDate + "',r_Specifications='" + hyrepinfo.R_Specifications + "',r_Units='" + hyrepinfo.R_Units + "',r_Amount='" + hyrepinfo.R_Amount + "',r_Uses='" + hyrepinfo.R_Uses + "',r_Hot='" + hyrepinfo.R_Hot + "' where r_NameID='" + this.r_NameID.Text + "'";
                int res = hyrepinfobll.com_ExecuteQuery(sql);
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
                    string sqlupdate = "select distinct r_DID,r_State,r_CID from HY_RequisitionInfo";
                    listViewDate(sqlupdate);
                }
            }


        }

        #region 录入框变色事件
        private void r_Person_Enter(object sender, EventArgs e)
        {
            this.r_Person.BackColor = Color.Green;
            this.r_Person.ForeColor = Color.White;
        }
        private void r_Person_Leave(object sender, EventArgs e)
        {
            this.r_Person.BackColor = Color.White;
            this.r_Person.ForeColor = Color.Black;
        }
        private void r_Name_Enter(object sender, EventArgs e)
        {
            this.r_Name.BackColor = Color.Green;
            this.r_Name.ForeColor = Color.White;
        }
        private void r_Name_Leave(object sender, EventArgs e)
        {
            this.r_Name.BackColor = Color.White;
            this.r_Name.ForeColor = Color.Black;
        }
        private void r_Specifications_Enter(object sender, EventArgs e)
        {
            this.r_Specifications.BackColor = Color.Green;
            this.r_Specifications.ForeColor = Color.White;
        }
        private void r_Specifications_Leave(object sender, EventArgs e)
        {
            this.r_Specifications.BackColor = Color.White;
            this.r_Specifications.ForeColor = Color.Black;
        }
        private void r_Amount_Enter(object sender, EventArgs e)
        {
            this.r_Amount.BackColor = Color.Green;
            this.r_Amount.ForeColor = Color.White;
        }
        private void r_Amount_Leave(object sender, EventArgs e)
        {
            this.r_Amount.BackColor = Color.White;
            this.r_Amount.ForeColor = Color.Black;
        }
        private void r_Uses_Enter(object sender, EventArgs e)
        {
            this.r_Uses.BackColor = Color.Green;
            this.r_Uses.ForeColor = Color.White;
        }
        private void r_Uses_Leave(object sender, EventArgs e)
        {
            this.r_Uses.BackColor = Color.White;
            this.r_Uses.ForeColor = Color.Black;
        }
        private void r_Notes_Enter(object sender, EventArgs e)
        {
            this.r_Notes.BackColor = Color.Green;
            this.r_Notes.ForeColor = Color.White;
        }
        private void r_Notes_Leave(object sender, EventArgs e)
        {
            this.r_Notes.BackColor = Color.White;
            this.r_Notes.ForeColor = Color.Black;
        }
        private void r_Origin_Enter(object sender, EventArgs e)
        {
            this.r_Origin.BackColor = Color.Green;
            this.r_Origin.ForeColor = Color.White;
        }
        private void r_Origin_Leave(object sender, EventArgs e)
        {
            this.r_Origin.BackColor = Color.White;
            this.r_Origin.ForeColor = Color.Black;
        }
        private void r_Amount_Enter_1(object sender, EventArgs e)
        {
            this.r_Amount.BackColor = Color.Green;
            this.r_Amount.ForeColor = Color.White;
        }
        private void r_Amount_Leave_1(object sender, EventArgs e)
        {
            this.r_Amount.BackColor = Color.White;
            this.r_Amount.ForeColor = Color.Black;
        }
        private void r_HY_Supplier_Enter(object sender, EventArgs e)
        {
            this.r_Supplier.BackColor = Color.Green;
            this.r_Supplier.ForeColor = Color.White;
        }
        private void r_HY_Supplier_Leave(object sender, EventArgs e)
        {
            this.r_Supplier.BackColor = Color.White;
            this.r_Supplier.ForeColor = Color.Black;
        }
        #endregion

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

        private void toolStripUPD_Click(object sender, EventArgs e)
        {
            this.toolStripADD.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = true;
            if (MessageBoxEx.Show("确定删除本条记录后不可恢复！", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from HY_RequisitionInfo where r_NameID='" + this.r_NameID.Text + "'";
                int res = hyrepinfobll.com_ExecuteQuery(sql);
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

        private void toolStripUPD_Click_1(object sender, EventArgs e)
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

        private void btnQG_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Invoicing.HY_RequisitionsID hyreqid = new HY_RequisitionsID();
            hyreqid.hyreq = this;
            hyreqid.ShowDialog();
        }
        /// <summary>
        /// 打开供应商信息列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSupplier_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Invoicing.HY_SupplierListSO hysup = new HY_SupplierListSO();
            hysup.hyreq = this;
            hysup.ShowDialog();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
            this.dataGridViewQG.AutoGenerateColumns = false;// 关闭自动创建列
            this.dataGridViewPLCG.AutoGenerateColumns = false;// 关闭自动创建列
            string sql = "select * from HY_RequisitionInfo where r_DID='" + str_DID + "'";
            this.dataGridViewQG.DataSource = hyrepinfobll.ExecuteQuery(sql);
            this.dataGridViewPLCG.DataSource = hyrepinfobll.ExecuteQuery(sql);

            
            string sqlcont = "select count(*) as con from HY_RequisitionInfo where r_DID='" + str_DID + "'";
            SqlDataReader sdrcont = hyrepinfobll.f_RequisitionInfo(sqlcont);
            while (sdrcont.Read())
            {
                this.Statistics.Text = sdrcont[0].ToString();
            }

        }
        //删除请购单动作
        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("请选择请购单后在确认删除", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBoxEx.Show("确认后此请购单将被从数据库删除", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
                    string sqldel = "delete from HY_RequisitionInfo where r_DID='" + str_DID + "'";
                    int res = hyrepinfobll.com_ExecuteQuery(sqldel);
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
        //查询单
        private void key_TextChanged(object sender, EventArgs e)
        {
            string k = this.key.Text.Trim();
            string sqlselect = "select distinct r_DID,r_State,r_CID from HY_RequisitionInfo where r_DID like '%" + k + "%' or r_CID like '%" + k + "%'";
            this.listView1.Items.Clear();//清空项
            listViewDate(sqlselect);
        }

        private void key_Enter(object sender, EventArgs e)
        {
            this.key.Text = "";
        }
        //请购单确认动作
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("请选择请购单后在确认审核", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
                string sqlok = "Update HY_RequisitionInfo set r_State='已确认' where r_DID='" + str_DID + "'";
                int res = hyrepinfobll.com_ExecuteQuery(sqlok);
                if (res > 0)
                {
                    MessageBoxEx.Show("请购单确认审核通过,可以将此单转为采购订单", "提示", MessageBoxButtons.OK);
                    this.listView1.Items.Clear();
                    listViewDate(sql);
                }
            }
        }
        //撤销动作
        private void btnCEL_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("请选择请购单后在确认审核", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string str_DID = this.listView1.SelectedItems[0].SubItems[0].Text;
                string sqlcel = "Update HY_RequisitionInfo set r_State='确认中' where r_DID='" + str_DID + "'";
                int res = hyrepinfobll.com_ExecuteQuery(sqlcel);
                if (res > 0)
                {
                    MessageBoxEx.Show("请购单已撤销审核确认", "提示", MessageBoxButtons.OK);
                    this.listView1.Items.Clear();
                    listViewDate(sql);
                }
            }
        }
        /// <summary>
        /// 请购人窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPerson_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Invoicing.HY_rPerson hyrp = new HY_rPerson();
            hyrp.hyreq = this;//当前窗口传给HY_rPerson窗口
            hyrp.ShowDialog();//对话框模式打开窗口
        }

        private void dataGridViewQG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripADD.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripDEL.Enabled = true;
            this.toolStripUPD.Enabled = true;
            string pid = this.dataGridViewQG[0, this.dataGridViewQG.CurrentCell.RowIndex].Value.ToString();
            string sql = "select r_ID,r_DID,r_NameID,r_Department,r_Person,r_Name,r_Supplier,r_Origin,r_QDate,r_XDate,r_Specifications,r_Units,r_Amount,r_Uses,r_Hot,r_Notes,r_CID from HY_RequisitionInfo where r_NameID='" + pid + "'";
            DataTable dt = hyrepinfobll.ExecuteQuery(sql);
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
        //批量分配供应商
        private void PLCG_Click(object sender, EventArgs e)
        {
            this.panelExPL.Visible = true;
        }
        //批量分配供应商窗口
        private void reflectionImageCGPL_Click(object sender, EventArgs e)
        {
            this.panelExPL.Visible = false;
        }
        //批量采购确认
        private void PLCGOK_Click(object sender, EventArgs e)
        {

            int count = 0;
            //用于保存选中的checkbox数量    
            //DG_List为datagridview控件    
            for (int i = 0; i < dataGridViewPLCG.RowCount; i++)
            {
                if (dataGridViewPLCG.SelectedRows.Count>0)
                //这里判断复选框是否选中    
                {
                    MessageBox.Show("aa" + dataGridViewPLCG.Rows[i].Cells[0].Value.ToString());
                    //count++;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("请至少选择一条数据！", "提示");
                return;
            }
            else  
           {    
                  if (MessageBox.Show(this, "您要更新数据么？", "提示", MessageBoxButtons.YesNo,    MessageBoxIcon.Information).ToString() == "Yes")   
                   {    
                       for (int i = 0; i < count; i++)    
                       {
                           //MessageBox.Show("aa" + dataGridViewPLCG.Rows[i].Cells[0].Value.ToString());
                           //ps.Pexcute(" update cf_prj_certi set FIsPrint='"+number+"' where fid='" +  DG_List.Rows[i].Cells["fnn"].Value.ToString() + "'"); //执行SQL   
                           //string sqlcgpl = "update HY_RequisitionInfo set r_XDate='" + this.r_XDatePL.Value + "',r_Supplier='" + this.r_SupplierPL.Text.Trim() + "',r_Units='" + this.r_UnitsPL.Text + "' where r_ID='" + dataGridViewPLCG.Rows[i].Cells[0].Value.ToString() + "'";
                           //int respl = hyrepinfobll.com_ExecuteQuery(sqlcgpl);
                           //if (respl > 0)
                           //{
                           //    MessageBox.Show("批量分配供应商完成！", "提示");
                           //}
                       }    
                    } 

          }    

        }

        private void dataGridViewPLCG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = Convert.ToInt16(dataGridViewPLCG.Rows.Count.ToString());
                    for (int i = 0; i < count; i++)
                    {
                        DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dataGridViewPLCG.Rows[i].Cells["cb_check"];  
                      Boolean flag = Convert.ToBoolean(checkCell.Value);
                      if (flag == true)  //查找被选择的数据行   
                      {
                          checkCell.Value = false;
                      } 
                    }

        }

        //获取请购单号
        private void btnQG_Click_1(object sender, EventArgs e)
        {
            HYWJ.HY_Invoicing.HY_RequisitionsID hyreqid = new HY_RequisitionsID();
            hyreqid.ShowDialog();
        }
    }
}