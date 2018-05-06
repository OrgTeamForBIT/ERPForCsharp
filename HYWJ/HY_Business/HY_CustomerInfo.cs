/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   客户信息主窗体
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

namespace HYWJ.HY_Business
{
    public partial class HY_CustomerInfo : Office2007Form
    {
        private HY_BLL.HY_CustomerInfoBLL hycustobll;
        private HY_Model.HY_CustomerInfo hycustoomodel;
        private HYWJ.HY_System.OperateAndValidate valid;//实例化数据验证类
        public static int intFalg = 0;//控件方法状态
        public HY_CustomerInfo()
        {
            InitializeComponent();
            hycustobll = new HY_BLL.HY_CustomerInfoBLL();
            hycustoomodel=new HY_Model.HY_CustomerInfo();
            valid = new HYWJ.HY_System.OperateAndValidate();
        }

        private void HY_CustomerInfo_Load(object sender, EventArgs e)
        {
            this.toolStripEdit.Enabled = false;
            this.toolStripDel.Enabled = false;
            this.toolStripCEL.Enabled = false;
            this.toolStripSave.Enabled = false;
            this.groupPanel1.Enabled = false;

            f_CustomerInfo();
        }
        //自定义绑定数据
        private void f_CustomerInfo()
        {
            string sql = "select * from HY_CustomerInfo order by c_ID desc";
            this.dataGridViewCUS.DataSource = hycustobll.ExecuteQuery(sql);
        }
        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            this.toolStripEdit.Enabled = false;
            this.toolStripDel.Enabled = false;
            this.toolStripAdd.Enabled = false;
            this.toolStripSave.Enabled = true;
            this.toolStripCEL.Enabled = true;
            this.groupPanel1.Enabled = true;
            this.groupPanel2.Enabled = false;
            this.c_FID.Text = "";
            this.c_Name.Text = "";
            intFalg = 1;
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            hycustoomodel.O_Name = this.c_Name.Text.Trim();
            hycustoomodel.C_FID = this.c_FID.Text.Trim();
            if (!valid.validateNull(hycustoomodel.O_Name))
            {
                MessageBoxEx.Show("提示信息：客户名不能为空","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.c_Name.Focus();
                return;
            }
            if (!valid.validateNull(hycustoomodel.C_FID))
            {
                MessageBoxEx.Show("提示信息：客户番号不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.c_FID.Focus();
                return;
            }
            if (intFalg==1)
            {
                string sql="insert into HY_CustomerInfo(c_Name,c_FID) values('"+hycustoomodel.O_Name+"','"+hycustoomodel.C_FID+"')";
                int res = hycustobll.com_HY_CustomerInfo(sql);
                if (res > 0)
                {
                    MessageBoxEx.Show("客户信息添加成功，确定后可继续添加");
                    this.c_FID.Text = "";
                    this.c_Name.Text = "";
                    f_CustomerInfo();
                }
                else
                {
                    return;
                }
            }
            if (intFalg==2)
            {
                string sql = "update HY_CustomerInfo set c_Name='" + hycustoomodel.O_Name + "',c_FID='" + hycustoomodel.C_FID + "' where c_ID='"+this.label3.Text+"'";
                int res = hycustobll.com_HY_CustomerInfo(sql);
                if (res > 0)
                {
                    MessageBoxEx.Show("客户信息更新成功，确定返回");
                    f_CustomerInfo();
                }
                else
                {
                    return;
                }
            }

        }

        private void toolStripDel_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("确定后本条客户信息从数据库删除！", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int a = int.Parse(this.dataGridViewCUS[1, this.dataGridViewCUS.CurrentCell.RowIndex].Value.ToString());
                string sql = "delete from HY_CustomerInfo where c_ID='" + a + "'";
                int res = hycustobll.com_HY_CustomerInfo(sql);
                if (res > 0)
                {
                    f_CustomerInfo();
                }
            }
            
        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            this.toolStripAdd.Enabled = false;
            this.groupPanel1.Enabled = true;
            this.toolStripSave.Enabled = true;
            this.toolStripEdit.Enabled = false;
            this.groupPanel2.Enabled = false;
            intFalg = 2;
     
        }

        private void toolStripCEL_Click(object sender, EventArgs e)
        {
            this.toolStripAdd.Enabled = true;
            this.toolStripCEL.Enabled = false;
            this.toolStripDel.Enabled = false;
            this.toolStripSave.Enabled = false;
            this.toolStripEdit.Enabled = false;
            this.groupPanel1.Enabled = false;
            this.groupPanel2.Enabled = true;
            this.c_FID.Text = "";
            this.c_Name.Text = "";
        }

        private void c_Name_Enter(object sender, EventArgs e)
        {
            this.c_Name.BackColor = Color.Green;
            this.c_Name.ForeColor = Color.White;
        }

        private void c_Name_Leave(object sender, EventArgs e)
        {
            this.c_Name.BackColor = Color.White;
            this.c_Name.ForeColor = Color.Black;
        }

        private void c_FID_Enter(object sender, EventArgs e)
        {
            this.c_FID.BackColor = Color.Green;
            this.c_FID.ForeColor = Color.White;
        }

        private void c_FID_Leave(object sender, EventArgs e)
        {
            this.c_FID.BackColor = Color.White;
            this.c_FID.ForeColor = Color.Black;
        }
        private void toolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridViewCUS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripAdd.Enabled = false;
            this.toolStripEdit.Enabled = true;
            this.toolStripDel.Enabled = true;
            this.toolStripCEL.Enabled = true;
            this.label3.Text = this.dataGridViewCUS[1, this.dataGridViewCUS.CurrentCell.RowIndex].Value.ToString();
            this.c_Name.Text = this.dataGridViewCUS[2, this.dataGridViewCUS.CurrentCell.RowIndex].Value.ToString();
            this.c_FID.Text = this.dataGridViewCUS[3, this.dataGridViewCUS.CurrentCell.RowIndex].Value.ToString();
        }
    }
}
