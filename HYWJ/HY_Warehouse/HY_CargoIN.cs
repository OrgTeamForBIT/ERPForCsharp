using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using HY_BLL;
using System.Windows.Forms;

namespace HYWJ.HY_Warehouse
{
    public partial class HY_CargoIN : Form
    {
        public HY_CargoIN()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            
            HY_BLL.HY_StorageBLL hystor = new HY_StorageBLL();
            string sql = "insert into HY_CPClass(c_Class) values('" + this.c_Class.Text.Trim() + "')";
            int res = hystor.com_HY_HY_Storagelslist(sql);
            if (res > 0)
            {
                MessageBox.Show("产品类别添加成功，确定后可继续添加！");
                cp_Class();
                this.c_Class.Text = "";//清空输入框
            }
        }

        private void HY_CargoIN_Load(object sender, EventArgs e)
        {
            cp_Class();
            this.tabControl1.SelectedIndex = 1;
        }
        //绑定产品类别
        private void cp_Class()
        {
            HY_BLL.HY_StorageBLL hystorbll = new HY_StorageBLL();
            string sql = "select * from HY_CPClass order by c_ID desc";
            this.listBoxClass.DataSource = hystorbll.ExecuteQuerySelect(sql);
            this.listBoxClass.DisplayMember = "c_Class";
            this.listBoxClass.ValueMember = "c_ID";

        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            int cid = int.Parse(this.listBoxClass.SelectedValue.ToString());//选择产品类别值
            HY_BLL.HY_StorageBLL hystorbll = new HY_StorageBLL();
            string sql="delete from HY_CPClass where c_ID='"+cid+"'";
            int res = hystorbll.com_HY_HY_Storagelslist(sql);
            if (res > 0)
            {
                MessageBox.Show("提示：成功删除产品类别!");
                cp_Class();
            }
        }
    }
}
