using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using HY_BLL;

namespace HYWJ.HY_Report
{
    public partial class HY_StorageAccountDB : Office2007Form
    {
        public HY_StorageAccountDB()
        {
            InitializeComponent();
        }

        private void HY_StorageAccountDB_Load(object sender, EventArgs e)
        {
            HY_BLL.HY_StorageBLL hystorfobll = new HY_StorageBLL();
            string sql = "select * from HY_Storage order by s_ID desc";
            DataSet ds = hystorfobll.ExecuteQueryDataSet(sql);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HYWJ.HY_Report.HY_StorageAccountReport.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("StorageAccount", ds.Tables[0]));
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
