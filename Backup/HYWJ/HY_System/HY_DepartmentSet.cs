using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using HY_BLL;

namespace HYWJ.HY_System
{
    public partial class HY_DepartmentSet : Office2007Form
    {
        public HY_BLL.HY_DepartmentBLL hydep;
        public HY_DepartmentSet()
        {
            InitializeComponent();
            hydep = new HY_DepartmentBLL();
        }

        private void HY_DepartmentSet_Load(object sender, EventArgs e)
        {
            lbHYList_BM();
            string sql = "select h_ID,h_UserName from HY_user";
            this.s_Person.DataSource = hydep.ExecuteQuery(sql);
            this.s_Person.DisplayMember = "h_UserName";
        }
        //部门
        private void lbHYList_BM()
        {
            string sql = "select * from HY_Department";
            this.lbHY.DataSource = hydep.ExecuteQuery(sql);
            this.lbHY.DisplayMember = "d_Name";

        }

        private void OK_Click(object sender, EventArgs e)
        {
            string sql = "update HY_user set h_Department='" + this.lbHY.Text.ToString() + "' where h_UserName='" + this.s_Person.Text.ToString() + "'";
            int res = hydep.com_DepartmentZSG(sql);
            if (res > 0)
            {
                MessageBoxEx.Show("用户部门信息分配成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }
    }
}