using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using HY_BLL;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using Microsoft.Reporting.WinForms;
using DevComponents.DotNetBar;
namespace HYWJ.HY_Report
{
    public partial class HY_PurchasingdetailsDH : Office2007Form
    {
        public HY_PurchasingdetailsDH()
        {
            InitializeComponent();
        }

        private void HY_PurchasingdetailsDH_Load(object sender, EventArgs e)
        {
            HY_Invoicing.HY_Purchasingstatus hypur;//实例化传值窗体
            hypur = (HY_Invoicing.HY_Purchasingstatus)this.Owner;
            string aa = hypur.GetMainvalue;//单号传值
            string sup = hypur.HYSupplier;//供应商传值
            string model = hypur.ModelID;//模号

            HY_BLL.HY_StorageBLL hystorfobll = new HY_StorageBLL();
            string sql = "select * from HY_ProcurementInfo where c_DID='" + aa + "' and c_Supplier='" + sup + "'";
            DataSet ds = hystorfobll.ExecuteQueryDataSet(sql);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HYWJ.HY_Report.HY_ProcurementInfoReportDH.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("HY_ProcurementInfo", ds.Tables[0]));
            //设置打印布局模式,显示物理页面大小
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            //缩放模式为百分比,以100%方式显示
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;

            ReportParameter rp = new ReportParameter("content", sup);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
            ReportParameter rp1 = new ReportParameter("cgID", aa);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1 });
            ReportParameter mod = new ReportParameter("modelID", model);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { mod });

            // TODO: 这行代码将数据加载到表“hYMISDataSet.HY_ProcurementInfo”中。您可以根据需要移动或移除它。
            //this.HY_ProcurementInfoTableAdapter.Fill(this.DataSet1.HY_ProcurementInfo, aa);
            this.reportViewer1.RefreshReport();
        }
    }
}
