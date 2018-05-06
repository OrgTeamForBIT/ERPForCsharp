/*  
 * 作者: JOY 
 * 创建时间: 2009-12-30 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明: 入库信息主窗体
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using HY_Model;
using HY_BLL;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HYWJ.HY_Warehouse
{
    public partial class HY_Storage : Office2007Form
    {
        private HY_BLL.HY_StorageBLL hystorbll=null;
        public static int intFalg = 0;//控件方法状态
        public HY_Storage()
        {
            InitializeComponent();
            hystorbll = new HY_StorageBLL();
        }

        private void HY_Storage_Load(object sender, EventArgs e)
        {
            this.toolStripCEL.Enabled = false;
            this.toolStripSave.Enabled = false;
            this.groupBox1.Enabled = false;
            this.groupBox2.Enabled = false;
            this.toolStripUPD.Enabled = false;
            this.toolStripDEL.Enabled = false;
            requistionDate();//初始化绑定数据
  
        }
        //自定义绑定数据
        private void requistionDate()
        {
            this.dataGridViewCK.AutoGenerateColumns = false;// 关闭自动创建列
            HY_BLL.HY_StorageBLL hystorfobll = new HY_StorageBLL();
            string sql = "select s_ID,s_DID,s_CID,s_Supplier,s_Person,s_Class,s_Warehouse,s_XDate,s_DDate,s_PID,s_Pname,s_Origin,s_Specifications,s_Amount,s_Price,s_Notes,(s_Amount*s_Price) as ABV,s_WFDate,s_DWDate,s_WFSup,s_WFDateHot,s_DWDateHot,s_WFHotSup,s_WFDateBM,s_DWDateBM,s_WFSupBM from HY_Storage order by s_ID desc";
            this.dataGridViewCK.DataSource = hystorfobll.ExecuteQuerySelect(sql);
        }
        private void toolStripADD_Click(object sender, EventArgs e)
        {
            this.toolStripADD.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = true;
            this.groupBox1.Enabled = true;
            this.groupBox2.Enabled = true;
            this.groupBox3.Enabled = false;
            f_CID();//绑定入库单号
            f_PID();//绑定品号
            lbHYList_CK();// 绑定仓库
            c_Class();//绑定产品类别
            intFalg = 1;
        }
        /// <summary>
        /// 自定义绑定入库单
        /// </summary>
        private void f_CID()
        {
            string C = "CK";
            HYWJ.HY_System.HY_NO hyNO = new HYWJ.HY_System.HY_NO();
            this.s_DID.Text = hyNO.JhGoodsID(C);
        }
        /// <summary>
        /// 自定义绑定品号
        /// </summary>
        private void f_PID()
        {
            string P = "PH";
            HYWJ.HY_System.HY_NO hyNO = new HYWJ.HY_System.HY_NO();
            this.s_PID.Text = hyNO.JhGoodsID(P);
        }
        //绑定产品类别
        private void c_Class()
        {
            //HY_BLL.HY_StorageBLL hystorbll = new HY_StorageBLL();
            string sql = "select * from HY_CPClass order by c_ID desc";
            this.s_Class.DataSource = hystorbll.ExecuteQuerySelect(sql);
            this.s_Class.DisplayMember = "c_Class";
            this.s_Class.ValueMember = "c_ID";
        }
        //绑定仓库
        private void lbHYList_CK()
        {
            HY_BLL.HY_WarehouseBLL hywar = new HY_WarehouseBLL();
            this.s_Warehouse.DataSource = hywar.ExecuteQuery();
            this.s_Warehouse.DisplayMember = "c_ckName";
            this.s_Warehouse.ValueMember = "c_ID";
        }
        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (this.s_Person.Text == string.Empty)
            {
                MessageBoxEx.Show("入库人姓名不能为空,请正确填写", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.s_Person.Focus();
                return;  
            }
            if (this.s_CID.Text == string.Empty)
            {
                MessageBoxEx.Show("厂内编号不能为空,请正确填写", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.s_CID.Focus();
                return;
            }
            if (this.s_Supplier.Text == string.Empty)
            {
                MessageBoxEx.Show("供应商名称不能为空,请正确填写", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.s_Supplier.Focus();
                return;
            }
            if (this.s_DDate.Text == "")
            {
                MessageBoxEx.Show("到货日期不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.s_DDate.Focus();
                return;
            }
            if (this.s_XDate.Text == "")
            {
                MessageBoxEx.Show("入库日期不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.s_XDate.Focus();
                return;
            }
            if (this.s_Price.Text == string.Empty)
            {
                MessageBoxEx.Show("产品单价不能为空", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.s_Price.Focus();
                return;
            }

            HY_Model.HY_Storage hystormodel = new HY_Model.HY_Storage();
            hystormodel.S_DID = this.s_DID.Text;
            hystormodel.S_CID = this.s_CID.Text.Trim();
            hystormodel.S_Person = this.s_Person.Text.Trim();
            hystormodel.S_Class = this.s_Class.Text;
            hystormodel.S_Warehouse = this.s_Warehouse.Text;
            hystormodel.S_XDate = Convert.ToDateTime(this.s_XDate.Value);
            hystormodel.S_DDate = Convert.ToDateTime(this.s_DDate.Value);
            hystormodel.S_PID = this.s_PID.Text;
            hystormodel.S_Pname = this.s_Pname.Text.Trim();
            hystormodel.S_Specifications = this.s_Specifications.Text.Trim();
            hystormodel.S_Units = this.s_Units.Text.Trim();
            hystormodel.S_Amount = int.Parse(this.s_Amount.Text.Trim());
            hystormodel.S_Price = float.Parse(this.s_Price.Text.Trim());
            hystormodel.S_Notes = this.s_Notes.Text.Trim();
            hystormodel.S_Origin = this.s_Origin.Text.Trim();
            hystormodel.S_Supplier = this.s_Supplier.Text.Trim();

            if (intFalg == 1)
            {
                string sql = "insert into HY_Storage(s_DID,s_CID,s_Person,s_Class,s_Warehouse,s_XDate,s_DDate,s_PID,s_Pname,s_Specifications,s_Units,s_Amount,s_Price,s_Notes,s_Origin,s_Supplier) values('" + hystormodel.S_DID + "','" + hystormodel.S_CID + "','" + hystormodel.S_Person + "','" + hystormodel.S_Class + "','" + hystormodel.S_Warehouse + "','" + hystormodel.S_XDate + "','" + hystormodel.S_DDate + "','" + hystormodel.S_PID + "','" + hystormodel.S_Pname + "','" + hystormodel.S_Specifications + "','" + hystormodel.S_Units+ "','" + hystormodel.S_Amount + "','" + hystormodel.S_Price + "','" + hystormodel.S_Notes + "','" + hystormodel.S_Origin + "','" + hystormodel.S_Supplier + "')";
                int res = hystorbll.com_HY_HY_Storagelslist(sql);
                if (res > 0)
                {
                    //写入log库存表
                    string sqllog = "insert into HY_StorageLog(s_DID,s_CID,s_Person,s_Class,s_Warehouse,s_XDate,s_DDate,s_PID,s_Pname,s_Specifications,s_Units,s_Amount,s_Price,s_Notes,s_Origin,s_Supplier) values('" + hystormodel.S_DID + "','" + hystormodel.S_CID + "','" + hystormodel.S_Person + "','" + hystormodel.S_Class + "','" + hystormodel.S_Warehouse + "','" + hystormodel.S_XDate + "','" + hystormodel.S_DDate + "','" + hystormodel.S_PID + "','" + hystormodel.S_Pname + "','" + hystormodel.S_Specifications + "','" + hystormodel.S_Units+ "','" + hystormodel.S_Amount + "','" + hystormodel.S_Price + "','" + hystormodel.S_Notes + "','" + hystormodel.S_Origin + "','" + hystormodel.S_Supplier + "')";
                    hystorbll.com_HY_HY_Storagelslist(sqllog);

                    MessageBoxEx.Show("产品入库成功，确定后可继续添加", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    requistionDate();
                    f_PID();//品号
                    f_CID();//单号
                    this.s_CID.Focus();
                    this.s_CID.Text = "";
                    this.s_Person.Text = "";
                    this.s_Class.Text = "";
                    this.s_Warehouse.Text = "";
                    this.s_Pname.Text = "";
                    this.s_Specifications.Text = "";
                    this.s_Amount.Text = "";
                    this.s_Price.Text = "";
                    this.s_Notes.Text = "";

                }
            }
            if (intFalg == 2)
            {
                string sql = "Update HY_Storage set s_DID='" + hystormodel.S_DID + "',s_CID='" + hystormodel.S_CID + "',s_Person='" + hystormodel.S_Person + "',s_Class='" + hystormodel.S_Class + "',s_Warehouse='" + hystormodel.S_Warehouse + "',s_XDate='" + Convert.ToDateTime(this.s_XDate.Value) + "',s_DDate='" + Convert.ToDateTime(this.s_DDate.Value) + "',s_Pname='" + hystormodel.S_Pname + "',s_Specifications='" + hystormodel.S_Specifications + "',s_Amount='" + hystormodel.S_Amount + "',s_Price='" + hystormodel.S_Price + "',s_Notes='" + hystormodel.S_Notes + "' where s_PID='" + hystormodel.S_PID + "'";
                int res = hystorbll.com_HY_HY_Storagelslist(sql);
                if (res > 0)
                {
                    //写入log库存表
                    //string sqllog = "insert into HY_StorageLog(s_DID,s_CID,s_Person,s_Class,s_Warehouse,s_XDate,s_DDate,s_PID,s_Pname,s_Specifications,s_Amount,s_Price,s_Notes) values('" + hystormodel.S_DID + "','" + hystormodel.S_CID + "','" + hystormodel.S_Person + "','" + hystormodel.S_Class + "','" + hystormodel.S_Warehouse + "','" + hystormodel.S_XDate + "','" + hystormodel.S_DDate + "','" + hystormodel.S_PID + "','" + hystormodel.S_Pname + "','" + hystormodel.S_Specifications + "','" + hystormodel.S_Amount + "','" + hystormodel.S_Price + "','" + hystormodel.S_Notes + "')";
                    //hystorbll.com_HY_HY_Storagelslist(sqllog);

                    MessageBoxEx.Show("产品修改成功，确定后可继续操作", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    f_Back();
                    requistionDate();
                    this.s_CID.Text = "";
                    this.s_Person.Text = "";
                    this.s_Class.Text = "";
                    this.s_Warehouse.Text = "";
                    this.s_Pname.Text = "";
                    this.s_Specifications.Text = "";
                    this.s_Amount.Text = "";
                    this.s_Price.Text = "";
                    this.s_Notes.Text = "";
                    this.groupBox1.Enabled = false;
                    this.groupBox2.Enabled = false;
                    this.groupBox3.Enabled = true;



                }

            }
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Warehouse.HY_Person hyper = new HY_Person();
            hyper.hystor = this;
            hyper.ShowDialog();
        }
        /// <summary>
        /// 自定义返回入库人(跨窗口传值定义)
        /// </summary>
        /// <param name="supName">姓名</param>
        public void f_Person(string supName)
        {
            this.s_Person.Text = supName;
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Warehouse.HY_CargoIN hycar = new HY_CargoIN();
            hycar.ShowDialog();
        }

        private void toolStripCEL_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
            this.groupBox2.Enabled = false;
            this.groupBox3.Enabled = true;
            this.toolStripADD.Enabled = true;
            this.toolStripCEL.Enabled = false;
            this.toolStripSave.Enabled = false;
            this.toolStripUPD.Enabled = false;
            this.toolStripDEL.Enabled = false;
            f_Back();//返回状态
           
        }
        //返回状态
        private void f_Back()
        {
            this.s_DID.Text = "";
            this.s_PID.Text = "";
            this.s_CID.Text = "";
            this.s_Person.Text = "";
            this.s_Class.Text = "";
            this.s_Warehouse.Text = "";
            this.s_Pname.Text = "";
            this.s_Specifications.Text = "";
            this.s_Amount.Text = "";
            this.s_Price.Text = "";
            this.s_Notes.Text = "";
            this.toolStripSave.Enabled = false;
            this.toolStripUPD.Enabled = false;
            this.toolStripDEL.Enabled = false;
            this.toolStripCEL.Enabled = false;
            this.toolStripADD.Enabled = true;
            this.groupBox1.Enabled = false;
            this.groupBox2.Enabled = false;
        }
        #region 文本框变色
        private void s_CID_Enter(object sender, EventArgs e)
        {
            this.s_CID.BackColor = Color.Green;
            this.s_CID.ForeColor = Color.White;
        }

        private void s_CID_Leave(object sender, EventArgs e)
        {
            this.s_CID.BackColor = Color.White;
            this.s_CID.ForeColor = Color.Black;
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

        private void s_Pname_Enter(object sender, EventArgs e)
        {
            this.s_Pname.BackColor = Color.Green;
            this.s_Pname.ForeColor = Color.White;
        }

        private void s_Pname_Leave(object sender, EventArgs e)
        {
            this.s_Pname.BackColor = Color.White;
            this.s_Pname.ForeColor = Color.Black;
        }

        private void s_Specifications_Enter(object sender, EventArgs e)
        {
            this.s_Specifications.BackColor = Color.Green;
            this.s_Specifications.ForeColor = Color.White;
        }

        private void s_Specifications_Leave(object sender, EventArgs e)
        {
            this.s_Specifications.BackColor = Color.White;
            this.s_Specifications.ForeColor = Color.Black;
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

        private void s_Price_Enter(object sender, EventArgs e)
        {
            this.s_Price.BackColor = Color.Green;
            this.s_Price.ForeColor = Color.White;
        }

        private void s_Price_Leave(object sender, EventArgs e)
        {
            this.s_Price.BackColor = Color.White;
            this.s_Price.ForeColor = Color.Black;
        }

        private void s_Notes_Enter(object sender, EventArgs e)
        {
            this.s_Notes.BackColor = Color.Green;
            this.s_Notes.ForeColor = Color.White;
        }

        private void s_Notes_Leave(object sender, EventArgs e)
        {
            this.s_Notes.BackColor = Color.White;
            this.s_Notes.ForeColor = Color.Black;
        }
        #endregion
        // 删除
        private void toolStripDEL_Click(object sender, EventArgs e)
        {

            if (MessageBoxEx.Show("确定后此条产品将被删除不可恢复！ ", "操作提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                string pid = this.dataGridViewCK[2, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString();
                string sql = "delete from HY_Storage where s_PID='" + pid + "'";
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

        private void toolStripOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //修改
        private void toolStripUPD_Click(object sender, EventArgs e)
        {

            this.toolStripADD.Enabled = false;
            this.toolStripUPD.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = true;
            this.groupBox1.Enabled = true;
            this.groupBox2.Enabled = true;
            this.groupBox3.Enabled = false;
            c_Class();//类别
            lbHYList_CK();//仓库
            intFalg = 2;
        }

        private void dataGridViewCK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripDEL.Enabled = true;
            this.toolStripUPD.Enabled = true;
            this.toolStripADD.Enabled = false;
            this.toolStripCEL.Enabled = true;
            this.toolStripSave.Enabled = false;
            this.s_DID.Text = this.dataGridViewCK[0, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString();
            this.s_CID.Text = this.dataGridViewCK[1, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString();
            this.s_PID.Text = this.dataGridViewCK[2, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString();
            this.s_Pname.Text = this.dataGridViewCK[3, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString();
            this.s_Supplier.Text = this.dataGridViewCK[4, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString();
            this.s_Origin.Text = this.dataGridViewCK[5, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString();
            this.s_Specifications.Text = this.dataGridViewCK[6, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString();
            this.s_Amount.Text = this.dataGridViewCK[7, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString();
            this.s_Price.Text = this.dataGridViewCK[8, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString();
            this.s_Class.Text = this.dataGridViewCK[9, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString();
            this.s_Person.Text = this.dataGridViewCK[10, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString();
            this.s_DDate.Value = Convert.ToDateTime(this.dataGridViewCK[11, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString());
            this.s_XDate.Value = Convert.ToDateTime(this.dataGridViewCK[12, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString());
            this.s_Warehouse.Text = this.dataGridViewCK[13, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString();
            this.s_Notes.Text = this.dataGridViewCK[14, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString();
        }

        /// <summary>
        /// 自定义返回采购单信息(跨窗口传值定义)
        /// </summary>
        /// <param name="c_CID">厂内编号（模号）</param>
        /// <param name="c_Name">品名</param>
        /// <param name="c_Supplier">供应商</param>
        /// <param name="c_Origin">型号</param>
        /// <param name="c_Specifications">规格</param>
        /// <param name="c_Units">单位</param>
        /// <param name="c_Amount">数量</param>
        public void f_Procinfo(string c_CID, string c_Name, string c_Supplier, string c_Origin, string c_Specifications,string c_Units, string c_Amount)
        {
            this.s_CID.Text = c_CID;
            this.s_Pname.Text = c_Name;
            this.s_Supplier.Text = c_Supplier;
            this.s_Origin.Text = c_Origin;
            this.s_Specifications.Text = c_Specifications;
            this.s_Units.Text = c_Units;
            this.s_Amount.Text = c_Amount;
        }
        //导入采购产品信息
        private void btnCG_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Warehouse.HY_procurementInfo hyprocinfo = new HY_procurementInfo();
            hyprocinfo.hystor = this;//当前窗口传给HY_rPerson窗口
            hyprocinfo.ShowDialog();
            
        }

        //外发加工
        private void toolStripWFJG_Click(object sender, EventArgs e)
        {
            this.panelEx2.Visible = true;
            this.WFTitle.Text = "外发生产加工";
            this.WFTitle.Tag = 1;
        }

        private void btnCEL_Click(object sender, EventArgs e)
        {
            CL();
        }
        //处理后控件状态
        private void CL()
        {
            this.panelEx2.Visible = false;
            this.WFTitle.Text = "";
            this.dateWF.Text = "";
            this.dateDW.Text = "";
            this.Sup.Text = "";
        }
        //外发热处理
        private void toolStripWFRCL_Click(object sender, EventArgs e)
        {
            this.panelEx2.Visible = true;
            this.WFTitle.Text = "外发热处理加工";
            this.WFTitle.Tag = 2;
        }
        //外发表面处理
        private void toolStripWFBMCL_Click(object sender, EventArgs e)
        {
            this.panelEx2.Visible = true;
            this.WFTitle.Text = "外发表面处理加工";
            this.WFTitle.Tag = 3;
        }
        //动作确认外发
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.dateWF.Text == string.Empty)
            {
                MessageBoxEx.Show("外发日期不能为空，请选择日期！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dateWF.Focus();
                return;
            }
            if (this.dateDW.Text == string.Empty)
            {
                MessageBoxEx.Show("到位日期不能为空，请选择日期！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dateDW.Focus();
                return;
            }
            if (this.dateWF.Value > this.dateDW.Value)
            {
                MessageBoxEx.Show("外发日期不能大于到位日期！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dateWF.Focus();
                return;
            }
            if (this.Sup.Text.Trim() == string.Empty)
            {
                MessageBoxEx.Show("外发供应商不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Sup.Focus();
                return;
            }
            //判断选择执行外发类别
            switch (int.Parse(this.WFTitle.Tag.ToString()))
	        {
                case 1:
                    string sqlwf = "Update HY_Storage set s_WFDate='" + Convert.ToDateTime(this.dateWF.Value) + "',s_DWDate='" + Convert.ToDateTime(this.dateDW.Value) + "',s_WFSup='" + this.Sup.Text.Trim() + "' where s_DID='" + this.s_DID.Text + "'";
                    int reswf = hystorbll.com_HY_HY_Storagelslist(sqlwf);
                    if (reswf > 0)
                    {
                        MessageBoxEx.Show("外发生产加工记录成功！", "外发加工处理");
                        CL();
                        requistionDate();
                    }
                 break;

                case 2:
                 string sqlwfhot = "Update HY_Storage set s_WFDateHot='" + Convert.ToDateTime(this.dateWF.Value) + "',s_DWDateHot='" + Convert.ToDateTime(this.dateDW.Value) + "',s_WFHotSup='" + this.Sup.Text.Trim() + "' where s_DID='" + this.s_DID.Text + "'";
                 int reswfhot = hystorbll.com_HY_HY_Storagelslist(sqlwfhot);
                 if (reswfhot > 0)
                 {
                     MessageBoxEx.Show("外发热处理加工记录成功！", "外发热处理");
                     CL();
                     requistionDate();
                 }
                 break;
                case 3:
                 string sqlwfbm = "Update HY_Storage set s_WFDateBM='" + Convert.ToDateTime(this.dateWF.Value) + "',s_DWDateBM='" + Convert.ToDateTime(this.dateDW.Value) + "',s_WFSupBM='" + this.Sup.Text.Trim() + "' where s_DID='" + this.s_DID.Text + "'";
                 int reswfbm = hystorbll.com_HY_HY_Storagelslist(sqlwfbm);
                 if (reswfbm > 0)
                 {
                     MessageBoxEx.Show("外发表面处理加工记录成功！","外发表面处理");
                     CL();
                     requistionDate();
                 }
                 break;
             
	         }
        }
    }
}
