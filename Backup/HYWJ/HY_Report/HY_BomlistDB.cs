using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using HY_BLL;

namespace HYWJ.HY_Report
{
    public partial class HY_BomlistDB : Form
    {
        public HY_BomlistDB()
        {
            InitializeComponent();
           
        }

        private void HY_BomlistDB_Load(object sender, EventArgs e)
        {
            HYWJ.HY_Production.HY_BOMListInventory hybomlist;//实例化传值窗体
            hybomlist = (HYWJ.HY_Production.HY_BOMListInventory)this.Owner;
            string aa = hybomlist.GetBomvalue;//传值

            HY_BLL.HY_StorageBLL hystorfobll = new HY_StorageBLL();
            string sql = "select * from HY_BomDetails where d_SKID='" + aa + "' order by d_ID desc";
            DataSet ds = hystorfobll.ExecuteQueryDataSet(sql);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HYWJ.HY_Report.HY_BomlistReport.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("HY_BomDetails", ds.Tables[0]));
            // TODO: 这行代码将数据加载到表“DataSet1.HY_Storage”中。您可以根据需要移动或移除它。
            //this.HY_StorageTableAdapter.Fill(this.DataSet1.HY_Storage);
            //设置打印布局模式,显示物理页面大小
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            //缩放模式为百分比,以100%方式显示
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }
    }
}
