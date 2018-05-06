/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   海益数据信息系统主窗体
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
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Management;
using System.Management.Instrumentation;
using System.Security.Cryptography;
using DevComponents.DotNetBar;
using System.IO;

namespace HYWJ
{
    public partial class MianForm : Office2007Form
    {
        //定义全局变量保存用户的信息
        public  string UserName = "";
        //private string AppPath = Environment.CurrentDirectory;//获取软件运行目录
        //private HYWJ.HY_System.Ini ini;
        public MianForm()
        {
            InitializeComponent();
            //ini = new HYWJ.HY_System.Ini(AppPath + @"\config.ini");
        }    
        private void 关于系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HYWJ.About about = new About();
            about.Show();
        }

        /// <summary>
        /// 系统运行时加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MianForm_Load(object sender, EventArgs e)
        {
                //string license = ini.ReadValue("License", "key");
                //if (Decrypt(license, "joy64000") != GetMotherBoardSerialNumber())
                //{
                //    this.menuHY.Enabled = false;
                //    this.toolStripHY.Enabled = false;
                //    HYWJ.Register reg = new Register();
                //    reg.ShowDialog();
                //    return;
                //}
                this.toolStripStatusName.Text = "当前登录用户：" + UserName;
                this.timerHY.Enabled = true;
                HYWJ.HY_System.HY_Workflow hyworkf = new HYWJ.HY_System.HY_Workflow();
                hyworkf.TopLevel = false;
                this.panelEx1.Controls.Add(hyworkf);
                hyworkf.Show();
                QX();//载入权限验证
        }
        #region  自定义权限验证
        /// <summary>
        /// 权限控制
        /// </summary>
        private void QX()
        {
            HYWJ.HY_System.QuanXian qx = new HYWJ.HY_System.QuanXian();
            //系统设置
            if (!qx.f_QuanXian("10000", UserName))
            {
                this.btnSystemSet.Enabled = false;
            }
            //账户管理
            if (!qx.f_QuanXian("10001", UserName))
            {
                this.btnMangSet.Enabled = false;
            }
            //部门设置
            if (!qx.f_QuanXian("10002", UserName))
            {
                this.btnDepSet.Enabled = false;
            }
            //权限管理
            if (!qx.f_QuanXian("10003", UserName))
            {
                this.btnQX.Enabled = false;
            }
            //日志管理
            if (!qx.f_QuanXian("10004", UserName))
            {
                this.btnSystemLog.Enabled = false;
            }
            //录入客户信息

            if (!qx.f_QuanXian("12", UserName))
            {
                this.btnBJD.Enabled = false;
            }
            if (!qx.f_QuanXian("13", UserName))
            {
                this.btnCustOrder.Enabled = false;
            }
            if (!qx.f_QuanXian("14", UserName))
            {
                this.btnXSBB.Enabled = false;
            }
            if (!qx.f_QuanXian("22", UserName))
            {
                this.btnSuppLR.Enabled = false;
            }
            if (!qx.f_QuanXian("23", UserName))
            {
                this.btnSuppPirc.Enabled = false;
            }
            if (!qx.f_QuanXian("26", UserName))
            {
                this.btnReq.Enabled = false;
            }
            if (!qx.f_QuanXian("27", UserName))
            {
                this.btnReqToPro.Enabled = false;
            }
            if (!qx.f_QuanXian("28", UserName))
            {
                this.btnQGMX.Enabled = false;
            }
            if (!qx.f_QuanXian("290", UserName))
            {
                this.btnCGD.Enabled = false;
            }
            if (!qx.f_QuanXian("291", UserName))
            {
                this.btnCGMX.Enabled = false;
            }
            if (!qx.f_QuanXian("31", UserName))
            {
                this.btnWare.Enabled = false;
            }
            if (!qx.f_QuanXian("32", UserName))
            {
                this.btnWareLL.Enabled = false;
            }
            if (!qx.f_QuanXian("36", UserName))
            {
                this.btnWareDB.Enabled = false;
            }
            if (!qx.f_QuanXian("37", UserName))
            {
                this.btnWareM.Enabled = false;
            }
            if (!qx.f_QuanXian("38", UserName))
            {
                this.btnWareOUT.Enabled = false;
            }
            if (!qx.f_QuanXian("39", UserName))
            {
                this.btnWareLog.Enabled = false;
            }
            if (!qx.f_QuanXian("41", UserName))
            {
                this.btnProdPCJH.Enabled = false;
            }
            if (!qx.f_QuanXian("42", UserName))
            {
                this.btnBom.Enabled = false;
            }
            if (!qx.f_QuanXian("43", UserName))
            {
                this.btnBomList.Enabled = false;
            }
            if (!qx.f_QuanXian("44", UserName))
            {
                this.btnBomSH.Enabled = false;
            }
            if (!qx.f_QuanXian("45", UserName))
            {
                this.btnBomTORrq.Enabled = false;
            }
            if (!qx.f_QuanXian("46", UserName))
            {
                this.btnBomPD.Enabled = false;
            }
        }
        #endregion
        private void timerHY_Tick(object sender, EventArgs e)
        {
            this.da.Text="系统时间:" + System.DateTime.Now.ToString();
            //this.about.Text= DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }

        private void 帐户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_System.Management)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_System.Management hyng = new HYWJ.HY_System.Management();
            //hyng.MdiParent = this;
            hyng.Show();
        }

        private void 关于系统ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            About abo = new About();
            abo.Owner = this;
            abo.ShowDialog();
        }

        private void 软件注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.Register)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.Register reg = new Register();
            //reg.MdiParent = this;
            reg.Show();
        }

        /// <summary>
        /// 获取主板序号
        /// </summary>
        /// <returns>返回主板ID</returns>
        private static string GetMotherBoardSerialNumber()
        {
            ManagementClass mc = new ManagementClass("WIN32_BaseBoard");
            ManagementObjectCollection moc = mc.GetInstances();
            string SerialNumber = "";
            foreach (ManagementObject mo in moc)
            {
                SerialNumber = mo["SerialNumber"].ToString();
                break;
            }
            return SerialNumber;
        }

        ///// <summary>
        ///// 进行DES解密。
        ///// </summary>
        ///// <param name="pToDecrypt">要解密的以Base64</param>
        ///// <param name="sKey">密钥，且必须为8位。</param>
        ///// <returns>已解密的字符串。</returns>
        //public string Decrypt(string pToDecrypt, string sKey)
        //{
        //    byte[] inputByteArray = Convert.FromBase64String(pToDecrypt);
        //    using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
        //    {
        //        des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
        //        des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
        //        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        //        using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write))
        //        {
        //            cs.Write(inputByteArray, 0, inputByteArray.Length);
        //            cs.FlushFinalBlock();
        //            cs.Close();
        //        }
        //        string str = Encoding.UTF8.GetString(ms.ToArray());
        //        ms.Close();
        //        return str;
        //    }
        //}        

        //退出系统
        private void toolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //主窗体关闭事件
        private void MianForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBoxEx.Show("\n欢迎再次使用海益信息管理系统   \n\n\n    确认是否退出(Y/N)", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                e.Cancel = false;
                this.Dispose();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }   

        }

        private void 客户基础设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Business.HY_CustomerInfo)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Business.HY_CustomerInfo hycust = new HYWJ.HY_Business.HY_CustomerInfo();
            //hycust.MdiParent = this;
            hycust.ShowDialog();
        }

        private void toolStripKCMX_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Warehouse.HY_StockDetails)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Warehouse.HY_StockDetails hystordet = new HYWJ.HY_Warehouse.HY_StockDetails();
            //hystordet.MdiParent = this;
            hystordet.ShowDialog();
        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Invoicing.HY_Requisitions)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Invoicing.HY_Requisitions hyrep = new HYWJ.HY_Invoicing.HY_Requisitions();
            //hyrep.MdiParent = this;
            hyrep.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonItem23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //基础设置
        private void btnSystemSet_Click(object sender, EventArgs e)
        {
            HYWJ.HY_System.HY_SystemSet hysyset = new HYWJ.HY_System.HY_SystemSet();
            hysyset.ShowDialog();
        }
        //供应商设置
        private void btnSuppSet_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_System.HY_Supplier)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_System.HY_Supplier hysup = new HYWJ.HY_System.HY_Supplier();
            //hysup.MdiParent = this;
            hysup.ShowDialog();
        }

        // 客户设置
        private void btnCustSet_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Business.HY_CustomerInfo)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Business.HY_CustomerInfo hycust = new HYWJ.HY_Business.HY_CustomerInfo();
            //hycust.MdiParent = this;
            hycust.ShowDialog();
        }
        //权限管理
        private void btnQX_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_System.HY_Permissions)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_System.HY_Permissions hy_s = new HYWJ.HY_System.HY_Permissions();
            hy_s.UserName = UserName;
            hy_s.ShowDialog();
        }
        //部门设置
        private void btnDepSet_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_System.HY_DepartmentSet)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_System.HY_DepartmentSet hydepset = new HYWJ.HY_System.HY_DepartmentSet();
            //hydepset.MdiParent = this;
            hydepset.ShowDialog();
        }
        //账户管理
        private void btnMangSet_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_System.Management)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_System.Management hyng = new HYWJ.HY_System.Management();
            //hyng.MdiParent = this;
            hyng.ShowDialog();
        }
        //录入客户信息
        private void btnSuppXS_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Business.HY_CustomerInfo)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Business.HY_CustomerInfo hycust = new HYWJ.HY_Business.HY_CustomerInfo();
            //hycust.MdiParent = this;
            hycust.ShowDialog();
        }
        //录入客户订单
        private void btnCustOrder_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Business.HY_CustomerOrder)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Business.HY_CustomerOrder hycusorder = new HYWJ.HY_Business.HY_CustomerOrder();
            //hycusorder.MdiParent=this;
            hycusorder.ShowDialog();
        }
        //供应商设置
        private void btnSuppLR_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_System.HY_Supplier)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_System.HY_Supplier hysup = new HYWJ.HY_System.HY_Supplier();
            //hysup.MdiParent = this;
            hysup.ShowDialog();
        }
        //供应商料件价格
        private void btnSuppPirc_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Invoicing.HY_SupplierPrice)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Invoicing.HY_SupplierPrice hysupc = new HYWJ.HY_Invoicing.HY_SupplierPrice();
            //hysupc.MdiParent = this;
            hysupc.ShowDialog();
        }

        //录入请购单
        private void btnReq_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Invoicing.HY_Requisitions)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Invoicing.HY_Requisitions hyrep = new HYWJ.HY_Invoicing.HY_Requisitions();
            //hyrep.MdiParent = this;
            hyrep.ShowDialog();
        }
        //从请购单生成采购单
        private void btnReqToPro_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Invoicing.HY_RequisitionsTOProcurement)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Invoicing.HY_RequisitionsTOProcurement hyreqtopro = new HYWJ.HY_Invoicing.HY_RequisitionsTOProcurement();
            //hyreqtopro.MdiParent = this;
            hyreqtopro.ShowDialog();
        }
        //录入入库单
        private void btnWare_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Warehouse.HY_Storage)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Warehouse.HY_Storage hystor = new HYWJ.HY_Warehouse.HY_Storage();
            //hystor.MdiParent = this;
            hystor.ShowDialog();
        }
        //录入领料单
        private void btnWareLL_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Warehouse.HY_Requisitioned)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Warehouse.HY_Requisitioned hyreq = new HYWJ.HY_Warehouse.HY_Requisitioned();
            //hyreq.MdiParent = this;
            hyreq.ShowDialog();
        }
        //库存明细表
        private void btnWareDB_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Warehouse.HY_StockDetails)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Warehouse.HY_StockDetails hystordet = new HYWJ.HY_Warehouse.HY_StockDetails();
            //hystordet.MdiParent = this;
            hystordet.ShowDialog();
        }
        //库存明细账
        private void btnWareM_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Warehouse.HY_StockAccount)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Warehouse.HY_StockAccount hystoacc = new HYWJ.HY_Warehouse.HY_StockAccount();
            //hystoacc.MdiParent = this;
            hystoacc.ShowDialog();
        }

        private void btnWareOUT_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Report.HY_RequisitionedDB hyreqdb = new HYWJ.HY_Report.HY_RequisitionedDB();
            hyreqdb.ShowDialog();
        }
        //生产排程计划
        private void btnProdPC_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Production.HY_ProductionPlanning)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Production.HY_ProductionPlanning hyprotp = new HYWJ.HY_Production.HY_ProductionPlanning();
            //hyprotp.MdiParent = this;
            hyprotp.ShowDialog();
        }
        //录入BOM
        private void btnBom_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Production.HY_Bomlist)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Production.HY_Bomlist hybomlist = new HYWJ.HY_Production.HY_Bomlist();
            //hybomlist.MdiParent = this;
            hybomlist.ShowDialog();
        }

        private void btnBomList_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Production.HY_BomDetails)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Production.HY_BomDetails hybomdet = new HYWJ.HY_Production.HY_BomDetails();
            //hybomlist.MdiParent = this;
            hybomdet.ShowDialog();
        }
        //BOM深圳
        private void btnBomSH_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Production.HY_BomAudit)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Production.HY_BomAudit hybomaut = new HYWJ.HY_Production.HY_BomAudit();
            //hybomaut.MdiParent = this;
            hybomaut.ShowDialog();
        }
        //从BOM生成请购单
        private void btnBomTORrq_Click(object sender, EventArgs e)
        {
            //判断窗体是否重复打开
            foreach (Form f in this.MdiChildren)
            {
                if (f is HYWJ.HY_Production.HY_BomTORequisitions)
                {
                    f.Activate();
                    return;
                }
            }
            HYWJ.HY_Production.HY_BomTORequisitions hybomtoreq = new HYWJ.HY_Production.HY_BomTORequisitions();
            //hybomtoreq.Owner= this;
            hybomtoreq.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            HYWJ.About abo = new About();
            abo.ShowDialog();
        }
        //供应商信息管理
        private void btnGYS_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Invoicing.HY_SupplierList hysup = new HYWJ.HY_Invoicing.HY_SupplierList();
            //hybomtoreq.Owner= this;
            hysup.ShowDialog();
        }
        //请购明细表
        private void btnQGMX_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Invoicing.HY_RequisitionDetail hyreqdel = new HYWJ.HY_Invoicing.HY_RequisitionDetail();
            hyreqdel.ShowDialog();
        }
        //采购明细表
        private void btnCGMX_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Invoicing.HY_Purchasingdetails hypurdet = new HYWJ.HY_Invoicing.HY_Purchasingdetails();
            hypurdet.ShowDialog();
        }
        //采购状况表
        private void btnCGZK_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Invoicing.HY_Purchasingstatus hypurstat = new HYWJ.HY_Invoicing.HY_Purchasingstatus();
            hypurstat.ShowDialog();
        }
        //BOM物料盘点
        private void btnBomPD_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Production.HY_BOMListInventory hybomlistinv = new HYWJ.HY_Production.HY_BOMListInventory();
            hybomlistinv.ShowDialog();
        }
        //仓库物料状态
        private void btnWareZT_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Report.HY_WarehouseStateDB hywawrstat = new HYWJ.HY_Report.HY_WarehouseStateDB();
            hywawrstat.ShowDialog();
        }
        //仓库查询BOM单信息
        private void btnBOMSO_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Warehouse.HY_BomSo hybomso = new HYWJ.HY_Warehouse.HY_BomSo();
            hybomso.ShowDialog();
        }

        //营业查看库存
        private void btnCKKCS_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Warehouse.HY_LookStorage hylookstor = new HYWJ.HY_Warehouse.HY_LookStorage();
            hylookstor.ShowDialog();
        }
        //工程查看库存
        private void btnCKKCGC_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Warehouse.HY_LookStorage hylookstor = new HYWJ.HY_Warehouse.HY_LookStorage();
            hylookstor.ShowDialog();
        }
        //生管查看库存
        private void btnCKKCSG_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Warehouse.HY_LookStorage hylookstor = new HYWJ.HY_Warehouse.HY_LookStorage();
            hylookstor.ShowDialog();
        }
        //采购查看库存
        private void btnCKKCCG_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Warehouse.HY_LookStorage hylookstor = new HYWJ.HY_Warehouse.HY_LookStorage();
            hylookstor.ShowDialog();
        }
        //仓库查看采购状况
        private void btnCGZKCK_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Invoicing.HY_Purchasingstatus hypurstat = new HYWJ.HY_Invoicing.HY_Purchasingstatus();
            hypurstat.ShowDialog();
        }
        //新增采购信息
        private void btnCGD_Click(object sender, EventArgs e)
        {
            HYWJ.HY_Invoicing.HY_Purchaseorder hypurorder = new HYWJ.HY_Invoicing.HY_Purchaseorder();
            hypurorder.ShowDialog();
        }
    }
}
