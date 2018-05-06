/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明: BOM物料清单信息主窗体
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

namespace HYWJ.HY_Production
{
    public partial class HY_Bomlist : Office2007Form
    {
        private HY_BLL.HY_BomlistBLL hybombll;
        private HY_BLL.HY_BomDetailsBLL hybomdel;
        private HYWJ.HY_System.OperateAndValidate valid;//实例化数据验证类
        public static int intFalg = 0;//控件方法状态
        public HY_Bomlist()
        {
            InitializeComponent();
            hybombll = new HY_BomlistBLL();
            hybomdel = new HY_BomDetailsBLL();
            valid = new HYWJ.HY_System.OperateAndValidate();
        }

        private void HY_Bomlist_Load(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
            this.groupBox4.Enabled = false;
            this.toolStripDel.Enabled = false;
            this.toolStripEdit.Enabled = false;
            this.toolStripSave.Enabled = false;
            this.toolStripCEL.Enabled = false;
            requistionDate();
        }

        //自定义绑定数据
        private void requistionDate()
        {
            this.dataGridViewBOM.AutoGenerateColumns = false;// 关闭自动创建列
            HY_BLL.HY_BomlistBLL hybombll = new HY_BomlistBLL();
            string sql = "select * from HY_BomInfo order by b_ID desc";
            this.dataGridViewBOM.DataSource = hybombll.ExecuteQuery(sql);
        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
            this.groupBox3.Enabled = false;
            this.groupBox4.Enabled = true;
            this.toolStripDel.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = true;
            this.toolStripAdd.Enabled = false;
            b_BOMID();//获取BOM单号
            intFalg = 1;
        }
        /// <summary>
        /// 自定义物料单号
        /// </summary>
        private void b_BOMID()
        {
            string P = "B";
            HYWJ.HY_System.HY_NO hyNO = new HYWJ.HY_System.HY_NO();
            this.b_SKID.Text = hyNO.JhGoodsID(P);
        }
        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (!valid.validateNull(this.b_SPerson.Text.Trim()))
            {
                MessageBoxEx.Show("设计人不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.b_SPerson.Focus();
                return;
            }
            if (!valid.validateNull(this.b_CID.Text.Trim()))
            {
                MessageBoxEx.Show("厂内编号不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.b_CID.Focus();
                return;
            }
            if (!valid.validateNull(this.b_CustomerID.Text.Trim()))
            {
                MessageBoxEx.Show("客户编号不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.b_CustomerID.Focus();
                return;
            }
            if (!valid.validateNull(this.b_No.Text.Trim()))
            {
                MessageBoxEx.Show("工程数不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.b_No.Focus();
                return;
            }
            if (!valid.validateNull(this.b_Material.Text.Trim()))
            {
                MessageBoxEx.Show("料件材质不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.b_Material.Focus();
                return;
            }
            if (!valid.validateNull(this.b_Height.Text.Trim()))
            {
                MessageBoxEx.Show("闭合高度不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.b_Height.Focus();
                return;
            }
            if (!valid.validateNull(this.b_Tonnage.Text.Trim()))
            {
                MessageBoxEx.Show("冲床吨位不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.b_Tonnage.Focus();
                return;
            }
            if (!valid.validateNull(this.b_BomSize.Text.Trim()))
            {
                MessageBoxEx.Show("用料尺寸不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.b_BomSize.Focus();
                return;
            }
            if (!valid.validateNull(this.b_Name.Text.Trim()))
            {
                MessageBoxEx.Show("模具名称不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.b_Name.Focus();
                return;
            }
            if (!valid.validateNull(this.b_ModClass.Text.Trim()))
            {
                MessageBoxEx.Show("模具类型不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.b_ModClass.Focus();
                return;
            }

            HY_Model.HY_Bomlist hybomodel = new HY_Model.HY_Bomlist();
            hybomodel.B_SKID = this.b_SKID.Text.Trim();
            hybomodel.B_SPerson = this.b_SPerson.Text.Trim();
            hybomodel.B_Department = this.b_Department.Text.Trim();
            hybomodel.B_SDate = this.b_SDate.Value.Date;
            hybomodel.B_CID = this.b_CID.Text.Trim();
            hybomodel.B_CustomerID = this.b_CustomerID.Text.Trim();
            hybomodel.B_No = this.b_No.Text.Trim();
            hybomodel.B_Material = this.b_Material.Text.Trim();
            hybomodel.B_Height = this.b_Height.Text.Trim();
            hybomodel.B_Tonnage = this.b_Tonnage.Text.Trim();
            hybomodel.B_BomSize = this.b_BomSize.Text.Trim();
            hybomodel.B_Notes = this.b_Notes.Text.Trim();
            hybomodel.B_Name = this.b_Name.Text.Trim();
            hybomodel.B_ModClass = this.b_ModClass.Text.Trim();

            if (intFalg == 1)
            {       
                
                int res = hybombll.com_HY_Bomlist(hybomodel);
                if (res > 0)
                {
                    MessageBoxEx.Show("BOM单添加成功，确定后继续添加物料明细");
                    requistionDate();
                }                             
            }
            if (intFalg == 2)
            {
                string did = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
                string sql1 = "Select b_SKID,b_Audit from HY_BomInfo where b_SKID='" + did + "'";
                SqlDataReader dr = hybomdel.f_SQLBom(sql1);
                while (dr.Read())
                {
                    if (dr[1].ToString() == string.Empty)
                    {
                        string sql = "Update HY_BomInfo set b_SKID='" + hybomodel.B_SKID + "',b_CID='" + hybomodel.B_CID + "',b_CustomerID='" + hybomodel.B_CustomerID + "',b_No='" + hybomodel.B_No + "',b_Material='" + hybomodel.B_Material + "',b_BomSize='" + hybomodel.B_BomSize + "',b_Notes='" + hybomodel.B_Notes + "',b_Height='" + hybomodel.B_Height + "',b_Tonnage='" + hybomodel.B_Tonnage + "',b_Name='" + hybomodel.B_Name + "',b_SPerson='" + hybomodel.B_SPerson + "',b_Department='" + hybomodel.B_Department + "',b_SDate='" + hybomodel.B_SDate + "' where b_SKID='" + this.b_SKID.Text + "'";
                        int res = hybombll.com_HY_BomlistX(sql);
                        if (res > 0)
                        {

                            MessageBoxEx.Show("BOM单修改修改成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            requistionDate();
                        }

                    }
                }
                
            }
        }

        private void toolStripDel_Click(object sender, EventArgs e)
        {            
            string did = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            string sql1 = "Select b_Audit from HY_BomInfo where b_SKID='" + did + "'";
            SqlDataReader dr = hybomdel.f_SQLBom(sql1);
            while (dr.Read())
            {
                this.label10.Text = dr[0].ToString();
            }
            if (this.label10.Text != string.Empty)
            {
                MessageBoxEx.Show("此BOM单已审核不能删除,请解除审核后在删除", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             if (MessageBoxEx.Show("确定删除此BOM单后所属此单的物料明细将全部删除请谨慎操作", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "Delete from HY_BomDetails where d_SKID='" + did + "'";
                string sql2 = "Delete from HY_BomInfo where b_SKID='" + did + "'";
                hybomdel.f_HYBomDetailslist(sql);
                hybomdel.f_HYBomDetailslist(sql2);
                requistionDate();
            }
            return;
        }

        private void b_CID_Enter(object sender, EventArgs e)
        {
            this.b_CID.BackColor = Color.Green;
            this.b_CID.ForeColor = Color.White;
        }

        private void b_CID_Leave(object sender, EventArgs e)
        {
            this.b_CID.BackColor = Color.White;
            this.b_CID.ForeColor = Color.Black;
        }

        private void b_CustomerID_Enter(object sender, EventArgs e)
        {
            this.b_CustomerID.BackColor = Color.Green;
            this.b_CustomerID.ForeColor = Color.White;
        }

        private void b_CustomerID_Leave(object sender, EventArgs e)
        {
            this.b_CustomerID.BackColor = Color.White;
            this.b_CustomerID.ForeColor = Color.Black;
        }

        private void b_No_Enter(object sender, EventArgs e)
        {
            this.b_No.BackColor = Color.Green;
            this.b_No.ForeColor = Color.White;
        }

        private void b_No_Leave(object sender, EventArgs e)
        {
            this.b_No.BackColor = Color.White;
            this.b_No.ForeColor = Color.Black;
        }

        private void b_Material_Enter(object sender, EventArgs e)
        {
            this.b_Material.BackColor = Color.Green;
            this.b_Material.ForeColor = Color.White;
        }

        private void b_Material_Leave(object sender, EventArgs e)
        {
            this.b_Material.BackColor = Color.White;
            this.b_Material.ForeColor = Color.Black;
        }

        private void b_Height_Enter(object sender, EventArgs e)
        {
            this.b_Height.BackColor = Color.Green;
            this.b_Height.ForeColor = Color.White;
        }

        private void b_Height_Leave(object sender, EventArgs e)
        {
            this.b_Height.BackColor = Color.White;
            this.b_Height.ForeColor = Color.Black;
        }

        private void b_Tonnage_Enter(object sender, EventArgs e)
        {
            this.b_Tonnage.BackColor = Color.Green;
            this.b_Tonnage.ForeColor = Color.White;
        }

        private void b_Tonnage_Leave(object sender, EventArgs e)
        {
            this.b_Tonnage.BackColor = Color.White;
            this.b_Tonnage.ForeColor = Color.Black;
        }

        private void b_BomSize_Enter(object sender, EventArgs e)
        {
            this.b_BomSize.BackColor = Color.Green;
            this.b_BomSize.ForeColor = Color.White;
        }

        private void b_BomSize_Leave(object sender, EventArgs e)
        {
            this.b_BomSize.BackColor = Color.White;
            this.b_BomSize.ForeColor = Color.Black;
        }

        private void b_Notes_Enter(object sender, EventArgs e)
        {
            this.b_Notes.BackColor = Color.Green;
            this.b_Notes.ForeColor = Color.White;
        }

        private void b_Notes_Leave(object sender, EventArgs e)
        {
            this.b_Notes.BackColor = Color.White;
            this.b_Notes.ForeColor = Color.Black;
        }

        private void b_Name_Enter(object sender, EventArgs e)
        {
            this.b_Name.BackColor = Color.Green;
            this.b_Name.ForeColor = Color.White;
        }

        private void b_Name_Leave(object sender, EventArgs e)
        {
            this.b_Name.BackColor = Color.White;
            this.b_Name.ForeColor = Color.Black;
        }

        private void toolStripCEL_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
            this.groupBox4.Enabled = false;
            this.groupBox3.Enabled = true;
            this.toolStripCEL.Enabled = false;
            this.toolStripEdit.Enabled = false;
            this.toolStripDel.Enabled = false;
            this.toolStripAdd.Enabled = true;
            this.toolStripSave.Enabled = false;

            this.b_SKID.Text = "";
            this.b_SPerson.Text = "";
            this.b_CID.Text = "";
            this.b_CustomerID.Text = "";
            this.b_No.Text = "";
            this.b_Material.Text = "";
            this.b_Height.Text = "";
            this.b_Tonnage.Text = "";
            this.b_BomSize.Text = "";
            this.b_Notes.Text = "";
            this.b_Name.Text = "";
        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            string did = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            string sql1 = "Select b_Audit from HY_BomInfo where b_SKID='" + did + "'";
            SqlDataReader dr = hybomdel.f_SQLBom(sql1);
            while (dr.Read())
            {
                this.label10.Text = dr[0].ToString();
            }
            if (this.label10.Text != string.Empty)
            {
                MessageBoxEx.Show("此BOM单已审核不能做修改,请解除审核后在修改", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.groupBox1.Enabled = false;
                this.groupBox4.Enabled = false;
                this.toolStripCEL.Enabled = false;
                this.toolStripSave.Enabled = false;
                return;
            }
            this.groupBox1.Enabled = true;
            this.groupBox4.Enabled = true;
            this.groupBox3.Enabled = false;
            this.toolStripAdd.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = true;
            this.toolStripDel.Enabled = false;
            this.toolStripEdit.Enabled = false;
            intFalg = 2;
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewBOM_DoubleClick(object sender, EventArgs e)
        {
            string i = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.tabControlBOM.SelectedTabIndex = 1;
            this.dataGridViewBOMDET.AutoGenerateColumns = false;// 关闭自动创建列
            this.dataGridViewBOMDET.DataSource = hybomdel.ExecuteQuerySelect(i);
        }

        private void dataGridViewBOM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripAdd.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripDel.Enabled = true;
            this.toolStripEdit.Enabled = true;
            this.label10.Text = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.b_CID.Text = this.dataGridViewBOM[1, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.b_SKID.Text = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.b_CustomerID.Text = this.dataGridViewBOM[2, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.b_No.Text = this.dataGridViewBOM[3, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.b_Material.Text = this.dataGridViewBOM[4, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.b_BomSize.Text = this.dataGridViewBOM[5, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.b_Height.Text = this.dataGridViewBOM[6, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.b_Tonnage.Text = this.dataGridViewBOM[7, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.b_Name.Text = this.dataGridViewBOM[8, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.b_SPerson.Text = this.dataGridViewBOM[9, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.b_SDate.Value = Convert.ToDateTime(this.dataGridViewBOM[10, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString());
            this.b_Department.Text = this.dataGridViewBOM[16, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
        }
        /// 自定义返回请购人(跨窗口传值定义)
        /// </summary>
        /// <param name="Name">用户</param>
        /// <param name="Dep">所属部门</param>
        public void q_Person(string Name, string Dep)
        {
            this.b_SPerson.Text = Name;
            this.b_Department.Text = Dep;
        }
        //调入用户窗体
        private void btnPerson_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Production.HY_Person hyperson = new HY_Person();
            hyperson.hybom = this;//当前窗口传给HY_rPerson窗口
            hyperson.ShowDialog();//对话框模式打开窗口
        }
    }
}
