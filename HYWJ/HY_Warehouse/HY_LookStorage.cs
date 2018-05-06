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

namespace HYWJ.HY_Warehouse
{
    public partial class HY_LookStorage : Office2007Form
    {
        private HYWJ.HY_System.OperateAndValidate valid;//实例化数据验证类
        private HY_BLL.HY_StorageBLL hystorbll = null;
        public HY_LookStorage()
        {
            InitializeComponent();
            valid = new HYWJ.HY_System.OperateAndValidate();
            hystorbll = new HY_StorageBLL();
        }

        private void HY_LookStorage_Load(object sender, EventArgs e)
        {
            this.comboBoxClass.SelectedIndex = 0;
            string sql = "select s_ID,s_DID,s_CID,s_Supplier,s_Person,s_Class,s_Warehouse,s_XDate,s_DDate,s_PID,s_Pname,s_Origin,s_Specifications,s_Amount,s_Notes,s_WFDate,s_DWDate,s_WFSup,s_WFDateHot,s_DWDateHot,s_WFHotSup,s_WFDateBM,s_DWDateBM,s_WFSupBM from HY_Storage order by s_ID desc";
            requistionDate(sql);
        }

        //自定义绑定数据
        private void requistionDate(string sql)
        {
            this.dataGridViewCK.AutoGenerateColumns = false;// 关闭自动创建列
            HY_BLL.HY_StorageBLL hystorfobll = new HY_StorageBLL();
            
            this.dataGridViewCK.DataSource = hystorfobll.ExecuteQuerySelect(sql);
        }
        //检索数据
        private void btnOK_Click(object sender, EventArgs e)
        {
            string k = this.key.Text.Trim();
            if (!valid.validateNull(k))
            {
                MessageBoxEx.Show("检索关键字不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.key.Focus();
                return;
            }
            switch (this.comboBoxClass.SelectedIndex)
            {
                case 0:
                    string sql0 = "select s_ID,s_DID,s_CID,s_Supplier,s_Person,s_Class,s_Warehouse,s_XDate,s_DDate,s_PID,s_Pname,s_Origin,s_Specifications,s_Amount,s_Notes,s_WFDate,s_DWDate,s_WFSup,s_WFDateHot,s_DWDateHot,s_WFHotSup,s_WFDateBM,s_DWDateBM,s_WFSupBM from HY_Storage where s_CID like '%" + k + "%'";
                    requistionDate(sql0);
                    break;

                case 1:
                    string sql1 = "select s_ID,s_DID,s_CID,s_Supplier,s_Person,s_Class,s_Warehouse,s_XDate,s_DDate,s_PID,s_Pname,s_Origin,s_Specifications,s_Amount,s_Notes,s_WFDate,s_DWDate,s_WFSup,s_WFDateHot,s_DWDateHot,s_WFHotSup,s_WFDateBM,s_DWDateBM,s_WFSupBM from HY_Storage where s_Pname like '%" + k + "%'";
                    requistionDate(sql1);
                    break;

                case 2:
                    string sql2 = "select s_ID,s_DID,s_CID,s_Supplier,s_Person,s_Class,s_Warehouse,s_XDate,s_DDate,s_PID,s_Pname,s_Origin,s_Specifications,s_Amount,s_Notes,s_WFDate,s_DWDate,s_WFSup,s_WFDateHot,s_DWDateHot,s_WFHotSup,s_WFDateBM,s_DWDateBM,s_WFSupBM from HY_Storage where s_DID like '%" + k + "%'";
                    requistionDate(sql2);
                    break;

            }
        }
    }
}
