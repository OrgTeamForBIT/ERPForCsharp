using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using HY_BLL;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HYWJ.HY_System
{
    public partial class HY_Permissions : Office2007Form
    {
        public string UserName;
        private HY_BLL.HY_setbll hyset;
        private string sql = "Select s_ID,s_QID,s_QName from HY_Security order by s_ID asc";
        public HY_Permissions()
        {
            InitializeComponent();
            hyset = new HY_setbll();
        }

        private void HY_Permissions_Load(object sender, EventArgs e)
        {
            this.chkALL.Checked =false; 
            this.checkedListBox.DataSource = hyset.userSecurity(sql).DefaultView;
            this.checkedListBox.ValueMember = "s_QID";
            this.checkedListBox.DisplayMember = "s_QName";

            //绑定用户信息
            HY_BLL.HY_UserListBLL hyul = new HY_UserListBLL();
            this.comboBoxuserName.DataSource = hyul.back_SupplierPrice();
            this.comboBoxuserName.DisplayMember = "h_UserName";
            this.comboBoxuserName.ValueMember = "h_ID";

        }

        private void chkALL_CheckedChanged_1(object sender, EventArgs e)
        {
            int i;
            if (this.chkALL.Checked == true)
            {
                for (i = 0; i <= (checkedListBox.Items.Count - 1); i++)
                {
                    this.checkedListBox.SetItemChecked(i, true);
                }
                this.chkALL.Text = "取消全选";
            }
            else if (this.chkALL.Checked == false)
            {
                for (i = 0; i <= (checkedListBox.Items.Count - 1); i++)
                {
                    this.checkedListBox.SetItemChecked(i, false);
                }
                this.chkALL.Text = "全选";
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            int i;
            string s = string.Empty;
            //循环找出选中项
            for (i = 0; i <= (checkedListBox.Items.Count - 1); i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    s = s + hyset.userSecurity(sql).Rows[i]["s_QID"].ToString() + ",";
                }
            }
            HY_Model.User uset = new HY_Model.User();
            uset.Security = s;
            int res = hyset.userSecurityUpdate(uset, this.comboBoxuserName.Text);
            if (res > 0)
            {
                MessageBoxEx.Show("权限分配成功,确认后请重新启动系统!", this.comboBoxuserName.Text + "用户权限分配", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void CEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
