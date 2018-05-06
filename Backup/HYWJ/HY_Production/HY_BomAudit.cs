/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明: BOM物料清单审核校队主窗体
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

namespace HYWJ.HY_Production
{
    public partial class HY_BomAudit : Office2007Form
    {    
        private HY_BLL.HY_BomlistBLL hybombll;
        public static int intFalg = 0;//控件方法状态
        public HY_BomAudit()
        {
            InitializeComponent();
            hybombll = new HY_BomlistBLL();
        }

        private void HY_BomAudit_Load(object sender, EventArgs e)
        {
            requistionDate();
            this.toolStripXD.Enabled = false;
            this.toolStripSH.Enabled = false;
            this.groupBox1.Enabled = false;
        }
        //自定义绑定数据
        private void requistionDate()
        {
            this.dataGridViewBOM.AutoGenerateColumns = false;// 关闭自动创建列
            string sql = "select * from HY_BomInfo order by b_ID desc";
            this.dataGridViewBOM.DataSource = hybombll.ExecuteQuery(sql);
        }

        private string b_SKID;      //BOM单号
        private string b_CNID;        //厂内编号
        private string b_CustomerID; //客户编号
        private string b_No;        //工程数
        private string b_Notes;   //工作内容
        private string b_Tonnage;   //冲床吨位
        private string b_Material; //材质
        private string b_BomSize;   //用料尺寸
        private string b_Name;   //磨具名称
        private string b_Height; //闭合高度

        //BOM单号
        public string B_SKID
        {
            get { return b_SKID; }
            set { b_SKID = value; }
        }
        //厂内编号（模号）
        public string B_CNID
        {
            get { return b_CNID; }
            set { b_CNID = value; }
        }
        //客户编号
        public string B_CustomerID
        {
            get { return b_CustomerID; }
            set { b_CustomerID = value; }
        }
        //工程数
        public string B_No
        {
            get { return b_No; }
            set { b_No = value; }
        }
        //工作内容
        public string B_Notes
        {
            get { return b_Notes; }
            set { b_Notes = value; }
        }
        //冲床吨位
        public string B_Tonnage
        {
            get { return b_Tonnage; }
            set { b_Tonnage = value; }
        }
        //材质
        public string B_Material
        {
            get { return b_Material; }
            set { b_Material = value; }
        }
        //用料尺寸
        public string B_BomSize
        {
            get { return b_BomSize; }
            set { b_BomSize = value; }
        }
        //模具名称
        public string B_Name
        {
            get { return b_Name; }
            set { b_Name = value; }
        }
        //闭合高度
        public string B_Height
        {
            get { return b_Height; }
            set { b_Height = value; }
        }

        //审核
        //TODO
        private void toolStripSH_Click(object sender, EventArgs e)
        {
            if (this.b_BID.Text != string.Empty)
            {
               
                    string bid = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
                    string sql = "update HY_BomInfo set b_Audit='A',b_HDate='" + DateTime.Now.ToShortDateString() + "' where b_SKID='" + this.b_BID.Text + "'";
                    int res = hybombll.com_HY_BomlistX(sql);
                    if (res > 0)
                    {
                        MessageBoxEx.Show("核对确认成功，确认完成！", "核对提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        requistionDate();
                    }
            }
        }

        private void dataGridViewBOM_DoubleClick(object sender, EventArgs e)
        {
            string i = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.tabControlBOM.SelectedTabIndex = 1;
            HY_BLL.HY_BomDetailsBLL hybomdel = new HY_BomDetailsBLL();
            this.dataGridViewBOMDET.AutoGenerateColumns = false;// 关闭自动创建列
            this.dataGridViewBOMDET.DataSource = hybomdel.ExecuteQuerySelect(i);
        }

        private void dataGridViewBOM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripXD.Enabled = true;
            this.toolStripSH.Enabled = true;
            this.groupBox1.Enabled = true;

            this.b_BID.Text = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.b_CID.Text = this.dataGridViewBOM[1, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.b_Person.Text = this.dataGridViewBOM[9, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.b_Date.Text = this.dataGridViewBOM[10, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();

            string xd = this.dataGridViewBOM[11, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            string sh = this.dataGridViewBOM[13, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            if (sh == string.Empty)
            {
                this.toolStripQX.Enabled = false;
            }
            else
            {
                this.toolStripQX.Enabled = true;
            }
            if (xd == string.Empty)
            {
                this.toolStripXD.Enabled = true;
            }
            else
            {
                this.toolStripXD.Enabled = false;
            }
            if (sh == string.Empty)
            {
                this.toolStripSH.Enabled = true;
            }
            else
            {
                this.toolStripSH.Enabled = false;
            }
            //显示隐藏审核图标
            if (sh != string.Empty)
            {
                this.panelH.Visible = true;
            }
            else
            {
                this.panelH.Visible = false;
            }
            
        }

        private void btnBOMS_Click(object sender, EventArgs e)
        {

            B_SKID = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            B_CNID = this.dataGridViewBOM[1, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            B_CustomerID = this.dataGridViewBOM[2, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            B_No = this.dataGridViewBOM[3, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            B_Material = this.dataGridViewBOM[4, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            B_BomSize = this.dataGridViewBOM[5, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            B_Height = this.dataGridViewBOM[6, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            B_Tonnage = this.dataGridViewBOM[7, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            B_Name = this.dataGridViewBOM[8, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            B_Notes = this.dataGridViewBOM[15, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            HYWJ.HY_Report.HY_BomlistDB2 hybom = new HYWJ.HY_Report.HY_BomlistDB2();
            hybom.Owner = this;
            hybom.ShowDialog();//对话框模式窗口
            hybom.Dispose();
        }
        //校队审核
        private void toolStripXD_Click(object sender, EventArgs e)
        {
            if (this.b_BID.Text != string.Empty)
            {
           
                    string bid = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
                    string sqlx = "update HY_BomInfo set b_Proofreading='JOY',b_XDate='" + DateTime.Now.ToShortDateString() + "' where b_SKID='" + this.b_BID.Text + "'";
                    int res = hybombll.com_HY_BomlistX(sqlx);
                    if (res > 0)
                    {
                        MessageBoxEx.Show("校队确认成功，确认完成！", "校对提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        requistionDate();
                    }
            }
        }

        private void toolStripQX_Click(object sender, EventArgs e)
        {
            if (this.b_BID.Text != string.Empty)
            {

                string bid = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
                string sqls = "update HY_BomInfo set b_Proofreading=null,b_Audit=null,b_XDate=null,b_HDate=null where b_SKID='" + this.b_BID.Text + "'";
                int res = hybombll.com_HY_BomlistX(sqls);
                if (res > 0)
                {
                    MessageBoxEx.Show("BOM单已取消审核,确认后可做其他操作！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    requistionDate();
                }
            }
        }
    }
}