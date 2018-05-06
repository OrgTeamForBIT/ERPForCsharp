/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   客户订单主窗体
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

namespace HYWJ.HY_Business
{
    public partial class HY_CustomerOrder : Office2007Form
    {
        private HY_BLL.HY_CustomerInfoBLL hycustobll;
        public static int intFalg = 0;//控件方法状态
        private HYWJ.HY_System.OperateAndValidate valid;//实例化数据验证类
        public HY_CustomerOrder()
        {
            InitializeComponent();
            hycustobll = new HY_CustomerInfoBLL();
            valid = new HYWJ.HY_System.OperateAndValidate();
        }

        private void HY_CustomerOrder_Load(object sender, EventArgs e)
        {
            this.toolStripEdit.Enabled = false;
            this.toolStripDel.Enabled = false;
            this.toolStripCEL.Enabled = false;
            this.toolStripSave.Enabled = false;
            this.groupBox1.Enabled = false;
            f_CustomerInfo();
        }
        //自定义绑定数据
        private void f_CustomerInfo()
        {
            this.dataGridViewDD.AutoGenerateColumns = false;// 关闭自动创建列
            string sql = "select * from HY_CustomerOrder order by o_ID desc";
            this.dataGridViewDD.DataSource = hycustobll.ExecuteQuery(sql);
        }
        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            this.toolStripAdd.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = true;
            this.groupBox1.Enabled = true;
            this.groupBox2.Enabled = false;
            intFalg = 1;
            b_BOMID();//绑定销售单号
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            string sid = this.dataGridViewDD[0, this.dataGridViewDD.CurrentCell.RowIndex].Value.ToString();
            HY_Model.HY_CustomerInfo hycusmodel = new HY_Model.HY_CustomerInfo();
            hycusmodel.O_Name = this.o_Name.Text;
            hycusmodel.C_FID = this.o_FID.Text;
            hycusmodel.O_CPName = this.o_CPName.Text.Trim();
            hycusmodel.O_Person = this.o_Person.Text.Trim();
            hycusmodel.O_Notes = this.o_Notes.Text.Trim();
            hycusmodel.O_RDate = System.DateTime.Now.Date;
            hycusmodel.O_XDate = this.o_XDate.Value.Date;
            hycusmodel.O_JDate = this.o_JDate.Value.Date;
            hycusmodel.O_DID = this.label6.Text;
            hycusmodel.O_Amount = this.o_Amount.Text.Trim();
            hycusmodel.O_Class = this.o_Class.Text.Trim();

            if (!valid.validateNull(hycusmodel.O_Name))
            {
                MessageBoxEx.Show("提示：客户名称不能为空", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!valid.validateNull(hycusmodel.O_CPName))
            {
                MessageBoxEx.Show("提示：厂内编号不能为空", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.o_CPName.Focus();
                return;
            }
            if (!valid.validateNull(hycusmodel.O_Person))
            {
                MessageBoxEx.Show("提示：录单人不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.o_Person.Focus();
                return;
            }
            if (!valid.validateNull(hycusmodel.O_Amount))
            {
                MessageBoxEx.Show("提示：数量不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.o_Amount.Focus();
                return;
            }
            if (!valid.validateNull(hycusmodel.O_Class))
            {
                MessageBoxEx.Show("提示：模具类型名称不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.o_Class.Focus();
                return;
            }
         

            //添加动作
            if (intFalg==1)
            {
                string sql = "insert into HY_CustomerOrder(o_DID,o_Name,o_FID,o_CPName,o_Person,o_RDate,o_Notes,o_XDate,o_JDate,o_Amount,o_Class) values('" + hycusmodel.O_DID + "','" + hycusmodel.O_Name + "','" + hycusmodel.C_FID + "','" + hycusmodel.O_CPName + "','" + hycusmodel.O_Person + "','" + hycusmodel.O_RDate + "','" + hycusmodel.O_Notes + "','" + hycusmodel.O_XDate + "','" + hycusmodel.O_JDate + "','" + hycusmodel.O_Amount + "','" + hycusmodel.O_Class + "')";
                int res = hycustobll.com_HY_CustomerInfo(sql);
                if (res > 0)
                {
                    MessageBoxEx.Show("客户订单添加成功");
                    f_CustomerInfo();
                    this.o_Name.Text = "";
                    this.o_FID.Text = "";
                    this.o_Person.Text = "";
                    this.o_CPName.Text = "";
                    this.o_Amount.Text = "";
                    this.o_Class.Text = "";
                    this.o_XDate.Text = "";
                    this.o_JDate.Text = "";
                    this.o_Notes.Text = "";
                    this.groupBox1.Enabled = false;
                    this.groupBox2.Enabled = true;
                }
            }
            //修改动作
            if (intFalg == 2)
            {
                string sql = "update HY_CustomerOrder set o_Name='" + hycusmodel.O_Name + "',o_FID='" + hycusmodel.C_FID + "',o_CPName='" + hycusmodel.O_CPName + "',o_Person='" + hycusmodel.O_Person + "',o_RDate='" + hycusmodel.O_RDate + "',o_Notes='" + hycusmodel.O_Notes + "',o_Amount='" + hycusmodel.O_Amount + "',o_Class='" + hycusmodel.O_Class + "',o_XDate='" + hycusmodel.O_XDate + "',o_JDate='" + hycusmodel.O_JDate + "' where o_DID='" + sid + "'";
                int res = hycustobll.com_HY_CustomerInfo(sql);
                if (res > 0)
                {
                    MessageBoxEx.Show("客户订单修改成功");
                    f_CustomerInfo();
                    this.o_Name.Text = "";
                    this.o_FID.Text = "";
                    this.o_Person.Text = "";
                    this.o_CPName.Text = "";
                    this.o_Amount.Text = "";
                    this.o_Class.Text = "";
                    this.o_XDate.Text = "";
                    this.o_JDate.Text = "";
                    this.o_Notes.Text = "";
                    this.groupBox1.Enabled = false;
                    this.groupBox2.Enabled = true;
                }
            }
          
        }
        /// <summary>
        /// 自定义返回销售单号(跨窗口传值定义)
        /// </summary>
        /// <param name="Number">单号</param>
        public void f_Name(string Name,string Fid)
        {
            this.o_Name.Text = Name;
            this.o_FID.Text = Fid;
        }
        /// <summary>
        /// 自定义生成销售单号
        /// </summary>
        private void b_BOMID()
        {
            string P = "S";
            HYWJ.HY_System.HY_NO hyNO = new HYWJ.HY_System.HY_NO();
            this.label6.Text = hyNO.JhGoodsID(P);
        }
        private void btnCus_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Business.HY_Customer hycustom = new HY_Customer();
            hycustom.hycustomer= this;// 跨窗体传值
            hycustom.ShowDialog();
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripCEL_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
            this.groupBox2.Enabled = true;
            this.toolStripAdd.Enabled = true;
            this.toolStripCEL.Enabled = false;
            this.toolStripDel.Enabled = false;
            this.toolStripEdit.Enabled = false;
            this.toolStripSave.Enabled = false;
            this.o_Name.Text = "";
            this.o_FID.Text = "";
            this.o_CPName.Text ="";
            this.o_Person.Text ="";
            this.o_Notes.Text = "";
        }

        private void o_CPName_Enter(object sender, EventArgs e)
        {
            this.o_CPName.BackColor = Color.Green;
            this.o_CPName.ForeColor = Color.White;
        }

        private void o_CPName_Leave(object sender, EventArgs e)
        {
            this.o_CPName.BackColor = Color.White;
            this.o_CPName.ForeColor = Color.Black;
        }

        private void o_Person_Enter(object sender, EventArgs e)
        {
            this.o_Person.BackColor = Color.Green;
            this.o_Person.ForeColor = Color.White;
        }

        private void o_Person_Leave(object sender, EventArgs e)
        {
            this.o_Person.BackColor = Color.White;
            this.o_Person.ForeColor = Color.Black;
        }

        private void o_Notes_Enter(object sender, EventArgs e)
        {
            this.o_Notes.BackColor = Color.Green;
            this.o_Notes.ForeColor = Color.White;
        }

        private void o_Notes_Leave(object sender, EventArgs e)
        {
            this.o_Notes.BackColor = Color.White;
            this.o_Notes.ForeColor = Color.Black;
        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
            this.groupBox2.Enabled = false;
            this.toolStripAdd.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripDel.Enabled = false;
            this.toolStripEdit.Enabled = false;
            this.toolStripSave.Enabled = true;
            intFalg = 2;
        }

        private void toolStripDel_Click(object sender, EventArgs e)
        {
            string did = this.dataGridViewDD[1, this.dataGridViewDD.CurrentCell.RowIndex].Value.ToString();
            string sql = "Delete from HY_CustomerOrder where o_DID='" + did + "'";
            if (MessageBox.Show("此销售单和其他表有关系不能删除！", "删除提示", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int res = hycustobll.com_HY_CustomerInfo(sql);
                if (res < 0)
                {
                    MessageBoxEx.Show("删除出现异常，请重新删除！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            
        }

        private void dataGridViewDD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripAdd.Enabled = false;
            this.toolStripEdit.Enabled = true;
            this.toolStripDel.Enabled = true;
            this.toolStripCEL.Enabled = true;
            string sid = this.dataGridViewDD[0, this.dataGridViewDD.CurrentCell.RowIndex].Value.ToString();
            this.o_Name.Text = this.dataGridViewDD[1, this.dataGridViewDD.CurrentCell.RowIndex].Value.ToString();
            this.o_FID.Text = this.dataGridViewDD[2, this.dataGridViewDD.CurrentCell.RowIndex].Value.ToString();
            this.o_CPName.Text = this.dataGridViewDD[3, this.dataGridViewDD.CurrentCell.RowIndex].Value.ToString();
            this.o_Amount.Text = this.dataGridViewDD[4, this.dataGridViewDD.CurrentCell.RowIndex].Value.ToString();
            this.o_Class.Text = this.dataGridViewDD[5, this.dataGridViewDD.CurrentCell.RowIndex].Value.ToString();
            this.o_Person.Text = this.dataGridViewDD[9, this.dataGridViewDD.CurrentCell.RowIndex].Value.ToString();
            this.o_Notes.Text = this.dataGridViewDD[8, this.dataGridViewDD.CurrentCell.RowIndex].Value.ToString();
            this.o_XDate.Value = (DateTime)this.dataGridViewDD[6, this.dataGridViewDD.CurrentCell.RowIndex].Value;
            this.o_JDate.Value = (DateTime)this.dataGridViewDD[7, this.dataGridViewDD.CurrentCell.RowIndex].Value;
        }
    }
}
