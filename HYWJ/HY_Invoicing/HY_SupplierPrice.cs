/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   供应商询价单信息主窗体
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
using HY_Model;

namespace HYWJ.HY_Invoicing
{
    public partial class HY_SupplierPrice : Office2007Form
    {
        public static int intFalg = 0;//控件方法状态
        private HY_BLL.HY_SupplierPriceBLL supbll;
        private HYWJ.HY_System.OperateAndValidate valid;//实例化数据验证类
        private HYWJ.HY_System.HY_NO hyNO; 
        public HY_SupplierPrice()
        {
            InitializeComponent();
            supbll = new HY_SupplierPriceBLL();
            valid = new HYWJ.HY_System.OperateAndValidate();
            hyNO = new HYWJ.HY_System.HY_NO();
        }

        private void HY_SupplierPrice_Load(object sender, EventArgs e)
        {
            this.toolStripEdit.Enabled = false;
            this.toolStripCEL.Enabled = false;
            this.toolStripDEL.Enabled = false;
            this.toolStripSave.Enabled = false;
            this.groupA.Enabled = false;
            this.groupB.Enabled = false;
            this.p_ID.Enabled = false;
            //绑定供应商料件信息列表
            gyInfo();
            //自动查询匹配下拉列表
            this.p_gyName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.p_gyName.AutoCompleteSource = AutoCompleteSource.ListItems;
            
        }

        /// <summary>
        /// 供应商信息数据绑定
        /// </summary>
        private void gyInfo()
        {
            this.dataGridViewSupplierPrice.AutoGenerateColumns = false;// 关闭自动创建列
            this.dataGridViewSupplierPrice.DataSource = supbll.back_SupplierPrice();
            //this.dataGridViewSupplierPrice.Columns["p_ID"].Visible = false;
            //this.da、taGridViewSupplierPrice.Columns["p_PID"].Visible = false;
        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            this.toolStripEdit.Enabled = false;
            this.toolStripAdd.Enabled = false;
            this.toolStripSave.Enabled = true;
            this.toolStripCEL.Enabled = true;
            this.groupA.Enabled = true;
            this.groupB.Enabled = true;
            string d = "DH";
            this.p_ID.Text = hyNO.JhGoodsID(d);
            intFalg = 1;

            //绑定供应商信息
            HY_BLL.HY_SupplierBLL hysup = new HY_SupplierBLL();
            this.p_gyName.DataSource = hysup.back_Supplier();
            this.p_gyName.DisplayMember = "s_gyName";
            this.p_gyName.ValueMember = "s_ID";

            //绑定用户信息
            HY_BLL.HY_UserListBLL hyul = new HY_UserListBLL();
            this.p_rPerson.DataSource = hyul.back_SupplierPrice();
            this.p_rPerson.DisplayMember = "h_UserName";
            this.p_rPerson.ValueMember = "h_ID";
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (!valid.validateNull(this.p_PID.Text.Trim()))
            {
                MessageBoxEx.Show("模号不能为空", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.p_PID.Focus();
                return;
            }
            if (!valid.validateNull(this.p_PName.Text.Trim()))
            {
                MessageBoxEx.Show("品名不能为空", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.p_PName.Focus();
                return;
            }
            if (!valid.validateNull(this.p_Price.Text.Trim()))
            {
                MessageBoxEx.Show("单价不能为空", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.p_Price.Focus();
                return;
            }
            if (!valid.validateNull(this.p_Weight.Text.Trim()))
            {
                MessageBoxEx.Show("重量不能为空", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.p_Weight.Focus();
                return;
            } 
            //添加动作
            if (intFalg == 1)
            {
                HY_Model.HY_SupplierPrice sup = new HY_Model.HY_SupplierPrice();
                sup.P_DID = this.p_ID.Text.Trim();
                sup.P_PID = this.p_PID.Text.Trim();
                sup.P_PName = this.p_PName.Text.Trim();
                sup.P_gyName = this.p_gyName.Text;
                sup.P_Date = (DateTime)(this.p_Date.Value.Date);
                sup.P_Price = int.Parse(this.p_Price.Text.Trim());
                sup.P_Weight = this.p_Weight.Text.Trim();
                sup.P_Vray = this.p_Vray.Text.Trim();
                sup.P_SM = this.p_SM.Text.Trim();
                sup.P_rPerson = this.p_rPerson.Text;
                    int res = supbll.com_SupplierPrice(sup);
                    if (res > 0)
                    {
                        MessageBoxEx.Show("提示信息：物料信息添加成功,您可以继续添加物料信息!", "操作提示信息");
                        this.p_PID.Text = "";
                        this.p_Weight.Text = "";
                        this.p_Vray.Text = "";
                        this.p_PName.Text = "";
                        this.p_Price.Text = "";
                        this.p_SM.Text = "";
                        string d = "DH";
                        this.p_ID.Text = hyNO.JhGoodsID(d);
                        gyInfo();
                    }          
            }

            //修改动作
            if (intFalg == 2)
            {
                string id = this.dataGridViewSupplierPrice[0, this.dataGridViewSupplierPrice.CurrentCell.RowIndex].Value.ToString();
                string sql = "update HY_SupplierPrice set p_DID='" + this.p_ID.Text.Trim() + "',p_PID='" + this.p_PID.Text.Trim() + "',p_gyName='" + this.p_gyName.Text + "',p_Date='" + this.p_Date.Value.Date + "',p_PName='" + this.p_PName.Text.Trim() + "',p_Price='" + this.p_Price.Text.Trim() + "',p_Weight='" + this.p_Weight.Text.Trim() + "',p_Vray='" + this.p_Vray.Text.Trim() + "',p_SM='" + this.p_SM.Text.Trim() + "',p_rPerson='" + this.p_rPerson.Text + "' where p_DID='" + id + "'";
                int res = supbll.f_SupplierPrice(sql);
                if (res > 0)
                {
                    MessageBoxEx.Show("请购信息更新修改成功！", "操作提示", MessageBoxButtons.OK);
                    gyInfo();//绑定数据显示
                }
            }
            
        }
      
        private void toolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            this.groupA.Enabled = true;
            this.groupB.Enabled = true;
            this.groupC.Enabled = false;
            this.toolStripAdd.Enabled = false;
            this.toolStripDEL.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripEdit.Enabled = false;
            this.toolStripSave.Enabled = true;
            intFalg = 2;
        }

        private void toolStripCEL_Click(object sender, EventArgs e)
        {
            this.toolStripAdd.Enabled = true;
            this.toolStripEdit.Enabled = false;
            this.toolStripCEL.Enabled = false;
            this.toolStripDEL.Enabled = false;
            this.toolStripSave.Enabled = false;
            this.groupA.Enabled = false;
            this.groupB.Enabled = false;
            this.groupC.Enabled = true;
        }

        private void dataGridViewSupplierPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripAdd.Enabled = false;
            this.toolStripDEL.Enabled = true;
            this.toolStripEdit.Enabled = true;
            this.toolStripCEL.Enabled = true;
            this.groupA.Enabled = true;
            this.p_ID.Text = this.dataGridViewSupplierPrice[0, this.dataGridViewSupplierPrice.CurrentCell.RowIndex].Value.ToString();
            this.p_gyName.Text = this.dataGridViewSupplierPrice[6, this.dataGridViewSupplierPrice.CurrentCell.RowIndex].Value.ToString();
            this.p_rPerson.Text = this.dataGridViewSupplierPrice[9, this.dataGridViewSupplierPrice.CurrentCell.RowIndex].Value.ToString();
            this.p_PName.Text = this.dataGridViewSupplierPrice[2, this.dataGridViewSupplierPrice.CurrentCell.RowIndex].Value.ToString();
            this.p_Price.Text = this.dataGridViewSupplierPrice[3, this.dataGridViewSupplierPrice.CurrentCell.RowIndex].Value.ToString();
            this.p_Weight.Text = this.dataGridViewSupplierPrice[4, this.dataGridViewSupplierPrice.CurrentCell.RowIndex].Value.ToString();
            this.p_Vray.Text = this.dataGridViewSupplierPrice[5, this.dataGridViewSupplierPrice.CurrentCell.RowIndex].Value.ToString();
            this.p_PID.Text = this.dataGridViewSupplierPrice[1, this.dataGridViewSupplierPrice.CurrentCell.RowIndex].Value.ToString();
            this.p_SM.Text = this.dataGridViewSupplierPrice[7, this.dataGridViewSupplierPrice.CurrentCell.RowIndex].Value.ToString();
            this.p_Date.Value = (DateTime)this.dataGridViewSupplierPrice[8, this.dataGridViewSupplierPrice.CurrentCell.RowIndex].Value;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripDEL_Click(object sender, EventArgs e)
        {
            string id = this.dataGridViewSupplierPrice[1, this.dataGridViewSupplierPrice.CurrentCell.RowIndex].Value.ToString();
            if (MessageBoxEx.Show("确定后此条信息将被删除不可恢复！ ", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string sql = "Delete from HY_SupplierPrice where p_PID='" + id + "'";
                    int res = supbll.f_SupplierPrice(sql);
                    gyInfo();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                return;
            }   
        }
    }
}
