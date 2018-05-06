/*  
 * 作者: JOY 
 * 创建时间: 2009-12-23 10:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明: 生产计划排程主窗体
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
    public partial class HY_ProductionPlanning : Office2007Form
    {
        private HY_Model.HY_ProductionPlanning hypromodel;
        private HY_BLL.HY_ProductionPlanningBLL hyprod;
        public HY_ProductionPlanning()
        {
            InitializeComponent();
            hypromodel = new HY_Model.HY_ProductionPlanning();
            hyprod = new HY_ProductionPlanningBLL();
        }

        private void HY_ProductionPlanning_Load(object sender, EventArgs e)
        {
            this.groupBox2.Enabled = false;
            this.p_Class.SelectedIndex = 0;
            requistionDate();//自定义绑定数据库
            if (this.p_DID1.Text == string.Empty)
            {
                this.btnYY.Enabled = false;
                this.btnSJ.Enabled = false;
                this.btnST.Enabled = false;
                this.btnCG.Enabled = false;
                this.btnJJG.Enabled = false;
                this.btnHOT.Enabled = false;
                this.btnCNC.Enabled = false;
                this.btnM.Enabled = false;
                this.btnXG.Enabled = false;
                this.btnZL.Enabled = false;
                this.btnSZ.Enabled = false;
                this.btnXJ.Enabled = false;
                this.btnOK.Enabled = false;
                this.btnYJ.Enabled = false;
                this.p_YKDate.Enabled = false;
                this.p_YWDate.Enabled = false;
                this.p_SKDate.Enabled = false;
                this.p_SWDate.Enabled = false;
                this.p_STKDate.Enabled = false;
                this.p_STWDate.Enabled = false;
                this.p_CLKDate.Enabled = false;
                this.p_CLWDate.Enabled = false;
                this.p_CNCKDate.Enabled = false;
                this.p_CNCWDate.Enabled = false;
                this.p_JJKDate.Enabled = false;
                this.p_YWDate.Enabled = false;
                this.p_HKDate.Enabled = false;
                this.p_HWDate.Enabled = false;
                this.p_MKDate.Enabled = false;
                this.p_MWDate.Enabled = false;
                this.p_XKDate.Enabled = false;
                this.p_XWDate.Enabled = false;
                this.p_ZLKDate.Enabled = false;
                this.p_ZLWDate.Enabled = false;
                this.p_SZKDate.Enabled = false;
                this.p_SZWDate.Enabled = false;
                this.p_XJWDate.Enabled = false;
                this.p_OKWDate.Enabled = false;
                this.p_YDWDate.Enabled = false;

            }
        }
        //自定义绑定数据
        private void requistionDate()
        {
            this.dataGridViewSCPC.AutoGenerateColumns = false;// 关闭自动创建列
            HY_BLL.HY_ProductionPlanningBLL hyprobll = new HY_ProductionPlanningBLL();
            string sql = "select * from HY_ProductionPlanning order by p_ID desc";
            this.dataGridViewSCPC.DataSource = hyprobll.ExecuteQuery(sql);
        }
        //生成计划表
        private void toolStripSCPC_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Report.HY_ProductionPlanningDB hypur = new HYWJ.HY_Report.HY_ProductionPlanningDB();
            hypur.Owner = this;
            hypur.Show();
        }

        // 新增计划
        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            this.groupBox2.Enabled = true;
            this.toolStripAdd.Enabled = false;
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (this.toolStripAdd.Enabled == false)
            {
                HY_Model.HY_ProductionPlanning hypromodel = new HY_Model.HY_ProductionPlanning();
                hypromodel.P_DID = this.p_DID.Text.Trim();
                hypromodel.P_KID = this.p_KID.Text.Trim();
                hypromodel.P_CID = this.p_CID.Text.Trim();
                hypromodel.P_Engineering = this.textBoxX2.Text.Trim();
                hypromodel.P_Design = this.p_Design.Text.Trim();

                HY_BLL.HY_ProductionPlanningBLL hyprobll = new HY_ProductionPlanningBLL();
                string sql = "insert into HY_ProductionPlanning(p_DID,p_KID,p_CID,p_Engineering,p_Design) values('" + hypromodel.P_DID + "','" + hypromodel.P_KID + "','" + hypromodel.P_CID + "','" + hypromodel.P_Engineering + "','" + hypromodel.P_Design + "')";
                int res = hyprobll.com_HY_ProductionPlanninglist(sql);
                if (res > 0)
                {
                    MessageBox.Show("生产排程计划添加成功！");
                    requistionDate();//自定义绑定数据库
                }
            }
        }
        /// <summary>
        /// 自定义返回销售单号(跨窗口传值定义)
        /// </summary>
        /// <param name="Number">单号</param>
        public void p_Number(string Number)
        {
            this.p_DID1.Text = Number;

        }
        /// <summary>
        /// 自定义返回销售单号(跨窗口传值定义)
        /// </summary>
        /// <param name="Number">单号</param>
        public void p_NumberC(string Number,string FID)
        {
            this.p_DID.Text = Number;
            this.p_KID.Text = FID;

        }

        private void btnYY_Click(object sender, EventArgs e)
        {
            hypromodel.P_YKDate = Convert.ToDateTime(this.p_YKDate.Value);
            hypromodel.P_YWDate = Convert.ToDateTime(this.p_YWDate.Value);

            string sql = "update HY_ProductionPlanning set p_YKDate='" + hypromodel.P_YKDate + "',p_YWDate='" + hypromodel.P_YWDate + "' where p_DID='" + this.p_DID1.Text + "'";
            int res = hyprod.com_HY_ProductionPlanninglist(sql);
            if (res > 0)
            {
                MessageBox.Show("营业课时间确认完成！");
                requistionDate();//自定义绑定数据库
            }
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Production.HY_SalesID hysal = new HY_SalesID();
            hysal.hyproduc = this;//
            hysal.ShowDialog();
        }
        //设计确认
        private void btnSJ_Click(object sender, EventArgs e)
        {
            hypromodel.P_SKDate = Convert.ToDateTime(this.p_SKDate.Value);
            hypromodel.P_SWDate = Convert.ToDateTime(this.p_SWDate.Value);

            string sql = "update HY_ProductionPlanning set p_SKDate='" + hypromodel.P_SKDate + "',p_SWDate='" + hypromodel.P_SWDate + "' where p_DID='" + this.p_DID1.Text + "'";
            int res = hyprod.com_HY_ProductionPlanninglist(sql);
            if (res > 0)
            {
                MessageBox.Show("设计时间确认完成！");
                requistionDate();//自定义绑定数据库
            }
        }
        //审图确认
        private void btnST_Click(object sender, EventArgs e)
        {
            hypromodel.P_STKDate = Convert.ToDateTime(this.p_STKDate.Value);
            hypromodel.P_STWDate = Convert.ToDateTime(this.p_STWDate.Value);

            string sql = "update HY_ProductionPlanning set p_STKDate='" + hypromodel.P_STKDate + "',p_STWDate='" + hypromodel.P_STWDate + "' where p_DID='" + this.p_DID1.Text + "'";
            int res = hyprod.com_HY_ProductionPlanninglist(sql);
            if (res > 0)
            {
                MessageBox.Show("审图时间确认完成！");
                requistionDate();//自定义绑定数据库
            }
        }
        //材料购入
        private void btnCG_Click(object sender, EventArgs e)
        {
            hypromodel.P_CLKDate = Convert.ToDateTime(this.p_CLKDate.Value);
            hypromodel.P_CLWDate = Convert.ToDateTime(this.p_CLWDate.Value);

            string sql = "update HY_ProductionPlanning set p_CLKDate='" + hypromodel.P_CLKDate + "',p_CLWDate='" + hypromodel.P_CLWDate + "' where p_DID='" + this.p_DID1.Text + "'";
            int res = hyprod.com_HY_ProductionPlanninglist(sql);
            if (res > 0)
            {
                MessageBox.Show("材料到位时间确认完成！");
                requistionDate();//自定义绑定数据库
            }

        }
        //CNC确认 
        private void btnCNC_Click(object sender, EventArgs e)
        {
            hypromodel.P_CNCKDate = Convert.ToDateTime(this.p_CNCKDate.Value);
            hypromodel.P_CNCWDate = Convert.ToDateTime(this.p_CNCWDate.Value);

            string sql = "update HY_ProductionPlanning set p_CNCKDate='" + hypromodel.P_CNCKDate + "',p_CNCWDate='" + hypromodel.P_CNCWDate + "' where p_DID='" + this.p_DID1.Text + "'";
            int res = hyprod.com_HY_ProductionPlanninglist(sql);
            if (res > 0)
            {
                MessageBox.Show("CNC时间确认完成！");
                requistionDate();//自定义绑定数据库
            }
        }
        //机加工确认
        private void btnJJG_Click(object sender, EventArgs e)
        {
            hypromodel.P_JJKDate = Convert.ToDateTime(this.p_JJKDate.Value);
            hypromodel.P_JJWDate = Convert.ToDateTime(this.p_JJWDate.Value);

            string sql = "update HY_ProductionPlanning set p_JJKDate='" + hypromodel.P_JJKDate + "',p_JJWDate='" + hypromodel.P_JJWDate + "' where p_DID='" + this.p_DID1.Text + "'";
            int res = hyprod.com_HY_ProductionPlanninglist(sql);
            if (res > 0)
            {
                MessageBox.Show("机加工时间确认完成！");
                requistionDate();//自定义绑定数据库
            }
        }
        //热处理确认
        private void btnHOT_Click(object sender, EventArgs e)
        {
            hypromodel.P_HKDate = Convert.ToDateTime(this.p_HKDate.Value);
            hypromodel.P_HWDate = Convert.ToDateTime(this.p_HWDate.Value);

            string sql = "update HY_ProductionPlanning set p_HKDate='" + hypromodel.P_HKDate + "',p_HWDate='" + hypromodel.P_HWDate + "' where p_DID='" + this.p_DID1.Text + "'";
            int res = hyprod.com_HY_ProductionPlanninglist(sql);
            if (res > 0)
            {
                MessageBox.Show("热处理时间确认完成！");
                requistionDate();//自定义绑定数据库
            }
        }
        //磨加工确认
        private void btnM_Click(object sender, EventArgs e)
        {
            hypromodel.P_MKDate = Convert.ToDateTime(this.p_MKDate.Value);
            hypromodel.P_MWDate = Convert.ToDateTime(this.p_MWDate.Value);

            string sql = "update HY_ProductionPlanning set p_MKDate='" + hypromodel.P_MKDate + "',p_MWDate='" + hypromodel.P_MWDate + "' where p_DID='" + this.p_DID1.Text + "'";
            int res = hyprod.com_HY_ProductionPlanninglist(sql);
            if (res > 0)
            {
                MessageBox.Show("磨加工时间确认完成！");
                requistionDate();//自定义绑定数据库
            }
        }
        //线切割时间确认
        private void btnXG_Click(object sender, EventArgs e)
        {
            hypromodel.P_XKDate= Convert.ToDateTime(this.p_XKDate.Value);
            hypromodel.P_XWDate = Convert.ToDateTime(this.p_XWDate.Value);

            string sql = "update HY_ProductionPlanning set p_XKDate='" + hypromodel.P_XKDate + "',p_XWDate='" + hypromodel.P_XWDate + "' where p_DID='" + this.p_DID1.Text + "'";
            int res = hyprod.com_HY_ProductionPlanninglist(sql);
            if (res > 0)
            {
                MessageBox.Show("线切割时间确认完成！");
                requistionDate();//自定义绑定数据库
            }
        }
        //组立确认
        private void btnZL_Click(object sender, EventArgs e)
        {
            hypromodel.P_ZLKDate = Convert.ToDateTime(this.p_ZLKDate.Value);
            hypromodel.P_ZLWDate = Convert.ToDateTime(this.p_ZLWDate.Value);

            string sql = "update HY_ProductionPlanning set p_ZLKDate='" + hypromodel.P_ZLKDate + "',p_ZLWDate='" + hypromodel.P_ZLWDate + "' where p_DID='" + this.p_DID1.Text + "'";
            int res = hyprod.com_HY_ProductionPlanninglist(sql);
            if (res > 0)
            {
                MessageBox.Show("组立时间确认完成！");
                requistionDate();//自定义绑定数据库
            }
        }
        //试作时间确认
        private void btnSZ_Click(object sender, EventArgs e)
        {
            hypromodel.P_SZKDate = Convert.ToDateTime(this.p_SZKDate.Value);
            hypromodel.P_SZWDate = Convert.ToDateTime(this.p_SZWDate.Value);

            string sql = "update HY_ProductionPlanning set p_SZKDate='" + hypromodel.P_SZKDate + "',p_SZWDate='" + hypromodel.P_SZWDate + "' where p_DID='" + this.p_DID1.Text + "'";
            int res = hyprod.com_HY_ProductionPlanninglist(sql);
            if (res > 0)
            {
                MessageBox.Show("试作时间确认完成！");
                requistionDate();//自定义绑定数据库
            }
        }
        //型检时间确认
        private void btnXJ_Click(object sender, EventArgs e)
        {
            hypromodel.P_XJWDate = Convert.ToDateTime(this.p_XJWDate.Value);
            string sql = "update HY_ProductionPlanning set p_XJWDate='" + hypromodel.P_XJWDate + "'  where p_DID='" + this.p_DID1.Text + "'";
            int res = hyprod.com_HY_ProductionPlanninglist(sql);
            if (res > 0)
            {
                MessageBox.Show("型检时间确认完成！");
                requistionDate();//自定义绑定数据库
            }
        }
        //OK样提交时间确认
        private void btnOK_Click(object sender, EventArgs e)
        {
            hypromodel.P_OKWDate = Convert.ToDateTime(this.p_OKWDate.Value);
            string sql = "update HY_ProductionPlanning set p_OKWDate='" + hypromodel.P_OKWDate + "'  where p_DID='" + this.p_DID1.Text + "'";
            int res = hyprod.com_HY_ProductionPlanninglist(sql);
            if (res > 0)
            {
                MessageBox.Show("OK样提交时间确认完成！");
                requistionDate();//自定义绑定数据库
            }
        }
        //模具移交时间确认
        private void btnYJ_Click(object sender, EventArgs e)
        {
            hypromodel.P_YDWDate= Convert.ToDateTime(this.p_YDWDate.Value);
            string sql = "update HY_ProductionPlanning set p_YDWDate='" + hypromodel.P_YDWDate + "'  where p_DID='" + this.p_DID1.Text + "'";
            int res = hyprod.com_HY_ProductionPlanninglist(sql);
            if (res > 0)
            {
                MessageBox.Show("模具移交时间确认完成！");
                requistionDate();//自定义绑定数据库
            }
        }

        private void p_DID1_TextChanged(object sender, EventArgs e)
        {
            string sql = "select p_DID,p_KID from HY_ProductionPlanning where p_DID='" + this.p_DID1.Text + "'";
            HY_BLL.HY_ProductionPlanningBLL hyprod = new HY_ProductionPlanningBLL();
            SqlDataReader sdr = hyprod.f_ProductionPlanningslist(sql);
            while (sdr.Read())
            {
                this.p_KID1.Text = sdr[1].ToString();
                this.p_KID2.Text = sdr[1].ToString();
                this.p_KID3.Text = sdr[1].ToString();
                this.p_KID4.Text = sdr[1].ToString();
                this.p_KID5.Text = sdr[1].ToString();
                this.p_KID6.Text = sdr[1].ToString();
                this.p_KID7.Text = sdr[1].ToString();
                this.p_KID8.Text = sdr[1].ToString();
                this.p_KID9.Text = sdr[1].ToString();
                this.p_KID10.Text = sdr[1].ToString();
                this.p_KID11.Text = sdr[1].ToString();
                this.p_KID12.Text = sdr[1].ToString();
                this.p_KID13.Text = sdr[1].ToString();
                this.p_KID14.Text = sdr[1].ToString();
                this.p_KID15.Text = sdr[1].ToString();

                this.btnYY.Enabled = true;
                this.btnSJ.Enabled = true;
                this.btnST.Enabled = true;
                this.btnCG.Enabled = true;
                this.btnJJG.Enabled = true;
                this.btnHOT.Enabled = true;
                this.btnCNC.Enabled = true;
                this.btnM.Enabled = true;
                this.btnXG.Enabled = true;
                this.btnZL.Enabled = true;
                this.btnSZ.Enabled = true;
                this.btnXJ.Enabled = true;
                this.btnOK.Enabled = true;
                this.btnYJ.Enabled = true;
                this.p_YKDate.Enabled = true;
                this.p_YWDate.Enabled = true;
                this.p_SKDate.Enabled = true;
                this.p_SWDate.Enabled = true;
                this.p_STKDate.Enabled = true;
                this.p_STWDate.Enabled = true;
                this.p_CLKDate.Enabled = true;
                this.p_CLWDate.Enabled = true;
                this.p_CNCKDate.Enabled = true;
                this.p_CNCWDate.Enabled = true;
                this.p_JJKDate.Enabled = true;
                this.p_YWDate.Enabled = true;
                this.p_HKDate.Enabled = true;
                this.p_HWDate.Enabled = true;
                this.p_MKDate.Enabled = true;
                this.p_MWDate.Enabled = true;
                this.p_XKDate.Enabled = true;
                this.p_XWDate.Enabled = true;
                this.p_ZLKDate.Enabled = true;
                this.p_ZLWDate.Enabled = true;
                this.p_SZKDate.Enabled = true;
                this.p_SZWDate.Enabled = true;
                this.p_XJWDate.Enabled = true;
                this.p_OKWDate.Enabled = true;
                this.p_YDWDate.Enabled = true;
            }
        }

        private void btnS1_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Production.HY_SalesCID hysalcid = new HY_SalesCID();
            hysalcid.hyproduc = this;
            hysalcid.ShowDialog();
        }

        //按类别检索排程计划
        private void btnSO_Click(object sender, EventArgs e)
        {
            string v = this.p_Class.Text;
            string pkey = this.key.Text.Trim();
            if (pkey == string.Empty)
            {
                MessageBoxEx.Show("检索关键字不能为空,请确认你要检索的关键字！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }
        
        private void toolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}