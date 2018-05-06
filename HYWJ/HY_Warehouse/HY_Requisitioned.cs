/*  
 * 作者: JOY 
 * 创建时间: 2009-12-30 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明: 物料领取主窗体
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
using HY_Model;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HYWJ.HY_Warehouse
{
    public partial class HY_Requisitioned : Office2007Form
    {
        private HY_BLL.HY_RequisitionedBLL hyreqbll;
        private HYWJ.HY_System.OperateAndValidate valid;//实例化数据验证类
        public static int intFalg = 0;//控件方法状态
        public HY_Requisitioned()
        {
            InitializeComponent();
            hyreqbll = new HY_RequisitionedBLL();
            valid = new HYWJ.HY_System.OperateAndValidate();
        }

        private void HY_Requisitioned_Load(object sender, EventArgs e)
        {
            this.groupBox2.Enabled = false;
            this.toolStripCEL.Enabled = false;
            this.toolStripDEL.Enabled = false;
            this.toolStripUPD.Enabled = false;
            this.toolStripSave.Enabled = false;
            requistionDate();//加载数据
        }
        /// <summary>
        /// 自定义绑定领料单号
        /// </summary>
        private void f_DID()
        {
            string D = "L";
            HYWJ.HY_System.HY_NO hyNO = new HYWJ.HY_System.HY_NO();
            this.label1.Text = hyNO.JhGoodsID(D);
        }
        //自定义绑定数据
        private void requistionDate()
        {
            this.dataGridViewL.AutoGenerateColumns = false;// 关闭自动创建列
            string sql = "select * from HY_Receiving order by r_ID desc";
            this.dataGridViewL.DataSource = hyreqbll.ExecuteQuery(sql);
        }
        private void toolStripADD_Click(object sender, EventArgs e)
        {
            this.toolStripADD.Enabled = false;
            this.groupBox2.Enabled = true;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = true;
            f_DID();//生成领料单号
            intFalg = 1;
        }

        private void btnPN_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Warehouse.HY_MaterialID hymat = new HY_MaterialID();
            hymat.hyreq = this;
            hymat.ShowDialog();
        }
        /// <summary>
        /// 自定义返品名(跨窗口传值定义)
        /// </summary>
        /// <param name="Name">姓名</param>
        public void r_PName(string PID,string CID, string Name, string Specifications, string Price,string Rclass, string Warehouse)
        {
            this.s_CID.Text = CID;
            this.s_Pname.Text = Name;
            this.s_PID.Text=PID;
            this.s_Specifications.Text = Specifications;
            this.s_Price.Text =Price;
            this.s_Class.Text = Rclass;
            this.s_Warehouse.Text = Warehouse;
        }

        private void toolStripCEL_Click(object sender, EventArgs e)
        {
                this.s_PID.Text = "";
                this.s_Pname.Text = "";
                this.s_Person.Text = "";
                this.s_Price.Text = "";
                this.s_Specifications.Text = "";
                this.s_Amount.Text = "";
                this.s_DDate.Text = "";
                this.s_Notes.Text = "";

                this.groupBox2.Enabled = false;
                this.toolStripCEL.Enabled = false;
                this.toolStripDEL.Enabled = false;
                this.toolStripUPD.Enabled = false;
                this.toolStripSave.Enabled = false;
                this.toolStripADD.Enabled = true;
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (!valid.validateNull(this.s_Pname.Text.Trim()))
            {
                MessageBox.Show("领取物料品名不能为空", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.s_Pname.Focus();
                return;
            }
            if (!valid.validateNull(this.s_Person.Text.Trim()))
            {
                MessageBox.Show("领料人姓名不能为空", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.s_Person.Focus();
                return;
            }

            if (!valid.validateNull(this.s_Amount.Text.Trim()))
            {
                MessageBox.Show("领取物料数量不能为空", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.s_Amount.Focus();
                return;
            }
           else if (!valid.validateNum(this.s_Amount.Text.Trim()))
            {
                MessageBox.Show("领取物料数量只能是数字类型", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.s_Amount.Focus();
                return;
            }
           
            HY_Model.HY_Requisitioned hyreqmodel = new HY_Model.HY_Requisitioned();
            hyreqmodel.R_DID = this.label1.Text;
            hyreqmodel.R_CID = this.s_CID.Text.Trim();
            hyreqmodel.R_Person = this.s_Person.Text.Trim();
            hyreqmodel.R_PID = this.s_PID.Text.Trim();
            hyreqmodel.R_Pname = this.s_Pname.Text.Trim();
            hyreqmodel.R_LDate = Convert.ToDateTime(this.s_DDate.Value);
            hyreqmodel.R_Specifications = this.s_Specifications.Text.Trim();
            hyreqmodel.R_Price = this.s_Price.Text.Trim();
            hyreqmodel.R_Class = this.s_Class.Text;
            hyreqmodel.R_Amount = int.Parse(this.s_Amount.Text);
            hyreqmodel.R_Warehouse = this.s_Warehouse.Text;
            hyreqmodel.R_Notes = this.s_Notes.Text.Trim();

            if (intFalg == 1)
            {
                string sql = "insert into HY_Receiving(r_DID,r_CID,r_Person,r_Class,r_Warehouse,r_LDate,r_PID,r_Pname,r_Specifications,r_Amount,r_Price,r_Notes) values('" + hyreqmodel.R_DID + "','" + hyreqmodel.R_CID + "','" + hyreqmodel.R_Person + "','" + hyreqmodel.R_Class + "','" + hyreqmodel.R_Warehouse + "','" + hyreqmodel.R_LDate + "','" + hyreqmodel.R_PID + "','" + hyreqmodel.R_Pname + "','" + hyreqmodel.R_Specifications + "','" + hyreqmodel.R_Amount + "','" + hyreqmodel.R_Price + "','" + hyreqmodel.R_Notes + "')";
                int res = hyreqbll.com_HY_ProductionPlanninglist(sql);
                if (res > 0)
                {
                    //更新库存数量
                    string sql1 = "update HY_Storage set s_Amount=s_Amount-'" + hyreqmodel.R_Amount + "' where s_PID='" + hyreqmodel.R_PID + "'";
                    hyreqbll.com_HY_ProductionPlanninglist(sql1);
                    //写入log库存表
                    string sqllog = "insert into HY_StorageLog(s_DID,s_CID,s_Person,s_Class,s_Warehouse,s_XDate,s_DDate,s_PID,s_Pname,s_Specifications,s_Amount,s_Price,s_Notes,s_State) values('" + hyreqmodel.R_DID + "','" + hyreqmodel.R_CID + "','" + hyreqmodel.R_Person + "','" + hyreqmodel.R_Class + "','" + hyreqmodel.R_Warehouse + "','" + hyreqmodel.R_LDate + "','" + hyreqmodel.R_LDate + "','" + hyreqmodel.R_PID + "','" + hyreqmodel.R_Pname + "','" + hyreqmodel.R_Specifications + "','" + hyreqmodel.R_Amount + "','" + hyreqmodel.R_Price + "','" + hyreqmodel.R_Notes + "','仓库领料')";
                    hyreqbll.com_HY_ProductionPlanninglist(sqllog);
                    MessageBox.Show("领料单添加成功，确定后可以继续添加", "操作提示", MessageBoxButtons.OK);
                    requistionDate();
                }
            }
            if (intFalg == 2)
            {
                string sql = "update HY_Receiving set r_DID='" + hyreqmodel.R_DID + "',r_Person='" + hyreqmodel.R_Person + "',r_Class='" + hyreqmodel.R_Class + "',r_Warehouse='" + hyreqmodel.R_Warehouse + "',r_LDate='" + hyreqmodel.R_LDate + "',r_Pname='" + hyreqmodel.R_Pname + "',r_Specifications='" + hyreqmodel.R_Specifications + "',r_Amount='" + hyreqmodel.R_Amount + "',r_Price='" + hyreqmodel.R_Price + "',r_Notes='" + hyreqmodel.R_Notes + "' where r_PID='" + hyreqmodel.R_PID + "'";
                int res = hyreqbll.com_HY_ProductionPlanninglist(sql);
                if (res > 0)
                {
                    //更新库存数量
                    //string sql1 = "update HY_Storage set s_Amount=s_Amount-'" + hyreqmodel.R_Amount + "' where s_PID='" + hyreqmodel.R_PID + "'";
                    //hyreqbll.com_HY_ProductionPlanninglist(sql1);
                    MessageBox.Show("领料单信息修改成功，确定后可以继续操作", "操作提示", MessageBoxButtons.OK);
                    requistionDate();
                }
            }
            
        }
        private void s_Amount_Enter(object sender, EventArgs e)
        {
            this.s_Amount.BackColor = Color.Green;
            this.s_Amount.ForeColor = Color.White;
        }

        private void s_Amount_Leave(object sender, EventArgs e)
        {
            this.s_Amount.BackColor = Color.White;
            this.s_Amount.ForeColor = Color.Black;
        }

        private void s_Person_Enter(object sender, EventArgs e)
        {
            this.s_Person.BackColor = Color.Green;
            this.s_Person.ForeColor = Color.White;
        }

        private void s_Person_Leave(object sender, EventArgs e)
        {
            this.s_Person.BackColor = Color.White;
            this.s_Person.ForeColor = Color.Black;
        }
        //删除
        private void toolStripDEL_Click(object sender, EventArgs e)
        {
            string pid = this.dataGridViewL[1, this.dataGridViewL.CurrentCell.RowIndex].Value.ToString();
            string sql = "Delete from HY_Receiving where r_PID='" + pid + "'";
            if (MessageBox.Show("确定后此条领料单将被删除不可恢复！ ", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int res = hyreqbll.com_HY_ProductionPlanninglist(sql);
                requistionDate();
            }
            else
            {
                return;
            }
          
        }

        private void toolStripUPD_Click(object sender, EventArgs e)
        {
            this.toolStripADD.Enabled = false;
            this.toolStripUPD.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = true;
            this.groupBox2.Enabled = true;
            intFalg = 2;
        }

        private void toolStripOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripDEL.Enabled = true;
            this.toolStripUPD.Enabled = true;
            this.toolStripCEL.Enabled = true;

            this.s_PID.Text = this.dataGridViewL[1, this.dataGridViewL.CurrentCell.RowIndex].Value.ToString();
            this.s_Pname.Text = this.dataGridViewL[2, this.dataGridViewL.CurrentCell.RowIndex].Value.ToString();
            this.s_Specifications.Text = this.dataGridViewL[4, this.dataGridViewL.CurrentCell.RowIndex].Value.ToString();
            this.s_Price.Text = this.dataGridViewL[5, this.dataGridViewL.CurrentCell.RowIndex].Value.ToString();
            this.s_Amount.Text = this.dataGridViewL[6, this.dataGridViewL.CurrentCell.RowIndex].Value.ToString();
            this.s_Person.Text = this.dataGridViewL[7, this.dataGridViewL.CurrentCell.RowIndex].Value.ToString();
            this.s_DDate.Text = this.dataGridViewL[8, this.dataGridViewL.CurrentCell.RowIndex].Value.ToString();
            this.s_Notes.Text = this.dataGridViewL[9, this.dataGridViewL.CurrentCell.RowIndex].Value.ToString();
        }
    }
}
