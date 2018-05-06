/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   系统基础设置
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
using HY_Model;
using HY_BLL;

namespace HYWJ.HY_System
{
    public partial class HY_SystemSet : Office2007Form
    {
        public HY_SystemSet()
        {
            InitializeComponent();
        }

      
        /// <summary>
        /// 添加部门类别信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dnADD_Click(object sender, EventArgs e)
        {
            string dName = this.d_Name.Text.Trim();
            if (dName == string.Empty)
            {
                MessageBox.Show("部门名称不能为空!","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.d_Name.Focus();
                return;
            }
            //实例化部门实体类
            HY_Model.HY_Department d = new HY_Model.HY_Department();
            d.D_Name = this.d_Name.Text.Trim();

            //执行操作
            HY_BLL.HY_DepartmentBLL hydep = new HY_DepartmentBLL();
            int res = hydep.com_Department(d);
            if (res > 0)
            {
                MessageBox.Show("添加成功!");
                lbHYList_BM();
            }
        }

        //部门
        private void lbHYList_BM()
        {
            HY_BLL.HY_DepartmentBLL hydep = new HY_DepartmentBLL();
            string sql = "select * from HY_Department";
            this.lbHY.DataSource = hydep.ExecuteQuery(sql);
            this.lbHY.DisplayMember = "d_Name";
            this.lbHY.ValueMember = "d_ID";
        }


        //仓库
        private void lbHYList_CK()
        {
            HY_BLL.HY_WarehouseBLL hywar = new HY_WarehouseBLL();
            this.lbCK.DataSource = hywar.ExecuteQuery();
            this.lbCK.DisplayMember = "c_ckName";
            this.lbCK.ValueMember = "c_ID";
        
        }

        private void HY_SystemSet_Load(object sender, EventArgs e)
        {
            
            //返回公司基本信息
            HY_BLL.HY_InformationBLL hyinfo = new HY_InformationBLL();
            int I_ID = 1;
            DataTable dt = hyinfo.comf_Information(I_ID);
            if (dt.Rows.Count > 0)
            {
                this.companyName.Text = dt.Rows[0][1].ToString();
                this.Range.Text = dt.Rows[0][2].ToString();
                this.Address.Text = dt.Rows[0][3].ToString();
            }

            lbHYList_BM();//自定义部门数据绑定
            lbHYList_CK();//自定义仓库数据绑定
        }

      


        private void h_OK_Click(object sender, EventArgs e)
        {
            //公司基本信息实体类实例化
            HY_Model.HY_Information m = new HY_Information();
            m.S_Company = this.companyName.Text.Trim();
            m.S_Range = this.Range.Text.Trim();
            m.S_Address = this.Address.Text.Trim();

            //公司基本信息BLL层
            HY_BLL.HY_InformationBLL hyinfo = new HY_InformationBLL();
            int I_ID = 1;
            int res = hyinfo.com_Information(m, I_ID);
            if (res > 0)
            {
                MessageBoxEx.Show("提示：基本信息操作成功!");
                this.Close();
            }
        }

        //删除部门
        private void dnDEL_Click(object sender, EventArgs e)
        {
            //实例化部门实体类
            HY_Model.HY_Department del = new HY_Model.HY_Department();
            del.D_ID =int.Parse(this.lbHY.SelectedValue.ToString());//选择部门项值

            HY_BLL.HY_DepartmentBLL hydep = new HY_DepartmentBLL();
            int res = hydep.del_Department(del);
            if (res >0)
            {
                MessageBoxEx.Show("提示：成功删除部门!");
                lbHYList_BM();
            }
          
        }

        //添加仓库
        private void ckADD_Click(object sender, EventArgs e)
        {
            string ckName = this.ckName.Text.Trim();
            if (ckName == string.Empty)
            {
                MessageBoxEx.Show("提示：仓库名称不能为空!");
                this.ckName.Focus();
                return;
            }
            //实例化仓库实体类
            HY_Model.HY_Warehouse w = new HY_Model.HY_Warehouse();
            w.C_ckName = this.ckName.Text.Trim();

            HY_BLL.HY_WarehouseBLL hywar = new HY_WarehouseBLL();
            int res = hywar.com_Warehouse(w);
            if (res > 0)
            {
                MessageBoxEx.Show("提示：仓库添加成功!");
                this.ckName.Text = "";
                lbHYList_CK();
            }
        }

        //删除仓库
        private void ckDEL_Click(object sender, EventArgs e)
        {
            //实例化仓库实体类
            HY_Model.HY_Warehouse hywar = new HY_Model.HY_Warehouse();
            hywar.C_ID= int.Parse(this.lbCK.SelectedValue.ToString());//选择仓库项值

            HY_BLL.HY_WarehouseBLL hydep = new HY_WarehouseBLL();
            int res = hydep.del_Warehouse(hywar);
            if (res > 0)
            {
                MessageBoxEx.Show("提示：成功删除仓库!");
                lbHYList_BM();
            }
        }

        private void C_OK_Click(object sender, EventArgs e)
        {
            //公司基本信息实体类实例化
            HY_Model.HY_Information m = new HY_Information();
            m.S_Company = this.companyName.Text.Trim();
            m.S_Range = this.Range.Text.Trim();
            m.S_Address = this.Address.Text.Trim();

            //公司基本信息BLL层
            HY_BLL.HY_InformationBLL hyinfo = new HY_InformationBLL();
            int I_ID = 1;
            int res = hyinfo.com_Information(m, I_ID);
            if (res > 0)
            {
                MessageBoxEx.Show("提示：基本信息操作成功!");
                this.Close();
            }
        }

        private void C_CEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            //添加部门
        private void B_OK_Click(object sender, EventArgs e)
        {
            string dName = this.d_Name.Text.Trim();
            if (dName == string.Empty)
            {
                MessageBoxEx.Show("部门名称不能为空!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.d_Name.Focus();
                return;
            }
            //实例化部门实体类
            HY_Model.HY_Department d = new HY_Model.HY_Department();
            d.D_Name = this.d_Name.Text.Trim();

            //执行操作
            HY_BLL.HY_DepartmentBLL hydep = new HY_DepartmentBLL();
            int res = hydep.com_Department(d);
            if (res > 0)
            {
                MessageBoxEx.Show("添加成功!");
                lbHYList_BM();
            }
        }

        private void B_DEL_Click(object sender, EventArgs e)
        {
            //实例化部门实体类
            HY_Model.HY_Department del = new HY_Model.HY_Department();
            del.D_ID = int.Parse(this.lbHY.SelectedValue.ToString());//选择部门项值

            HY_BLL.HY_DepartmentBLL hydep = new HY_DepartmentBLL();
            int res = hydep.del_Department(del);
            if (res > 0)
            {
                MessageBoxEx.Show("提示：成功删除部门!");
                lbHYList_BM();
            }
        }

        private void W_ADD_Click(object sender, EventArgs e)
        {
            string ckName = this.ckName.Text.Trim();
            if (ckName == string.Empty)
            {
                MessageBoxEx.Show("提示：仓库名称不能为空!");
                this.ckName.Focus();
                return;
            }
            //实例化仓库实体类
            HY_Model.HY_Warehouse w = new HY_Model.HY_Warehouse();
            w.C_ckName = this.ckName.Text.Trim();

            HY_BLL.HY_WarehouseBLL hywar = new HY_WarehouseBLL();
            int res = hywar.com_Warehouse(w);
            if (res > 0)
            {
                MessageBoxEx.Show("提示：仓库添加成功!");
                this.ckName.Text = "";
                lbHYList_CK();
            }
        }

        private void W_DEL_Click(object sender, EventArgs e)
        {
            //实例化仓库实体类
            HY_Model.HY_Warehouse hywar = new HY_Model.HY_Warehouse();
            hywar.C_ID = int.Parse(this.lbCK.SelectedValue.ToString());//选择仓库项值

            HY_BLL.HY_WarehouseBLL hydep = new HY_WarehouseBLL();
            int res = hydep.del_Warehouse(hywar);
            if (res > 0)
            {
                MessageBoxEx.Show("提示：成功删除仓库!");
                lbHYList_BM();
            }
        }       
    }
}
