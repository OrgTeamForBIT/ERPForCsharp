using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using HY_Model;
using HY_BLL;

namespace HYWJ.HY_System
{
    
    public partial class HY_Supplier : Office2007Form
    {
        private HY_BLL.HY_StorageBLL hystorbll = null;
        public static int intFalg = 0;//控件方法状态
        public HY_Supplier()
        {
            InitializeComponent();
            hystorbll = new HY_StorageBLL();
        }

        /// <summary>
        /// 验证用户录入信息
        /// </summary>
        /// <returns></returns>
        private bool UserInputCheck()
        {
            // 供应商名称
            string gyName = this.gyName.Text.Trim();
            // 供应商简称
            string jName = this.jName.Text.Trim();
            //地区
            string Area = this.Area.Text.Trim();
            // 业务范围
            string cpName = this.cpName.Text.Trim();
            string name = this.name.Text.Trim();
            string tel = this.tel.Text.Trim();

            // 开始验证
            if (string.IsNullOrEmpty(gyName))
            {
                this.toolTip.ToolTipIcon = ToolTipIcon.Info;
                this.toolTip.ToolTipTitle = "录入提示：";
                Point showLocation = new Point(
                    this.gyName.Location.X + this.gyName.Width,
                    this.gyName.Location.Y);
                this.toolTip.Show("供应商名称不能为空！", this, showLocation, 5000);
                this.gyName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cpName))
            {
                this.toolTip.ToolTipIcon = ToolTipIcon.Info;
                this.toolTip.ToolTipTitle = "录入提示";
                Point showLocation = new Point(
                    this.cpName.Location.X + this.cpName.Width,
                    this.cpName.Location.Y);
                this.toolTip.Show("请您输入供应商业务范围！", this, showLocation, 5000);
                this.cpName.Focus();
                return false;
            }
            

            // 如果已通过以上所有验证则返回真
            return true;
        }

        private void gyName_Enter(object sender, EventArgs e)
        {
            this.gyName.BackColor = Color.Green;
            this.gyName.ForeColor = Color.White;
        }

        private void gyName_Leave(object sender, EventArgs e)
        {
            this.gyName.BackColor = Color.White;
            this.gyName.ForeColor = Color.Black;
        }

        private void jName_Enter(object sender, EventArgs e)
        {
            this.jName.BackColor = Color.Green;
            this.jName.ForeColor = Color.White;
        }

        private void jName_Leave(object sender, EventArgs e)
        {
            this.jName.BackColor = Color.White;
            this.jName.ForeColor = Color.Black;
        }

        private void Area_Enter(object sender, EventArgs e)
        {
            this.Area.BackColor = Color.Green;
            this.Area.ForeColor = Color.White;
        }

        private void Area_Leave(object sender, EventArgs e)
        {
            this.Area.BackColor = Color.White;
            this.Area.ForeColor = Color.Black;
        }

        private void cpName_Enter(object sender, EventArgs e)
        {
            this.cpName.BackColor = Color.Green;
            this.cpName.ForeColor = Color.White;
        }

        private void cpName_Leave(object sender, EventArgs e)
        {
            this.cpName.BackColor = Color.White;
            this.cpName.ForeColor = Color.Black;
        }

        private void name_Enter(object sender, EventArgs e)
        {
            this.name.BackColor = Color.Green;
            this.name.ForeColor = Color.White;
        }

        private void name_Leave(object sender, EventArgs e)
        {
            this.name.BackColor = Color.White;
            this.name.ForeColor = Color.Black;
        }

        private void tel_Enter(object sender, EventArgs e)
        {
            this.tel.BackColor = Color.Green;
            this.tel.ForeColor = Color.White;
        }

        private void tel_Leave(object sender, EventArgs e)
        {
            this.tel.BackColor = Color.White;
            this.tel.ForeColor = Color.Black;
        }

        //自定义绑定数据
        private void requistionDate()
        {
            this.dataGridViewSUP.AutoGenerateColumns = false;// 关闭自动创建列
            HY_BLL.HY_BomlistBLL hybombll = new HY_BomlistBLL();
            string sql = "select * from HY_Supplier order by s_ID desc";
            this.dataGridViewSUP.DataSource = hybombll.ExecuteQuery(sql);
        }

        private void CEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            HY_Model.HY_Supplier u = new HY_Model.HY_Supplier();
            u.S_gyName = this.gyName.Text.Trim();
            u.S_jName = this.jName.Text.Trim();
            u.S_Area = this.Area.Text.Trim();
            u.S_cpName = this.cpName.Text.Trim();
            u.S_name = this.name.Text.Trim();
            u.S_tel = this.tel.Text.Trim();
            
            //添加动作
            if (intFalg == 1)
            {
                bool isEmpty = UserInputCheck();
                if (isEmpty == true)
                {
                    HY_BLL.HY_SupplierBLL hysup = new HY_SupplierBLL();
                    int res = hysup.com_Supplier(u);
                    if (res > 0)
                    {
                        MessageBoxEx.Show("提示信息：供应商信息添加成功!");
                        this.Close();
                    }
                }
            }

            if (intFalg == 2)
            {
                bool isEmpty = UserInputCheck();
                if (isEmpty == true)
                {
                    string sql = "Update HY_Supplier set s_gyName='" + this.gyName.Text.Trim() + "',s_jName='" + this.jName.Text.Trim() + "',s_Area='" + this.Area.Text.Trim() + "',s_cpName='" + this.cpName.Text.Trim() + "',s_Name='" + this.name.Text.Trim() + "',s_Tel='" + this.tel.Text.Trim() + "' where s_ID='" + this.label1.Text.Trim() + "'";
                    int res = hystorbll.com_HY_HY_Storagelslist(sql);
                    if (res > 0)
                    {
                        MessageBoxEx.Show("产品修改成功，确定后关闭窗口!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                        requistionDate();
                        this.Close();
                    }
                }
            }
        }

        private void toolStripADD_Click(object sender, EventArgs e)
        {
            this.toolStripADD.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = true;
            this.groupPanel1.Enabled = true;
            this.groupPanel2.Enabled = false;
            intFalg = 1;
        }

        private void toolStripUPD_Click(object sender, EventArgs e)
        {
            this.toolStripADD.Enabled = false;
            this.toolStripUPD.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripDEL.Enabled = false;
            this.toolStripSave.Enabled = true;
            this.groupPanel1.Enabled = true;
            this.groupPanel2.Enabled = false;
            intFalg = 2;
        }

        private void toolStripOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HY_Supplier_Load(object sender, EventArgs e)
        {
            this.toolStripCEL.Enabled = false;
            this.toolStripSave.Enabled = false;
            this.toolStripUPD.Enabled = false;
            this.toolStripDEL.Enabled = false;
            requistionDate();
        }

        private void dataGridViewSUP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripDEL.Enabled = true;
            this.toolStripUPD.Enabled = true;
            this.toolStripADD.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = false;

            this.label1.Text = this.dataGridViewSUP[0, this.dataGridViewSUP.CurrentCell.RowIndex].Value.ToString();
            this.gyName.Text=this.dataGridViewSUP[1, this.dataGridViewSUP.CurrentCell.RowIndex].Value.ToString();
            this.jName.Text=this.dataGridViewSUP[2, this.dataGridViewSUP.CurrentCell.RowIndex].Value.ToString();
            this.Area.Text=this.dataGridViewSUP[3, this.dataGridViewSUP.CurrentCell.RowIndex].Value.ToString();
            this.cpName.Text=this.dataGridViewSUP[6, this.dataGridViewSUP.CurrentCell.RowIndex].Value.ToString();
            this.name.Text=this.dataGridViewSUP[4, this.dataGridViewSUP.CurrentCell.RowIndex].Value.ToString();
            this.tel.Text = this.dataGridViewSUP[5, this.dataGridViewSUP.CurrentCell.RowIndex].Value.ToString();
        }

        private void toolStripCEL_Click(object sender, EventArgs e)
        {
            this.toolStripADD.Enabled = true;
            this.toolStripCEL.Enabled = false;
            this.toolStripSave.Enabled = false;
            this.toolStripUPD.Enabled = false;
            this.toolStripDEL.Enabled = false;
            this.groupPanel1.Enabled = false;
            this.groupPanel2.Enabled = true;
        }

        private void toolStripDEL_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("确定后此条供应商信息将被删除不可恢复！ ", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string pid = this.dataGridViewSUP[0, this.dataGridViewSUP.CurrentCell.RowIndex].Value.ToString();
                string sql = "delete from HY_Supplier where s_ID='" + pid + "'";
                int res = hystorbll.com_HY_HY_Storagelslist(sql);
                if (res > 0)
                {
                    requistionDate();//初始化绑定数据 
                }
                else
                {
                    MessageBox.Show("删除信息时出现错误请检查！", "错误提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }       
        }
    }
}
