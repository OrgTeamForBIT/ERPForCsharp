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
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using HY_BLL;
using HY_Model;

namespace HYWJ.HY_Production
{
    public partial class HY_BomDetails : Office2007Form
    {
        private HY_BLL.HY_BomDetailsBLL hybombll;
        private HYWJ.HY_System.OperateAndValidate valid;//实例化数据验证类
        public static int intFalg = 0;//控件方法状态
        public HY_BomDetails()
        {
            InitializeComponent();
            hybombll = new HY_BomDetailsBLL();
            valid = new HYWJ.HY_System.OperateAndValidate();
        }

        private void HY_BomDetails_Load(object sender, EventArgs e)
        {
            this.groupBoxA.Enabled = false;
            this.groupBoxB.Enabled = false;
            this.toolStripDel.Enabled = false;
            this.toolStripEdit.Enabled = false;
            this.toolStripSave.Enabled = false;
            this.toolStripCEL.Enabled = false;
            requistionDate();
        }
        //自定义绑定数据
        private void requistionDate()
        {
            this.dataGridViewBOMDET.AutoGenerateColumns = false;// 关闭自动创建列
            this.dataGridViewBOMDET.DataSource = hybombll.ExecuteQuery();
        }
        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            this.groupBoxA.Enabled = true;
            this.groupBoxB.Enabled = true;
            this.groupBoxC.Enabled = false;
            this.toolStripAdd.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = true;
            intFalg = 1;
            b_PID();
        }
        /// <summary>
        /// 自定义返受控编号(跨窗口传值定义)
        /// </summary>
        /// <param name="Name">姓名</param>
        public void b_SKID(string NO)
        {
            this.d_SKID.Text = NO;
        }

        /// <summary>
        /// 自定义绑定品号
        /// </summary>
        private void b_PID()
        {
            string P = "P";
            HYWJ.HY_System.HY_NO hyNO = new HYWJ.HY_System.HY_NO();
            this.d_PID.Text = hyNO.JhGoodsID(P);
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            #region 数据验证部分
            if (!valid.validateNull(this.d_SKID.Text.Trim()))
            {
                MessageBoxEx.Show("所属物料单号不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.d_SKID.Focus();
                return;
            }
            if (!valid.validateNull(this.d_Name.Text.Trim()))
            {
                MessageBoxEx.Show("品名不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.d_Name.Focus();
                return;
            }
            if (!valid.validateNull(this.d_Model.Text.Trim()))
            {
                MessageBoxEx.Show("材料型号不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.d_Model.Focus();
                return;
            }
            if (!valid.validateNull(this.d_Model.Text.Trim()))
            {
                MessageBoxEx.Show("材料规格不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.d_Model.Focus();
                return;
            }
            if (!valid.validateNull(this.d_Amount.Text.Trim()))
            {
                MessageBoxEx.Show("材料数量不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.d_Amount.Focus();
                return;
            }
            else if (!valid.validateNum(this.d_Amount.Text.Trim()))
            {
                MessageBoxEx.Show("材料数量只能填写数字类型！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.d_Amount.Focus();
                return;
            }
            if (!valid.validateNull(this.d_Heat.Text.Trim()))
            {
                MessageBoxEx.Show("热处理不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.d_Heat.Focus();
                return;
            }
            #endregion
            #region 实体类
            HY_Model.HY_BomDetails hybommodel = new HY_Model.HY_BomDetails();
            hybommodel.D_SKID = this.d_SKID.Text.Trim();
            hybommodel.D_CID = this.d_CID.Text.Trim();
            hybommodel.D_PID = this.d_PID.Text.Trim();
            hybommodel.D_PName = this.d_Name.Text.Trim();
            hybommodel.D_Model = this.d_Model.Text.Trim();
            hybommodel.D_Specifications = this.d_Specifications.Text.Trim();
            hybommodel.D_Amount = this.d_Amount.Text.Trim();
            hybommodel.D_Heat = this.d_Heat.Text.Trim();
            hybommodel.D_Notes = this.d_Notes.Text.Trim();
            hybommodel.D_SPerson = this.d_SPerson.Text.Trim();
            hybommodel.ModClass = this.label1.Text;
            #endregion
            //保存动作
            if (intFalg==1)
            {
                //实例化BOM明细
                int res = hybombll.com_HY_BomDetailslist(hybommodel);
                if (res > 0)
                {
                    MessageBoxEx.Show("BOM明细添加成功，确定后可继续添加明细","操作提示",MessageBoxButtons.OK);
                    b_PID();//绑定品号
                    this.d_Name.Text = "";
                    this.d_Model.Text = "";
                    this.d_Specifications.Text = "";
                    this.d_Amount.Text = "";
                    this.d_Heat.Text = "";
                    this.d_Notes.Text = "";
                    requistionDate();//绑定BOM明细
                }
            }
            //修改动作
            if (intFalg == 2)
            {
                
                //实例化BOM明细
                string sql = "Update HY_BomDetails set d_PID='" + hybommodel.D_PID + "',d_PName='" + hybommodel.D_PName + "',d_Model='" + hybommodel.D_Model + "',d_Specifications='" + hybommodel.D_Specifications + "',d_Amount='" + hybommodel.D_Amount + "',d_Heat='" + hybommodel.D_Heat + "',d_Notes='" + hybommodel.D_Notes + "',d_SPerson='" + hybommodel.D_SPerson + "',d_ModClass='" + hybommodel.ModClass + "' where d_PID='" + hybommodel.D_PID + "'";
                int res = hybombll.f_HYBomDetailslist(sql);
                if (res > 0)
                {
                    MessageBoxEx.Show("BOM明细信息修改成功！", "操作提示", MessageBoxButtons.OK);
                    this.groupBoxA.Enabled = false;
                    this.groupBoxB.Enabled = false;
                    this.groupBoxC.Enabled = true;
                    this.d_Name.Text = "";
                    this.d_Model.Text = "";
                    this.d_Specifications.Text = "";
                    this.d_Amount.Text = "";
                    this.d_Heat.Text = "";
                    this.d_Notes.Text = "";
                    requistionDate();//绑定BOM明细
                }
            }
        }

        #region 输入框变色事件
        private void d_Name_Enter(object sender, EventArgs e)
        {
            this.d_Name.BackColor = Color.Green;
            this.d_Name.ForeColor = Color.White;
        }

        private void d_Name_Leave(object sender, EventArgs e)
        {
            this.d_Name.BackColor = Color.White;
            this.d_Name.ForeColor = Color.Black;
        }

        private void d_Model_Enter(object sender, EventArgs e)
        {
            this.d_Model.BackColor = Color.Green;
            this.d_Model.ForeColor = Color.White;
        }

        private void d_Model_Leave(object sender, EventArgs e)
        {
            this.d_Model.BackColor = Color.White;
            this.d_Model.ForeColor = Color.Black;
        }

        private void d_Specifications_Enter(object sender, EventArgs e)
        {
            this.d_Model.BackColor = Color.Green;
            this.d_Model.ForeColor = Color.White;
        }

        private void d_Specifications_Leave(object sender, EventArgs e)
        {
            this.d_Model.BackColor = Color.White;
            this.d_Model.ForeColor = Color.Black;
        }

        private void d_Amount_Enter(object sender, EventArgs e)
        {
            this.d_Amount.BackColor = Color.Green;
            this.d_Amount.ForeColor = Color.White;
        }

        private void d_Amount_Leave(object sender, EventArgs e)
        {
            this.d_Amount.BackColor = Color.White;
            this.d_Amount.ForeColor = Color.Black;
        }

        private void d_Heat_Enter(object sender, EventArgs e)
        {
            this.d_Heat.BackColor = Color.Green;
            this.d_Heat.ForeColor = Color.White;
        }

        private void d_Heat_Leave(object sender, EventArgs e)
        {
            this.d_Heat.BackColor = Color.White;
            this.d_Heat.ForeColor = Color.Black;
        }

        private void d_Notes_Enter(object sender, EventArgs e)
        {
            this.d_Notes.BackColor = Color.Green;
            this.d_Notes.ForeColor = Color.White;
        }

        private void d_Notes_Leave(object sender, EventArgs e)
        {
            this.d_Notes.BackColor = Color.White;
            this.d_Notes.ForeColor = Color.Black;
        }
        #endregion
        //删除动作
        private void toolStripDel_Click(object sender, EventArgs e)
        {
            string did = this.dataGridViewBOMDET[0, this.dataGridViewBOMDET.CurrentCell.RowIndex].Value.ToString();
            string pid = this.dataGridViewBOMDET[1, this.dataGridViewBOMDET.CurrentCell.RowIndex].Value.ToString();
            string sql1 = "Select b_SKID,b_Audit from HY_BomInfo where b_SKID='" + did + "'";
            SqlDataReader dr = hybombll.f_SQLBom(sql1);
            while (dr.Read())
            {
                this.label1.Text = dr[1].ToString();
            }
            if (this.label1.Text != string.Empty)
            {
                MessageBoxEx.Show("此条品号对应BOM单已审核不能删除,请解除审核后在删除", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBoxEx.Show("确定删除此条品号信息后不可恢复", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                
                if (this.label1.Text == string.Empty)
                {
                    string sql = "Delete from HY_BomDetails where d_PID='" + pid + "'";
                    int resdel=hybombll.f_HYBomDetailslist(sql);
                    requistionDate();
                } 
            }
        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
           
            string did = this.dataGridViewBOMDET[0, this.dataGridViewBOMDET.CurrentCell.RowIndex].Value.ToString();
            string pid = this.dataGridViewBOMDET[1, this.dataGridViewBOMDET.CurrentCell.RowIndex].Value.ToString();
            string sql1 = "Select b_SKID,b_Audit from HY_BomInfo where b_SKID='" + did + "'";
            SqlDataReader dr = hybombll.f_SQLBom(sql1);
            while (dr.Read())
            {
                this.label1.Text = dr[1].ToString();
            }
            if (this.label1.Text != string.Empty)
            {
                MessageBoxEx.Show("此条信息已审核不能修改,请解除审核后在修改", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.groupBoxA.Enabled = true;
            this.groupBoxB.Enabled = true;
            this.groupBoxC.Enabled = false;
            this.toolStripEdit.Enabled = false;
            this.toolStripDel.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = true;
            intFalg = 2;
        }

        private void toolStripCEL_Click(object sender, EventArgs e)
        {
            this.groupBoxA.Enabled = false;
            this.groupBoxB.Enabled = false;
            this.groupBoxC.Enabled = true;
            this.toolStripCEL.Enabled = false;
            this.toolStripEdit.Enabled = false;
            this.toolStripDel.Enabled = false;
            this.toolStripAdd.Enabled = true;
            this.toolStripSave.Enabled = false;

        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewBOMDET_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripAdd.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.d_SKID.Text = this.dataGridViewBOMDET[0, this.dataGridViewBOMDET.CurrentCell.RowIndex].Value.ToString();
            this.d_PID.Text = this.dataGridViewBOMDET[1, this.dataGridViewBOMDET.CurrentCell.RowIndex].Value.ToString();
            this.d_Name.Text = this.dataGridViewBOMDET[2, this.dataGridViewBOMDET.CurrentCell.RowIndex].Value.ToString();
            this.d_Model.Text = this.dataGridViewBOMDET[3, this.dataGridViewBOMDET.CurrentCell.RowIndex].Value.ToString();
            this.d_Specifications.Text = this.dataGridViewBOMDET[4, this.dataGridViewBOMDET.CurrentCell.RowIndex].Value.ToString();
            this.d_Amount.Text = this.dataGridViewBOMDET[5, this.dataGridViewBOMDET.CurrentCell.RowIndex].Value.ToString();
            this.d_Heat.Text = this.dataGridViewBOMDET[6, this.dataGridViewBOMDET.CurrentCell.RowIndex].Value.ToString();
            this.d_Notes.Text = this.dataGridViewBOMDET[8, this.dataGridViewBOMDET.CurrentCell.RowIndex].Value.ToString();
            
        }

        private void d_SKID_TextChanged(object sender, EventArgs e)
        {
            if (this.d_SKID.Text != string.Empty)
            {
                string skid = this.d_SKID.Text;
                HY_BLL.HY_BomlistBLL hybombll = new HY_BomlistBLL();
                SqlDataReader sdr = hybombll.f_BomlistSelect(skid);
                while (sdr.Read())
                {
                    this.d_CID.Text = sdr["b_CID"].ToString();
                    this.d_CustomerID.Text = sdr["b_CustomerID"].ToString();
                    this.d_SPerson.Text = sdr["b_SPerson"].ToString();
                    this.d_SDate.Text = sdr["b_SDate"].ToString();
                    this.label1.Text = sdr["b_ModClass"].ToString();
                }
            }
        }

        private void btnSKID_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Production.HY_SKID hysk = new HY_SKID();
            hysk.hybomdet = this;
            hysk.ShowDialog();
        }

        private void dataGridViewBOMDET_Click(object sender, EventArgs e)
        {
            this.toolStripDel.Enabled = true;
            this.toolStripEdit.Enabled = true;
        }
    }
}