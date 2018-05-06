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

namespace HYWJ.HY_Warehouse
{
    public partial class HY_BomSo : Office2007Form
    {
        private HY_BLL.HY_BomlistBLL hybombll;
        public HY_BomSo()
        {
            InitializeComponent();
            hybombll = new HY_BomlistBLL();
        }

        private void HY_BomSo_Load(object sender, EventArgs e)
        {
            requistionDate();
        }
        //自定义绑定数据
        private void requistionDate()
        {
            this.dataGridViewBOM.AutoGenerateColumns = false;// 关闭自动创建列
            string sql = "select * from HY_BomInfo where b_Audit<>'' order by b_ID desc";
            this.dataGridViewBOM.DataSource = hybombll.ExecuteQuery(sql);//5^1^a^s^p^x
        }
     
        private void dataGridViewBOM_DoubleClick(object sender, EventArgs e)
        {
            string i = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.tabControlBOM.SelectedTabIndex = 1;
            HY_BLL.HY_BomDetailsBLL hybomdel = new HY_BomDetailsBLL();
            this.dataGridViewBOMDET.AutoGenerateColumns = false;// 关闭自动创建列
            this.dataGridViewBOMDET.DataSource = hybomdel.ExecuteQuerySelect(i);
        }
    }
}
