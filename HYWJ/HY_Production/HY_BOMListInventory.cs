/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明: BOM物料清单盘点信息主窗体
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
using HY_Model;
using DevComponents.DotNetBar;

namespace HYWJ.HY_Production
{
    public partial class HY_BOMListInventory : Office2007Form
    {
        private HY_BLL.HY_BomlistBLL hybombll;
        public HY_BOMListInventory()
        {
            InitializeComponent();
            hybombll = new HY_BomlistBLL();
        }

        private void HY_BOMListInventory_Load(object sender, EventArgs e)
        {
            this.btnBomlist.Enabled = false;
            this.comboBoxClass.SelectedIndex = 0;
            string sql = "select * from HY_BomInfo order by b_ID desc";
            requistionDate(sql);
        }
       
        //自定义绑定数据
        private void requistionDate(string sql)
        {
            this.dataGridViewBOM.AutoGenerateColumns = false;// 关闭自动创建列
            this.dataGridViewBOM.DataSource = hybombll.ExecuteQuery(sql);
        }

        private void dataGridViewBOM_DoubleClick(object sender, EventArgs e)
        {
            string i = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            this.tabControlBOM.SelectedIndex = 1;
            HY_BLL.HY_BomDetailsBLL hybomdel = new HY_BomDetailsBLL();
            this.dataGridViewBOMDET.AutoGenerateColumns = false;// 关闭自动创建列
            this.dataGridViewBOMDET.DataSource = hybomdel.ExecuteQuerySelect(i);
        }
        private string mainvalue;//传给子窗体的值
        //跨窗体传值属性
        public string GetBomvalue
        {
            get { return mainvalue; }
            set { mainvalue = value; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string str_DID = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            HYWJ.HY_Report.HY_BomlistDB hybom = new HYWJ.HY_Report.HY_BomlistDB();
            hybom.Owner = this;
            hybom.ShowDialog();//对话框模式窗口
            hybom.Dispose();
        }

        private void dataGridViewBOM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnBomlist.Enabled = true;
            GetBomvalue = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
            string str_DID = this.dataGridViewBOM[0, this.dataGridViewBOM.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string k=this.key.Text.Trim();
            switch (this.comboBoxClass.SelectedIndex)
            {
                case 0:
                    string sql = "select * from HY_BomInfo where b_SKID like '%"+k+"%'";
                    requistionDate(sql);
                break;

                case 1:
                string sql1 = "select * from HY_BomInfo where b_CID like '%" + k + "%'";
                    requistionDate(sql1);
                break;

                case 2:
                string sql2 = "select * from HY_BomInfo where b_CustomerID like '%" + k + "%'";
                    requistionDate(sql2);
                break;

            }

        }
    }
}
